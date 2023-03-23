using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkade_DAL.BO
{
    public class UserProfileBO
    {
        public int UserID { get; set; } 
        public string UserName{ get; set; } 
        public string UserAddress{ get; set; } 
        public DateTime UserDOB{ get; set; } 
        public string UserEmail{ get; set; } 
        public long UserPhone{ get; set; } 
        public string UserPassword{ get; set; }
        public bool IsOtpVerifed { get; set; }
        public string UserProfileImage { get; set; }

        
    }
}
