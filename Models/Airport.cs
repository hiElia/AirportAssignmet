using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirPortAssignment.Models
{
    public class Airport
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string  City { get; set; }
        public virtual List<AirplaneType>AirplaneTypes { get; set; }

    }
}