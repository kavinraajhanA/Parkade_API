using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkade_DAL.BO
{
    public class LLProfileBO
    {
        public int LLID { get; set; }
        public string LLName { get; set; }
        public string LLAddress { get; set; }
        public DateTime LLDOB { get; set; }
        public string LLEmail { get; set; }
        public long LLPhone { get; set; }
        public string LLPassword { get; set; }
        public bool IsOtpVerifed { get; set; }
        public string LLProfileImage { get; set; }

    }
}
