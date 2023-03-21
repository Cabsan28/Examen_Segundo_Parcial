using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenSegundoPeriodo2023.Model
{
    internal class Moto : TipoVehiculo, ITipoLicencia
    {
        public string TipoLicencia()
        {
            return "Licencia tipo A (Motocicleta)";
        }
    }
}
