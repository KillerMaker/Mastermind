using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace Mastermind.Resources
    {
        public class Mastermind
        {
            private readonly List<CodePeg> code;

            public Mastermind(List<CodePeg> code)
            {
                this.code = code;
            }

            public List<ResultPeg> GetHints(List<CodePeg> guess)
            {
                if (guess.Equals(code))
                    return new List<ResultPeg>() { ResultPeg.Black, ResultPeg.Black, ResultPeg.Black, ResultPeg.Black };
                else
                {
                    List<ResultPeg> result = new List<ResultPeg>();

                    for (int i = 0; i < guess.Count; i++)
                    {
                        if (guess[i].Equals(code[i]))
                            result.Add(ResultPeg.Black);
                        else
                            if (code.Contains(guess[i]))
                                result.Add(ResultPeg.White);

                    }
                    return result;
                }
                
            }
        }

        public enum CodePeg
        {
            Black,
            Blue,
            Green,
            Red,
            White,
            Yellow,
        }

        public enum ResultPeg
        {
            Black,
            White,
        }
    }

