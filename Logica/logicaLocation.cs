using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Logica
{
    public class logicaLocation
    {
        datosLocation datos = new datosLocation();
        public List<LOCATION> SeleccionarLocations()
        {
            return datos.SeleccionarLocations();
        }

        public List<LOCATION> SeleccionarLocations(int idLocation)
        {
            return datos.SeleccionarLocations().Where(loc => loc.ID == idLocation).ToList();
        }

        public bool UpdateLocation(LOCATION actualizLoc)
        {
            return datos.UpdateLocation(actualizLoc);
        }
    }
}
