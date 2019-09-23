using System;

class Clock
{
  static decimal TimeToDegrees(decimal hours, decimal minutes)
  {
    return (((hours * 60) + minutes) / 720) *360;
    // Console.WriteLine(hourDegrees);
    // return hourDegrees;

  }

  static decimal CalculateAngle(decimal degreeHours, decimal degreeMinutes)
  {
    if(degreeHours>degreeMinutes)
    {
      decimal angle = degreeHours - degreeMinutes;
      if (angle>180)
      {
        angle = 360 - angle;
      }
      return angle;
    }
    else
    {
      decimal angle= degreeMinutes - degreeHours;
      if (angle>180)
      {
        angle = 360 - angle;
      }
      return angle;
    }

  }




  static void Main()
  {
  Console.WriteLine("What is the hour?");
  string stringHour = Console.ReadLine();
  decimal hour = Convert.ToDecimal(stringHour);

  Console.WriteLine("What are the mintues?");
  string stringMinutes = Console.ReadLine();
  decimal minutes = Convert.ToDecimal(stringMinutes);


  decimal minuteDegrees = (minutes * 6);
  decimal hourDegrees = TimeToDegrees(hour, minutes);
  decimal finalDegree = CalculateAngle(hourDegrees, minuteDegrees);
  Console.Write("The angle between the hour and minute hand is " + finalDegree);


  }

}
