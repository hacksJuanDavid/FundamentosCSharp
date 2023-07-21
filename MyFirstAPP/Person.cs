namespace MyFirstAPP;

public class Person
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method
    public void SayHello()
    {
        Console.WriteLine("Method SayHello in class Person");
        Console.WriteLine("Hello, my name is {0} and I am {1} years old.", Name, Age);
        // Jump line
        Console.WriteLine();
    }
}