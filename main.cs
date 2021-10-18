using System;

class Program {
  public static double CalculateCharges(int hours)
  {
    double total = 2.00;
    
    int extraHours = hours - 3;

    if(extraHours <= 0)
    total = total + 0;
    else if(extraHours > 0 && extraHours <= 16)
    total = total + (0.5 * extraHours);
    else
    total = 10.00;


    return total;
  }

  public static void Main (string[] args) {
    string answer;

    do
    {
    Console.WriteLine("For how many hours did the customer use the garage?");

    int customerHours = Convert.ToInt32(Console.ReadLine());

    double customerTotal = CalculateCharges(customerHours);

    Console.WriteLine("Total charge is $" + customerTotal);
    
    Console.WriteLine("Is there any more customers? (y/n)");
    answer = Console.ReadLine();

    }while (answer == "y");
    
  }
}