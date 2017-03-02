using System;
using System.Linq;

public class EnduranceRally
{
    public static void Main()
    {
        string[] participantInfo = Console.ReadLine()
                                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double[] zonesInfo = Console.ReadLine().Split(' ')
                                        .Select(double.Parse)
                                        .ToArray();
        double[] checkpointIndex = Console.ReadLine()
                                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(double.Parse)
                                        .ToArray();

        for (int i = 0; i < participantInfo.Length; i++)
        {
            string currentParticipant = participantInfo[i];
            double fuel = (double)(currentParticipant[0]);
            bool isFinished = true;

            for (int j = 0; j < zonesInfo.Length; j++)
            {
                bool isCheckpoint = false;

                for (int k = 0; k < checkpointIndex.Length; k++)
                {
                    if (checkpointIndex[k] == j)
                    {
                        isCheckpoint = true;
                        break;
                    }
                }

                if (isCheckpoint)
                {
                    fuel += zonesInfo[j];
                }
                else
                {
                    fuel -= zonesInfo[j];
                }      
                
                if (fuel <= 0)
                {
                    Console.WriteLine($"{currentParticipant} - reached {j}");
                    isFinished = false;
                    break;
                }          
            }

            if (isFinished)
            {
                Console.WriteLine($"{currentParticipant} - fuel left {fuel:f2}");
            }
        }
    }
}
