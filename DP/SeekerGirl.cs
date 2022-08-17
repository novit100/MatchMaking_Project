using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class SeekerGirl:Person
    {
        public byte?[] Picture { get; set; }//we will have a duff class for this
        public float? Height { get; set; }
        public int? GradeInStudies { get; set; }//ועד או שנת לימודים
        public int? Residency { get; set; }//*******************************how are we implementing KETOVET
        public PersonalStatus PersonalStatus { get; set; }
        public BodyStructure? BodyStructure { get; set; }
        public DoesSmoke? DoesSmoke { get; set; }
        public DateTime? DOB { get; set; }
        public int Age { get; set; }
        public string ElementrySchool { get; set; }
        public string HighSchool { get; set; }
        public Seminary Seminary { get; set; }
        public Girl_Working_status? Girl_Working_status { get; set; }
        public Questionnaire Questionnaire { get; set; }
        public Origin Origin { get; set; }

        //pointers to the family members:
        public Parent Father { get; set; }
        public Parent Mother { get; set; }
        public List<Sibiling> Sibilings { get; set; }
        public List<Acquaintance> Inquiries { get; set; }

    }
}
