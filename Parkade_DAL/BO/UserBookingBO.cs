using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkade_DAL.BO
{
    public class UserBookingBO
    {
        public int BookingID { get; set; }
        public DateTime FromHours { get; set; }
        public DateTime ToHours { get; set; }
        public DateTime FromDays { get; set; }
        public DateTime ToDays { get; set; }
        public int TotalHours { get; set; }
        public int TotalDays { get; set; }
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }
        public double Tax { get; set; }
        public double TotalPrice { get; set; }
        public bool CancellationStatus { get; set; }
        public DateTime CancellationDate { get; set; }
        public double CancellationAmount { get; set; }
        public long TranscationID { get; set; }
        public DateTime TranscationDatetime { get; set; }
        public string TranscationType { get; set; }
        public int RefundID { get; set; }
        public DateTime RefundDate { get; set; }

    }
}
