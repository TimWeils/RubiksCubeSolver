﻿# Vývojářský deník
### 1. den
Hned na samotném začátku na mě čekal velice obtížný úkol. Navrhnout jakým způsobem bude kostka reprezentována v paměti. Dlouho jsem nad tím přemýšlel až jsem nakonec dospěl k tomuto řešení. V rámci třídy Side budu ukládat jednotlivé kostky (4 rohové, 4 boční a 1 středovou) každé z šesti stěn. Každá z těchto kostek bude ukládat informace o všech svých barvách. Tedy i o barvách které se nacházejí na okolních stěnách. Slibuji si od toho pohodlnější implementaci algoritmů pro řešení kostky. Jednotlivé stěny jsou pak uloženy v rámci pole ve třídě Cube. Zde si také pamatuji jakým způsobem je kostka natočena k řešiteli (pozorovateli) a to tak, že si ukládám jaká je středová barva horní a čelní stěny.

Při psaní jsem však narazil na drobný problém. Původně jsem chtěl jednotlivé kostky uložit do jednoho pole. To by se dalo udělat přes společný interface. Jenže kostky nemají jednotný počet barev a proto by bylo složité vracet jejich hodnoty pomocí metod z jednoho předka. Interface jsem prozatím v kódu ponechal, možná se k jeho plné implementaci v budoucnu vratím. Nyní jsem však tuto myšlenku opustil a strana si ukládá kostky v rámci specializovaných polí. Zároveň trochu začínám pochybovat jestli zvolené řešení není zbytečně komplikované. Nic mi ale nebrání se v budoucnu uchýlit k jednodušší variantě. Například si v rámci stěn nadefinovat pouze pole barev, kde bych si pamatoval pouze barvy dané stěny.

Přesto, že ve výsledku půjde o WinForm aplikaci uchýlil jsem se zatím pouze ke konzolovému výstupu. Bylo jednodušší ho implementovat a lze s ním lehce otestovat funkčnost kódu. Jedinou nevýhodou je absence oranžové barvy v konzoli. Oranžová je tedy nahrazena magentou. 

Momentálně umí program uložit do paměti vyřešenou kostku a zpětně ji vypsat do konzole. V následujících dnech mě čeká implementace funkcí pro pohyb kostky. S jejich pomocí pak půjde s kostkou v paměti otáčet. Následovat bude postupná implementace jednotlivých algoritmů.

### 2. den
Dnes jsem se pustil do implementace pohybů kostky. Začal jsem těmi základními, tedy U, D, R, L, F, B a jejich inverzemi. Chvíli mi přišlo, že to bude lehce problematické, protože kostka se v době, kdy má k pohybu dojít, nemusí nacházet v počáteční pozici (tu jsem si definoval tak, že čelní stěna kostky je červená a horní žlutá). Záhy jsem ale přišel na to, že to až tak velký problém nebude. Postačí všechny pohyby naprogramovat pro tuto základní polohu a případné otáčení v jiných polohách nahradit korespondujícími pohyby v základní poloze.

Vrhnul jsem se tedy na implementaci. Během ní jsem se opět dostal k problému jak jednotlivé strany reprezentovat v paměti. Myslel jsem, že se mi moje obsáhlejší reprezentace bude hodit při implementaci. Ukázalo se však, že není vůbec potřeba. Rozhodl jsem se tedy reprezentaci zjednodušit. Jednotlivé stěny si tak ukládají pouze pole stejných políček, kde v každém je uložena pouze barva na dané stěně. Zatím ale nechci uplně vyhodit ani starou složitější reprezentaci. V kódu jsem ji tak zatím ponechal v rámci komentářů a pokud se v budoucnu ukáže, že by se mi hodila tak se k ní vrátím.

