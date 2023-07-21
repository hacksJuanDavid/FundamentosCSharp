namespace MyFirstAPP;

public class OperatorsArithmeticAndLogical
{
    // Properties 
    public int Number1 { get; set; }

    public int Number2 { get; set; }

    public int Number3 { get; set; }

    // Constructor
    public OperatorsArithmeticAndLogical(int number1, int number2, int number3)
    {
        Number1 = number1;
        Number2 = number2;
        Number3 = number3;
    }


    public void PrintTitleClass()
    {
        Console.WriteLine("Method PrintTitleClass");
        Console.WriteLine("Operators Arithmetic and Logical");
    }

    // Method Arithmetic Used

    // Method Sum
    public void Sum()
    {
        int sum = Number1 + Number2 + Number3;
        Console.WriteLine("The sum is {0}", sum);
    }

    // Method Subtraction
    public void Subtraction()
    {
        int subtraction = Number1 - Number2 - Number3;
        Console.WriteLine("The subtraction is {0}", subtraction);
    }

    // Method Multiplication
    public void Multiplication()
    {
        int multiplication = Number1 * Number2 * Number3;
        Console.WriteLine("The multiplication is {0}", multiplication);
    }

    // Method Division
    public void Division()
    {
        int division = Number1 / Number2 / Number3;
        Console.WriteLine("The division is {0}", division);
    }

    // Method Modulus
    public void Modulus()
    {
        int modulus = Number1 % Number2 % Number3;
        Console.WriteLine("The modulus is {0}", modulus);
    }

    // Method Increment
    public void Increment()
    {
        int increment = Number1++;
        Console.WriteLine("The increment is {0}", increment);
    }

    // Method Decrement
    public void Decrease()
    {
        int decrease = Number1--;
        Console.WriteLine("The decrease is {0}", decrease);
    }

    // Method Assignment
    public void Assignment()
    {
        int assignment = Number1 += Number2;
        Console.WriteLine("The assignment is {0}", assignment);
    }

    // Method Equality
    public void Equality()
    {
        bool equality = Number1 == Number2;
        Console.WriteLine("The equality is {0}", equality);
    }

    // Method Inequality
    public void Inequality()
    {
        bool inequality = Number1 != Number2;
        Console.WriteLine("The inequality is {0}", inequality);
    }

    // Method GreaterThan
    public void GreaterThan()
    {
        bool greaterThan = Number1 > Number2;
        Console.WriteLine("The greater than is {0}", greaterThan);
    }

    // Method LessThan
    public void LessThan()
    {
        bool lessThan = Number1 < Number2;
        Console.WriteLine("The less than is {0}", lessThan);
    }

    // Method GreaterThanOrEqual
    public void GreaterThanOrEqual()
    {
        bool greaterThanOrEqual = Number1 >= Number2;
        Console.WriteLine("The greater than or equal is {0}", greaterThanOrEqual);
    }

    // Method LessThanOrEqual
    public void LessThanOrEqual()
    {
        bool lessThanOrEqual = Number1 <= Number2;
        Console.WriteLine("The less than or equal is {0}", lessThanOrEqual);
    }

    // Method And
    public void And()
    {
        bool and = Number1 > Number2 && Number1 > Number3;
        Console.WriteLine("The and is {0}", and);
    }

    // Method Or
    public void Or()
    {
        bool or = Number1 > Number2 || Number1 > Number3;
        Console.WriteLine("The or is {0}", or);
    }

    // Method Not
    public void Not()
    {
        bool not = !(Number1 > Number2);
        Console.WriteLine("The not is {0}", not);
    }

    // Method BitwiseAnd
    public void BitwiseAnd()
    {
        int bitwiseAnd = Number1 & Number2;
        Console.WriteLine("The bitwise and is {0}", bitwiseAnd);
    }

    // Method BitwiseOr
    public void BitwiseOr()
    {
        int bitwiseOr = Number1 | Number2;
        Console.WriteLine("The bitwise or is {0}", bitwiseOr);
    }

    // Method BitwiseXor
    public void BitwiseXor()
    {
        int bitwiseXor = Number1 ^ Number2;
        Console.WriteLine("The bitwise xor is {0}", bitwiseXor);
    }

    // Method BitwiseComplement
    public void BitwiseComplement()
    {
        int bitwiseComplement = ~Number1;
        Console.WriteLine("The bitwise complement is {0}", bitwiseComplement);
    }

    // Method LeftShift
    public void LeftShift()
    {
        int leftShift = Number1 << Number2;
        Console.WriteLine("The left shift is {0}", leftShift);
    }

    // Method RightShift
    public void RightShift()
    {
        int rightShift = Number1 >> Number2;
        Console.WriteLine("The right shift is {0}", rightShift);
    }

    // Method AdditionAssignment
    public void AdditionAssignment()
    {
        int additionAssignment = Number1 += Number2;
        Console.WriteLine("The addition assignment is {0}", additionAssignment);
    }

    // Method SubtractionAssignment
    public void SubtractionAssignment()
    {
        int subtractionAssignment = Number1 -= Number2;
        Console.WriteLine("The subtraction assignment is {0}", subtractionAssignment);
    }

    // Method MultiplicationAssignment
    public void MultiplicationAssignment()
    {
        int multiplicationAssignment = Number1 *= Number2;
        Console.WriteLine("The multiplication assignment is {0}", multiplicationAssignment);
    }

    // Method DivisionAssignment
    public void DivisionAssignment()
    {
        int divisionAssignment = Number1 /= Number2;
        Console.WriteLine("The division assignment is {0}", divisionAssignment);
    }

    // Method ModulusAssignment
    public void ModulusAssignment()
    {
        int modulusAssignment = Number1 %= Number2;
        Console.WriteLine("The modulus assignment is {0}", modulusAssignment);
    }

    // Method BitwiseAndAssignment
    public void BitwiseAndAssignment()
    {
        int bitwiseAndAssignment = Number1 &= Number2;
        Console.WriteLine("The bitwise and assignment is {0}", bitwiseAndAssignment);
    }

    // Method BitwiseOrAssignment
    public void BitwiseOrAssignment()
    {
        int bitwiseOrAssignment = Number1 |= Number2;
        Console.WriteLine("The bitwise or assignment is {0}", bitwiseOrAssignment);
    }

    // Method BitwiseXorAssignment
    public void BitwiseXorAssignment()
    {
        int bitwiseXorAssignment = Number1 ^= Number2;
        Console.WriteLine("The bitwise xor assignment is {0}", bitwiseXorAssignment);
    }

    // Method LeftShiftAssignment
    public void LeftShiftAssignment()
    {
        int leftShiftAssignment = Number1 <<= Number2;
        Console.WriteLine("The left shift assignment is {0}", leftShiftAssignment);
    }

    // Method RightShiftAssignment
    public void RightShiftAssignment()
    {
        int rightShiftAssignment = Number1 >>= Number2;
        Console.WriteLine("The right shift assignment is {0}", rightShiftAssignment);
    }

    // Method TernaryConditional
    public void TernaryConditional()
    {
        int ternaryConditional = Number1 > Number2 ? Number1 : Number2;
        Console.WriteLine("The ternary conditional is {0}", ternaryConditional);
        // Jump line
        Console.WriteLine();
    }
}