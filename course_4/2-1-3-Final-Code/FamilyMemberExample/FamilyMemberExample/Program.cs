using System;

namespace FamilyMemberExample
{
    /// <summary>
    /// Demonstrates inheritance
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates inheritance
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // construct family members
            FamilyMember familyMember = new FamilyMember(69, 185);
            FamilyMember gamer = new Gamer(70, 200);
            FamilyMember geek = new Geek(71, 165);

            // everybody has fun
            familyMember.HaveFun();
            gamer.HaveFun();
            geek.HaveFun();
        }
    }
}
