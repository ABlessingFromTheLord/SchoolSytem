using System;

namespace SchoolSytem.Interfaces
{
    public interface IFaculty
    {
        #region Properties
        // FacultyName
        public string FacultyName { get; set; }
        // Number of subjects offered
        public int SubjectsOffered { get; set; }
        // Faculty chairperson
        public string ChairPersonName { get; set; }
        // Faculty dean
        public string DeanName { get; set; }
        // Faculty member
        public string Member { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Adds a person to the faculty and their role
        /// </summary>
        /// <param name="name"></param>
        public string AddFacultyMember(string id, string role);

        /// <summary>
        /// Removes faculty member with the id
        /// </summary>
        /// <param name="id"></param>
        public string RemoveFacultyMember(string id);

        /// <summary>
        /// Returns all faculty members
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetFacultyMembers();

        /// <summary>
        /// Returns all subjects taught by this faculty
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetFacultySubjects();

        /// <summary>
        /// True if the school member with the given id is a faculty member
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsFacultyMember(string id);
        #endregion
    }
}

