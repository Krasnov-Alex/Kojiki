//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Variables : MonoBehaviour
//{
//materialResources = 1000f; // ��������� ���������� ����������
//foodResources = 1000f; // ��������� ���������� ���
//happyResources = 1000f; // ��������� ���������� �������
//materialResourcesNew; // ����� ���������� ����������
//foodResourcesNew; // ����� ���������� ���
//happyResourcesNew; // ����� ���������� �������
//peopleResources = 1000f; // ��������� ���������� ���������
//peopleResoursesLast; // ���������� ��������� �� ���������� ����
//peopleCoef = peopleResoursesLast / 1000; // �������������� ����������� �� ���������
//peopleResourcesAdd = 500f; // ����������� ��������� �� ��������� ������ �����, �������� � ������� ��

//materialBuild = 1f; // ��������� ���������� ������ ���������� (����� ���� ��� ����������, ��� � ������������, ���������� ��������)
//foodBuild = 1f; // ��������� ���������� ������ ��� (����� ���� ��� ������� �����, ��� � ��������, ���������� ��������)
//happyBuild = 1f; // ��������� ���������� ������ ������� (����� ���� ��� �������, ��� � �����, ���������� ��������)
//peopleBuild = 1f; // ��������� ���������� ������ ����� (����� ���� ��� ��������, ��� � ����� �����, ���������� ��������)
//buildCost; // ��������� ������������� ����� ��������� (� �.�. �����), �������� � ������� ��
//materialBuildNew; // ����� ���������� ������ ����������
//foodBuildNew; // ����� ���������� ������ ���
//happyBuildNew; // ����� ���������� ������ �������
//peopleBuildNew; // ����� ���������� ������ �����

//templeIg = 1f; // ��������� ���������� ������ ��������
//templeIm = 1f; // ��������� ���������� ������ ��������
//templeAm = 0f; // ��������� ���������� ������ ���������
//templeCu = 0f; // ��������� ���������� ������ �������
//templeSu = 0f; // ��������� ���������� ������ �������
//templeTk = 0f; // ��������� ���������� ������ �������������
//templeOk = 0f; // ��������� ���������� ������ ���������
//templeEb = 0f; // ��������� ���������� ������ �����

//satisfactionIg = 0f; // ��������� ���������� ����� ����������������� (�� -30 �� 30) ��������
//satisfactionIm = 0f; // ��������� ���������� ����� ����������������� (�� -30 �� 30) ��������
//satisfactionAm = 0f; // ��������� ���������� ����� ����������������� (�� -30 �� 30) ���������
//satisfactionCu = 0f; // ��������� ���������� ����� ����������������� (�� -30 �� 30) �������
//satisfactionSu = 0f; // ��������� ���������� ����� ����������������� (�� -30 �� 30) �������
//satisfactionTk = 0f; // ��������� ���������� ����� ����������������� (�� -30 �� 30) �������������
//satisfactionOk = 0f; // ��������� ���������� ����� ����������������� (�� -30 �� 30) ���������
//satisfactionEb = 0f; // ��������� ���������� ����� ����������������� (�� -30 �� 30) �����
//satisfactionTakeMinus = 2f; // �������� ����������������� ����� �� ������, �������� � ������� ��
//satisfactionActionAdd = 2f; // ���������� ����������������� ����� �� ��������, �������� � ������� ��
//satisfactionActionMinus = 2f; // �������� ����������������� ����� �� ��������, �������� � ������� ��
//satisfactionBuildAdd = 5f; // ���������� ����������������� ����� �� ������� ��������, �������� � ������� ��
//satisfactionTempleAdd = 10f; // ���������� ����������������� ����� �� ������, �������� � ������� ��


//// ���� �������� New � �����, �� �������� ��� ���������� � ����� ����    




//// ����� ������
//moves = 0f; // ���������� �����
//season = 3f; // ����� ������ (1 - �����, 2 - ����, 3 - �����, 4 - ����)
//seasonNew; // ����� �����
//    if moves = 3 
//        seasonNew = season + 1; // ���� ������ 3 ����, ����� ��������




