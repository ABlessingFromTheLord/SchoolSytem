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
    public abstract class BasePerson
    {
        #region Fields
        private string _FirstName;
        private string _LastName;
        private string _Gender;
        private int _Age;
        private string _Id;

            
        #endregion

        #region Constructor
        public BasePerson(string FirstName, string LastName, string Gender, int Age, string id)
        {
            _FirstName = FirstName;
            _LastName = LastName;
            _Gender = Gender;
            _Age = Age;
            _Id = id;
        }
        #endregion

        #region Properties
        public string Id { get; set; }
        public string Role { get; set; }
        public string Address { get; set; }
        public string Telefon { get; set; }
        public string FacultyName { get; set; }
        public int Subjects { get; set; }
        #endregion

        #region Methods
        #region Getters
        /// <summary>
        /// Returns first name of person
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetFirstName() { return _FirstName; }

        /// <summary>
        /// Returns last name of person
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetLastName() { return _LastName; }

        /// <summary>
        /// Returns full name of person
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetName() { return _FirstName + " " + _LastName; }

        /// <summary>
        /// Returns gender of person
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetGender() {return _Gender; }

        /// <summary>
        /// Returns age of person
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetAge() { return (int)_Age; }

        /// <summary>
        /// Returns Id of person
        /// </summary>
        /// <returns></returns>
        public string GetId() { return _Id; }
        #endregion

        #region Setters
        /// <summary>
        /// Sets first name of person
        /// </summary>
        /// <param name="FirstName"></param>
        public void SetFirstName(string FirstName) { _FirstName = FirstName; }

        /// <summary>
        /// Sets last name of person
        /// </summary>
        /// <param name="LastName"></param>
        public void SetLastName(string LastName) {  _LastName = LastName;}

        /// <summary>
        /// Sets gender of person
        /// </summary>
        /// <param name="Gender"></param>
        public void SetGender(string Gender) {  _Gender = Gender;}

        /// <summary>
        /// Serts age of person
        /// </summary>
        /// <param name="Age"></param>
        public void SetAge(int Age) {  _Age = Age;}

        /// <summary>
        /// Sets id of person
        /// </summary>
        /// <param name="Id"></param>
        public void SetId(string Id) { _Id = Id; }
        #endregion

        #endregion
    }
}
