using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkade_DAL.BO
{
    public class NotificationBO
    {
        public int NotificationId { get; set; }
        public string NotificationContent { get; set; }
        public bool IsRead { get; set; }
        public bool IsUser { get; set; }
    
    }
}
