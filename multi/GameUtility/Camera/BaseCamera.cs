using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi.GameUtility.Camera
{
    class BaseCamera: ICamera
    {
        public Vector3 Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public void SetUpCamera()
        {

        }
    }
}
