using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkade_DAL.BO
{
    public class MembershipDetailsBO
    {
        public int MembershipId { get; set; }
        public int UserId { get; set; }
        public DateTime MembershipActivationDate { get; set; }
        public bool MembershipStatus { get; set; }
        public DateTime MembershipExpiryDate { get; set; }
        public DateTime LastExpiryDate { get; set; }
        public double  MembershipFee { get; set; }
        public string TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
    }
}
