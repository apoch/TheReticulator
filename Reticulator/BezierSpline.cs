using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Reticulator.Utility;

namespace Reticulator
{
    class BezierSpline
    {
        // Spline control points
        public PointF EntryPoint;
        public PointF ExitPoint;
        public PointF Control1;
        public PointF Control2;


        #region Bezier spline computation helpers

        public PointF EvalBezier(float t)
        {
            float invt = 1.0f - t;

            float term1x = (invt * invt * invt) * EntryPoint.X;
            float term1y = (invt * invt * invt) * EntryPoint.Y;

            float term2x = (invt * invt) * Control1.X * 3.0f * t;
            float term2y = (invt * invt) * Control1.Y * 3.0f * t;

            float term3x = (invt) * Control2.X * 3.0f * (t * t);
            float term3y = (invt) * Control2.Y * 3.0f * (t * t);

            float term4x = (t * t * t) * ExitPoint.X;
            float term4y = (t * t * t) * ExitPoint.Y;

            return new PointF(term1x + term2x + term3x + term4x, term1y + term2y + term3y + term4y);

        }

        public PointF EvalBezierDiff(float t)
        {
            float invt = 1.0f - t;

            float term1x = 3.0f * (invt * invt) * (Control1.X - EntryPoint.X);
            float term1y = 3.0f * (invt * invt) * (Control1.Y - EntryPoint.Y);

            float term2x = 6.0f * (invt) * (Control2.X - Control1.X) * t;
            float term2y = 6.0f * (invt) * (Control2.Y - Control1.Y) * t;

            float term3x = 3.0f * (ExitPoint.X - Control2.X) * (t * t);
            float term3y = 3.0f * (ExitPoint.Y - Control2.Y) * (t * t);

            return new PointF(term1x + term2x + term3x, term1y + term2y + term3y);
        }

        public PointF EvalBezierSecondDiff(float t)
        {
            float invt = 1.0f - t;

            float term1x = 6.0f * invt * (Control2.X - 2.0f * Control1.X + EntryPoint.X);
            float term1y = 6.0f * invt * (Control2.Y - 2.0f * Control1.Y + EntryPoint.Y);

            float term2x = 6.0f * t * (ExitPoint.X - 2.0f * Control2.X + Control1.X);
            float term2y = 6.0f * t * (ExitPoint.Y - 2.0f * Control2.Y + Control1.Y);

            return new PointF(term1x + term2x, term1y + term2y);
        }

        #endregion



        #region Arclength estimation routines

        public float EstimateArcLength_Numerical()
        {
            PointF a, b;

            const float delta = 0.01f;
            float t = delta;
            float arclen = 0;

            a = EntryPoint;

            do
            {
                b = EvalBezier(t);
                arclen += Distance(a, b);

                a = b;
                t += delta;

            } while (t < 1.0f);

            arclen += Distance(b, ExitPoint);

            return arclen;
        }

        public float EstimateArcLength_BoundPoly()
        {
            float nx = Distance(EntryPoint, ExitPoint);
            float nc1 = Distance(EntryPoint, Control1);
            float c1c2 = Distance(Control1, Control2);
            float c2x = Distance(Control2, ExitPoint);

            return ((nx + nc1 + c1c2 + c2x) / 2.0f);
        }

        public float EstimateArcLength_WeightedBoundPoly()
        {
            float nx = Distance(EntryPoint, ExitPoint);
            float nc1 = Distance(EntryPoint, Control1);
            float c1c2 = 0.9f * Distance(Control1, Control2);
            float c2x = Distance(Control2, ExitPoint);

            return ((nx + nc1 + c1c2 + c2x) / 2.0f);
        }

        #endregion


    }
}
