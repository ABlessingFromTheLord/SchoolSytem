using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSytem
{
    public class Student : BasePerson
    {
        #region Fields
        #endregion

        #region Constructor
        public Student(string FirstName, string LastName, string Gender, int Age, string Id)
            :base(FirstName, LastName, Gender, Age, Id)
        {
        
        }
        #endregion
    }
}
