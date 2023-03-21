using ExamenSegundoPeriodo2023.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenSegundoPeriodo2023.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewHistorial : ContentPage
    {
        public ViewHistorial()
        {
            InitializeComponent();
            BindingContext = new HistorialViewModel();



        }


    }
}