using System.Windows;

// ThemeInfo atribut defini�e gde se nalaze resursi za teme u WPF aplikaciji.
// Ovo omogu�ava WPF-u da prona�e stilove i resurse u zavisnosti od teme i lokacije.

[assembly: ThemeInfo(
    ResourceDictionaryLocation.None,            // Gde se nalaze tematski (theme-specific) resource dictionary-ji.
                                                // (Koristi se ako resurs nije prona�en u stranici ili aplikacionim resursima.)
    ResourceDictionaryLocation.SourceAssembly   // Gde se nalazi generi�ki resource dictionary.
                                                // (Koristi se ako resurs nije prona�en u stranici, aplikaciji ili tematskim resursima.)
)]
