using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment4
{
    /// <summary>
    /// Converts words to digits
    /// </summary>
    public class Digitizer
    {
        #region Fields

        // declare your Dictionary field and create the Dictionary object for it here
        Dictionary<string, int> dict = new Dictionary<string, int>() ;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Digitizer()
        {
            // populate your dictionary field here
            dict.Add("zero", 0);
            dict.Add("one",  1);
            dict.Add("two",  2);
            dict.Add("three",3);
            dict.Add("four", 4);
            dict.Add("five", 5);
            dict.Add("six",  6);
            dict.Add("seven",7);
            dict.Add("eight",8);
            dict.Add("nine", 9);

        }

        #endregion

        #region Public methods   

        /// <summary>
        /// Converts the given word to the corresponding digit.
        /// If the word isn't a valid digit name, returns -1
        /// </summary>
        /// <param name="word">word to convert</param>
        /// <returns>corresponding digit or -1</returns>
        public int ConvertWordToDigit(string word)
        {
            string low = word.ToLower();

            //Console.WriteLine(dict[low]);
            if(dict.ContainsKey(low)) 
            {
                return dict[low];
            }
            else
            {
                return -1;
            }

            //return dict[low];
        }

        #endregion
    }
}
