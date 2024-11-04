import java.util.List;

@DevelopmentHistory(version = 2,developer = "Minhaj",tester = "Tester")
public class Faculty
{
    public String facultyName;
    public String designation;
    public Double salary;
    public List<String> Course;
    @DevelopmentHistoryWithReviewer(version = 2,developer = "Minhaj",tester = "Tauhid",reviewers = {"Rifaf","Alif","Mir"})
    public void Teach(Course course)
    {
        System.out.println("Teaching: " + course.courseName+" "+course.courseCode +"/"+ course.courseType);
    }

    @DevelopmentHistoryWithReviewer(version = 2,developer = "Minhaj",tester = "Tauhid",reviewers = {"Alif","Mir"})
    public void Research(String Topic)
    {
        System.out.println(Topic);
    }

    @DevelopmentHistoryWithReviewer(version = 2,developer = "Minhaj",tester = "Tauhid",reviewers = {"Labib","Tasnim","Alif"})
    public Faculty(String facultyName, String designation, Double salary, List<String> course)
    {
        this.facultyName = facultyName;
        this.designation = designation;
        this.salary = salary;
        Course = course;
    }

    public Faculty(String facultyName, String designation, Double salary)
    {
        this.facultyName = facultyName;
        this.designation = designation;
        this.salary = salary;
    }
}
