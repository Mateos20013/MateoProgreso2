using MateoProgreso2.Interfaces;
using MateoProgreso2.Models;
using MateoProgreso2.Repositories;


namespace MateoProgreso2;

public partial class MRecarga : ContentPage
{
    public Recarga recarga;
    IRecarga _recargaRepository;
    public List<Recarga> recargaList;
    public string _fileName = Path.Combine(FileSystem.AppDataDirectory, "CrhystelVelasco.txt");
    public MRecarga()
    {
        InitializeComponent();
        recarga = new Recarga();
        BindingContext = recarga;
        _recargaRepository = new RecargaRepository();

    }


    private async void Buton1_Clicked(object sender, EventArgs e)
    {
        var nuevaRecarga = new Recarga
        {
            Nombre = mateoSotomayor_entry1.Text,
            NumeroTelefono = mateoSotomayor_entry.Text,
            MensajeResultado = "Recarga exitosa"
        };

        if (_recargaRepository.CrearRecarga(nuevaRecarga))
        {
            mateoSotomayor_label2.Text = "Recarga guardada con éxito.";
            CargarRecargas();
            await DisplayAlert("Alert", "Recarga guardada con éxito.\"", "OK");
        }
        else
        {
            await DisplayAlert("Alert", "Error al guardar la recarga.\"", "OK");
            mateoSotomayor_label2.Text = "Error al guardar la recarga.";
        }



    }
    private void CargarRecargas()
    {

        var recargas = _recargaRepository.DevuelveListRecarga();


        var recargasTexto = string.Join("\n", recargas.Select(r => $"{r.Nombre} - {r.NumeroTelefono}"));

        mateoSotomayor_label2.Text = recargasTexto;
    }
    private void Buton2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Grid());

    }
}