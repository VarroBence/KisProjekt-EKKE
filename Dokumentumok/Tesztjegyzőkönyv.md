 | Teszteset               | Elvárt eredmény                                                                                                     | 
 |-------------------------|---------------------------------------------------------------------------------------------------------------------| 
 | Helytelen adat megadása | A művelet nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy miért és milyen adatok megadásával történhet.|
 | Helyes adat megadása    | Megtörténik a művelet.                                                                                              | 
 | ... | ... | 

#### Ezeket a teszteseteket végrehalyatani a legtöbb kombinációval

**Tesztelő:** Tóth Tamás

**Tesztelés dátuma:** 2022.október.12.

| Tesztszám | Rövid leírás                     | Várt eredmény                                                                   | Eredmény                                                                       | Megjegyzés                |
|-----------|----------------------------------|---------------------------------------------------------------------------------|--------------------------------------------------------------------------------|---------------------------|
| Teszt #01 | Helytelen adat bevitele a "Feltöltés" mezőbe | Művelet nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy mi a gond. | Művelet nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy mi a gond.| Nem találtam problémát.   |
| Teszt #02 | Helytelen adat bevitele y mezőbe | Művelet nem hajtódik végre. Üzenetben jelezni a felhasználónak a problémát.     | Művelet végrehajtódik.                                                         | Ennek a műveletnek nem lehetett volna lefutnia. Mielőbbi javításra szorul |
| Teszt #XX | ... | ... | ... | ... |
| Teszt #XX | ... | ... | ... | ... |

**Tesztelő:** Varró Bence

**Tesztelés dátuma:** 2022.október.12.

| Tesztszám | Rövid leírás                     | Várt eredmény                                                                   | Eredmény                                                                       | Megjegyzés                |
|-----------|----------------------------------|---------------------------------------------------------------------------------|--------------------------------------------------------------------------------|---------------------------|
| Teszt #01 | Helytelen adat bevitele a "Feltöltés" mezőbe | Művelet nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy mi a gond. | Művelet nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy mi a gond.| Nem találtam problémát.   |
| Teszt #02 | A pénztárca feltöltése nélkül fizetni. | Művelet nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy mi a gond.| Művelet végrehajtódik, még akkor is, ha a tárcán nincs elég pénz a fizetéshez | Ennek a műveletnek nem lehetett volna lefutnia. Mielőbbi javításra szorul. |
| Teszt #03 | "Kávéautomata" mezőben nem választok ki kávét és fizetek. | Művelet nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy mi a gond. | Üzenetben jelzi, hogy nincs elég pénz a számlán. | A hiba üzenetét le kell kezelni. |
