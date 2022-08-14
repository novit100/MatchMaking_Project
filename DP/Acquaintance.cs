using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class Acquaintance : Person
    {
        public int SeekerId { get; set; }
        public AcquaintanceType? AcquaintanceType { get; set; }
        public string PhoneNumber { get; set; }
    }
}
