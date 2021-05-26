using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mastermind.Resources;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CodePeg> code = new List<CodePeg>() 
            { 
                CodePeg.Blue,
                CodePeg.Yellow,
                CodePeg.Red,
                CodePeg.Green
            };

            List<CodePeg> guess = new List<CodePeg>()
            {
                CodePeg.White,
                CodePeg.Red,
                CodePeg.Yellow,
                CodePeg.Green
            };
            Resources.Mastermind mastermind = new Resources.Mastermind(code);

            
            foreach(ResultPeg x in mastermind.GetHints(guess))
                Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
