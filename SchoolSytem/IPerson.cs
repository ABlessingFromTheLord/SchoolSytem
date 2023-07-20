using System;

namespace SchoolSytem.Interfaces
{
    public interface IPerson
    {
        #region Properties
        /// <summary>
        /// First name of person
        /// </summary>
        string FirstName { get; set; }
        /// <summary>
        /// Last name of person
        /// </summary>
        string LastName { get; set; }
        /// <summary>
        /// Id of person
        /// </summary>
        string Id { get; set; }
        /// <summary>
        /// Role in school
        /// </summary>
        string Role { get; set; }
        /// <summary>
        /// Date of bith of person
        /// </summary>
        string DateOfBirth { get; set; }
        /// <summary>
        /// Address of person
        /// </summary>
        string Address { get; set; }
        /// <summary>
        /// Telefon number of person
        /// </summary>
        string Telefon { get; set; }
        // Faculty studing
        string FacultyName { get; set; }
        /// <summary>
        /// Number of subject studying or teaching
        /// For teachers teaching, for students studying
        /// </summary>
         int Subjects { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Return role of person with given id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetRole(string id);

        /// <summary>
        /// Returns Telefon number of person with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetTelefon(string id);

        /// <summary>
        /// Returns faculty of person with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetFacultyName(string id);

        /// <summary>
        /// Returns Address of person with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetAddress(string id);

        /// <summary>
        /// Returns first name of person with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetFirstName(string id);

        /// <summary>
        /// Returns last name of person with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetLastName(string id);

        /// <summary>
        /// Returns first name and last name of person with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetName(string id);



        #endregion
    }
}

