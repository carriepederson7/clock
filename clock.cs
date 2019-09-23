using System;

class Clock
{
  static decimal TimeToDegrees(int hours, int minutes)
  {
    decimal hourDegrees = (((hour * 60) + minutes) / 720) *360;
    Console.WriteLine(hourDegrees);
    return hourDegrees

  }




  static void Main()
  {
  Console.WriteLine("What is the hour?");
  string stringHour = Console.ReadLine();
  int hour = int.Parse(stringHour);

  Console.WriteLine("What are the mintues?");
  string stringMinutes = Console.ReadLine();
  int minutes = int.Parse(stringMinutes);


  int minuteDegrees = (minutes * 6);




  }

}
