using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class Sibiling : Person
    {
        public int SeekerId { get; set; }
        public Gender Gender { get; set; }
        public int YearOfBirth { get; set; }//needs to be current
        public bool Married { get; set; }
        public string marriedTo { get; set; }
        public Occupation Occupation { get; set; }

    }
}
