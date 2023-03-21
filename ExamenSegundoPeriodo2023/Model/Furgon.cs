using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenSegundoPeriodo2023.Model
{
    internal class Furgon : TipoVehiculo, ITipoLicencia
    {
        public string TipoLicencia()
        {
            return "Licencia tipo CE (Pesada)";
        }
    }
}
