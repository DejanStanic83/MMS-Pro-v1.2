using System.Windows;

// ThemeInfo atribut definiše gde se nalaze resursi za teme u WPF aplikaciji.
// Ovo omoguæava WPF-u da pronaðe stilove i resurse u zavisnosti od teme i lokacije.

[assembly: ThemeInfo(
    ResourceDictionaryLocation.None,            // Gde se nalaze tematski (theme-specific) resource dictionary-ji.
                                                // (Koristi se ako resurs nije pronaðen u stranici ili aplikacionim resursima.)
    ResourceDictionaryLocation.SourceAssembly   // Gde se nalazi generièki resource dictionary.
                                                // (Koristi se ako resurs nije pronaðen u stranici, aplikaciji ili tematskim resursima.)
)]
