# -VP-TicTacToe-131507-131098-
Proektna Zadacha po Vizuelno Programiranje 2015

![alt tag](https://raw.githubusercontent.com/KristinaCvetanovska/-VP-TicTacToe-131507-131098-/master/MainMenu.PNG)

Целта на оваа проектна задача е имплементација на играта Х/0 (Икс-Точка). Оваа игра се игра на табла со 9 полиња (3х3 матрица), така што двајца играчи наизменично одбираат поле каде го поставуваат својот знак (Х или 0). Победникот е оној кој прв ќе нареди три свои знаци (Х или 0) во линија.

Во нашата имплементација корисникот има можност да одбере дали сака да игра против друг играч (Player vs Player) или сака да игра против компјутерот (Player vs PC).

Кога корисникот ќе ја отвори апликацијата TicTacToe.exe, на екранот се појавува почетниот прозорец во кој корисникот може да одбере против каков противник сака да игра (човек или компјутер). 

По изборот на противник, на екранот се појавува нов прозорец, во кој корисникот треба да го напише своето име (и името на својот противник доколку игра против друг човек) и колку партии сака да одигра. Доколку корисникот не го пополни полето за име, нема да биде во можност да го притисне копчето Start за започнување на играта. Исто така во овој прозорец се нуди и можноста за враќање во главното мени со притискање на копчето Cancel, при што ќе се појави прашање за тоа дали корисникот е сигурен дека сака да ја напушти играта.

![alt tag](https://raw.githubusercontent.com/KristinaCvetanovska/-VP-TicTacToe-131507-131098-/master/AddOnePlayer.PNG)

![alt tag](https://raw.githubusercontent.com/KristinaCvetanovska/-VP-TicTacToe-131507-131098-/master/AddTwoPlayers.PNG)


Откако претходниот прозорец уредно ќе се пополни и ќе се притисне копчето Start играта ќе започне. Корисникот (или првиот играч) е секогаш прв на потег и игра со знакот Х, додека компјутерот (или вториот играч) игра со знакот 0.

![alt tag](https://raw.githubusercontent.com/KristinaCvetanovska/-VP-TicTacToe-131507-131098-/master/PlayervsPlayer.PNG)

Во новиот прозорец се појавува таблата со 9 полиња, во долниот лев агол се појавува знакот и името на играчот кој е на потег, во долниот десен агол се наоѓа статистиката за целата игра (бројот на победи на секој од играчите и бројот на нерешени партии), додека помеѓу нив се наоѓа бројот на преостанати партии во играта.

![alt tag](https://raw.githubusercontent.com/KristinaCvetanovska/-VP-TicTacToe-131507-131098-/master/PlayervsPC.PNG)

Играчот кој е на потег одбира едно од слободните полиња на таблата и со притискање на одбраното поле, тој го обележува со својот знак. Играта трае се додека еден од играчите не нареди три свои знаци во линија или нема веќе празни полиња. Кога ќе заврши играта, се појавува или известување со името на играчот кој победил во дадената партија или известување дека партијата завршила нерешено. Потоа почнува нова партија во која играчот кој бил втор на потег во претходната партија сега е прв и така натаму, се додека не се одигра одбраниот број на партии. По завршувањето на играта се појавува известување за тоа кој победил во целата игра т.е. кој има најмногу победени партии или нерешено доколку двајцата играчи имаат ист број на победи.

![alt tag](https://raw.githubusercontent.com/KristinaCvetanovska/-VP-TicTacToe-131507-131098-/master/Draw.PNG)

Апликацијата е реализирана во 5 класи, и тоа:

-Form1 – го содржи почетниот прозорец

-AddOnePlayer – го содржи прозорецот за додавање на еден играч кој ќе игра против компјутер

-Game1p – го содржи прозорецот за играта и кодот за потезите на компјутерот

-AddTwoPlayers – го содржи прозорецот за додавање на двајца играчи кои ќе играат меѓу себе

-Game2p – го содржи прозорецот за играта

Во класата Game1p се наоѓа функцијата Turn() која покрај тоа што одредува кој играч е на потег, одлучува и како компјутерот ќе го одигра својот потег. Ако компјутерот е на потег, оваа функција прво проверува дали компјутерот може во тој потег да победи, а ако не продолжува со тоа што проверува дали може да го спречи противникот да победи во наредниот потег. Ако ни тоа не е можно, компјутерот по случаен избор избира агол од таблата. Доколку ниту еден агол не е слободен, компјутерот пробува да постави 0 во центарот на таблата, а ако и тој е зафатен избира random странично поле.

Исто така во класите Game1p и Game2p има и функција Check() која се повикува после секој потег и проверува дали некој од играчите победил.

Изработиле:  Горазд Николовски 131098 и Кристина Цветановска 131507 