//// �������� �������� �� ����� ������
//seasonDebuff; // �������� �������� �� ����� ������, �������� � ������� ��
//seasonDebuffCoef = 0.5f; // ��������� ��������� ������ �� ����� ������, �������� � ������� ��
//seasonCoef = 0.25f; // ��������� ������ �� ������, �������� � ������� ��
//seasonDebuffNew; // ����� ��������� ��������� ������ 
//seasonCoefNew; // ����� ��������� ������ �� ������

//    if seasonNew = 1
//        seasonDebuffNew = seasonDebuff;
//        seasonCoefNew = 1;
//        else if seasonNew = 2
//        seasonDebuffNew = seasonDebuff * (1 - seasonDebuffCoef) * peopleCoef;
//        seasonCoefNew = 1 + seasonCoef;
//        else if seasonNew = 3
//        seasonDebuffNew = seasonDebuff;
//        seasonCoefNew = 1;
//        else if seasonNew = 4
//        seasonDebuffNew = seasonDebuff * (1 + seasonDebuffCoef) * peopleCoef;
//        seasonCoefNew = 1 - seasonCoef;

//materialResourcesNew = materialResources - seasonDebuffNew;
//foodResourcesNew = foodResources - seasonDebuffNew;
//happyResourcesNew = happyResources - seasonDebuffNew;
//// ��������� �� ����������� �� �����!!!!





//choice; // ����� ����� (1 - ������, 2 - ��������, 3 - ���������)
//choiceNew; // ����� ��������� ����

//// ������ �������� ������
//cardTake; // ��� ����� ������ (1 - ���������, 2 - ���, 3 - �������)
//cardTakeNum; // ���������� ����� �� ����� ������

//    if choice = 1 
//      satisfactionIgNew = satisfactionIg - satisfactionTakeMinus; 
//      satisfactionImNew = satisfactionIm - satisfactionTakeMinus; 
//      satisfactionAmNew = satisfactionAm - satisfactionTakeMinus; 
//      satisfactionCuNew = satisfactionCu - satisfactionTakeMinus; 
//      satisfactionSuNew = satisfactionSu - satisfactionTakeMinus; 
//      satisfactionTkNew = satisfactionTk - satisfactionTakeMinus; 
//      satisfactionOkNew = satisfactionOk - satisfactionTakeMinus; 
//      satisfactionEbNew = satisfactionEb - satisfactionTakeMinus; 
    
//      if cardTake = 1
//        materialResourcesNew = materialResources + (((materialBuildNew * cardTakeNum) * peopleCoefNew) * seasonCoef); // ����� ���������� �������� � ����������� �� ���������� ������ ���� ��������, ������ �������� ������, ��������� �� ��������� � ��������� ������
                
//      if cardTake = 2
//        foodResourcesNew = foodResources + (((foodBuildNew * cardTakeNum) * peopleCoefNew) * seasonCoef);  // ����� ���������� �������� � ����������� �� ���������� ������ ���� ��������, ������ �������� ������, ��������� �� ��������� � ��������� ������

//      if cardTake = 3 
//        happyResourcesNew = happyResources + (((happyBuildNew * cardTakeNum) * peopleCoefNew) * seasonCoef);  // ����� ���������� �������� � ����������� �� ���������� ������ ���� ��������, ������ �������� ������, ��������� �� ��������� � ��������� ������


//// ������ �������� ��������
//cardAction; // ��� ����� �������� (1 - "��������� + / ��� -", 2 - "��� + / ��������� -", 3 - "��� + / ��������� -", 4 - "������� + / ��� -", 5 - "��������� + / ������� -")
//cardActionBuff; // ���������� �������� �� ����� �������� (�� 200 �� 500 � ����� 100)
//�ardActionDebuff; // �������� �������� �� ����� �������� (�� 100 �� 400 � ����� 100)
//cardActionBuff = �ardActionDebuff + 100; // ���������� ����������� �������� �� 100 ������ ������ �����������!!!
//cardActionName; // ��� ����� �������� (�� 1 �� 4, � ������� ������� ������� O26:S30 � ������������ � ������ ����)

