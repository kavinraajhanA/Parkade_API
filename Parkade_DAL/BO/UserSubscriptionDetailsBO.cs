using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkade_DAL.BO
{
    public class UserSubscriptionDetailsBO
    {
        public int SubscriptionID { get; set; }
        public int UserID { get; set; }
        public int MembershipID { get; set; }
        public int PlanID { get; set; }
        public DateTime PlanActivationDate { get; set; }
        public bool PlanActiveStatus { get; set; }
        public DateTime PlanExpiryDate { get; set; }
        public Double ActualPrice { get; set; }
        public Double CommissionAmount { get; set; }
        public Double CompanyPrice { get; set; }
        public String TranscationID { get; set; }
        public DateTime TranscationDateTime { get; set; }
        public string TranscationType { get; set; }
        public string Offercode { get; set; }
        public double Offerprice { get; set; }
        public double TotalPrice { get; set; }
        
    }
}
