// Static method Main

namespace MyFirstAPP


{
    class Program
    {
        static void Main()
        {
            // Create new object of class Person
            Person person = new Person("John", 36);
            // Call method SayHello
            person.SayHello();

            // Create new object of class TypesData
            TypesData typesData = new TypesData("John", 36, true, 1.80, 80, 'J', 1, 1000, 1000000000000000000, 1, 1, 1,
                1, 1, DateTime.Now, "Anything", new object?[] { "John", "Mary" }, new[] { 1, 2 },
                new List<string> { "John", "Mary" }, new Dictionary<string, int> { { "John", 1 }, { "Mary", 2 } },
                new Tuple<string, int>("John", 1), "Dynamic type");
            // Call method SayHello
            typesData.SayHello();
            typesData.PrintVar();

            // Crear una instancia de la clase OperatorsArithmeticAndLogical
            OperatorsArithmeticAndLogical calculator = new OperatorsArithmeticAndLogical(10, 5, 2);

            // Llamar al método Sum a través de la instancia
            calculator.PrintTitleClass();
            calculator.Sum();
            calculator.Subtraction();
            calculator.Multiplication();
            calculator.Division();
            calculator.Modulus();
            calculator.Increment();
            calculator.Decrease();
            calculator.Assignment();
            calculator.Equality();
            calculator.Inequality();
            calculator.GreaterThan();
            calculator.LessThan();
            calculator.GreaterThanOrEqual();
            calculator.LessThanOrEqual();
            calculator.And();
            calculator.Or();
            calculator.Not();
            calculator.BitwiseAnd();
            calculator.BitwiseOr();
            calculator.BitwiseXor();
            calculator.BitwiseComplement();
            calculator.LeftShift();
            calculator.RightShift();
            calculator.AdditionAssignment();
            calculator.SubtractionAssignment();
            calculator.MultiplicationAssignment();
            calculator.DivisionAssignment();
            calculator.ModulusAssignment();
            calculator.BitwiseAndAssignment();
            calculator.BitwiseOrAssignment();
            calculator.BitwiseXorAssignment();
            calculator.LeftShiftAssignment();
            calculator.RightShiftAssignment();
            calculator.TernaryConditional();

            // Create new object of class EstructureOfConditions
            EstructureOfConditions estructureOfConditions = new EstructureOfConditions(1, 2);
            // Call method If
            estructureOfConditions.If();
            // Call method Switch
            estructureOfConditions.Switch();
            // Call method While
            estructureOfConditions.While();
            estructureOfConditions.DoWhile();
            estructureOfConditions.For();
            estructureOfConditions.Foreach();
            estructureOfConditions.Break();
            estructureOfConditions.Continue();
            estructureOfConditions.Break();
            estructureOfConditions.Continue();
            estructureOfConditions.Return();
            estructureOfConditions.TryCatch();
            estructureOfConditions.Throw();
            estructureOfConditions.Using();
            estructureOfConditions.Lock();
            estructureOfConditions.Checked();
            estructureOfConditions.Unchecked();

        }
    }
}