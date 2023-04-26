using System;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour_hand, min_hand;
            double hour_angle, min_angle, angle_diff;

            Console.WriteLine("Please provide me the time. I will give you the lesser angle of the clock.\n");

            // ask the user for the hour
            while (true)
            {
                Console.WriteLine("What is the current hour (1 - 12)?: ");
                if (!int.TryParse(Console.ReadLine(), out hour_hand) || hour_hand < 1 || hour_hand > 12)
                    Console.WriteLine("Invalid input");
                else
                    break;
            }

            // ask the user for the minute
            while (true)
            {
                Console.WriteLine("What is the current minute?: ");
                if (!int.TryParse(Console.ReadLine(), out min_hand) || min_hand < 0 || hour_hand > 59)
                    Console.WriteLine("Invalid input");
                else
                    break;
            }

            /// since a circle has 360 degrees in total
            /// and we have numbers 1 - 12 in an analog clock,
            /// we can say that we have 12 equal sections in the circle with
            /// equal angles that will be computed by dividing 360 with 12
            /// 360 / 12 = 30 degrees, so the angle a number
            /// to its adjacent number is 30 degrees
            /// now we are going to use this to formulate
            /// 
            ///lets use 10:30 for example
            ///
            ///to find for the angle of the hour hand
            ///we will first multiply it by 30 then add minute divided by 60 multiplied to 30
            ///we multiply to 30 to get the angle it traveled from 12 (starting point) to the hour
            ///since we have 30 minutes past 10, the hour hand traveled from 10 to 11
            ///we will compute for the angle it traveled by dividing the minute by 60
            ///we use 60 since we have the proportion of 12:60 as hours:minutes
            ///we then again multiply to 30
            ///

            hour_angle = hour_hand * 30 + (min_hand / 60.0) * 30;

            /// now we calculate for the angle the minute hand has traveled
            /// for this one, we simply multiply by 6
            /// this is because we have a total of 60 minutes : 1 hour
            /// since we have 360 degrees total in a circle, we have 360 : 60 ratio for the minute hand
            /// simplying we get, 6:1

            min_angle = min_hand * 6;

            /// now we will compute for the differences of the angle and find the minimum
            /// 

            angle_diff = Math.Abs(hour_angle - min_angle);

            Console.WriteLine(Math.Min(angle_diff, 360 - angle_diff));
        }
    }
}
