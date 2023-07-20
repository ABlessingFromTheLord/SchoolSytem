using SchoolSytem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSytem
{
    /// <summary>
    /// This class represents a person 
    /// </summary>
    public abstract class Person : IPerson
    {
        #region Fields

        #endregion

        #region Constructor
        public Person()
        {

        }
        #endregion

        #region Properties
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string Id { get; set; }
        public string Role { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Telefon { get; set; }
        public string FacultyName { get; set; }
        public int Subjects { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        #region Methods
        public string GetAddress(string id)
        {
            throw new NotImplementedException();
        }

        public string GetFacultyName(string id)
        {
            throw new NotImplementedException();
        }

        public string GetFirstName(string id)
        {
            throw new NotImplementedException();
        }

        public string GetLastName(string id)
        {
            throw new NotImplementedException();
        }

        public string GetName(string id)
        {
            throw new NotImplementedException();
        }

        public string GetRole(string id)
        {
            throw new NotImplementedException();
        }

        public string GetTelefon(string id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
