using DP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking_Project.VM
{
    public class insertSeekerVM
    {
       public Person person { get; set; }
       public bool Boy { get; set; }
       public bool Girl { get; set; }
       public BoyOrGirlCMD BoyGirl { get; set; }
        public UpPictureCMD upPicture { get; set; }
       public insertSeekerVM()
        {
            BoyGirl = new BoyOrGirlCMD(this);
            upPicture = new UpPictureCMD(this);

        }
      

    }
}
