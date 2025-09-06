# Objašnjenje konfiguracije `appsettings.json`

Ovaj fajl sadrži podešavanja za aplikaciju, bazu podataka, logovanje i funkcionalnosti.  
Ispod su objašnjenja za svaku sekciju i kljuè:

---

## ConnectionStrings

- **DefaultConnection**  
  Povezivanje na SQL Server bazu podataka.  
  Sadrži: naziv servera, ime baze, korisnièko ime, lozinku i sigurnosne opcije.

---

## Logging

- **MinimumLevel**  
  Minimalni nivo logovanja (npr. Information, Warning, Error).
- **WriteTo**  
  Definiše destinacije za logove.
  - **Name**: Tip destinacije (ovde "File" znaèi logovanje u fajl).
  - **Args**:
    - **path**: Putanja do log fajla.
    - **rollingInterval**: Period rotacije log fajla (npr. dnevno).
    - **fileSizeLimitBytes**: Maksimalna velièina log fajla u bajtovima.

---

## FeatureFlags

Omoguæava ili iskljuèuje odreðene funkcionalnosti aplikacije:
- **Mapa**: Prikaz mape (true/false)
- **MultiValuta**: Više valuta (true/false)
- **Dunning**: Dunning proces (true/false)
- **Magacin**: Modul magacina (true/false)

---

## Auth

Podešavanja za autentifikaciju:
- **JwtSecret**: Tajni kljuè za JWT autentifikaciju.
- **TokenLifetimeMinutes**: Vreme važenja tokena u minutima.

---

## Shell

Podešavanja za korisnièki interfejs:
- **BannerText**: Tekst koji se prikazuje u zaglavlju aplikacije.
- **Modules**: Lista modula (stranica) koji su dostupni u aplikaciji.

---