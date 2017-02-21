using GoatHuntAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GoatHuntAPI.Controllers
{
    public class HuntController : ApiController
    {
        private ApplicationContext db = new ApplicationContext();

        public IQueryable<Hunt> Get()
        {
            return db.Hunts;
        }
    }
}
