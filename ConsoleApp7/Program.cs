using System;

// Create an interface called IQuittable
public interface IQuittable
{
    // Define a void method called Quit()
    void Quit();
}

// Create an Employee class that inherits the IQuittable interface
public class Employee : IQuittable
{
    // Implement the Quit() method from the IQuittable interface
    public void Quit()
    {
        Console.WriteLine("Employee has quit the job.");
    }

    // Other properties and methods of the Employee class can be added here
}

class Program
{
    static void Main()
    {
        // Create an object of type IQuittable using polymorphism
        IQuittable quittableEmployee = new Employee();

        // Call the Quit() method on the quittableEmployee object
        quittableEmployee.Quit();

        // Note: Although the object is declared as IQuittable, it is an instance of the Employee class,
        // and when you call Quit(), it calls the implementation from the Employee class.
    }
}
