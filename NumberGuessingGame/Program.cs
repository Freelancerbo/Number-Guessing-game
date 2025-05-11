// See https://aka.ms/new-console-template for more information

using System;

public class Program {
  
  public static void Main()
  {
    Console.WriteLine("Welcome to number guessing game !");
    
    int scretNumber = 7; // computers number
    int userguess = 5; //user guessed
    
    if  (userguess == scretNumber)
    {
          Console.WriteLine("Congratulations you passed");
    }
    else if (userguess < scretNumber)
    {
          Console.WriteLine("Too low, select a higher number please!");
    }
    else if  (userguess > scretNumber)
    {
          Console.WriteLine("Too higher");
    
    }
    
    Console.WriteLine(" Thanks for playing dear, Farhan and Tafseer");
    
  }
}