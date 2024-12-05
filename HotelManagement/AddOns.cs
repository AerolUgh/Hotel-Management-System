using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    internal class AddOns : Rooms
    {
        public int C1 { get; set; }
        public int C2 { get; set; }
        public int C3 { get; set; }
        
        public AddOns() 
        {
            C1 = 1599;
            C2 = 2099;
            C3 = 2599;
        }
    }
}
