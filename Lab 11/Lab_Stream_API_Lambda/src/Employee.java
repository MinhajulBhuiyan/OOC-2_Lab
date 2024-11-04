public class Employee
{
    private String firstName;
    private String lastName;
    private String postalCode;
    private String street;
    private String district;
    private int age;
    private String designation;
    private double remuneration;

    // Constructors
    public Employee()
    {

    }

    public Employee(String firstName, String lastName, String postalCode, String street, String district, int age, String designation, double remuneration)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.postalCode = postalCode;
        this.street = street;
        this.district = district;
        this.age = age;
        this.designation = designation;
        this.remuneration = remuneration;
    }

    // Getters
    public String getFirstName()
    {
        return firstName;
    }

    public String getLastName()
    {
        return lastName;
    }

    public String getPostalCode()
    {
        return postalCode;
    }

    public String getStreet()
    {
        return street;
    }

    public String getDistrict()
    {
        return district;
    }

    public int getAge()
    {
        return age;
    }

    public String getDesignation()
    {
        return designation;
    }

    public double getRemuneration()
    {
        return remuneration;
    }

    // Setters
    public void setFirstName(String firstName)
    {
        this.firstName = firstName;
    }

    public void setLastName(String lastName)
    {
        this.lastName = lastName;
    }

    public void setPostalCode(String postalCode)
    {
        this.postalCode = postalCode;
    }

    public void setStreet(String street)
    {
        this.street = street;
    }

    public void setDistrict(String district)
    {
        this.district = district;
    }

    public void setAge(int age)
    {
        this.age = age;
    }

    public void setDesignation(String designation)
    {
        this.designation = designation;
    }

    public void setRemuneration(double remuneration)
    {
        this.remuneration = remuneration;
    }
}
