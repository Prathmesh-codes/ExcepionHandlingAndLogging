using System;

namespace ExceptionHandlig
{
    class Divide
    {
        int result;

        Divide()
        {
            result = 0;
        }
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught = {0}", e);
                Console.WriteLine("Exception Handled Successfully");
            }
            finally
            {
                Console.WriteLine("Result = {0}", result);
            }
        }
        static void Main(string[] args)
        {
            Divide d = new Divide();
            d.division(400, 0);
            Console.WriteLine("Enter age to validate-");
            int age = int.Parse(Console.ReadLine());


            try
            {
                validate(age);
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e);

                Console.WriteLine("Exception Handled Successfully");
            }


            finally
            {
                Console.WriteLine("Age entered was-{0}", age);
            }


            Console.ReadKey();
        }



        static void validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
        }


    }

    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message) : base(message)
        {

        }
    }









}








