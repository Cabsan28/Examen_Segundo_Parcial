using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExamenSegundoPeriodo2023.ViewModels;
using ExamenSegundoPeriodo2023.Model;
using System.Collections.ObjectModel;

namespace ExamenSegundoPeriodo2023.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewLicencia : ContentPage
    {
        public ViewLicencia()
        {
            InitializeComponent();
            BindingContext = new LicenciaViewModel();

        }
 

        private ObservableCollection<Licencia> Licencias = new ObservableCollection<Licencia>();

        private void btnGuardarLicencia_Clicked(object sender, EventArgs e)
        {
            // Guarda los valores seleccionados del Picker y del Entry
            string vehiculo = vehiculoPicker.SelectedItem.ToString();
            string tipoLicencia = licenciaRequeridaEntry.Text;

            // Agrega la nueva licencia a la lista Licencias
            Licencias.Add(new Licencia { Vehiculo = vehiculo, TipoLicencia = tipoLicencia });

            // Muestra la información guardada en el Label
            lblLicenciaGuardada.Text = $"{vehiculo}\n{tipoLicencia}";
        }
    }
}