using System;
using System.Diagnostics;

while (true){
   try{
start:
Console.WriteLine("Please choose options:\n");
Console.WriteLine("1. Add two numbers");
Console.WriteLine("2. Subtract two numbers");
Console.WriteLine("3.Multiply two numbers");
Console.WriteLine("4.Divide two numbers");
Console.WriteLine("5.Exit");
int option = int.Parse(Console.ReadLine());
if(option>5)
{
    Console.WriteLine($"your input {option} is invalid\n");
    goto start;
} else if(option<=0)
{
    Console.WriteLine($"your input {option} is invalid\n");
    goto start;
}
else if(option==5)
{
Environment.Exit(0);
}
else 
{

}

    Console.WriteLine("Please enter first number");
    int num1 =int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter second number");
    int num2=int.Parse(Console.ReadLine());

 static void add(int num1, int num2)
 {
    int sum=num1+num2;
    Console.WriteLine("Addition is:"+ sum);
 }
 static void subtract(int num1, int num2)
 {
    int dif=num1-num2;
    Console.WriteLine("Subtraction is:"+ dif);
 }
  static void multiple(int num1, int num2)
 {
    int mul=num1*num2;
    Console.WriteLine("Multiple is:"+ mul);
 }
 static void division(int num1, int num2)
 {
    int div=num1/num2;
    Console.WriteLine("Division is:"+ div);
    
 }
 


switch(option)

{
     case 1:
       add(num1, num2);
       break;
     case 2:
      subtract(num1, num2);
        break;
     case 3:
       multiple(num1, num2);
     break;
     case 4:
        division(num1, num2);
     break;

}

 Console.WriteLine("Do you want to continue?");
 string decision=Console.ReadLine();
 switch(decision.ToUpper())
{
    case "YES":
    goto start;
    case "NO":
    break;
}
   
}

catch(FormatException)
{
Console.WriteLine("Please enter numbers from 1-5 only");
}
catch(Exception)
{
    Console.WriteLine("Something went wrong");
}
}