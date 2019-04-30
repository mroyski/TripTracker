using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripTrackerDTO
{
    public class Segment
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTimeOffset StartDateTime { get; set; }
        [Required]
        public DateTimeOffset EndDateTime { get; set; }
        [Required]
        public int TripId { get; set; }

    }
}
