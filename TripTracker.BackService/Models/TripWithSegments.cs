using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.BackService.Models
{
    public class TripWithSegments : TripTrackerDTO.Trip
    {
        public ICollection<Segment> Segments {get; set;}

    }
}
