# Quizzer tests
Ovo je projekt za kolegij Metode i tehnike testiranja programske podrške. Projekt sadrži automatske testove za aplikaciju Quizzer koja je izrađena u svrhu završnog rada. Testiraju se glavne funkcionalnosti koje aplikacija ima, a to su: prijavljivanje, registracija, kreiranje kvizova i pitanja, uređivanje kvizova i pitanja, igranje kvizova i uređivanje rezultata.

Testovi su napisani koristeći NUnit framework za testiranje u programskom jeziku C#. Testovi također koriste i Selenium WebDriver kako bi se simulirale korisničke akcije kao što su navigacija, unos podataka i klikanje na elemente. 

## Preduvjet 

Za pokretanje projekta potrebno je imati instaliran Visual Studio 2022.

## Koraci instaliranja projekta
Slijedeći ove korake moguće je pokrenuti napisane testove. 
1. Kloniranje repozitorija
   
   ```

   git clone https://github.com/josipnovak/MTTPP_Projekt.git

   ```

2. Pokretanje projekta

   Za pokretanje projekta potrebno je pokrenuti `MTTPP_Projekt.sln`

3. Instaliranje potrebnih paketa

   Nakon pokretanja projekta potrebno je instalirati određene pakete kako bi projekt radio.
   Pakete je potrebno instalirati na `Project` > `Manage NuGet Packages`, potrebni paketi su
   
    - NUnit framework 4.3.2
    - NUnit3TestAdapter 4.6.0
    - Selenium WebDriver 4.28.0
    - Selenium Support 4.28.0

4. Pokretanje testova
  
   Nakon što su instalirani potrebni paketi, testovi se pokreću na slijedeći način. Odabirom na `Test` > `Test Explorer` otvara se prozor na kojem su vidljivi svi testovi. Ako testovi nisu vidljivi potrebno je odabrati `Build` > `Build solution`.

   U prozoru koji je otvoren je potrebno odabrati `Run tests`, te će se nakon toga testovi početi izvršavati jedan nakon drugog.

## Promjena pretraživača

U apstraktnoj klasi `BaseTest`, nalaze se informacije koje se koriste u svakom testu. 

Kako bi se promijenio pretraživač u kojem želimo pokrenuti testove, u metodi `SetupTest`, vrijednost varijable `driver` je potrebno promijeniti s `FirefoxDriver()` u `ChromeDriver()` za korištenje Google Chrome-a, ili u `EdgeDriver()` za korištenje Microsoft Edge-a.
