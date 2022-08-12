using DP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IBL
    {
        #region Parent
        Parent AddparentToDAL(string firstName, string lastName, string middleName, Gender gender, Origin origin, int seekerId);
        #endregion
    }
}
