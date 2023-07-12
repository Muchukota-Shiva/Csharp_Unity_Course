using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMemberExample
{
	/// <summary>
	/// A geek
	/// </summary>
	internal class Geek : FamilyMember
	{
		#region Constructors

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="height">the height of the geek</param>
		/// <param name="weight">the weight of the geek</param>
		public Geek(int height, int weight)
			: base(height, weight)
		{
		}

		#endregion
	}
}
