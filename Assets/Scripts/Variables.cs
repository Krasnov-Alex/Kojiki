//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Variables : MonoBehaviour
//{
//materialResources = 1000f; // начальное количество материалов
//foodResources = 1000f; // начальное количество еды
//happyResources = 1000f; // начальное количество счастья
//materialResourcesNew; // новое количество материалов
//foodResourcesNew; // новое количество еды
//happyResourcesNew; // новое количество счастья
//peopleResources = 1000f; // начальное количество населения
//peopleResoursesLast; // количество населения на предыдущем ходе
//peopleCoef = peopleResoursesLast / 1000; // корректирующий коэффициент от населения
//peopleResourcesAdd = 500f; // прибавление населения от постройки зданий жилья, задается в админке ГД

//materialBuild = 1f; // начальное количество зданий материалов (может быть как лесопилкой, так и каменоломней, выбирается рандомно)
//foodBuild = 1f; // начальное количество зданий еды (может быть как рисовым полем, так и колодцем, выбирается рандомно)
//happyBuild = 1f; // начальное количество зданий счастья (может быть как театром, так и баней, выбирается рандомно)
//peopleBuild = 1f; // начальное количество зданий жилья (может быть как казармой, так и жилым домом, выбирается рандомно)
//buildCost; // стоимость строительства любой постройки (в т.ч. храма), задается в админке ГД
//materialBuildNew; // новое количество зданий материалов
//foodBuildNew; // новое количество зданий еды
//happyBuildNew; // новое количество зданий счастья
//peopleBuildNew; // новое количество зданий жилья

//templeIg = 1f; // начальное количество храмов Идзанаги
//templeIm = 1f; // начальное количество храмов Идзанами
//templeAm = 0f; // начальное количество храмов Аматерасу
//templeCu = 0f; // начальное количество храмов Цукуеми
//templeSu = 0f; // начальное количество храмов Сусаноо
//templeTk = 0f; // начальное количество храмов Такэмикадзуси
//templeOk = 0f; // начальное количество храмов Окунинуси
//templeEb = 0f; // начальное количество храмов Эбису

//satisfactionIg = 0f; // начальное количество очков удовлетворенности (от -30 до 30) Идзанаги
//satisfactionIm = 0f; // начальное количество очков удовлетворенности (от -30 до 30) Идзанами
//satisfactionAm = 0f; // начальное количество очков удовлетворенности (от -30 до 30) Аматерасу
//satisfactionCu = 0f; // начальное количество очков удовлетворенности (от -30 до 30) Цукуеми
//satisfactionSu = 0f; // начальное количество очков удовлетворенности (от -30 до 30) Сусаноо
//satisfactionTk = 0f; // начальное количество очков удовлетворенности (от -30 до 30) Такэмикадзуси
//satisfactionOk = 0f; // начальное количество очков удовлетворенности (от -30 до 30) Окунинуси
//satisfactionEb = 0f; // начальное количество очков удовлетворенности (от -30 до 30) Эбису
//satisfactionTakeMinus = 2f; // снижение удовлетворенности богам от добычи, задается в админке ГД
//satisfactionActionAdd = 2f; // добавление удовлетворенности богам от действий, задается в админке ГД
//satisfactionActionMinus = 2f; // снижение удовлетворенности богам от действий, задается в админке ГД
//satisfactionBuildAdd = 5f; // добавление удовлетворенности богам от простых построек, задается в админке ГД
//satisfactionTempleAdd = 10f; // добавление удовлетворенности богам от храмов, задается в админке ГД


//// если добавляю New в конце, то очевидно это количество в новом ходу    




//// смена сезона
//moves = 0f; // количество ходов
//season = 3f; // номер сезона (1 - весна, 2 - лето, 3 - осень, 4 - зима)
//seasonNew; // новый сезон
//    if moves = 3 
//        seasonNew = season + 1; // если прошло 3 хода, сезон меняется




