namespace MonkeyFinder.ViewModel;

[QueryProperty("Monkey", "Monkey")]
public partial class MonkeyDetailsViewModel : BaseViewModel
{

    public MonkeyDetailsViewModel()
    {
     
    }

    [ObservableProperty]
    Monkey monkey;


    //az animáció miatt kell, hogy a visszanavigálásnál oda menjen vissza ahova kell.

    //[RelayCommand]
    //async Task GoBackAsync()
    //{
    //    await Shell.Current.GoToAsync("..");
    //}
}

