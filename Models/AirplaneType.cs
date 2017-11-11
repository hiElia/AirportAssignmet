using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirPortAssignment.Models
{
    public class AirplaneType
    {
        // Airplane type has one to many r/S with Airport and has airport id(foreign id)
        // has also lists of airplanes
        public int Id { get; set; }
        public string Name { get; set; }
        public Airport Airport  { get; set; }
        public int? AirportId{ get; set; }
        public virtual List<Airplane> Airplanes { get; set; }


    }
}