Po naimplementování všech základních pohybů jsem se zamyslel nad implementací těch složitějších. Došlo mi, že je možné je naimplementovat pomocí těch základních a rotace. Začal jsem tedy s implementací rotace. Po dokončení jsem si chtěl funkčnost otestovat. Narazil jsem však na menší problém. Došlo mi, že tak jak mám základní pohyby L, R, F a B naimplementované tak jsou dobré pouze pokud je kostka v počáteční pozici. Jinak totiž nesedí rozložení políček na bílé a žluté stěně. Při hledání řešení jsem si uvědomil další nedostatek mého kódu. Ukázalo se totiž, že pohyby F a B by bylo možné naimplementovat i pomocí L a R. A pokud by se to mělo vzít do detailu pohyb L, lze nahradit pohybem R (a obráceně samozřejmě). Bylo by potřeba pouze vhodně zadat parametry pro pohyb.

Zároveň jsem si uvědolmil, že ani moje jednoduchá funkce na vypsaní kostky není bez chyb. Dokáže totiž kostku vypsat pouze v základní pozici a to i když je v paměti uložena v jiné. V budoucnu ji tedy budu muset upravit tak, aby dokázala kostku vypsat v takové pozici jaká je právě uložena v paměti.

Dnes tedy končím s rozpracovanou implementací pohybu. Díky chybám v základních pohybech jsem se k pokročilým nedostal. Během dalších dnů doladím pohyb kosty. Nejspíš se pokusím pohyby co nejvíce ořezat. Počítám, že mi nakonec zbyde pouze implementace pohybů U, D, R a jejich inverzí.

### 3. den
Podle plánu z minula jsem se vrhnul na opravu a doimplementování pohybů. Začal jsem tím, že jsem všechny pohyby převedl tak, aby využívaly pouze implementaci pohybů yU, yD, yR a jejich inverzí. Během toho jsem narazil na pár chyb v mém dosavadním kódu. V rámci vypisování kostky jsem barvu stěny četl ze špatného políčka na stěně. V rámci implementace R (a inverzního R) jsem indexoval políčka na zadní straně obráceně (0, 3, 6 namísto 6, 3, 0). Chyba nebyla zřejmá protože pohyby testuji na složené kostce a zatím je moc nekombinuji. Indexaci jsem upravil a doplnil i funkce které na základě barvy přední strany kostky vrátí příslušné indexy na žluté a bílé stěně kostky tak, aby bylo možné provést R (a jeho inverzi). Následně jsem začal implementovat zbylé pohyby. Během jejich implementace jsem zjistil, že v rámci L a R pohybů (a jejich inverzí) nezohledňuji případ, kdy je žlutá či bílá barva na přední stěně. Případy jsem lehce ošetřil a pokračoval v implementaci. Po dokončení jsem se pustil do testování sekvencí pohybů. Hned jsem ale narazil na problém. Při implementaci pohybů yU, yD a yR (a jejich inverzí) totiž nerotuji s políčky na rotovaných stěnách (při pohybu U se políčka na horní stěně neotočí kolem středu). Doteď jsem si toho nevšiml kvůli tomu, že pohyby testuji na složené kostce (jak jsem již zmiňoval výše). Tuto chybu budu opravovat až příště. Společně s tím na mě čeká implementace lepšího vypsaní kostky, kterou jsem avizoval již minule.

### 4. den
Začal jsem opravou chyby z minula. Nebylo to nic náročného. Zároveň jsem během opravování udělal pár vylepšení v kódu. Funkce rotace yR dříve vyžadovala barvu přední a zadní stěny kostky. Ukázalo se však, že po opravení chyby by bylo zapotřebí vyžadovat i barvu pravé stěny. Kód byl tedy upraven tak, že funkce vyžaduje pouze barvu přední stěny. Zbylé barvy si dopočítá sama. Zároveň jsem přesunul funkce počítající souřadnice na žluté a bílé stěně (GetYCoordinates a GetWCoordinates) do samotné kostky a rozšířil je na celou stěnu. Toto sjednocené indexování mi jistě pomůže při psaní řešících algoritmů. Následně jsem otestoval jestli jsem se chyby zbavil. Bylo tomu skutečně tak, bohužel se ukázalo, že chyba se nachází i ve funkcích pro Y a Z rotaci. Náprava však nebyla složitá.

