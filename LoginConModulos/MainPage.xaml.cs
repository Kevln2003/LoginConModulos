using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LoginConModulos
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        String usuari1 = "12";
        String usuario2 = "17";
        String contrasena = "12";
        String contra2 = "17";
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Obtén el valor seleccionado de la ComboBox
            string especialidadSeleccionada = (Especialidad.SelectedItem as ComboBoxItem)?.Content.ToString();
            string contaseñaIngresada = (Password.Password);
            string usuarioIngresado = (Usuario.Text);

            switch (especialidadSeleccionada)
            {
                case "Pediatría":
                    if (usuarioIngresado == usuari1 && contaseñaIngresada == contrasena)
                    {
                        Frame.Navigate(typeof(pediatria));
                    }
                    else
                    {
                        Console.WriteLine("Usuario o contraseña incorrecta");
                    }
                    break;

                case "Medicina Deportiva":
                    if (usuarioIngresado == usuario2 && contaseñaIngresada == contra2)
                    {
                        Frame.Navigate(typeof(MedicinaDeportiva));
                    }
                    else
                    {
                        Console.WriteLine("Usuario o contraseña incorrecta");
                    }
                    break;

                default:
                    Console.WriteLine("Especialidad no seleccionada");
                    break;
            }
        }
        private void Control_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            // Verificar si la tecla presionada es Enter
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                // Obtener el control actual
                var currentControl = sender as Control;

                // Mover el foco al siguiente elemento en la jerarquía
                FocusManager.TryMoveFocus(FocusNavigationDirection.Next);
            }
        }

    }

}
