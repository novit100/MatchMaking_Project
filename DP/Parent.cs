using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class Parent : Person
    {
        public int SeekerId { get; set; }
        public Gender Gender { get; set; }
        public Origin FathersOrigin { get; set; }
        public Origin? MotherOrigin { get; set; }
        public override string ToString()
        {
            return string.Format($"{"Parent Id: " + Id,-30}\n{"First Name: " + FirstName,-30}\n" +
                $"{"Middle Name: " + MiddleName,-30}\n{"Last Name: " + LastName,-30}\n{"Gender: " + Gender,-30}\n" +
                $"{"Origin: " + FathersOrigin,-30}\n{"Seeker Id: " + SeekerId,-30}\n");
        }

    }
}
