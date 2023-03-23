using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkade_DAL.BO
{
    public class LandDetailsBO
    {
      public int LandID { get; set; }  
      public int LandLordID { get; set; }  
      public string LandName { get; set; }  
      public string LandCoverPhoto { get; set; }  
      public string LandAddLn1 { get; set; }  
      public string LandAddLn2 { get; set; }  
      public string LandAddCity { get; set; }  
      public string LandAddState { get; set; }  
      public string LandAddCountry { get; set; }  
      public long LandAddPostalCode { get; set; }  
      public string LandSize { get; set; }  
      public int AvailableSlots { get; set; }  
      public double PriceForHours { get; set; }  
      public double PriceForDays { get; set; }  
      public double Ratings { get; set; }  
      public string Features { get; set; }
        public double onemnth { get; set; }
        public double threemnth { get; set; }
        public double sixmnth { get; set; }
        public bool CCTV { get; set; }
        public bool Security { get; set; }
        public bool Alarm { get; set; }
        public bool FireExtinguish { get; set; }
        public bool fullDay { get; set; }

    }
}
