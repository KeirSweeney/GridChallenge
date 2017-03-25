using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridChallenge
{
    class Event
    {
        public Coordinates Coord { get; set; }
        public int UniqueID { get; set; }
        
        public Event(Coordinates coord, int uniqueID)
        {
            Coord = coord;
            UniqueID = uniqueID;
        }
    }
}
