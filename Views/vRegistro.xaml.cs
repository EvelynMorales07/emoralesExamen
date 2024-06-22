using static System.Runtime.InteropServices.JavaScript.JSType;

namespace emoralesExamen.Views;

public partial class vRegistro : ContentPage
{
	public vRegistro(string nombre)
	{
        {
            InitializeComponent();
            lblNombre.Text = "Bienvenido " + nombre;

        }
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vResumen());
    }
}