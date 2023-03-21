using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ExamenSegundoPeriodo2023.ViewModels
{
    public class UsuarioViewModel : INotifyPropertyChanged
    {
        private string nombre;
        private string apellido;
        private string edad;
        private string identidad;
        private ICommand guardarInformacionCommand;
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<string> Usuarios { get; set; }

        public UsuarioViewModel()
        {
            Usuarios = new ObservableCollection<string>();

        }

        private string usuarioInfo;

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

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Nombre)));
                }
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set
            {
                if (apellido != value)
                {
                    apellido = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Apellido)));
                }
            }
        }

        public string Edad
        {
            get { return edad; }
            set
            {
                if (edad != value)
                {
                    edad = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Edad)));
                }
            }
        }

        public string Identidad
        {
            get { return identidad; }
            set
            {
                if (identidad != value)
                {
                    identidad = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Identidad)));
                }
            }
        }

        public ICommand GuardarInformacionCommand => guardarInformacionCommand ?? (guardarInformacionCommand = new Command(() =>
        {
            string usuario = $"Nombre: {Nombre} \nApellido: {Apellido} \nEdad: {Edad} \nIdentidad: {Identidad}";
            Usuarios.Add(usuario);
            UsuarioInfo = usuario;

            // Enviar el mensaje "UsuarioGuardado"
            MessagingCenter.Send(this, "UsuarioGuardado", usuario);
        }));
    }
}

