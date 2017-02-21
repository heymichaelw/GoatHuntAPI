using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoatHuntAPI.Models
{
    public class Hunt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Permits { get; set; }
        public int HuntersAfield { get; set; }
        public int Harvest { get; set; }
        public double AverageDays { get; set; }
        public double PercentSuccess { get; set; }
    }
}