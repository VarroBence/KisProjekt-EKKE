
# Rendszerterv
## 1. A rendszer célja
A rendszer célja, hogy a felhasználó egy virtuális módon szimulált kávéautomatát használhat. A felhasználó kiválaszthatja, hogy milyen fajta kávét, abba milyen hozzávalót (cukor, tej, stb…) kér. Fontos az átlátható felület, ezért az automata felülete szimpla desgin-t kap.A rendszer ablakos alkalmazás formájában használható. a felhasználó egy mezőbe beírva feltöltheti a digitális tárcáját és onnan fogja levonni az automata a kávé árát. Miután a felhasználó feltöltötte a digitális tárcáját és kiválasztott mindent, amit meg akar vásárolni, a végösszeg megjelenik az automata felületén, majd egy megerősítés után levonja a fizetendő összeget a digitális tárcából.
## 2. Projektterv
### 2.1 Projektszerepkörök, felelősségek:
Product owner: Tóth Tamás
Scrum masters: Varró Bence, Iván Ákos
### 2.2 Projektmunkások és felelősségek:
Design: Iván Ákos
Developer: Tóth Tamás, Varró Bence
Tesztelő: Iván Ákos, Tóth Tamás, Varró Bence
### 2.3 Ütemterv:
![Ütemterv](https://user-images.githubusercontent.com/78543866/193145052-71ea9ab4-3964-4d29-8778-5d478561096c.PNG)
## 3. Üzleti folyamatok modellje
![Blank document](https://user-images.githubusercontent.com/78543866/193145603-2fa70d27-21b5-4322-a144-9bfaac7884a4.jpeg)
## 4. Követelmények
Funkcionális követelmények:
Felhasználó által feltöltött pénz, digitális tárolása.
Windows forms-os környezeten való működés.
Nem funkcionális követelmények:
A felhasználó nem tud egyszerre több kávét rendelni.
### Támogatott eszközök
Asztali számítógép.
## 5. Funkcionális terv
### 5.1 Rendszerszereplők:
Felhasználó
### 5.2 Rendszerhasználati esetek és lefutásaik:
Feltöltheti a digitális tárcáját.
Kiválaszthat egy fajta kávét.
A kávé mellé választhat cukrot/tejet.
### 5.3 Menühierarchiák:
Main ablak:
Tárcafeltöltés.
Kávé kiválasztás.
Cukor/tej kiválasztás.
## 6. Fizikai környezet
Az alkalmazás asztali számítógépre, Windows operációs rendszerre készül.
Nincsenek megvásárolt komponenseink.
Fejlesztői eszközök:
Visual Studio 2022.
## 7. Architekturális terv
Az alkalmazásnak nincs szüksége adatbázis rendszerre, illetve keretrendszerre.
## 8. Implementációs terv
Windows forms / C#: Az alkalmazás felületét windows formsban, az alkalmazást működtető kódot C#-ban írjuk meg.
## 9.Tesztterv
A tesztelések célja a rendszer és komponensei funkcionalitásának teljes vizsgálata, ellenőrzése, a rendszer által megvalósított üzleti szolgáltatások verifikálása.
