using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public enum Room {ROOM_101 = 101,
    ROOM_102 =102,
    ROOM_201 = 201,
    ROOM_202 = 202,
    ROOM_301 =301,
    ROOM_302=302, }

    public class Conference
    { 
        public string GroupName{ get; set; }
        public int Attendees { get; set; }

        public Room Room { get; set; }
        public DateTime StartingDate { get; set; }
       


       public string Display() { string texts = "\n"+$"({Attendees}) {GroupName} on {StartingDate.ToLongDateString()} in {Room}";
            return texts;
        }

    }
}
