namespace MonkeyFinder.ViewModel;

[QueryProperty("Monkey", "Monkey")]
public partial class MonkeyDetailsViewModel : BaseViewModel
{

    public MonkeyDetailsViewModel()
    {

        IMap map;

    }

    [ObservableProperty]
    Monkey monkey;

    [RelayCommand]
    async Task OpenMapAsync()
    {
        try
        {
            await Map.OpenAsync(Monkey.Latitude, Monkey.Longitude,
            new MapLaunchOptions
            {
                Name = Monkey.Name,
                NavigationMode = NavigationMode.None
            });
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error!",
                $"Nem tudom megnyitni a térképet! {ex.Message}", "OK");
            throw;
        }
    }

    //az animáció miatt kell, hogy a visszanavigálásnál oda menjen vissza ahova kell.

    //[RelayCommand]
    //async Task GoBackAsync()
    //{
    //    await Shell.Current.GoToAsync("..");
    //}
}

