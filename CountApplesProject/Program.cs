using System;
    
class Program
{
    static void Main()
    {
        Console.WriteLine("HOW MANY APPLES DO WE HAVE TOGETHER?\n");

        string personOne = "Martin";
        int martinApples = 7;

        // TODO: Classmate must add his / hers name and how many apples he / she have
        string personTwo = "PersonTwo"; 
        int personTwoApples = 0;

        // TODO: Classmate must add his / hers name and how many apples he / she have
        string personThree = "PersonThree";
        int personThreeApples = 0;


        int totalApples = martinApples + personTwoApples +  personThreeApples;

        Console.WriteLine("My name is " + personOne + " and I have " + martinApples + " apples.");
        Console.WriteLine("My name is " + personTwo + " and I have " + personTwoApples + " apples.");
        Console.WriteLine("My name is " + personThree + " and I have " + personThreeApples + " apples.");

        Console.WriteLine("\nTogether we have " + totalApples + " apples. That will be one hell of an apple pie!!!");
        

    }
}
