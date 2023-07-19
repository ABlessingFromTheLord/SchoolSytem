using System;
namespace SchoolSytem
{
	public interface Subject
	{
		// Name of subject
		public string SubjectName{ get; set; }
		// Credit points obtained from studying this subject
		public int CreditPoints { get; set; }
		// Workload of this suject
		public int Workload { get; set; }
		// Amount of teachers teaching this subject
		public int NumberOfTeachers { get; set; }
		// Amount of students taking this subject
		public int NumberOfStudents { get; set; }
	}
}

