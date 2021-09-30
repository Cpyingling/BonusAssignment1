/* Author Charlie Yingling              Date 9/30/21
Write a C# Sharp program to check whether a triangle(exist) is Equilateral, Isosceles or Scalene
*/
using System;

class Program {
  public static void Main (string[] args) {

//get lenth of 3 sides    
Console.WriteLine("Enter the Length of Side A:");
int sidea = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Length of Side B:");
int sideb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Length of Side C:");
int sidec = Convert.ToInt32(Console.ReadLine());

    //Determine if this is indeed a triangle
    if(sidea+sideb > sidec && sideb+sidec > sidea && sidea+sidec > sideb) {   
        Console.WriteLine("Triangle can be formed.");  
    } else {  
        Console.WriteLine("Triangle cannot be formed.");
        return;
    }
    //Determine the type of triangle
    if(sidea==sideb && sideb==sidec) {  
        Console.WriteLine("The triangle is Equilateral.");  
    } else if(sidea==sideb || sidea==sidec || sideb==sidec) {  
        Console.WriteLine("The triangle is Isoceles.");  
    } else {  
        Console.WriteLine("The triangle is Scalene.");  
    }  
  }
}