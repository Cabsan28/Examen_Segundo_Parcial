using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenSegundoPeriodo2023.Model
{
    internal class Cuatrimoto : TipoVehiculo, ITipoLicencia
    {
        public string TipoLicencia()
        {
            return "Licencia tipo B1 (Cuatrimoto)";
        }
    }
}
