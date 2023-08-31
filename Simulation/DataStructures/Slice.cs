using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.DataStructures
{
    public struct Slice
    {
        public float Xlower { get; }
        public float Ylower { get; }
        public float XUpper { get; }
        public float YUpper { get; }

        public float Area => (XUpper - Xlower) * (YUpper - Ylower);
        public Slice(float xlower, float ylower, float xUpper, float yUpper)
        {
            Xlower = xlower;
            Ylower = ylower;
            XUpper = xUpper;
            YUpper = yUpper;
        }

      

    }
}
