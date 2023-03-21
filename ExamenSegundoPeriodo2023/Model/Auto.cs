using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenSegundoPeriodo2023.Model
{
    internal class Auto : TipoVehiculo, ITipoLicencia
    {
        public string TipoLicencia()
        {
            return "Licencia tipo B (liviana)";
        }
    }
}
