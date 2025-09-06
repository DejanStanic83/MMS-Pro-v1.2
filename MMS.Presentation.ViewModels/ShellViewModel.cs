using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

public class ShellViewModel : INotifyPropertyChanged
{
    public ObservableCollection<string> MenuItems { get; }
    private string? _selectedPage;
    public string? SelectedPage
    {
        get => _selectedPage;
        set
        {
            if (_selectedPage != value)
            {
                _selectedPage = value;
                OnPropertyChanged();
            }
        }
    }
    public ICommand? NavigateCommand { get; }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public ShellViewModel()
    {
        MenuItems = new ObservableCollection<string> { "Klijenti", "Objekti", "Usluge" };
        _selectedPage = MenuItems[0];
    }
}