using System;

public class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN";

    public virtual void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

//Let's inheritence the Parttimeemployee from Employee class to get the common data
//also called a child class
public class PartTimeEmployee : Employee
{

    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Part time");

    }
}

public class TemporaryEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Temp");

    }

}

//Similarly the common data will be derives to Fulltime inheritance class
public class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Fulltime");

    }
}

public class program
{
    public static void Main()
    {

        // using the override in the methods above to over from the 
        // to override the parents classes methods from child class at run time 
        //called nothing but Polymorphism

        // in other word, Polymorphism enable us to derive through base class to
        //over ride the main class referance veriable at runtime

        Employee[] employee = new Employee[4];
        employee[0] = new Employee();
        employee[1] = new PartTimeEmployee();
        employee[2] = new FullTimeEmployee();
        employee[3] = new TemporaryEmployee();


        foreach (Employee e in employee)
        {
            e.PrintFullName();
        }
        // the final test .. only for comming and push
    }
}