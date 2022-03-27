using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    //new class that allows for the frequency of specific letters and punctuation to be checked after all the analyse programs are ran
    public class Frequency
    {
        // method for finding the frequency of leters and punctuation(used to seperate the code and make it easier to understand)
        // using data abstraction and encapsulation, the private values are hidden as they are not required outside the class
        private int totalfrequency = 0;
        public void textfrequency(string input)
        {
            Console.WriteLine("please input a letter or piece of punctuation you would like to check: ");
            string freqcheck = Console.ReadLine();
            for(int i = 0; i < input.Length; i++)
            {
                if (freqcheck.Contains(input[i]))
                {
                    totalfrequency++;
                }
                else
                {

                }
            }
            Console.WriteLine("a appears " + totalfrequency + " times!");
            return;

        }
    }
}
