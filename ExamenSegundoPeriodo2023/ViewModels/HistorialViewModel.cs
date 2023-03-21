using ExamenSegundoPeriodo2023.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace ExamenSegundoPeriodo2023.ViewModels
{
    public class HistorialViewModel : INotifyPropertyChanged
    {
        private string usuarioInfo;
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Licencia> licencias = new ObservableCollection<Licencia>();

        public HistorialViewModel()
        {
            MessagingCenter.Subscribe<UsuarioViewModel, string>(this, "UsuarioGuardado", (sender, usuario) =>
            {
                UsuarioInfo = usuario;
            });

            MessagingCenter.Subscribe<LicenciaViewModel, ObservableCollection<Licencia>>(this, "LicenciasGuardadas", (sender, licencias) =>
            {
                Licencias = licencias;
            });



        }

        public string UsuarioInfo
        {
            get { return usuarioInfo; }
            set
            {
                if (usuarioInfo != value)
                {
                    usuarioInfo = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UsuarioInfo)));
                }
            }
        }

        public ObservableCollection<Licencia> Licencias
        {
            get { return licencias; }
            set
            {
                if (licencias != value)
                {
                    licencias = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Licencias)));
                }
            }
        }


    }


}
