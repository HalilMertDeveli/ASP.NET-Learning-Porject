namespace RepeatOperationForAspNet.Models
{
    public static class StudentContext
    {


        public static List<Student> studentList = new List<Student>() {
                new Student()
                {
                    StudentId = 1,
                    StudentName ="HMD",
                    StudentLastName = "DEVELI",
                    StudentGrade  =22,
                },
                new Student()
                {
                    StudentId = 2,
                    StudentName ="Musa",
                    StudentLastName = "DEVELI",
                    StudentGrade  =50,
                },
                new Student()
                {
                    StudentId = 3,
                    StudentName ="Kadir",
                    StudentLastName = "KARADELI",
                    StudentGrade  =52,
                },
                new Student()
                {
                    StudentId = 4,
                    StudentName ="Murat",
                    StudentLastName = "BAS",
                    StudentGrade  =53,
                },
                new Student()
                {
                    StudentId = 5,
                    StudentName ="Kemal",
                    StudentLastName = "GENC",
                    StudentGrade  =22,
                }
             };


    }
}
