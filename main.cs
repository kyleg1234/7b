using System;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine(Power(10, 3));
    
  }
 //assuming numbers are positive, this will give the exponent
  public static int Power(int baseNumber, int pow)
  {
      int total = 1;

      for(int i = 0; i < pow; i++)
      {
          total = total * baseNumber;
      }

      return total;
  }
}
