using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSytem
{
    /// <summary>
    /// This class is a representation of a faculty
    /// </summary>
    public class Faculty 
    {
        #region Fields

        #endregion

        #region Constructor
        public Faculty()
        {

        }
        #endregion

        #region Properties
        public string? FacultyName { get; set; }
        public int? SubjectsOffered { get; set; }
        public string? ChairPersonName { get; set; }
        public string? DeanName { get; set; }
        public string? Member { get; set; }
        #endregion

        #region Methods
        public string AddFacultyMember(string id, string role)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetFacultyMembers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetFacultySubjects()
        {
            throw new NotImplementedException();
        }

        public bool IsFacultyMember(string id)
        {
            throw new NotImplementedException();
        }

        public string RemoveFacultyMember(string id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
