namespace MyFirstAPP;

public class EstructureOfConditions
{
    // Properties
    public int Number1 { get; set; }

    public int Number2 { get; set; }


    // Constructor
    public EstructureOfConditions(int number1, int number2)
    {
        Number1 = number1;
        Number2 = number2;
    }

    // Method If
    public void If()
    {   
        //Jump line
        Console.WriteLine();
        
        //Title of the class
        Console.WriteLine("Estructure of conditions");
        
        if (Number1 > Number2)
        {
            Console.WriteLine("The number1 is greater than number2");
        }
        else
        {
            Console.WriteLine("The number2 is greater than number1");
        }
    }

    // Method Switch
    public void Switch()
    {
        switch (Number1)
        {
            case 1:
                Console.WriteLine("The number1 is 1");
                break;
            case 2:
                Console.WriteLine("The number1 is 2");
                break;
            case 3:
                Console.WriteLine("The number1 is 3");
                break;
            default:
                Console.WriteLine("The number1 is not 1, 2 or 3");
                break;
        }
    }

    // Method While
    public void While()
    {
        while (Number1 < Number2)
        {
            Console.WriteLine("The number1 is less than number2");
            Number1++;
        }
    }

    // Method DoWhile
    public void DoWhile()
    {
        do
        {
            Console.WriteLine("The number1 is less than number2");
            Number1++;
        } while (Number1 < Number2);
    }

    // Method For
    public void For()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("The number1 is less than number2");
        }
    }

    // Method Foreach
    public void Foreach()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int number in numbers)
        {
            Console.WriteLine("The number is {0}", number);
        }
    }

    // Method Break
    public void Break()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break;
            }

            Console.WriteLine("The number is {0}", i);
        }
    }

    // Method Continue
    public void Continue()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                continue;
            }

            Console.WriteLine("The number is {0}", i);
        }
    }

    // Method Return
    public void Return()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                return;
            }

            Console.WriteLine("The number is {0}", i);
        }
    }

    // Method TryCatch
    public void TryCatch()
    {
        try
        {
            int division = Number1 / Number2;
            Console.WriteLine("The division is {0}", division);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
    }

    // Method Throw
    public void Throw()
    {
        try
        {
            if (Number1 == 0)
            {
                throw new Exception("The number1 is 0");
            }

            int division = Number1 / Number2;
            Console.WriteLine("The division is {0}", division);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
    }

    // Method Finally
    public void Finally()
    {
        try
        {
            int division = Number1 / Number2;
            Console.WriteLine("The division is {0}", division);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
        finally
        {
            Console.WriteLine("The finally is executed");
        }
    }


    // Method Using
    public void Using()
    {
        using (StreamWriter writer = new StreamWriter("file.txt"))
        {
            writer.WriteLine("Hello World");
        }
    }

    // Method Lock
    public void Lock()
    {
        lock (this)
        {
            Console.WriteLine("The lock is executed");
        }
    }

    // Method Checked
    public void Checked()
    {
        checked
        {
            int number = int.MaxValue;
            Console.WriteLine("The number is {0}", number);
        }
    }

    // Method Unchecked
    public void Unchecked()
    {
        unchecked
        {
            int number = int.MaxValue;
            Console.WriteLine("The number is {0}", number);
        }
    }
}