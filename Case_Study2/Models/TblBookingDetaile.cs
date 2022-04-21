using System;
using System.Collections.Generic;

#nullable disable

namespace Case_Study2.Models
{
    public partial class TblBookingDetaile
    {
        public int Id { get; set; }
        public string FlightName { get; set; }
        public string NoOfSeats { get; set; }
        public string PaymentStatus { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime? DepartureTime { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public int? TicketConfirmation { get; set; }
    }
}
