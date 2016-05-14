using System;

class EnglishDigit
{

    static void Main()
    {

        int inputNum = int.Parse(Console.ReadLine());

        Console.WriteLine((Digit)(inputNum % 10));
    }

    public enum Digit
    {
        zero = 0,
        one = 1,
        two = 2,
        three = 3,
        four = 4,
        five = 5,
        six = 6,
        seven = 7,
        eight = 8,
        nine = 9
    }
}