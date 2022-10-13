# Követelmény specifikáció
## 1. Áttekintés
***

Az alkalmazás célja, hogy szimulálja egy kávéautomata működését.
Az alkalmazás Windows Forms kezelőfelülettel rendelkezik.
Kezeli a különbözú elkészítési variációkat, melyeket a felhasználó adhat meg, gombokkal, legördülő sávból.
Miután végzett vele a program, kiirja az összeget, amit megpróbál levonni az egyenlegből. Ha nem tudja, akkor megszakítja a folyamatot és az egyenleg feltöltéshez irányítja a felhasználót. Amennyiben sikeres az összeg levétele, akkor levonja az összeget.

## 2. Jelenlegi rendszer
***
A megrendelőnek van egy kávézója és ami modernizálni szeretne azzal, hogy ne csak helyben, hanem online is lehessen rendeléseket leadni, és mi erre keresünk megoldást.


## 3. Vágyálom rendszer
***
Egy pénztárcát feltudunk tölteni pénzzel, amit ellehet majd költeni arra amit akarunk.
A kávégép rendelkezik majd több variációval, és az alapján számolja ki az összeget, majd vonja le a pénztárcánkból.
Nem lehet mindent kombinálni mindennel, hanem csak azokat a dolgokat, amiknek értelme is van.


## 4. Funkcionális követelmény
***
Felhasználói funkció -  A felhasználó fel tud tölteni egy összeget, amivel később rendelkezhet.

Ez után gombokat használva tudja kiválasztani, hogy mit szeretne elkészíttetni, majd a gép levonja az összeget, amennyiben lehetséges a variáció.

## 5. Jelenlegi üzleti folyamatok modellje
***
A programunk elősegíti az automatizációt egy ital összeállításában.
Gombnyomásra elkészíti a gép azt az italt, amit a vásárló szeretne.

## 6. Igényelt üzleti folyamatok
***
A felhasználó a fő oldalon látja az egyenlegét, és ha szeretné akkor tölthet fel hozzá összeget.
A feltöltés mellett kitudja gomokkal választani, hogy mit szeretne inni. Felületen látja, hogy mik küzöl választhat, és egy gomb megnyomásával fizethet.
Utánna a program kiirja, hogy mennyit kell fizetni, és hogyha nincsen annyi összeg a tárcában, akkor jelez a felhasználónak és megszakítja a folyamatot.
Amennyiben rendelkezik az összeggel, akkor levonja az árat.


## 7. Követelménylista
***

| Modul      | ID         | Név  |v. |  Kifejtés|
| ------------- |:-------------:| -----:|-|--|
| Felület   | K1 | Balance kiirása |1.0| A felhasználó látja a feltöltött egyenlegét|
|Modifikáció | K2 | Balance feltöltése  |1.0| A felhasználó feltud tölteni összeget a tárcájába|
| Felület| K3 | Ital kiválasztása  | 1.0| A felhasználó kitudja választani, hogy milyen jellegű italt szeretne választani|
| Felület| K4 | Cukor mennyiség kiválasztása  |1.0|A felhasználó + / - gombokkal kitudja választani hogy mennyi cukrot szeretne, és ezt a mennyiséget egy progress báron látja|
|Felület | K5 |A végösszeg kiirása  |1.0| A felhasználónak kiirja a program, hogy mennyibe kerül az itala|
|Modifikáció | K6 |Az összeg levonása  |1.0|A program levonja a megrendelés összegét a tárcából, amennyiben rendelkezik a megfelelő összeggel|

## 8. Fogalomtár
***
Drop-down menü - Legördülő lista,<br>
Balance - Egyenleg,<br>
Progress Bar - Az adott folyamat előrehaladottságát egy csíkon vizuálisan megmutatja<br>

