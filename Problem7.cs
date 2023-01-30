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
        Console.Write("Enter the radius of the circle in cm : ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("Area of the circle in cm^2 : {0:F}", area);
    }
}
