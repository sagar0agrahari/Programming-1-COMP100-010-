/*Student Name: Sagar Agrahari
    Student Number: 301324889
    Current Semester: First
    Course Number: 
    Course Name: 
    College: Centennial College, Progress Campus
    Contact Number: +1 6478987932 
    Gmail: sagaragrahari106@gmail.com*/

using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Enter a number: ");
        double input = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("number as double : " + input);
        int inputAsInt = (int) input;
        Console.WriteLine("number as  int: " + inputAsInt);
        char inputAsChar = (char) inputAsInt;
        Console.WriteLine("number as  char: " + inputAsChar);
    }
}