Provedl jsem také vyčištění kódu. Zbavil jsem se zakomentovaných sekcí, které používaly složitější variantu ukládání kostky v paměti. Zbavil jsem se i tříd, které tuto variantu uložení podporovaly. S rostoucí velikostí kódu by bylo složité se k této variantě vracet a přijde mi, že se obejdu i bez ní.

Následně jsem se pustil do psaní vylepšené verze vypisování. Nyní se kostka vypíše v rotaci v jaké je v paměti uložena.

Jako další jsem dnes naimplementoval funkci, která dokáže načíst do paměti kostku na základě hodnot od uživatele. Vzhledem k tomu, že se stejně bude aplikace přesouvat z konzole do jiného UI, tak je implementace velice primitivní. Nijak nekontroluje správnost vstupu a tak to i zůstane. Přijde mi zbytečné nad tím v tuto chvíli ztrácet čas. Ošetření nevhodných vstupů tak bude implementováno až s novým UI.

Plán na další dny je jasný, implementace algoritmů pro skládání kostky dle návodu pro začátečníky. Jako první mě čeká algoritmus na White Cross.

### 5. den
Měl jsem začít s implementací White Cross algoritmu. Z obav, že je to až moc náročný úkol, který bude vyžadovat komplikované rešení jsem se ale dnes věnoval úplně něčemu jinému. A to konkrétně UI.

Od začátku jsem plánoval, že půjde o okenní aplikaci s klasickým GUI nikoliv o pouhou konzolovou záležitost. A tak jsem měl v hlavě problém, který bylo třeba vyřešit. Jakým způsobem uživateli zobrazit samotnou kostku, kterou se snaží s pomocí programu složit. Jako první mě napadlo kostku rozložit na síť a tu uživateli zobrazit. Záhy jsem ale zjistil, že to rozhodně není moc elegantní řešení. V takovémto zobrazení se totiž snadno ztratí pohyby barev při otáčení kostkou. Navíc by pohyb probíhal na více místech v jeden okamžik a ještě různými směry. Zároveň by bylo komplikované uživateli ukazovat, kde a v jakém směru se bude s kostkou pohybovat. Navíc síťové zobrazení by mohlo být hodně nepřehledné pro lidi bez prostorové představivosti. Spojit si v hlavě síť v kostku by jim činilo obtíže a mohlo by jim to zcela znemožnit či znechutit používání aplikace.

Asi nejelegantnější řešení, které se nabízelo dále byl 3D model. Model by byl hezky přehledný a pro zobrazení kostky zcela ideální. Bohužel i zde se objevil menší problém. Pokud by šlo pouze o model s barvami tak by se pohyby na kostce mohly snadno ztrácet. Tento problém by jistě vyřešily animace modelu pro pohyb kostky. Indikaci zamýšleného pohybu by pak například šlo realizovat podsvícením či pulzováním dílů, které se budou pohybu účastnit. Kde je tedy problém tohoto řešení? Obávám se, že je až příliš náročné na zpracování. O 3D grafice toho nevím úplně mnoho a nikdy jsem 3D grafiku nedělal od píky. A o animaci toho také nevím mnoho. A proto bych si nejspíš musel hodně věcí nastudovat než bych byl schopný nějaký povedený a funkční 3D model vytvořit.

Jak tedy kostku uživateli zobrazit? Nakonec jsem přišel s tímto nápadem. Uživatel uvidí v rámci GUI pouze jednu stěnu kostky. Ostatní mu budou skryty. Mezi jednotlivými stěnami však půjde přepínat a uživatel tak bude moci s tímto 2D náhledem kostky rotovat. Navíc nebude obtížné naznačovat směry rotací, které má uživatel provést. Jednoduše se kolem náhledu budou ukazovat šipky naznačující směr rotace. Rotace, které se budou odehrávat na kostkách mimo náhled (například B rotace) budou naznačeny také šipkami, ale odlišnými od těch značících rotaci na zobrazované stěně (například rotace F). Prvotní návrh toho jak bych si takové GUI představoval lze nalézt v Gitu jako obrázek *GUI Concept v1.jpg*. Pod samotným 2D náhledem je pak prostor pro zobrazení textu, který bude uživateli říkat jaká rotace se provádí a přidá i doprovodný text popisující rotaci (proč se dělá, jaký je její cíl). Tlačítka po stranách umožní uživateli procházet jednotlivé kroky řešení. Když nad tím teď přemýšlím, možná by nebylo od věci mít k dispozici i tlačítko na přeskočení daného úseku řešení (například pokud chci přeskočit White Cross, protože ho již zvládnu sám). Toto je tedy prozatím můj hrubý návrh toho jak by mohlo GUI vypadat. Přiznávám, že nejde o nejlepší možné řešení, ale přijde mi že nebude těžké ho naimplementovat a pomůže uživateli se na kostce dobře (z)orientovat.

