# MMS Servisna aplikacija (.NET 8, WPF)

## Opis projekta
MMS je desktop servisna aplikacija za vođenje klijenata, objekata, komora, ugovora, radnih naloga, materijala, faktura, uplata, rashoda i izveštaja.  
Arhitektura je slojevita: Presentation (WPF/MVVM), Application (servisi), Infrastructure (baza, logging), Domain (modeli).

## Struktura rešenja
- **Presentation** – UI sloj (Views, ViewModels, Resources, Helpers)
- **Application** – poslovna logika, servisi, DTOs, interfejsi
- **Infrastructure** – pristup podacima, migracije, logging, konfiguracija
- **Domain** – entiteti, value objekti, enum-i

## Tehnologije
- .NET 8
- WPF (MVVM)
- Entity Framework Core / ADO.NET
- Serilog (logging)
- xUnit, Moq (testovi)

## Pokretanje projekta
1. Kloniraj repozitorijum
2. Otvori rešenje u Visual Studio 2022
3. Restore NuGet pakete (__Restore NuGet Packages__)
4. Podesi konekcioni string u `appsettings.json` ili User Secrets
5. Pokreni projekat `MMS.Presentation`

## Naming konvencije
- Projekti: MMS.[Sloj]
- Klase: PascalCase ([Entitet]ViewModel, [Entitet]Service, [Entitet])
- Interfejsi: I[Opis]
- Fajlovi: Ime klase (.cs), Ime view-a (.xaml)
- Testovi: [TestiranoIme]Tests

## Kontakt i podrška
Za pitanja i podršku, kontaktirajte tim na [email].

---
Evo ti ceo tekst iz dokumenta lepo prebačen u **čeklistu sa kvadratićima za čekiranje** (GitHub/Markdown stil):

---

### ✅ Checklist — Faza 0

* [ ] **0.1. Postavi solution strukturu (projekti po slojevima)**

  * [x] Kreiraj novi solution (ServisMMS) u Visual Studio 2022
  * [x] Dodaj projekte: Presentation (WPF .NET 8), Application, Infrastructure, Domain
  * [x] Organizuj foldere (Views, ViewModels, Services, Entities, DTOs, itd.)
  * [x] Postavi naming konvencije (projekti, klase, fajlovi)
  * [x] Dodaj README.md i .gitignore
  * [x] Prvi commit sa praznim projektima i strukturom

* [x] **0.2. Dodaj reference između projekata**

  * [x] Presentation → Application, Domain
  * [x] Application → Domain, Infrastructure
  * [x] Infrastructure → Domain
  * [x] Domain → nezavisan (bez referenci)
  * [x] Dokumentuj zavisnosti u README

---

#### Zavisnosti između projekata

- **Presentation** koristi servise i modele iz Application i Domain sloja.
- **Application** koristi entitete iz Domain i pristup podacima iz Infrastructure.
- **Infrastructure** koristi entitete iz Domain.
- **Domain** je potpuno nezavisan, ne referencira druge projekte.

Ova struktura omogućava čistu arhitekturu, lakše testiranje i održavanje koda.

* [x] **0.3. Dodaj osnovne NuGet pakete**

  * [x] Presentation: CommunityToolkit.Mvvm, Microsoft.Extensions.DependencyInjection (DI), Microsoft.Extensions.Configuration (Config), Serilog
  * [x] Application: Microsoft.Extensions.DependencyInjection (DI), Microsoft.Extensions.Configuration (Config), Serilog, xUnit, Moq
  * [x] Infrastructure: Microsoft.EntityFrameworkCore (EF Core), System.Data.SqlClient, Serilog, xUnit, Moq
  * [x] Domain: bez eksternih paketa
  * [x] Restore NuGet Packages i dokumentuj u README

---

#### Osnovni NuGet paketi po projektu

- **Presentation**
  - CommunityToolkit.Mvvm
  - Microsoft.Extensions.DependencyInjection
  - Microsoft.Extensions.Configuration
  - Serilog

- **Application**
  - Microsoft.Extensions.DependencyInjection
  - Microsoft.Extensions.Configuration
  - Serilog
  - xUnit (testovi)
  - Moq (testovi)

- **Infrastructure**
  - Microsoft.EntityFrameworkCore
  - System.Data.SqlClient
  - Serilog
  - xUnit (testovi)
  - Moq (testovi)

- **Domain**
  - Bez eksternih paketa

* [x] **0.4. Podesi Dependency Injection (DI)**

  * [x] Inicijalizuj ServiceCollection u App.xaml.cs
  * [x] Registruj servise i interfejse
  * [x] Registruj ViewModel-e (AddTransient/Scoped)
  * [x] Registruj DbContext/DatabaseConnector
  * [x] Registruj IConfiguration i Serilog logger
  * [x] Omogući pristup preko ServiceProvider-a
  * [x] Dodaj globalni error handler

---

#### DI podešavanje (Presentation sloj)

- U `App.xaml.cs` inicijalizovan je `ServiceCollection`.
- Registrovani su svi servisi i interfejsi iz Application i Infrastructure sloja.
- ViewModel-i su registrovani kao Transient ili Scoped.
- DbContext/DatabaseConnector je registrovan sa konekcijom iz konfiguracije.
- IConfiguration i Serilog logger su registrovani kao singleton.
- Pristup svim servisima i ViewModel-ima omogućen je preko globalnog `ServiceProvider`-a.
- Implementiran je globalni error handler za neuhvaćene greške (AppDomain i Dispatcher), sa logovanjem kroz Serilog i user-friendly porukom korisniku.

