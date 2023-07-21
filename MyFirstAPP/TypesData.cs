namespace MyFirstAPP;

public class TypesData
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsMale { get; set; }
    public double Height { get; set; }
    public float Weight { get; set; }
    public char FirstLetter { get; set; }
    public byte Number { get; set; }
    public decimal Money { get; set; }
    public long BigNumber { get; set; }
    public short SmallNumber { get; set; }
    public uint PositiveNumber { get; set; }
    public ulong PositiveBigNumber { get; set; }
    public ushort PositiveSmallNumber { get; set; }
    public sbyte NegativeNumber { get; set; }
    public DateTime Date { get; set; }
    public object Anything { get; set; }
    public object?[]? Names { get; set; }
    public int[] Numbers { get; set; }
    public List<string> ListOfNames { get; set; }
    public Dictionary<string, int> DictionaryOfNames { get; set; }
    public Tuple<string, int> TupleOfNames { get; set; }
    public dynamic DynamicType { get; set; }

    // Constructor
    public TypesData(string name, int age, bool isMale, double height, float weight, char firstLetter, byte number,
        decimal money, long bigNumber, short smallNumber, uint positiveNumber, ulong positiveBigNumber,
        ushort positiveSmallNumber, sbyte negativeNumber, DateTime date, object anything, object?[] names,
        int[] numbers, List<string> listOfNames, Dictionary<string, int> dictionaryOfNames,
        Tuple<string, int> tupleOfNames, dynamic dynamicType)
    {
        Name = name;
        Age = age;
        IsMale = isMale;
        Height = height;
        Weight = weight;
        FirstLetter = firstLetter;
        Number = number;
        Money = money;
        BigNumber = bigNumber;
        SmallNumber = smallNumber;
        PositiveNumber = positiveNumber;
        PositiveBigNumber = positiveBigNumber;
        PositiveSmallNumber = positiveSmallNumber;
        NegativeNumber = negativeNumber;
        Date = date;
        Anything = anything;
        Names = names;
        Numbers = numbers;
        ListOfNames = listOfNames;
        DictionaryOfNames = dictionaryOfNames;
        TupleOfNames = tupleOfNames;
        DynamicType = dynamicType;
    }

    // Method
    public void SayHello()
    {
        Console.WriteLine("Method SayHello in class TypesData");
        //Console write differents types of data
        Console.WriteLine("My name is {0}", Name);
        Console.WriteLine("I am {0} years old", Age);
        Console.WriteLine("Gender introduce {0}", IsMale);
        Console.WriteLine("My height is {0}", Height);
        Console.WriteLine("My weight is {0}", Weight);
        Console.WriteLine("My first letter is {0}", FirstLetter);
        Console.WriteLine("My number is {0}", Number);
        Console.WriteLine("My money is {0}", Money);
        Console.WriteLine("My big number is {0}", BigNumber);
        Console.WriteLine("My small number is {0}", SmallNumber);
        Console.WriteLine("My positive number is {0}", PositiveNumber);
        Console.WriteLine("My positive big number is {0}", PositiveBigNumber);
        Console.WriteLine("My positive small number is {0}", PositiveSmallNumber);
        Console.WriteLine("My negative number is {0}", NegativeNumber);
        Console.WriteLine("My date is {0}", Date);
        Console.WriteLine("My anything is {0}", Anything);
        Console.WriteLine("My names is {0}", Names);
        Console.WriteLine("My numbers is {0}", Numbers);
        Console.WriteLine("My list of names is {0}", ListOfNames);
        Console.WriteLine("My dictionary of names is {0}", DictionaryOfNames);
        Console.WriteLine("My tuple of names is {0}", TupleOfNames);
        Console.WriteLine("My dynamic type is {0}", DynamicType);
        // Jump line
        Console.WriteLine();
    }

    // Second Method
    public void PrintVar()
    {
        // Create a Var , used not implicit type
        var name = "John";
        var age = 36;

        // Create a Const , used const type
        const int velocity = 300000000;
        const double pi = 3.14159265359;

        // Print Var
        Console.WriteLine("Method PrintVar");
        Console.WriteLine("My name is {0}", name);
        Console.WriteLine("I am {0} years old", age);
        Console.WriteLine("My velocity is {0}", velocity);
        Console.WriteLine("My pi is {0}", pi);
        // Jump line
        Console.WriteLine();
    }
}