# Uhlovodíky
Aplikace "Uhlovodíky" vznikla jako školní projekt pro předměty informatika a chemie pro 9. třídu ZŠ (v rámci domácího vzdělávání). Na aplikaci jsem spolupracovala s taťkou, který je dlouholetým vývojářem a poskytoval mi mnoho pomoci.

## Zadání
Cílem bylo převést část aplikace, kterou jsem dříve připravila v jazyce Scratch, do jazyka C# a nasadit aplikaci do internetu. Úkolem aplikace bude převádět názvy jednoduchých uhlovodíků (alkany, alkeny, alkyny) na jejich vzorce a opačně (vzorce na názvy). Aplikace bude fungovat bez uživatelského rozhraní (to by bylo už poměrně složité), ale poskytne možnost reagovat na vstup uživatele:
- uživatel zadá typ uhlovodíku a vzorec, aplikace zobrazí název nebo chybový text
- uživatel zadá typ uhlovodíku a název, aplikace zobrazí sumární vzorec nebo chybový text.

## Návrh řešení
S taťkou jsme se dohodli, že vhodným prostředím pro takovou aplikaci bude Azure Functions, což je cloudová výpočetní platformy společnosti Microsoft. Tak budeme mít k dispozici velmi jednoduché rozhraní pro zadávání vstupu uživatele přímo v internetové adrese.
Pro obě možnosti aplikac (převod vzorce na název, převod názvu na vzorec) vytvoříme samostatnou funkci. Logiku zpracování umístíme do samostatné knihovny, aby bylo možné ji případně použít i v jiném projektu (např. aplikace pro mobilní telefon nebo počítač s Windows). Tím nám vzniknou dva projekty - knihovna a projekt s funkcemi pro Azure Functions.
K programování jsme použili Visual Studio 2022 Community Edition a taťkovo předplatné služeb Microsoft Azure.

### Předání uživatelského vstupu
Parametry pro zpracování budou předány přímo jako součást adresy (požadavku), což funkce v Azure Functions umožňují:
- převod názvu na vzorec: https://adresaaplikace/vzorecznazvu/{druh}/{nazev}, kde {druh} je určení druhu uhlovodíku a {nazev} je název uhlovodíku, jehož vzorec chceme získat
- převod názvu na vzorec: https://adresaaplikace/nazevzevzorce/{druh}/{vzorec}, kde {druh} je určení druhu uhlovodíku a {vzorec} je vzorec uhlovodíku, jehož název chceme získat
Parametr {druh} může v obou případech nabývat pouze jedné z hodnot "alkan", "alken", "alkyn".

### Zpracování uživatelského vstupu
Podle druhu uhlovodíku bude vybrána správná třída pro výpočet. Všechny tři výpočetní třídy (Alkan, Alken, Alkyn) budou implementovat rozhraní IUhlovodik se dvěma metodami:
- VzorecZNazvu
- NazevZeVzorce
Tyto metody budou zodpovědné za zpracování vstupu a přípravu odpovědi jednoduchým voláním jedné z těchto metod z odpovídající funkce podle zadaného typu uhlovodíku. Funkce si prostě vyrobí objekt správné třídy a tento objekt provede výpočet. 
Složité je poznat ze vzorce, o který uhlovodík se jedná, protože k tomu potřebujeme rozložit vzorec na části, které nám řeknou, kolik uhlíků a kolik vodíků ve vzorci je. Taťka mi pomohl vyrobil regulární výraz (to se těžko vysvětluje, co to je) a přes ten se k počtu uhlíků a vodíků dostaneme. Dokonce i poznáme, jestli vzorec odpovídá tomu, jak by měl obecně vypadat (CxHy).
Pro práci se základy názvů uhlovodíků jsme připravili jednoduchou paměťovou strukturu, ve které se dá hledat podle počtu uhlíků, ale i podle základu názvu (např. "eth" nebo "prop"). V našem seznamu základů máme 10 základních uhlovodíků, ale šlo by ho rozšířit i na další složitější uhlovodíky s více než 10 uhlíky. Když tvoříme vzorec, hledáme v seznamu základů podle základu názvu. Když tvořím název, hledám v seznamu základů podle počtu uhlíků. K hledání v seznamu používáme LINQ, to je dotazovací jazyk pro práci různými daty nebo strukturami.

## Výsledek naší práce
Výsledek naší práce lze vyzkoušet na adrese http://uhlovodiky.azurewebsites.net.
- pro zjištění vzorce ethenu stačí zadat do prohlížeče adresu http://uhlovodiky.azurewebsites.net/vzorecznazvu/alken/ethen
- pro zjištění názvu ze vzorce C2H4 stačí zadat do prohlížeče adresu http://uhlovodiky.azurewebsites.net/nazevzevzorce/alken/c2h4

Áňa
