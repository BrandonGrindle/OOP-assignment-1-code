using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        public List<int> values = new List<int>();
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        //use of data abstraction and encapsulation here to hide all irrelevant to the user
        private char[] allvowel = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        private char[] allcons = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
        private char[] sentanceEnd = { '!', '.', '?' };
        private int sentances = 0;
        private int vowels = 0;
        private int consonants = 0;
        private int uppercase = 0;
        private int lowercase = 0;
        public List<int> analyseText(string input)
        {
            
            
            int index = 0;
            
            //string[] stringinput = new string[] { input };
            char[] text = input.ToCharArray();
            
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            
            
            sentanceCount(text, index, ref sentances, sentanceEnd);
            vowelandcons(text, index, ref vowels, ref consonants, allvowel, allcons);
            upperandlower(text, index, ref uppercase, ref lowercase);
                
            
               

            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }

            values[0] = sentances;
            values[1] = vowels;
            values[2] = consonants;
            values[3] = uppercase;
            values[4] = lowercase;
            Console.WriteLine(values[0]);
            return values;
        }
        // method for finding sentances(used to seperate the code and make it easier to understand)

        private static void sentanceCount(char[] input, int index,ref int sentances, char[] sentanceEnd)
        {
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    
                    if (sentanceEnd.Contains(input[i]))
                    {
                        sentances++;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("a index error has occured");
            }
            
            return;
        }
        // method for finding the vowels and consonants(used to seperate the code and make it easier to understand)
        private static void vowelandcons(char[] input, int index,ref int vowels,ref int consonants, char[] vowelcheck, char[] conscheck)
        {
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (vowelcheck.Contains(input[i]))
                    {
                        vowels++;
                    }
                    else if (conscheck.Contains(Char.ToLower(input[i])))
                    {
                        consonants++;
                    }
                    
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("a index error has occured");
            }

            return;

        }

        // method for finding the upper and lowercase(used to seperate the code and make it easier to understand)
        private static void upperandlower(char[] input, int index, ref int upper, ref int lower)
        {
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    
                    if (Char.IsUpper(input[i]))
                    {
                        upper++;
                    }
                    else if (Char.IsLower(input[i]))
                    {
                        lower++;
                    }
                    
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("a index error has occured");
            }
            

            return;
        }   
    }
}


