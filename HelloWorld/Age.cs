using System;

class Age
{
    static void Main()
    {
        string birthString = Console.ReadLine();

        int year = int.Parse(birthString.Substring(6));
        int day = int.Parse(birthString.Substring(3, 2));
        int month = int.Parse(birthString.Substring(0, 2));

        int currentYear = int.Parse(DateTime.Now.Year.ToString());
        int currentMonth = 2;
        int currentDay = int.Parse(DateTime.Now.Day.ToString());

        int currentAge = currentYear - year;

        if(month > currentMonth)
        {
            currentAge--;
        }
        else if(month == currentMonth && currentDay<day)
        {
            currentAge--;
        }
        Console.WriteLine(currentAge);
        Console.WriteLine(currentAge + 10);


        Console.ReadLine();
    }
}
