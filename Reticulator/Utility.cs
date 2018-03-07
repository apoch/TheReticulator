using System;
using System.Drawing;

namespace Reticulator
{
    static class Utility
    {
        //
        // Linear Cartesian distance between 2 points
        //
        public static float Distance(PointF a, PointF b)
        {
            float dx = (b.X - a.X);
            float dy = (b.Y - a.Y);
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
