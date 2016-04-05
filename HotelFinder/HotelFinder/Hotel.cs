using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder
{
    [ComVisible(true)]
    public class Hotel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Rating { get; set; }
    }
}
