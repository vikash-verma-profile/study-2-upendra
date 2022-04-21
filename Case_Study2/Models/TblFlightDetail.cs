using System;
using System.Collections.Generic;

#nullable disable

namespace Case_Study2.Models
{
    public partial class TblFlightDetail
    {
        public int Id { get; set; }
        public string FlightName { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public DateTime? DepatureTime { get; set; }
        public decimal? FlightCharges { get; set; }
        public int? AvailableSeats { get; set; }
        public int? TotalSeats { get; set; }
    }
}
