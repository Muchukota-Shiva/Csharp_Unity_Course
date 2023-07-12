using System.Security.Cryptography;

namespace Exercise4
{
    /// <summary>
    /// Exercise 4 solution
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates inheritance
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // parent class message
            Kid kid = new Kid();
            kid.PrintMessage();

            // a child class message
            DisobedientKid disobedientKid = new DisobedientKid();
            disobedientKid.PrintMessage();

            // another child class message
            SharingKid sharingKid = new SharingKid();
            sharingKid.PrintMessage();

            Console.WriteLine();
        }
    }
}
