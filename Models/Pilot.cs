using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirPortAssignment.Models
{
    public class Pilot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AirplanTypeCanFly { get; set; }
        public virtual  List<AirplaneType>AirplaneTypes{ get; set; }



        //        ID
        //Name
        //AirPlane Types(types of airplanes pilot can fly. )



    }
}