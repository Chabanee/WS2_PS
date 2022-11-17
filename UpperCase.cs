using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS1_PS
{
   public class UpperCase
    {
        private string word;
        private string words;
        public void changeToUpperCase()
        {
            Console.WriteLine("**************************WELCOME**********************");
            Console.WriteLine("Please enter a text: ");

            word = Convert.ToString(Console.ReadLine());


            if(word.Length < 1 || word.Length > 8)
            {
                Console.WriteLine("Word too long or too short, please try again.");
            }
            else
            {
                words = word.ToUpper();

                Console.WriteLine(words);
            }

        }
    }
}
