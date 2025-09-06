# Obja�njenje konfiguracije `appsettings.json`

Ovaj fajl sadr�i pode�avanja za aplikaciju, bazu podataka, logovanje i funkcionalnosti.  
Ispod su obja�njenja za svaku sekciju i klju�:

---

## ConnectionStrings

- **DefaultConnection**  
  Povezivanje na SQL Server bazu podataka.  
  Sadr�i: naziv servera, ime baze, korisni�ko ime, lozinku i sigurnosne opcije.

---

## Logging

- **MinimumLevel**  
  Minimalni nivo logovanja (npr. Information, Warning, Error).
- **WriteTo**  
  Defini�e destinacije za logove.
  - **Name**: Tip destinacije (ovde "File" zna�i logovanje u fajl).
  - **Args**:
    - **path**: Putanja do log fajla.
    - **rollingInterval**: Period rotacije log fajla (npr. dnevno).
    - **fileSizeLimitBytes**: Maksimalna veli�ina log fajla u bajtovima.

---

## FeatureFlags

Omogu�ava ili isklju�uje odre�ene funkcionalnosti aplikacije:
- **Mapa**: Prikaz mape (true/false)
- **MultiValuta**: Vi�e valuta (true/false)
- **Dunning**: Dunning proces (true/false)
- **Magacin**: Modul magacina (true/false)

---

## Auth

Pode�avanja za autentifikaciju:
- **JwtSecret**: Tajni klju� za JWT autentifikaciju.
- **TokenLifetimeMinutes**: Vreme va�enja tokena u minutima.

---

## Shell

Pode�avanja za korisni�ki interfejs:
- **BannerText**: Tekst koji se prikazuje u zaglavlju aplikacije.
- **Modules**: Lista modula (stranica) koji su dostupni u aplikaciji.

---