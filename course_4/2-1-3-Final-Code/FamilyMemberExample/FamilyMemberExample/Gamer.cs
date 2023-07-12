using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMemberExample
{
	/// <summary>
	/// A gamer
	/// </summary>
	internal class Gamer : FamilyMember
	{
		#region Constructors

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="height">the height of the gamer</param>
		/// <param name="weight">the weight of the gamer</param>
		public Gamer(int height, int weight)
			: base(height, weight)
		{
		}

		#endregion

		#region Public methods

		/// <summary>
		/// Makes the gamer have fun
		/// </summary>
		public override void HaveFun()
		{
			Console.WriteLine("I'm playing a game!");
		}

		#endregion
	}
}