Je zde však jedna věc, kterou ještě nemám úplně vyřešenou. Pokud bude uživatel náhledem rotovat měly by se v textovém poli upravovat rotace tak aby seděly na novou orientaci kostky? Nebo by měly zůstat stejné? Nebude to ale uživatele mást? Pomocné šipky by se totiž měly měnit určitě. A nehodilo by se tedy mít po ruce tlačítko, které by vrátilo náhled do původní polohy?

To jsou otázky, které budu muset časem vyřešit. Myslím, že správnou odpověď na ně najdu až během implementace GUI.

### 6. den

Tento den jsem se konečně odhodlal k vypracování algoritmu na White Cross. Přes prvotní peripetie, kdy jsem si moc nevěděl rady jak problém řešit jsem se nakonec uchýlil ke stromu všech možných řešení. V programu tedy simuluji všechny možnosti řešení White Crossu a nakonec vybírám to které obsahuje nejméně pohybů kostkou.

Tento souhrn je zkrácený protože mám ke dni detailní poznámky na papíře.

### 7. den

Tento den jsem se pustil do další části řešícího algoritmu. Tentokrát to byl algoritmus na White Corners. Základní myšlenka implementace zůstala stejná jako u White Crossu. Přišlo mi, že i zde jde o dobré řešení.

Tento souhrn je zkrácený protože mám ke dni detailní poznámky na papíře.

### 8. den

Implementoval jsem algoritmus řešící hrany v prostřední vrstvě kostky. Zvolil jsem podobný postup jako u předchozího algoritmu.

Tento souhrn je zkrácený protože mám ke dni detailní poznámky na papíře.

### 9. den

Zamýšlel jsem se nad otázkou jestli jsem při implementování jednotlivých kroků zvolil postup vhodný pro začátečníky. Ukázalo se, že moje řešení White Corners moc intuitivní a jednoduché není. Rozhodl jsem se ho tedy naimplementovat znovu, ale jednodušeji. To se mi podařilo.

Tento souhrn je zkrácený protože mám ke dni detailní poznámky na papíře.

### 10. den

Po včerejších pochybách jsem se nakonec zamyslel i nad White Cross řešením a došel jsem k názoru, že ač je můj postup správný, pro úplného začátečníka (někoho, kdo skládá kostku poprvé) není úplně vhodný. Rozhold jsem se tedy naimplementovat novou jednodušší verzi tohoto algoritmu.

Následně jsem se pustil do zbývajících algoritmů, které mi ještě chyběly. Během dne jsem stihl naimplementovat Yellow Cross a Yellow Side algoritmy, které slouží k naorientování žluté strany kostky. Stihl jsem také naimplementovat algoritmus, který žluté rohy správně nasměruje.

Tento souhrn je zkrácený protože mám ke dni detailní poznámky na papíře.

### 11. den

Naimplementoval jsem poslední zbývající algoritmus, který správně umístí žluté hrany. Program je teď tedy schopný kompletně složit celou kostku. Následně jsem program odzkoušel a lehce upravil algoritmy. Nahradil jsem U pohyby sloužící k přesunutí daného dílku na přední stranu za y rotace. Nestane se mi pak, že bych si rozhodil již správně umístěný díl od své spodní části. Následně jsem pomocí programu zkusil složit další kostky. Všechny byly úspěšně složeny nicméně to nezaručuje, že v programu není chyba. Je možné, že na ni akorát program nenarazil.

Tento souhrn je zkrácený protože mám ke dni detailní poznámky na papíře.