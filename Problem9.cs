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
        Console.Write("Welcome to ticket booking system !!\n");
        Console.Write("Enter number of adult tickets: ");
        int adultTickets = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of child tickets: ");
        int childTickets = Convert.ToInt32(Console.ReadLine());
        double adultTicketCost = 3.75;
        double childTicketCost = 2.25;
        double totalCost = adultTicketCost * adultTickets + childTicketCost * childTickets;
        Console.WriteLine("You have purchased {0} adult tickets and {1} child tickets ", adultTickets, childTickets);
        Console.WriteLine("Your total cost for Tickets is {0:C}", totalCost);
        // I am facing a problem in this line . in output there is a question mark infornt of totalCost 
        // I have tried others ways as well to solve but I am unable to solve . either it display only totalCost else throws back error .
    }
}
