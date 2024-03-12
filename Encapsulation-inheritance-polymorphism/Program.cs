namespace Encapsulation_inheritance_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumericInputError numericInputError = new NumericInputError();
            TextInputError textInputError = new TextInputError();

            Console.WriteLine("NumericInputError message: " + numericInputError.UEMessage());
            Console.WriteLine("TextInputError message: " + textInputError.UEMessage());
        }
    }
}
