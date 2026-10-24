using System.Collections.ObjectModel;

namespace NotatkiMobilne;

public partial class MainPage : ContentPage
{
    ObservableCollection<string> notatki = new ObservableCollection<string>
    {
        "Podlać kwiatki",
        "Zrobić obiad",
        "Wyjść na spacer"
    };

    public MainPage()
    {
        InitializeComponent();

        ListaNotatek.ItemsSource = notatki;
    }

    private void DodajNotatke(object sender, EventArgs e)
    {
        string nowaNotatka = NowaNotatkaEntry.Text;

        if (!string.IsNullOrWhiteSpace(nowaNotatka))
        {
            notatki.Add(nowaNotatka);
            NowaNotatkaEntry.Text = string.Empty;
        }
    }
}
