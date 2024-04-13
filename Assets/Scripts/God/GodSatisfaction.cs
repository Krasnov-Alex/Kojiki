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
        godDescriptionEx[0] = "<b>Идзанаги.</b>\r\nПервый мужчина на земле, вместе с сестрой Идзанами, ставшей ему женой, был послан, чтобы создать физический мир. Олицетворяет собой мужское начало. После смерти Идзанами спускается за ней в страну мертвых, надеясь ее вернуть, но в ужасе убегает прочь. Выбравшись из страны мертвых, совершает омовение в реке, порождая новых божеств.\r\n";
        godDescriptionEx[1] = "<b>Идзанами.</b>\r\nПервая женщина на земле, вместе с братом Идзанаги, ставшим её мужем, была послана, чтобы создать физический мир. Олицетворяет собой женское начало, порождает множество малых божеств. Умирает после рождения бога огня и попадает в страну мертвых, став олицетворением смерти.\r\n";
        godDescriptionEx[2] = "<b>Аматерасу.</b>\r\nРождена из левого глаза Идзанаги после его омовения в реке. Является Богиней Солнца. Вместе с братом Сусаноо породила 3 девочек и 5 мальчиков. Погрузилась в траур и скрылась в глубокой пещере, после смерти богини ткачества из-за выходок Сусаноо. Другие боги с трудом смогли ее выманить из пещеры и, привязав священной веревкой, вынудили остаться в мире навсегда в виде солнца.\r\n";
        godDescriptionEx[3] = "<b>Цукуёми.</b>\r\nРожден из правого глаза Идзанаги после его омовения в реке. Является Богом Ночи.\r\nДолгое время жил в Высокой Долине Небес во дворце Аматерасу. Ужаснувшись от того, что мог съесть что-то, что могло явиться из нечистых частей тела богини пищи, он убивает ее. За это убийство Аматерасу изгоняет его, и с тех пор, луна блуждает по небу ночью, а солнце днем.\r\n";
        godDescriptionEx[4] = "<b>Сусаноо.</b>\r\nРожден из носа Идзанаги после его омовения в реке. Изначально был властителем моря, но из-за того, что слишком часто устраивал штормы, Идзанаги отобрал у него это право. Скрывался в Высокой Долине Небес у Аматерасу. Но после безобразий, из-за которых погибла богиня ткачества, был изгнан из владений Аматерасу после чего стал властителем Японских островов.\r\n";

        likeAGod[0] = "Нравится:\r\n\nДействия:\r\n- Странствующий торговец привез материалы\r\n- Поменяться с соседом на материалы\r\n- Отправиться в экспедицию за специями\r\n- Задобрить Идзанаги\r\n\r\nПостройки:\r\n- Рисовое поле\r\n- Театр\r\n- Онсен\r\n- Храм Идзанаги\r\n";
        likeAGod[1] = "Нравится:\r\n\nДействия:\r\n- Странствующий торговец привез еду\r\n- Поменяться с соседом на еду\r\n- Принять беженцев\r\n- Бум рождаемости\r\n- Задобрить Идзанами\r\n\r\nПостройки:\r\n- Рисовое поле\r\n- Театр\r\n- Жилые дома\r\n- Храм Идзанами\r\n";
        likeAGod[2] = "Нравится:\r\n\nДействия:\r\n- Отправиться в экспедицию за материалами\r\n- Напасть на соседей\r\n- Нанять ронинов\r\n- Собрать ополчение\r\n- Задобрить Аматерасу\r\n\r\nПостройки:\r\n- Лесопилка\r\n- Рисовое поле\r\n- Казарма\r\n- Храм Аматерасу\r\n";
        likeAGod[3] = "Нравится:\r\n\nДействия:\r\n- Сосватать девушек\r\n- Буддистская миссия\r\n- Купить рабов\r\n- Задобрить Цукуеми\r\n\r\nПостройки:\r\n- Лесопилка\r\n- Каменоломня\r\n- Театр\r\n- Храм Цукуеми\r\n";
        likeAGod[4] = "Нравится:\r\n\nДействия:\r\n- Закупиться рудой\r\n- Закупиться солью\r\n- Продать детей\r\n- Задобрить Сусаноо\r\n\r\nПостройки:\r\n- Лесопилка\r\n- Колодец\r\n- Театр\r\n- Храм Сусаноо\r\n";

        unLikeAGod[0] = "Не нравится:\r\n\nДействия:\r\n- Продать детей\r\n- Буддистская миссия\r\n-  Выпить сакэ\r\n- Пленные\r\n\r\nПостройки:\r\n- Храм Сусаноо\r\n";
        unLikeAGod[1] = "Не нравится:\r\n\nДействия:\r\n- Закупиться рудой\r\n- Отправиться в экспедицию за материалами\r\n- Напасть на соседей\r\n- Нанять ронинов\r\n- Задобрить Цукуеми \r\n\r\nПостройки:\r\n- Храм Цукуеми\r\n";
        unLikeAGod[2] = "Не нравится:\r\n\nДействия:\r\n- Поменяться с соседом на еду\r\n- Сосватать девушек\r\n- Принять беженцев\r\n- Задобрить Идзанами\r\n\r\nПостройки:\r\n- Храм Идзанами\r\n";
        unLikeAGod[3] = "Не нравится:\r\n\nДействия:\r\n- Странствующий торговец привез еду\r\n- Закупиться солью\r\n- Отправиться в экспедицию за специями\r\n- Задобрить Аматерасу\r\n\r\nПостройки:\r\n- Храм Аматерасу\r\n";
        unLikeAGod[4] = "Не нравится:\r\n\nДействия:\r\n- Странствующий торговец привез материалы\r\n- Поменяться с соседом на материалы\r\n- Бум рождаемости\r\n- Задобрить Идзанаги\r\n\r\nПостройки:\r\n- Храм Идзанаги\r\n";

        likeAGodMessages[0] = "Ты! Ты! Ты радуешь меня! Я вижу мы не ошиблись назначив именно тебя Старейшиной!";
        likeAGodMessages[1] = "Старейшина. Твои деяния радуют меня. Продолжай и будет долог твой век.";
        likeAGodMessages[2] = "Смертный. Ты удивляешь меня с каждым сезоном. Твое почитание.. так.. приятно.";
        likeAGodMessages[3] = "… И? Ты ждешь от меня похвалы? … Ну… хвалю.";
        likeAGodMessages[4] = "Мир сияет в моих глазах, Счастье и радость я дарю, Пусть каждый вкусит благодать.";

        unlikeAGodMessages[0] = "Ты! Ты! Да как ты смеешь?! Ты хочешь испытать мой гнев?!";
        unlikeAGodMessages[1] = "Ты! Зовущийся Старейшиной! Ты не достоин этого звания! Я найду тебе замену!";
        unlikeAGodMessages[2] = "Смертный! А ты наглец! Пользуешься моими благами! Но твои люди меня не почитают! Берегись смертный!";
        unlikeAGodMessages[3] = "… я и не ожидал другого…";
        unlikeAGodMessages[4] = "Ах, смертный, смертный, смертный. Прощения нет тебе!";
    }
}
