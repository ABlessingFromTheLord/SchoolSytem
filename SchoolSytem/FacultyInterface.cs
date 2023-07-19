using System;
namespace SchoolSytem
{
	public interface Faculty
	{
		// FacultyName
		public string FacultyName { get; set; }
		// Number of subjects offered
		public int SubjectsOffered { get; set; }
		// Faculty chairperson
		public string ChairPersonName { get; set; }
	}
}

