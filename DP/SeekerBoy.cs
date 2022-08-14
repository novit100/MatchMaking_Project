using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class SeekerBoy : Person
    {
        public byte?[] Picture { get; set; }//we will have a duff class for this
        public float? Height { get; set; }
        public int? GradeInStudies { get; set; }//ועד או שנת לימודים
        public int? Residency { get; set; }//*******************************how are we implementing KETOVET
        public PersonalStatus PersonalStatus { get; set; }
        public BodyStructure? BodyStructure { get; set; }
        public bool? DoesSmoke { get; set; }
        public DateTime? DOB { get; set; }
        public string ElementrySchool { get; set; }
        public string YeshivaKetana { get; set; }
        public YeshivaGedola YeshivaGedola { get; set; }
        public Torah_Study_Status Torah_Study_Status { get; set; }
        public Questionnaire Questionnaire { get; set; }//can i nme them the same
        public Origin Origin { get; set; }

        //pointers to the family members:
        public Parent Father { get; set; }
        public Parent Mother { get; set; }
        public List<Sibiling> Sibilings { get; set; }
        public List<Acquaintance> Inquiries { get; set; }
        


        // public int NumberOfSiblings { get; set; }
        //public Origin Myorigin() { }// we should do a function that takes the fathers father origin


    }
}
