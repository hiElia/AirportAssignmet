using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirPortAssignment.Models
{
    public class Airplane
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public int MaxNumOfPassangers { get; set; }
        public int SizeInMeter { get; set; }
        public int CurrentAirportId { get; set; }  //Foreign Key
        public int PilotId { get; set; }  //Foreign Key
        public int CurrentCoPilotId { get; set; }  //Foreign Key
        public AirplaneType AirplaneType { get; set; }
        public int AirplaneTypeId { get; set; }  //Foreign Key




        //        ID
        //Name
        //Airplane Type -(Foreign key)
        //Max Nr of passengers
        //Size in Meters
        //Current Airport(Foreign key)
        //Current Pilot(Foreign key)
        //Current Co Pilot(Foreign key)



    }
}