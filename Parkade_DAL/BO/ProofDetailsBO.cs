using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkade_DAL.BO
{
    public class ProofDetailsBO
    {
        public int ProofID { get; set; }
        public int UserID { get; set; }
        public int LLID { get; set; }
        public string UserLicFrontImage { get; set; }
        public string UserLicBackImage { get; set; }
        public DateTime UserLicValidTillDate { get; set; }
        public string LLAnotherproof { get; set; }
        public string LLTaxProof { get; set; }
       
    }
}
