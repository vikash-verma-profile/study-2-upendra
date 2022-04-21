using System;
using System.Collections.Generic;

#nullable disable

namespace Case_Study2.Models
{
    public partial class TblBookingFlightUserMapping
    {
        public int Id { get; set; }
        public int? BookingId { get; set; }
        public int? FlightId { get; set; }
        public int? UserId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? IsDeleted { get; set; }
    }
}
