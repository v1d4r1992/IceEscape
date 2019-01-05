using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multi.GameUtility.Control;
using Microsoft.Xna.Framework;

namespace multi.GameUtility
{
	class PlayerPosition
	{
		public IControll _controll = new NormalControll();
		private float speed=8f;

		public Vector2 Position = Vector2.Zero;
		public Vector2 Forward = new Vector2(1,0);


		public PlayerPosition()
		{
			
		}

		public PlayerPosition(Vector2 startPosition)
		{
			Position = startPosition;

		}

		public void SetControllType(IControll controll)
		{
			_controll = controll;
		}

		public void Update(GameTime gameTime)
		{
			_controll.Update(gameTime,this);

			this.Position += this.Forward * speed * _controll.GroundSpeed;
		}
	}
}
