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
        Console.Write("Enter the current flowing in the wire (in Amperes): ");
        double current = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the resistance of the wire (in Ohms): ");
        double resistance = Convert.ToDouble(Console.ReadLine());
        double potentialDifference = current * resistance;
        Console.WriteLine("The potential difference between the ends of the wire is {0:F} Volts", potentialDifference);
    }
}
