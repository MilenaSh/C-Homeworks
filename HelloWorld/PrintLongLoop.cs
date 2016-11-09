using System;

class PrintLongLoop
{
    static void Main()
    {
        // Initialize the counter
        int counter = 2;
        // Execute the loop body while the loop condition holds
        while (counter <= 1001)
        {
            // Console.WriteLine((counter % 2 != 0 ? "-" : "") + counter);
            if (counter % 2 == 1)
            {
                Console.WriteLine("-" + counter);
            }
            else
            {
                Console.WriteLine(counter);
            }
            // Increment the counter
            counter++;
        }
    }
}

