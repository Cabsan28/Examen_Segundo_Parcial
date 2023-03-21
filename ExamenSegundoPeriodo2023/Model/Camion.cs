using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenSegundoPeriodo2023.Model
{
    public class Camion : TipoVehiculo, ITipoLicencia
    {
        public string TipoLicencia()
        {
            return "Licencia tipo C1 (Camión)";
        }
    }
 
}
