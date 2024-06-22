using static System.Runtime.InteropServices.JavaScript.JSType;

namespace emoralesExamen.Views;

public partial class vResumen : ContentPage
{
    public vResumen( string nombre)
	{
        InitializeComponent();
        lblNombre.Text = "Bienvenido " + nombre;
        lblnombre.Text = 
    }
}