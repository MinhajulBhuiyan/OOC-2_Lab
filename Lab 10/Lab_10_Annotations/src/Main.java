import java.lang.reflect.Method;

public class Main
{
    public static void main(String[] args)
    {
        Faculty faculty1 = new Faculty("Md. Jubair Ibna Mostafa","Assistant Professor",100000.00);
        Course course1 = new Course(4304, "OOP",3.00, type.LAB);

        faculty1.Teach(course1);
        faculty1.Research("Annotation and Reflection");


        for(Method method : Faculty.class.getDeclaredMethods())
        {
            if(method.isAnnotationPresent(DevelopmentHistoryWithReviewer.class))
            {
                DevelopmentHistoryWithReviewer reviewer=method.getAnnotation(DevelopmentHistoryWithReviewer.class);
                System.out.printf(method.getName() + " is reviewed by ");

                for(String s : reviewer.reviewers())
                {
                    System.out.print(s+" ");
                }
                System.out.println();
            }
        }
    }
}