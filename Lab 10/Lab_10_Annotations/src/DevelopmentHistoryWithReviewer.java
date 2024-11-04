import java.lang.annotation.*;

@Documented
@Target({ElementType.CONSTRUCTOR,ElementType.METHOD})
@Retention(RetentionPolicy.RUNTIME)
public @interface DevelopmentHistoryWithReviewer
{
    int version() default 1;
    String developer();
    String tester() default "";
    String[] reviewers();
}
