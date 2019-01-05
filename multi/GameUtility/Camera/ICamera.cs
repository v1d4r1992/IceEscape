using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi.GameUtility.Camera
{
    interface ICamera
    {
        Vector3 Position { get; set; }
        Vector3 CameraTarget { get; set; }
        Vector3 UpCamera { get; set; }

        void Update(GameTime _gametime);
    }
}
