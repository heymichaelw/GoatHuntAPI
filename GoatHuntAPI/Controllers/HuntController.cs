using GoatHuntAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace GoatHuntAPI.Controllers
{
    public class HuntController : ApiController
    {
        private ApplicationContext db = new ApplicationContext();

        public IQueryable<Hunt> Get()
        {
            return db.Hunts;
        }

        [ResponseType(typeof(Hunt))]
        public IHttpActionResult Get(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var instance = db.Hunts.Find(id);
            if (instance == null)
            {
                return NotFound();
            }
            return Ok(instance);
        }
    }
}