//// списание ресурсов за смену сезона
//seasonDebuff; // списание ресурсов за смену сезона, задается в админке ГД
//seasonDebuffCoef = 0.5f; // множитель изменения дебафа за смену сезона, задается в админке ГД
//seasonCoef = 0.25f; // множитель сезона на добычу, задается в админке ГД
//seasonDebuffNew; // новый множитель изменения дебафа 
//seasonCoefNew; // новый мнозитель сезона на добычу

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
//// население не списывается за сезон!!!!





//choice; // выбор карты (1 - добыча, 2 - действие, 3 - постройка)
//choiceNew; // выбор следущего хода

//// взятие карточки добычи
//cardTake; // вид карты добычи (1 - материалы, 2 - еда, 3 - счастье)
//cardTakeNum; // количество очков за карту добычи

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
//        materialResourcesNew = materialResources + (((materialBuildNew * cardTakeNum) * peopleCoefNew) * seasonCoef); // новое количество ресурсов в зависимости от количества зданий этих ресурсов, выбора карточки добычи, множителя от населения и множителя сезона
                
//      if cardTake = 2
//        foodResourcesNew = foodResources + (((foodBuildNew * cardTakeNum) * peopleCoefNew) * seasonCoef);  // новое количество ресурсов в зависимости от количества зданий этих ресурсов, выбора карточки добычи, множителя от населения и множителя сезона

//      if cardTake = 3 
//        happyResourcesNew = happyResources + (((happyBuildNew * cardTakeNum) * peopleCoefNew) * seasonCoef);  // новое количество ресурсов в зависимости от количества зданий этих ресурсов, выбора карточки добычи, множителя от населения и множителя сезона


//// взятие карточки действия
//cardAction; // вид карты действия (1 - "материалы + / еда -", 2 - "еда + / материалы -", 3 - "еда + / население -", 4 - "счастье + / еда -", 5 - "население + / счастье -")
//cardActionBuff; // добавление ресурсов за карту действия (от 200 до 500 с шагом 100)
//сardActionDebuff; // списание ресурсов за карту действия (от 100 до 400 с шагом 100)
//cardActionBuff = сardActionDebuff + 100; // количество добавленных ресурсов на 100 единиц больше потраченных!!!
//cardActionName; // тип карты действия (от 1 до 4, в Балансе Кодзики таблица O26:S30 в соответствии с видами карт)

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

//// взятие карты постройки              
//cardBuild; // вид карты постройки (1 - материалы, 2 - еда, 3 - счастье, 4 - жилье, 5 - храм)
//materialBuildName; // тип карты постройки материалов (либо 1, либо 2, по номерам здесь в зависимости от типа https://docs.google.com/document/d/1NZxKjx5kebJ-ujNRXWZCpF21uk3yNCs14vKUsxv8sqc/edit)        
//foodBuildName; // тип карты постройки еды (либо 1, либо 2, по номерам здесь в зависимости от типа https://docs.google.com/document/d/1NZxKjx5kebJ-ujNRXWZCpF21uk3yNCs14vKUsxv8sqc/edit)        
//happyBuildName; // тип карты постройки счастья (либо 1, либо 2, по номерам здесь в зависимости от типа https://docs.google.com/document/d/1NZxKjx5kebJ-ujNRXWZCpF21uk3yNCs14vKUsxv8sqc/edit)        
//peopleBuildName; // тип карты постройки жилья (либо 1, либо 2, по номерам здесь в зависимости от типа https://docs.google.com/document/d/1NZxKjx5kebJ-ujNRXWZCpF21uk3yNCs14vKUsxv8sqc/edit)        
//templeName; // тип храма (в зависимости от бога от 1 до 8)
//buildLes; // количество построенных за прошлые ходы лесопилок
//buildLesNew; // количество построенных за текущий и прошлые ходы лесопилок
//buildKam; // количество построенных за прошлые ходы каменоломен
//buildKamNew; // количество построенных за текущий и прошлые ходы каменоломен
//buildKol; // количество построенных за прошлые ходы колодцев 
//buildKolNew; // количество построенных за текущий и прошлые ходы колодцев
//buildLes; // количество построенных за прошлые ходы рисовых полей
//buildLesNew; // количество построенных за текущий и прошлые ходы полей
//buildTea; // количество построенных за прошлые ходы театров
//buildTeaNew; // количество построенных за текущий и прошлые ходы театров
//buildBan; // количество построенных за прошлые ходы бань
//buildBanNew; // количество построенных за текущий и прошлые ходы бань
//buildZhil; // количество построенных за прошлые ходы жилых домов
//buildZhilNew; // количество построенных за текущий и прошлые ходы домов
//buildKaz; // количество построенных за прошлые ходы казарм
//buildKazNew; // количество построенных за текущий и прошлые ходы казарм


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




