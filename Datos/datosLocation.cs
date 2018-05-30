using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class datosLocation
    {
        ProyectoFinalMoranEntities contexto = new ProyectoFinalMoranEntities();
         public datosLocation()
        {
            contexto.Configuration.ProxyCreationEnabled = false;
        }

        public List<LOCATION> SeleccionarLocations()
        {
            return contexto.LOCATION.ToList();
        }

        public bool UpdateLocation(LOCATION actualizLoc)
        {
            LOCATION loc = contexto.LOCATION.Where(l => l.ID == actualizLoc.ID).SingleOrDefault();
            if (loc != null)
            {
                loc.LATITUD = actualizLoc.LATITUD;
                loc.LONGITUD = actualizLoc.LONGITUD;
                contexto.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
