namespace Udemy_Exercise_Set.Entities
{
    public class Courses
    {
        public int Students { get; set; }
        public string Course { get; set; }

        public Courses(int students, string course)
        {
            Students = students;
            Course = course;
        }

        public override int GetHashCode()
        {
            return Students.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Courses)) return false;

            Courses other = obj as Courses;

            return Students.Equals(other.Students);
        }
    }
}
