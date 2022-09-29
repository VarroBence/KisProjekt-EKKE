# Követelmény specifikáció
#### Áttekintés
***

Az alkalmazás célja, hogy szimulálni lehessen egy kávéautomata működését.
Az alkalmazás windows form kezelőfelülettel rendelkezik.
Kezeli a különbözú elkészítési variációkat, melyeket a felhasználó ad meg, gombokkal, és legördülő sávból.
Miután végzett vele a program kiirja az összeget, amit megpróbál levonni az egyenlegből, ha nem tudja, akkor megszakítja a folyamatot és az egyenleg feltöltéshez irányítja a felhasználót. Amennyiben sikeres az összeg levétele, akkor levonja az összeget.

#### Vágyálom rendszer
***
Egy pénztárcát feltudunk tölteni pénzzel, amit ellehet majd költeni arra amit akarunk.
A kávégép rendelkezik majd több variációval, és az alapján számolja ki az összeget, majd vonja le a pénztárcánkból.
Nem lehet mindent kombinálni mindennel, hanem csak azokat a dolgokat, amiknek értelme is van.

#### Funkcionális követelmény
***
Felhasználói funkció -  A felhasználó fel tud tölteni egy összeget, amivel később rendelkezhet.

Ez után gombokat használva tudja kiválasztani, hogy mit szeretne elkészíttetni, majd a gép levonja az összeget, amennyiben lehetséges a variáció.

#### Jelenlegi üzleti folyamatok modellje
***
A programunk elősegíti az automatizációt egy ital összeállításában.
Gombnyomásra elkészíti a gép azt az italt, amit a vásárló szeretne.

#### Igényelt üzleti folyamatok
***
A felhasználó a fő oldalon látja az egyenlegét, és ha szeretné akkor tölthet fel hozzá összeget.
A feltöltés mellett kitudja gomokkal választani, hogy mit szeretne inni. Felületen látja, hogy mik küzöl választhat, és egy gomb megnyomásával fizethet.
Utánna a program kiirja, hogy mennyit kell fizetni, és hogyha nincsen annyi összeg a tárcában, akkor jelez a felhasználónak és megszakítja a folyamatot.
Amennyiben rendelkezik az összeggel, akkor levonja az árat.
