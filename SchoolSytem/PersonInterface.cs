using System;
namespace SchoolSytem
{
	public interface Person
	{
		// First name of person
		public string FirstName { get; set; }
		// Last name of person
		public string LastName { get; set; }
		// Address of person
		public string Address { get; set; }
		// Telefon number of person
		public string Telefon { get; set; }
		// Faculty studing
		public string FacultyName { get; set; }
		// Number of subject studying or teaching
		// For teachers teaching, for students studying
		public int Subjects { get; set; }
	}
}

