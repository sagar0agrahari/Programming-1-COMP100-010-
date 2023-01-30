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
        Console.Write("Enter a statement: ");
        string statement = Console.ReadLine();
        Console.Write("Is the statement true or false? (Enter 'true' or 'false'): ");
        bool response = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Statement: " + statement);
        Console.WriteLine("Response: " + response);
    }
}