Ovim korakom DI kontejner je spreman za rad i aplikacija je robusna na greške.

* [x] **0.5. Podesi konfiguraciju**

  * [x] Dodan appsettings.json u Presentation i Infrastructure projekte
  * [x] Definisane sekcije: ConnectionStrings, Logging, FeatureFlags, Auth, Shell
  * [x] Sensitive podatke (connection string, API ključevi) prebačeni u User Secrets
  * [x] Konfiguracija se učitava na startu aplikacije (App.xaml.cs)
  * [x] Servisi i ViewModel-i pristupaju konfiguraciji preko DI (IConfiguration)

---

#### Konfiguracija

- appsettings.json sadrži:
  - **ConnectionStrings**: konekcioni string za bazu
  - **Logging**: Serilog podešavanja (putanja, nivo, rolling)
  - **FeatureFlags**: podešavanje funkcionalnosti (Mapa, MultiValuta, Dunning, Magacin)
  - **Auth**: parametri za autentikaciju
  - **Shell**: podešavanja za UI (moduli, banner, redosled)

- Sensitive podaci (connection string, API ključevi) se čuvaju u User Secrets i nisu deo repozitorijuma.

- Konfiguracija se učitava na startu aplikacije i dostupna je svim servisima i ViewModel-ima preko Dependency Injection.

Ovim korakom obezbeđena je centralizovana i bezbedna konfiguracija za sve slojeve aplikacije.

* [x] **0.6. Podesi logging (Serilog)**

  * [x] Dodaj konfiguraciju u appsettings.json
  * [x] Implementiraj IAppLogger interfejs i AppLogger klasu
  * [x] Registruj logger u DI
  * [x] Testiraj logovanje u svim slojevima

* [ ] **0.7. Podesi DatabaseConnector ili EF DbContext**

  * [x] Implementiraj TestConnectionAsync / CanConnectAsync
  * [x] Kreiraj DbContext sa DbSet za master tabele
  * [x] Dodaj HealthCheckAsync + logovanje rezultata
  * [x] Pozovi health check na startu aplikacije
  *	[x] Ukloni duplu proveru health check-a(Trenutno pozivaš health check dva puta:)
         Prvo: var healthOk = await dbConnector.HealthCheckAsync();
         Drugo: bool dbOk = await db.HealthCheckAsync(logger);
         Dovoljno je da koristiš samo jedan health check (preporučujem onaj sa logger-om).
  * [x] Centralizuj logiku za health check
         Možeš koristiti samo AppDbContext.HealthCheckAsync(logger) ili samo DatabaseConnector.HealthCheckAsync() (ako oba rade isto).
  * [x] (Opciono) Prikaži korisniku samo jednu poruku o grešci
Sada može da se desi da korisnik vidi dve poruke ako oba health check-a padnu.

* [ ] **0.8. Implementiraj UserSession**

  * [x] Singleton sa UserId, UserName, Role, DisplayName
  * [x] Popunjavanje na login, reset na logout
  * [x] Dostupan svim ViewModel-ima i servisima
  * [x] UI meniji i status bar zavise od Role/UserName

* [ ] **0.9. Uvedi IsActive i RowVersion u master entitete**

  * [x] Dodaj kolone u SQL (IsActive BIT, RowVersion ROWVERSION)
  * [ ] Ako koristiš Entity Framework, proveri još da li su te kolone mapirane i u tvojim C# modelima (entitetima).
  * [ ] Dodaj property u modele u Domain sloju
  * [ ] Soft delete umesto fizičkog brisanja
  * [ ] Implementiraj optimistic concurrency (RowVersion)

* [ ] **0.10. Dodaj globalni error handler**

  * [ ] Hvataj AppDomain.CurrentDomain.UnhandledException
  * [ ] Hvataj DispatcherUnhandledException
  * [ ] Loguj sve greške kroz Serilog
  * [ ] Prikazuj user-friendly poruku korisniku

* [ ] **0.11. Dodaj FeatureFlags**

  * [ ] Dodaj sekciju u appsettings.json (Mapa, MultiValuta, Dunning, Magacin)
  * [ ] Implementiraj IFeatureFlagService
  * [ ] Registruj ga u DI kao singleton
  * [ ] Funkcionalnosti se pale/gase kroz konfiguraciju

* [ ] **0.12. Pripremi seed podataka i migracije**

  * [ ] Seed korisnika (Admin, Serviser, Komercijala, Finansije, Viewer)
  * [ ] Seed lookup vrednosti (TipUsluge, Prioritet, Statusi, JM, Uloge)
  * [ ] Seed demo klijenata i objekata
  * [ ] Napravi SeedDataService (idempotentan)
  * [ ] Loguj rezultat seeda kroz Serilog

* [ ] **0.13. Postavi automatizovane testove**

  * [ ] Kreiraj test projekte (Application.Tests, Infrastructure.Tests)
  * [ ] Dodaj xUnit, Moq, EF InMemory
  * [ ] Testiraj DI, konekciju, UserSession, logovanje
  * [ ] Testove pokretati kroz Test Explorer

* [ ] **0.14. Testiraj start aplikacije**

  * [ ] Startuj aplikaciju → prikaže se Shell bez greške
  * [ ] Konfiguracija i konekcija rade
  * [ ] Migracije i seed izvršeni
  * [ ] Log fajl beleži start, seed i greške
  * [ ] FeatureFlags dostupni i menjaju ponašanje aplikacije
  * [ ] User-friendly error handling funkcioniše

---

#