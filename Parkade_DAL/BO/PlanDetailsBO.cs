using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkade_DAL.BO
{
    public class PlanDetailsBO
    {
        public int PlanId { get; set; } 
        public int LLId { get; set; } 
        public int LandId { get; set; } 
        public string PlanName { get; set; } 
        public string NoOfMonths { get; set; } 
        public string Extraoffer { get; set; } 
        public double PlanAmount { get; set; } 
        public double CommissionAmount { get; set; } 
        public double CompanyPrice { get; set; } 
    }
}
