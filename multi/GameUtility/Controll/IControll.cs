using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace multi.GameUtility.Control
{
	interface IControll
	{
		Vector2 ClickPosition { get; set; }
		Vector2 DestinationVector { get; set; }
		float GroundSpeed { get; set; }
		int SideMultiplier { set; get; }
	    string TESTANGLE { set; get; }
        void Update(GameTime time, PlayerPosition player);
	}
}
