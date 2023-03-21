using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using ExamenSegundoPeriodo2023.Model;
using Xamarin.Forms;

namespace ExamenSegundoPeriodo2023.ViewModels
{
    public class LicenciaViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> Vehiculos { get; set; } = new ObservableCollection<string> { "Moto", "Camion", "Auto", "Autobus", "Cuatrimoto", "Furgón" };

        public ObservableCollection<Licencia> Licencias { get; set; } = new ObservableCollection<Licencia>();


        private int _selectedIndex;
        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                if (_selectedIndex != value)
                {
                    _selectedIndex = value;
                    OnPropertyChanged(nameof(SelectedIndex));
                }
            }
        }

        private string _licenciaRequerida;
        public string LicenciaRequerida
        {
            get { return _licenciaRequerida; }
            set
            {
                if (_licenciaRequerida != value)
                {
                    _licenciaRequerida = value;
                    OnPropertyChanged(nameof(LicenciaRequerida));
                }
            }
        }

        public ICommand VehiculoSeleccionadoCommand => new Command<string>((vehiculo) =>
        {
            ITipoLicencia tipoLicencia;

            switch (vehiculo)
            {
                case "Moto":
                    tipoLicencia = new Moto();
                    break;
                case "Camion":
                    tipoLicencia = new Camion();
                    break;
                case "Auto":
                    tipoLicencia = new Auto();
                    break;
                case "Autobus":
                    tipoLicencia = new Autobus();
                    break;
                case "Cuatrimoto":
                    tipoLicencia = new Cuatrimoto();
                    break;
                case "Furgón":
                    tipoLicencia = new Furgon();
                    break;
                default:
                    tipoLicencia = null;
                    break;
            }

            if (tipoLicencia != null)
            {
                LicenciaRequerida = tipoLicencia.TipoLicencia();
            }
        });

        public ICommand GuardarLicenciaCommand => new Command(() =>
        {
            var licencia = new Licencia
            {
                Vehiculo = Vehiculos[SelectedIndex],
                TipoLicencia = LicenciaRequerida,
            };

            Licencias.Add(licencia);

            // Mostrar mensaje de éxito al usuario
            MessagingCenter.Send(this, "LicenciasGuardadas", Licencias);
        });

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}