//// появление богов
//Ig; // Идзанаги
//Im; // Идзанами
//Am; // Аматерасу
//Cu; // Цукуеми
//Su; // Сусаноо
//Tk; // Такэмикадзуси
//Ok; // Окунинуси
//Eb; // Эбису
//cardActionSuNum; // количество выполненных карточек "население + / счастье -" за прошлые ходы
//cardActionSuNumNew; // количество выполненных карточек "население + / счастье -" за прошлые и текущий ход
//cardActionEbNum; // количество выполненных карточек "счастье + / еда -" за прошлые ходы
//cardActionEbNumNew; // количество выполненных карточек "счастье + / еда -"  за прошлые и текущий ход
//cardActionNum; // количество карточек, которое нужно для появления бога, задается в админке ГД
//peopleLoss; // количество людей, потерянных с предыдущего хода, задается в админке ГД
//buildRisNew; // количество построенных рисовых полей за прошлые и текущий ход
//buildRisNum; // количество рисовых полей для появления Окунинуси

//// появление Аматерасу и Цукуеми
//if seasonNew = 2
// Am = SetActive 
// Cu = SetActive
// satisfactionAm = 0f
// satisfactionCu = 0f

//// появление Сусаноо
//if choice = 2
//  if cardAction = 5
//     cardActionSuNumNew = cardActionSuNum + 1;
//if cardActionSuNumNew >= cardActionNum
// Su = SetActive
// satisfactionSu = 0f

//// появление Такэмикадзуси
//if peopleResources - peopleResoursesLast >= peopleLoss
// Tk = SetActive
// satisfactionTk = 0f 

//// появление Окунинуси
//if buildRisNew >= buildRisNum
// Ok = SetActive
// satisfactionOkNew = 0f

//// появление Эбису
//if choice = 2
//  if cardAction = 4
//      cardActionEbNumNew = cardActionEbNum + 1;
//if cardActionSuNumNew >= cardActionNum
// Eb = SetActive
// satisfactionEb = 0f




//// влияние богов

//// проигрыш
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

//// на -20, все происходит единовременно
//hardGodPunish = 0.2f; // уровень дебафа за -20 удовлетворенности, задается в админке ГД

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


//// на -10, все происходит единовременно
//softGodPunish = 0.1f; // уровень дебафа за -10 удовлетворенности, задается в админке ГД

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


//// на +10, все происходит единовременно
//softGodPunish = 0.1f; // уровень дебафа за -10 удовлетворенности, задается в админке ГД

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



//// на +20, все происходит единовременно
//softGodAdd = 0.2f; // уровень бафа за +20 удовлетворенности, задается в админке ГД

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


//// на +30, все происходит единовременно
//hardGodAdd = 1.5f; // уровень бафа за +30 удовлетворенности, задается в админке ГД (кроме идзанами и идзанаги)
//satisfactionIgIm = 5f;  // уровень бафа за +30 удовлетворенности для идзанами и идзанаги, задается в админке ГД

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