//    if choice = 2
//      if cardAction = 1
//        materialResourcesNew = materialResources + ((cardActionBuff * peopleCoefNew) * seasonCoef);
//        foodResourcesNew = foodResources - ((cardActionDebuff * peopleCoefNew) * seasonCoef);
//        cardActionName = random(1,4)
//        if cardActionName = 2
//           satisfactionIgNew = satisfactionIg + satisfactionActionAdd;
//        if cardActionName = 3
//           satisfactionCuNew = satisfactionCu + satisfactionActionAdd;
//        if cardActionName = 4
//           satisfactionOkNew = satisfactionOk - satisfactionActionMinus;

//      if cardAction = 2 
//        materialResourcesNew = materialResources - ((cardActionBuff* peopleCoefNew) * seasonCoef);
//        foodResourcesNew = foodResources + ((cardActionDebuff* peopleCoefNew) * seasonCoef);
//         cardActionName = random(1,4)
//         if cardActionName = 1
//           satisfactionImNew = satisfactionIm + satisfactionActionAdd;
//         if cardActionName = 2
//           satisfactionTkNew = satisfactionTk - satisfactionActionMinus;
//         if cardActionName = 4
//           satisfactionOkNew = satisfactionOk - satisfactionActionMinus;

//      if cardAction = 3
//        peopleResourcesNew = peopleResources - ((cardActionBuff* peopleCoefNew) * seasonCoef);
//        foodResourcesNew = foodResources + ((cardActionDebuff* peopleCoefNew) * seasonCoef);
//        cardActionName = random(1,4)
//         if cardActionName = 1
//           satisfactionSuNew = satisfactionSu - satisfactionActionMinus;
//         if cardActionName = 2
//           satisfactionImNew = satisfactionIm - satisfactionActionMinus;
//         if cardActionName = 4
//           satisfactioIgNew = satisfactionIg - satisfactionActionMinus;

//      if cardAction = 4
//        happyResourcesNew = happyResources + ((cardActionBuff* peopleCoefNew)* seasonCoef);
//        foodResourcesNew = foodResources - ((cardActionDebuff* peopleCoefNew)* seasonCoef);
//        cardActionName = random(1,4)
//         if cardActionName = 1
//           satisfactionEbNew = satisfactionEb + satisfactionActionAdd;
//         if cardActionName = 2
//           satisfactionAmNew = satisfactionAm - satisfactionActionMinus;
//         if cardActionName = 4
//           satisfactioCuNew = satisfactionCu - satisfactionActionMinus;

//      if cardAction = 5
//        happyResourcesNew = happyResources - ((cardActionBuff* peopleCoefNew)* seasonCoef);
//        peopleResourcesNew = peopleResources + ((cardActionDebuff* peopleCoefNew)* seasonCoef);
//        cardActionName = random(1,4)
//         if cardActionName = 1
//           satisfactionAmNew = satisfactionAm + satisfactionActionAdd;
//         if cardActionName = 2
//           satisfactionSuNew = satisfactionSu + satisfactionActionAdd;
//         if cardActionName = 3
//           satisfactioEbNew = satisfactionEb - satisfactionActionMinus;
//         if cardActionName = 4
//           satisfactioTkNew = satisfactionTk + satisfactionActionAdd;

