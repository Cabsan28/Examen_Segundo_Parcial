using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ExamenSegundoPeriodo2023.Model
{
    public class Licencia : INotifyPropertyChanged
    {
        private string tipoLicencia;
        private string vehiculo;

        public string TipoLicencia
        {
            get { return tipoLicencia; }
            set
            {
                if (tipoLicencia != value)
                {
                    tipoLicencia = value;
                    OnPropertyChanged(nameof(TipoLicencia));
                }
            }
        }

        public string Vehiculo
        {
            get { return vehiculo; }
            set
            {
                if (vehiculo != value)
                {
                    vehiculo = value;
                    OnPropertyChanged(nameof(Vehiculo));
                }
            }
        }

   

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}