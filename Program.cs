namespace GA_MethodOverloading_StephanieLopez
{
    internal class Program
    {
        //Stephanie Lopez
        static void Main(string[] args)
        {
            // Method overloading is a feature that allows classes to define multiple methods with the same name but different parameters. 
            // Method overloading works in different ways according to the parameters. When a method is called, it is determined which version of the method will be used. 
            // Some of the benefits of using method over are, code reusability, readability, and flexibility!

            // The reasoning for using method overloading is because it allows us to define several methods within the same class but with different parameters. 
            // And different methods with the same name are distinguished based on the number, order type!
            // And different scenarios where method overloading may be useful consist of, math operations, file handling and graphic rendering.

            MathOperations math = new MathOperations();
            // Math operations
            int sum1 = math.Add(10, 5);
            Console.WriteLine($"Sum1: {sum1}");

            double difference = math.Subtract(7.5, 3.2);
            Console.WriteLine($"Difference: {difference}");

            double product = math.Multiply(4.0, 2.5, 3.0);
            Console.WriteLine($"Product: {product}");

                try
                {
                    double result = math.Divide(8.0, 2.0);
                    Console.WriteLine($"Division Result: {result}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

            // Employee class
            EmployeeDatabase database = new EmployeeDatabase();
            database.AddEmployee("John Doe");
            database.AddEmployee("Jane Smith", 30);
            database.AddEmployee("Robert Johnson", 25, "HR");
        }
    }
}