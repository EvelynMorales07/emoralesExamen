namespace emoralesExamen.Views;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string[,] usuarios = new string[2, 2];

        // Asignar nombres de usuario y contrase�as
        usuarios[0, 0] = "estudiante";
        usuarios[0, 1] = "moviles";
        usuarios[1, 0] = "uisrael";
        usuarios[1, 1] = "2024";

        // Simular un proceso de login
        Console.WriteLine("Ingrese su nombre de usuario:");
        string nombreUsuario = txtUsuario.Text;

        Console.WriteLine("Ingrese su contrase�a:");
        string contrase�a = txtContrasena.Text;

        // Verificar si las credenciales ingresadas coinciden con las almacenadas en la matriz
        bool credencialesValidas = false;

        for (int i = 0; i < usuarios.GetLength(0); i++)
        {
            if (nombreUsuario == usuarios[i, 0] && contrase�a == usuarios[i, 1])
            {
                credencialesValidas = true;
                Navigation.PushAsync(new vRegistro(nombreUsuario));
                break;
            }
        }

        if (credencialesValidas)
        {
            DisplayAlert("Alerta", "Inicio de sesi�n exitoso", "OK");
        }
        else
        {
            DisplayAlert("ALERTA", "USUARIO Y CONTRASE�A SON INCORRECTOS", "OK");
        }
    }
}