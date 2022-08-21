using DP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking_Project.ViewModels
{
    class Sibiling
    {

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SeekerId { get; set; }
        public Gender? Gender { get; set; }
        public int? YearOfBirth { get; set; }//needs to be current
        public int Age { get; set; }
        public int OrderInFamily { get; set; }
        public bool? Married { get; set; }
        public string marriedTo { get; set; }
        public Occupation? Occupation { get; set; }
        public string InstituteOfOccupation { get; set; }



    }
}