//// ������ ����� ���������              
//cardBuild; // ��� ����� ��������� (1 - ���������, 2 - ���, 3 - �������, 4 - �����, 5 - ����)
//materialBuildName; // ��� ����� ��������� ���������� (���� 1, ���� 2, �� ������� ����� � ����������� �� ���� https://docs.google.com/document/d/1NZxKjx5kebJ-ujNRXWZCpF21uk3yNCs14vKUsxv8sqc/edit)        
//foodBuildName; // ��� ����� ��������� ��� (���� 1, ���� 2, �� ������� ����� � ����������� �� ���� https://docs.google.com/document/d/1NZxKjx5kebJ-ujNRXWZCpF21uk3yNCs14vKUsxv8sqc/edit)        
//happyBuildName; // ��� ����� ��������� ������� (���� 1, ���� 2, �� ������� ����� � ����������� �� ���� https://docs.google.com/document/d/1NZxKjx5kebJ-ujNRXWZCpF21uk3yNCs14vKUsxv8sqc/edit)        
//peopleBuildName; // ��� ����� ��������� ����� (���� 1, ���� 2, �� ������� ����� � ����������� �� ���� https://docs.google.com/document/d/1NZxKjx5kebJ-ujNRXWZCpF21uk3yNCs14vKUsxv8sqc/edit)        
//templeName; // ��� ����� (� ����������� �� ���� �� 1 �� 8)
//buildLes; // ���������� ����������� �� ������� ���� ���������
//buildLesNew; // ���������� ����������� �� ������� � ������� ���� ���������
//buildKam; // ���������� ����������� �� ������� ���� �����������
//buildKamNew; // ���������� ����������� �� ������� � ������� ���� �����������
//buildKol; // ���������� ����������� �� ������� ���� �������� 
//buildKolNew; // ���������� ����������� �� ������� � ������� ���� ��������
//buildLes; // ���������� ����������� �� ������� ���� ������� �����
//buildLesNew; // ���������� ����������� �� ������� � ������� ���� �����
//buildTea; // ���������� ����������� �� ������� ���� �������
//buildTeaNew; // ���������� ����������� �� ������� � ������� ���� �������
//buildBan; // ���������� ����������� �� ������� ���� ����
//buildBanNew; // ���������� ����������� �� ������� � ������� ���� ����
//buildZhil; // ���������� ����������� �� ������� ���� ����� �����
//buildZhilNew; // ���������� ����������� �� ������� � ������� ���� �����
//buildKaz; // ���������� ����������� �� ������� ���� ������
//buildKazNew; // ���������� ����������� �� ������� � ������� ���� ������


//    if choice = 3
//      materialResourcesNew = materialResources - buildCost * (peopleCoefNew * seasonCoef); 
//      if cardBuild = 1
//        materialBuildName = random(1,2)
//        materialBuildNew = materialBuild + 1;
//         if materialBuildName = 1;
//           buildLesNew = buildLes + 1;
//           satisfactionAmNew = satisfactionAm + satisfactionBuildAdd;
//         if materialBuildName = 2;
//           buildKamNew = buildKam + 1;
//           satisfactionCuNew = satisfactionCu + satisfactionBuildAdd;

//      if cardBuild = 2
//        foodBuildName = random(1,2)
//        foodBuildNew = foodBuild + 1;
//         if foodBuildName = 1;
//           satisfactionSuNew = satisfactionSu + satisfactionBuildAdd;
//           buildKolNew = buildKol + 1;
//         if foodBuildName = 2;
//           satisfactionOkNew = satisfactionOk + satisfactionBuildAdd;
//           buildRisNew = buildRis + 1;

//      if cardBuild = 3
//        happyBuildName = random(1,2)
//        happyBuildNew = happyBuild + 1;
//         if happyBuildName = 1;
//           satisfactionEbNew = satisfactionEb + satisfactionBuildAdd;
//           buildTeaNew = buildTea + 1;
//         if happyBuildName = 2;
//           satisfactionIgNew = satisfactionIg + satisfactionBuildAdd;
//           buildBanNew = buildBan + 1;

//      if cardBuild = 4
//        peopleBuildName = random(1,2)
//        peopleBuildNew = peopleBuild + 1;
//        peopleResourcesNew = peopleResources + peopleResourcesAdd;
//         if peopleBuildName = 1;
//           satisfactionImNew = satisfactionIm + satisfactionBuildAdd;
//           buildZhilNew = buildZhil + 1;
//         if peopleBuildName = 2;
//           satisfactionTkNew = satisfactionTk + satisfactionBuildAdd;
//           buildKazNew = buildKaz + 1;

//      if cardBuild = 5
//        templeName = random(1,8)
//          if templeName = 1
//              templeIgNew = templeIg + 1;
//              satisfactionIgNew = satisfactionIg + satisfactionTempleAdd;
//          if templeName = 2   
//              templeImNew = templeIm + 1;
//              satisfactionImNew = satisfactionIm + satisfactionTempleAdd;
//          if templeName = 3   
//              templeAmNew = templeAm + 1;
//              satisfactionAmNew = satisfactionAm + satisfactionTempleAdd;
//          if templeName = 4   
//              templeCuNew = templeCu + 1;
//              satisfactionCuNew = satisfactionCu + satisfactionTempleAdd;
//          if templeName = 5   
//              templeSuNew = templeSu + 1;
//              satisfactionSuNew = satisfactionSu + satisfactionTempleAdd;
//          if templeName = 6   
//              templeTkNew = templeTk + 1;
//              satisfactionTkNew = satisfactionTk + satisfactionTempleAdd;
//          if templeName = 7   
//              templeOkNew = templeOk + 1;
//              satisfactionOkNew = satisfactionOk + satisfactionTempleAdd;
//          if templeName = 8   
//              templeEbNew = templeEb + 1;
//              satisfactionEbNew = satisfactionEb + satisfactionTempleAdd




