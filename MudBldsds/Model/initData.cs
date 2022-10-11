namespace MudBldsds.Model
{
    public static class initData
    {
        public static void GenData(SchoolDbContext db)
        {
            db.Database.EnsureCreated();
            if (db.Students.Any())
            {
                //return;
            }

            Grade grade = new Grade();
            grade.GradeId = 01;
            grade.GradeName = "A";
            grade.Section = "dfdg";
            db.Grades.Add(grade);
            db.SaveChanges();

            Grade grade2 = new Grade();
            grade2.GradeId = 02;
            grade2.GradeName = "B";
            grade2.Section = "ddgd";
            db.Grades.Add(grade2);
            db.SaveChanges();

            Student std = new Student();
            std.StudentID = 01;
            std.StudentName = "Adidas";
            std.DateOfBirth = new DateTime(2004 - 05 - 06);
            std.Height = 165;
            std.Weight = 50;
            std.GradeID = grade.GradeId;
            db.Students.Add(std);
            db.SaveChanges();

        }
    }
}
