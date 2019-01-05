using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace multi.GameUtility.Control
{
	class NormalControll : IControll
	{
		public Vector2 ClickPosition { get; set; }
		public Vector2 DestinationVector { get; set; } = Vector2.Zero;
		public int SideMultiplier { get; set; } = 0;
		public float GroundSpeed { get; set; } = 1;
	    private ButtonState _oldButtonPushed;


        public string TESTANGLE { get; set; }="";

		public void Update(GameTime time, PlayerPosition player)
		{
			var mouse = Mouse.GetState();

			if (mouse.RightButton == ButtonState.Pressed && _oldButtonPushed == ButtonState.Released)
			{

				ClickPosition = mouse.Position.ToVector2();
			    DestinationVector = (ClickPosition - player.Position);
				DestinationVector = Vector2.Normalize(DestinationVector);

				var dotProduct = Vector2.Dot(DestinationVector, player.Forward);

				if (AdditionalMath.MyMath.AngleDir(player.Forward, DestinationVector) >= 0)
				{
					SideMultiplier = -1;
				}
				else
				{
					SideMultiplier = 1;
				}
			}


			if (DestinationVector != Vector2.Zero)
			{
				var angle = (int)Math.Floor(MathHelper.ToDegrees((float)Math.Acos(Vector2.Dot(player.Forward, (Vector2)DestinationVector))));

				if (angle > 6)
				{
					DestinationVector = (ClickPosition - player.Position);
					DestinationVector = Vector2.Normalize(DestinationVector);
					player.Forward = AdditionalMath.MyMath.Rotate(player.Forward, SideMultiplier * 5);
				}
				else
				{
				    player.Forward = AdditionalMath.MyMath.Rotate(player.Forward, SideMultiplier* angle);
				    angle = (int)Math.Floor(MathHelper.ToDegrees((float)Math.Acos(Vector2.Dot(player.Forward, (Vector2)DestinationVector))));
                }
			    TESTANGLE = angle.ToString();
            }

		    _oldButtonPushed = mouse.RightButton;

		}
	}
}
