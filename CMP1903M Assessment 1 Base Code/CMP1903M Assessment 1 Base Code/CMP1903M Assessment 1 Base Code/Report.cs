using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public void valueOutput(List<int> values, string input)
        {
            Console.WriteLine("number of sentances: " + values[0]);
            Console.WriteLine("number of vowels: " + values[1]);
            Console.WriteLine("number of consonants: " + values[2]);
            Console.WriteLine("number of uppercase letters: " + values[3]);
            Console.WriteLine("number of lowercase letters: " + values[4]);

            Console.WriteLine("would you like to know the frequency of a certain letter or punctuation?");
            string userinput = Console.ReadLine();
            if (userinput == "yes" || userinput == "Yes")
            {
                Frequency frequency = new Frequency();
                frequency.textfrequency(input);
            }
            else if(userinput == "no" || userinput == "No")
            {
                
            }
            else
            {
                Console.WriteLine("invalid input");
            }

            Console.WriteLine("would you like to generate a text file with the info on long words?");
            string userinput2 = Console.ReadLine();
            if (userinput2 == "yes" || userinput2 == "Yes")
            {
                Longwords longword = new Longwords();
                longword.longwords(input);
            }
            else if (userinput2 == "no" || userinput2 == "No")
            {
               
            }
            else
            {
                Console.WriteLine("invalid input");
            }

        }
    }
}
