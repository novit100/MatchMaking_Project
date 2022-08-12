using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class Seeker : Person
    {
        public Gender Gender { get; set; }
        public string Picture { get; set; }
        public decimal Height { get; set; }
        public string Grade { get; set; }//ועד או שנת לימודים
        public BodyStructure BodyStructure { get; set; }
        public DateTime DOB { get; set; }
        public string ElementrySchool { get; set; }

        public Questionnaire Questionnaire { get; set; }//can i nme them the same
        //pointers to the family members
        public Parent Father { get; set; }
        public Parent Mother { get; set; }
        public List<Sibiling> Sibilings { get; set; }
        public List<Acquaintance> Inquiries { get; set; }

        // public int NumberOfSiblings { get; set; }
        //public Origin Myorigin() { }// we should do a function that takes the fathers father origin


    }
}
