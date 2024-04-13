using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GodSatisfaction : MonoBehaviour
{
    [SerializeField] public Text godName; 
    [SerializeField] public float satisfaction = 0f;

    [SerializeField] private GameObject godDescription;
    [SerializeField] private Text godDescriptionText;

    [SerializeField] private Text likeAGodText;
    [SerializeField] private Text unLikeAGodText;

    private string likeAGodMessageText;
    private string unLikeAGodMessageText;

    [SerializeField] private Sprite[] iconEx;
    [SerializeField] private string[] godNameEx;
    private string[] godDescriptionEx = new string[5];
    private string[] likeAGod = new string[5];
    private string[] unLikeAGod = new string[5];
    private string[] likeAGodMessages = new string[5];
    private string[] unlikeAGodMessages = new string[5];
    [SerializeField] private GodControl godControl;
    [SerializeField] private Gamover gamover;
    [SerializeField] private string atribut;
    [SerializeField] private Slider goodLine;
    [SerializeField] private Slider badLine;
    private int minSatis = -30;
    private int maxSatis = 30;
    public Text satis;

    [SerializeField] Image godImage;
    [SerializeField] private Sprite calmSprite;
    [SerializeField] private Sprite angrySprite;
    [SerializeField] private Sprite happySprite;

    [SerializeField] private GameObject reverseButton;
    private bool isReverseButton = true;

    [SerializeField] private GameObject godMessege;
    [SerializeField] private Text godMessegeText;
    [SerializeField] private GodsMessage godMessegeMessage;
    private bool isLikeGodMessege = false;
    private bool isUnlikeGodMessege = false;

    [SerializeField] public GameObject karaGods;
    [SerializeField] public GameObject satisGods;
    [SerializeField] public GameObject cardRev;
    [SerializeField] private GodsDebuff godDebuff;
    public bool isGodDebuff = true;

    public bool dontTakeMinus = false;
    public bool dontTakeMinusCheck = true;

    [SerializeField] private AudioInGame audioInGame;


    private void Start()
    {
        AddDescription();
        GetDescription();
        goodLine.value = 0;
        badLine.value = 0;
        godImage.sprite = calmSprite;
    }

    private void Update()
    {
        satis.text = satisfaction.ToString();

        if (satisfaction < 0)
        {
            badLine.value = -(float)satisfaction / 30f;
            goodLine.value = 0;
        }
        else if (satisfaction > 0)
        {
            goodLine.value = (float)satisfaction / 30f;
            badLine.value = 0;
        }
        else
        {
            goodLine.value = 0;
            badLine.value = 0;
        }

        if (satisfaction <= minSatis)
        {
            gamover.GameOver(false);
        }
        if (satisfaction >= maxSatis)
        {
            satisfaction = maxSatis;
        }

        if (satisfaction <= -20 && isGodDebuff && SceneManager.GetActiveScene().buildIndex != 2)
        {
            GodsMessage temp = karaGods.GetComponent<GodsMessage>();
            temp.ActiveMessege(karaGods);
            godDebuff.StartDebuff();
            audioInGame.DebuffGod();
            isGodDebuff = false;
        }

        if (satisfaction <= -10)
        {
            godImage.sprite = angrySprite;
            if (!isUnlikeGodMessege)
            {
                godMessegeText.text = unLikeAGodMessageText.ToString();
                godMessegeMessage.ActiveMessege(godMessege);
                audioInGame.DebuffGod();
                isUnlikeGodMessege = true;
            }
            
        }
        else if (satisfaction >= 10)
        {
            godImage.sprite = happySprite;
            if (!isLikeGodMessege)
            {
                godMessegeText.text = likeAGodMessageText.ToString();
                godMessegeMessage.ActiveMessege(godMessege);
                audioInGame.BuffGod();
                isLikeGodMessege = true;
            }
        }
        else
        {
            godImage.sprite = calmSprite;
        }

        if (satisfaction == 30 && isReverseButton)
        {
            isReverseButton = false;
            reverseButton.SetActive(true);
            audioInGame.BuffGod();
            GodsMessage temp = cardRev.GetComponent<GodsMessage>();
            temp.ActiveMessege(cardRev);
        }
    }

    public void SetSatisfaction(int satis)
    {
        if (!dontTakeMinus)
        {
            satisfaction += satis;
        }
        else 
        {
            if (satis > 0)
            {
                satisfaction += satis;
            }
        }
    }

    public void GodDescription()
    {
        if (godDescription.activeSelf)
        {
            godDescription.SetActive(false);
        }
        else
        {
            godDescription.SetActive(true);
        }
    }

    private void GetDescription()
    {
        switch (atribut)
        {
            case "Ig":
                godDescriptionText.text = godDescriptionEx[0];
                likeAGodText.text = likeAGod[0];
                unLikeAGodText.text = unLikeAGod[0];
                likeAGodMessageText = likeAGodMessages[0];
                unLikeAGodMessageText = unlikeAGodMessages[0];
                break;
            case "Im":
                godDescriptionText.text = godDescriptionEx[1];
                likeAGodText.text = likeAGod[1];
                unLikeAGodText.text = unLikeAGod[1];
                likeAGodMessageText = likeAGodMessages[1];
                unLikeAGodMessageText = unlikeAGodMessages[1];
                break;
            case "Am":
                godDescriptionText.text = godDescriptionEx[2];
                likeAGodText.text = likeAGod[2];
                unLikeAGodText.text = unLikeAGod[2];
                likeAGodMessageText = likeAGodMessages[2];
                unLikeAGodMessageText = unlikeAGodMessages[2];
                break;
            case "Ts":
                godDescriptionText.text = godDescriptionEx[3];
                likeAGodText.text = likeAGod[3];
                unLikeAGodText.text = unLikeAGod[3];
                likeAGodMessageText = likeAGodMessages[3];
                unLikeAGodMessageText = unlikeAGodMessages[3];
                break;
            case "Su":
                godDescriptionText.text = godDescriptionEx[4];
                likeAGodText.text = likeAGod[4];
                unLikeAGodText.text = unLikeAGod[4];
                likeAGodMessageText = likeAGodMessages[4];
                unLikeAGodMessageText = unlikeAGodMessages[4];
                break;
        }
    }

    private void AddDescription()
    {
        godDescriptionEx[0] = "<b>��������.</b>\r\n������ ������� �� �����, ������ � ������� ��������, ������� ��� �����, ��� ������, ����� ������� ���������� ���. ������������ ����� ������� ������. ����� ������ �������� ���������� �� ��� � ������ �������, ������� �� �������, �� � ����� ������� �����. ���������� �� ������ �������, ��������� �������� � ����, �������� ����� �������.\r\n";
        godDescriptionEx[1] = "<b>��������.</b>\r\n������ ������� �� �����, ������ � ������ ��������, ������� � �����, ���� �������, ����� ������� ���������� ���. ������������ ����� ������� ������, ��������� ��������� ����� �������. ������� ����� �������� ���� ���� � �������� � ������ �������, ���� �������������� ������.\r\n";
        godDescriptionEx[2] = "<b>���������.</b>\r\n������� �� ������ ����� �������� ����� ��� �������� � ����. �������� ������� ������. ������ � ������ ������� �������� 3 ������� � 5 ���������. ����������� � ����� � �������� � �������� ������, ����� ������ ������ ��������� ��-�� ������� �������. ������ ���� � ������ ������ �� �������� �� ������ �, �������� ��������� ��������, �������� �������� � ���� �������� � ���� ������.\r\n";
        godDescriptionEx[3] = "<b>������.</b>\r\n������ �� ������� ����� �������� ����� ��� �������� � ����. �������� ����� ����.\r\n������ ����� ��� � ������� ������ ����� �� ������ ���������. ����������� �� ����, ��� ��� ������ ���-��, ��� ����� ������� �� �������� ������ ���� ������ ����, �� ������� ��. �� ��� �������� ��������� �������� ���, � � ��� ���, ���� �������� �� ���� �����, � ������ ����.\r\n";
        godDescriptionEx[4] = "<b>�������.</b>\r\n������ �� ���� �������� ����� ��� �������� � ����. ���������� ��� ����������� ����, �� ��-�� ����, ��� ������� ����� ��������� ������, �������� ������� � ���� ��� �����. ��������� � ������� ������ ����� � ���������. �� ����� ����������, ��-�� ������� ������� ������ ���������, ��� ������ �� �������� ��������� ����� ���� ���� ����������� �������� ��������.\r\n";

        likeAGod[0] = "��������:\r\n\n��������:\r\n- ������������� �������� ������ ���������\r\n- ���������� � ������� �� ���������\r\n- ����������� � ���������� �� ��������\r\n- ��������� ��������\r\n\r\n���������:\r\n- ������� ����\r\n- �����\r\n- �����\r\n- ���� ��������\r\n";
        likeAGod[1] = "��������:\r\n\n��������:\r\n- ������������� �������� ������ ���\r\n- ���������� � ������� �� ���\r\n- ������� ��������\r\n- ��� �����������\r\n- ��������� ��������\r\n\r\n���������:\r\n- ������� ����\r\n- �����\r\n- ����� ����\r\n- ���� ��������\r\n";
        likeAGod[2] = "��������:\r\n\n��������:\r\n- ����������� � ���������� �� �����������\r\n- ������� �� �������\r\n- ������ �������\r\n- ������� ���������\r\n- ��������� ���������\r\n\r\n���������:\r\n- ���������\r\n- ������� ����\r\n- �������\r\n- ���� ���������\r\n";
        likeAGod[3] = "��������:\r\n\n��������:\r\n- ��������� �������\r\n- ����������� ������\r\n- ������ �����\r\n- ��������� �������\r\n\r\n���������:\r\n- ���������\r\n- �����������\r\n- �����\r\n- ���� �������\r\n";
        likeAGod[4] = "��������:\r\n\n��������:\r\n- ���������� �����\r\n- ���������� �����\r\n- ������� �����\r\n- ��������� �������\r\n\r\n���������:\r\n- ���������\r\n- �������\r\n- �����\r\n- ���� �������\r\n";

        unLikeAGod[0] = "�� ��������:\r\n\n��������:\r\n- ������� �����\r\n- ����������� ������\r\n-  ������ ����\r\n- �������\r\n\r\n���������:\r\n- ���� �������\r\n";
        unLikeAGod[1] = "�� ��������:\r\n\n��������:\r\n- ���������� �����\r\n- ����������� � ���������� �� �����������\r\n- ������� �� �������\r\n- ������ �������\r\n- ��������� ������� \r\n\r\n���������:\r\n- ���� �������\r\n";
        unLikeAGod[2] = "�� ��������:\r\n\n��������:\r\n- ���������� � ������� �� ���\r\n- ��������� �������\r\n- ������� ��������\r\n- ��������� ��������\r\n\r\n���������:\r\n- ���� ��������\r\n";
        unLikeAGod[3] = "�� ��������:\r\n\n��������:\r\n- ������������� �������� ������ ���\r\n- ���������� �����\r\n- ����������� � ���������� �� ��������\r\n- ��������� ���������\r\n\r\n���������:\r\n- ���� ���������\r\n";
        unLikeAGod[4] = "�� ��������:\r\n\n��������:\r\n- ������������� �������� ������ ���������\r\n- ���������� � ������� �� ���������\r\n- ��� �����������\r\n- ��������� ��������\r\n\r\n���������:\r\n- ���� ��������\r\n";

        likeAGodMessages[0] = "��! ��! �� ������� ����! � ���� �� �� �������� �������� ������ ���� �����������!";
        likeAGodMessages[1] = "����������. ���� ������ ������ ����. ��������� � ����� ����� ���� ���.";
        likeAGodMessages[2] = "��������. �� ��������� ���� � ������ �������. ���� ���������.. ���.. �������.";
        likeAGodMessages[3] = "� �? �� ����� �� ���� �������? � �� �����.";
        likeAGodMessages[4] = "��� ����� � ���� ������, ������� � ������� � ����, ����� ������ ������ ���������.";

        unlikeAGodMessages[0] = "��! ��! �� ��� �� ������?! �� ������ �������� ��� ����?!";
        unlikeAGodMessages[1] = "��! ��������� �����������! �� �� ������� ����� ������! � ����� ���� ������!";
        unlikeAGodMessages[2] = "��������! � �� ������! ����������� ����� �������! �� ���� ���� ���� �� ��������! �������� ��������!";
        unlikeAGodMessages[3] = "� � � �� ������ �������";
        unlikeAGodMessages[4] = "��, ��������, ��������, ��������. �������� ��� ����!";
    }
}
