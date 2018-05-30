using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;
using Logica;

namespace REST.Controllers
{
    public class LocationController : ApiController
    {
        logicaLocation logica = new logicaLocation();

        // GET: api/Location
        public List<LOCATION> Get()
        {
            return logica.SeleccionarLocations();
        }

        // GET: api/Location/5
        public List<LOCATION> Get(int id)
        {
            return logica.SeleccionarLocations(id);
        }

        // POST: api/Location
        public void Post(LOCATION loc)
        {
        }

        // PUT: api/Location/5
        public bool Put(LOCATION updLoc)
        {
            return logica.UpdateLocation(updLoc);
        }

        // DELETE: api/Location/5
        public void Delete(int id)
        {
        }
    }
}
