using SchoolSytem;

#region Faculty Instances
Faculty faculty1 = new Faculty
{
    FacultyName = "Computer Science",
    SubjectsOffered = 10,
    ChairPersonName = "John Smith",
    DeanName = "Jane Doe",
    Member = "Michael Johnson"
};

Faculty faculty2 = new Faculty
{
    FacultyName = "Electrical Engineering",
    SubjectsOffered = 8,
    ChairPersonName = "Emily Brown",
    DeanName = "James Lee",
    Member = "Emma Wilson"
};

Faculty faculty3 = new Faculty
{
    FacultyName = "Mechanical Engineering",
    SubjectsOffered = 7,
    ChairPersonName = "Daniel Taylor",
    DeanName = "Olivia Anderson",
    Member = "William Martinez"
};

Faculty faculty4 = new Faculty
{
    FacultyName = "Physics",
    SubjectsOffered = 6,
    ChairPersonName = "Ava Garcia",
    DeanName = "Liam Lopez",
    Member = "Sophia Hernandez"
};

Faculty faculty5 = new Faculty
{
    FacultyName = "Mathematics",
    SubjectsOffered = 9,
    ChairPersonName = "Noah Gonzalez",
    DeanName = "Isabella Miller",
    Member = "James Davis"
};

#endregion

#region Student Instances
Student student1 = new Student("John", "Doe", "Male", 20, "ID001");
Student student2 = new Student("Jane", "Smith", "Female", 19, "ID002");
Student student3 = new Student("Michael", "Johnson", "Male", 22, "ID003");
Student student4 = new Student("Emily", "Brown", "Female", 21, "ID004");
Student student5 = new Student("James", "Lee", "Male", 18, "ID005");
Student student6 = new Student("Emma", "Wilson", "Female", 23, "ID006");
Student student7 = new Student("Daniel", "Taylor", "Male", 20, "ID007");
Student student8 = new Student("Olivia", "Anderson", "Female", 19, "ID008");
Student student9 = new Student("William", "Martinez", "Male", 22, "ID009");
Student student10 = new Student("Ava", "Garcia", "Female", 21, "ID010");


List<Student> students = new List<Student>();
students.Add(student1);
students.Add(student2);
students.Add(student3);
students.Add(student4);
students.Add(student5);
students.Add(student6);
students.Add(student7);
students.Add(student8);
students.Add(student9);
students.Add(student10);


for (int i = 0; i < students.Count; i++) {
    Console.WriteLine(students[i].Telefon);
}

// Console.WriteLine(students.Count);



#endregion