//// ��������� �����
//Ig; // ��������
//Im; // ��������
//Am; // ���������
//Cu; // �������
//Su; // �������
//Tk; // �������������
//Ok; // ���������
//Eb; // �����
//cardActionSuNum; // ���������� ����������� �������� "��������� + / ������� -" �� ������� ����
//cardActionSuNumNew; // ���������� ����������� �������� "��������� + / ������� -" �� ������� � ������� ���
//cardActionEbNum; // ���������� ����������� �������� "������� + / ��� -" �� ������� ����
//cardActionEbNumNew; // ���������� ����������� �������� "������� + / ��� -"  �� ������� � ������� ���
//cardActionNum; // ���������� ��������, ������� ����� ��� ��������� ����, �������� � ������� ��
//peopleLoss; // ���������� �����, ���������� � ����������� ����, �������� � ������� ��
//buildRisNew; // ���������� ����������� ������� ����� �� ������� � ������� ���
//buildRisNum; // ���������� ������� ����� ��� ��������� ���������

//// ��������� ��������� � �������
//if seasonNew = 2
// Am = SetActive 
// Cu = SetActive
// satisfactionAm = 0f
// satisfactionCu = 0f

//// ��������� �������
//if choice = 2
//  if cardAction = 5
//     cardActionSuNumNew = cardActionSuNum + 1;
//if cardActionSuNumNew >= cardActionNum
// Su = SetActive
// satisfactionSu = 0f

//// ��������� �������������
//if peopleResources - peopleResoursesLast >= peopleLoss
// Tk = SetActive
// satisfactionTk = 0f 

//// ��������� ���������
//if buildRisNew >= buildRisNum
// Ok = SetActive
// satisfactionOkNew = 0f

//// ��������� �����
//if choice = 2
//  if cardAction = 4
//      cardActionEbNumNew = cardActionEbNum + 1;
//if cardActionSuNumNew >= cardActionNum
// Eb = SetActive
// satisfactionEb = 0f




//// ������� �����

//// ��������
//if satisfactionIg <= -30
//        LohPidorAzazaGameOver

//if satisfactionIm <= -30
//        LohPidorAzazaGameOver

//if satisfactionAm <= -30
//        LohPidorAzazaGameOver

//if satisfactionCu <= -30
//        LohPidorAzazaGameOver

//if satisfactionSu <= -30
//        LohPidorAzazaGameOver

//if satisfactionTk <= -30
//        LohPidorAzazaGameOver

//if satisfactionOk <= -30
//        LohPidorAzazaGameOver

//if satisfactionEb <= -30
//        LohPidorAzazaGameOver

//// �� -20, ��� ���������� �������������
//hardGodPunish = 0.2f; // ������� ������ �� -20 �����������������, �������� � ������� ��

//if satisfactionIg <= -20
//        materialResourcesNew = materialResources * (1 - hardGodPunish)

//if satisfactionIm <= -20
//        foodResourcesNew = foodResources * (1 - hardGodPunish)

//if satisfactionAm <= -20
//        materialResourcesNew = materialResources * (1 - hardGodPunish)        

//if satisfactionCu <= -20
//        peopleResourcesNew = peopleResources * (1 - hardGodPunish)        

//if satisfactionSu <= -20
//        peopleResourcesNew = peopleResources * (1 - hardGodPunish)        

//if satisfactionTk <= -20
//        happyResourcesNew = happyResources * (1 - hardGodPunish)        

//if satisfactionOk <= -20
//        foodResourcesNew = foodResources * (1 - hardGodPunish)           

//if satisfactionEb <= -20
//        happyResourcesNew = happyResources * (1 - hardGodPunish)           


//// �� -10, ��� ���������� �������������
//softGodPunish = 0.1f; // ������� ������ �� -10 �����������������, �������� � ������� ��

//if satisfactionIg <= -10
//        materialResourcesNew = materialResources * (1 - softGodPunish)

//if satisfactionIm <= -10
//        foodResourcesNew = foodResources * (1 - softGodPunish)

//if satisfactionAm <= -10
//        materialResourcesNew = materialResources * (1 - softGodPunish)        

//if satisfactionCu <= -10
//        peopleResourcesNew = peopleResources * (1 - softGodPunish)        

//if satisfactionSu <= -10
//        peopleResourcesNew = peopleResources * (1 - softGodPunish)        

//if satisfactionTk <= -10
//        happyResourcesNew = happyResources * (1 - softGodPunish)        

//if satisfactionOk <= -10
//        foodResourcesNew = foodResources * (1 - softGodPunish)           

//if satisfactionEb <= -10
//        happyResourcesNew = happyResources * (1 - softGodPunish)           


//// �� +10, ��� ���������� �������������
//softGodPunish = 0.1f; // ������� ������ �� -10 �����������������, �������� � ������� ��

//if satisfactionIg >= 10
//        happyBuildNew = happyBuild + 1
//        buildBanNew = buildBan + 1

//if satisfactionIm >= 10
//        peopleBuildNew =  peopleBuild + 1
//        buildZhilNew = buildZhil + 1

//if satisfactionAm >= 10
//        materialBuildNew =  materialBuild + 1
//        buildLesNew = buildLes + 1

//if satisfactionCu >= 10
//        materialBuildNew =  materialBuild + 1
//        buildKamNew = buildKam + 1        

//if satisfactionSu >= 10
//        foodBuildNew =  foodBuild + 1
//        buildKolNew = buildKol + 1        

//if satisfactionTk >= 10
//        peopleBuildNew =  peopleBuild + 1
//        buildKazNew = buildKaz + 1        

//if satisfactionOk >= 10
//        foodBuildNew =  foodBuild + 1
//        buildRisNew = buildRis + 1        

//if satisfactionEb >= 10
//        happyBuildNew =  happyBuild + 1
//        buildTeaNew = buildTea + 1



//// �� +20, ��� ���������� �������������
//softGodAdd = 0.2f; // ������� ���� �� +20 �����������������, �������� � ������� ��

//if satisfactionIg >= 20
//        materialResourcesNew = materialResources * (1 + softGodAdd)

//if satisfactionIm >= 20
//        foodResourcesNew = foodResources * (1 + softGodAdd)

//if satisfactionAm >= 20
//        materialResourcesNew = materialResources * (1 + softGodAdd)        

//if satisfactionCu >= 20
//        peopleResourcesNew = peopleResources * (1 + softGodAdd)        

//if satisfactionSu >= 20
//        peopleResourcesNew = peopleResources * (1 + softGodAdd)        

//if satisfactionTk >= 20
//        happyResourcesNew = happyResources * (1 + softGodAdd)        

//if satisfactionOk >= 20
//        foodResourcesNew = foodResources * (1 + softGodAdd)           

//if satisfactionEb >= 20
//        happyResourcesNew = happyResources * (1 + softGodAdd)           


//// �� +30, ��� ���������� �������������
//hardGodAdd = 1.5f; // ������� ���� �� +30 �����������������, �������� � ������� �� (����� �������� � ��������)
//satisfactionIgIm = 5f;  // ������� ���� �� +30 ����������������� ��� �������� � ��������, �������� � ������� ��

//if satisfactionIg >= 30
//        satisfactionImNew = satisfactionIm + satisfactionIgIm

//if satisfactionIm >= 30
//        satisfactionIgNew = satisfactionIg + satisfactionIgIm

//if satisfactionAm >= 30
//        materialResourcesNew = materialResources * hardGodAdd     

//if satisfactionCu >= 30
//        peopleResourcesNew = peopleResources * hardGodAdd     

//if satisfactionSu >= 30
//        peopleResourcesNew = peopleResources * hardGodAdd       

//if satisfactionTk >= 30
//        happyResourcesNew = happyResources * hardGodAdd        

//if satisfactionOk >= 30
//        foodResourcesNew = foodResources * hardGodAdd          

//if satisfactionEb >= 30
//        happyResourcesNew = happyResources * hardGodAdd


//}
