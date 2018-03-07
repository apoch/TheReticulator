using System;
using System.Drawing;

namespace Reticulator
{
    class SplineRenderer : IDisposable
    {

        Pen SplinePen = Pens.Black;
        Pen BoundingPolyPen = Pens.LightGreen;
        Pen TangentPen = Pens.Blue;
        Pen AccelVecPen;
        Pen NormalPen;

        Brush ControlPointBrush = Brushes.Red;
        Brush SamplePointBrush = Brushes.Green;

        public bool OptionDrawAcceleration = true;
        public bool OptionDrawBoundingPoly = true;
        public bool OptionDrawControlPoint1 = true;
        public bool OptionDrawControlPoint2 = true;
        public bool OptionDrawEntryPoint = true;
        public bool OptionDrawExitPoint = true;
        public bool OptionDrawNormal = true;
        public bool OptionDrawSamplePoint = true;
        public bool OptionDrawSpline = true;
        public bool OptionDrawTangent = true;


        public SplineRenderer()
        {
            AccelVecPen = new Pen(Color.Red)
            {
                EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor
            };

            NormalPen = new Pen(Color.LightGreen)
            {
                EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor
            };
        }


        public void Dispose()
        {
            AccelVecPen.Dispose();
            AccelVecPen = null;
        }


        public void Render(Graphics g, BezierSpline spline, float t)
        {
            // The basics: spline, control points, bounding polygon
            if (OptionDrawSpline)
                g.DrawBezier(SplinePen, spline.EntryPoint, spline.Control1, spline.Control2, spline.ExitPoint);

            if (OptionDrawEntryPoint)
                DrawPoint(g, spline.EntryPoint);

            if (OptionDrawControlPoint1)
                DrawPoint(g, spline.Control1);

            if (OptionDrawControlPoint2)
                DrawPoint(g, spline.Control2);

            if (OptionDrawExitPoint)
                DrawPoint(g, spline.ExitPoint);

            if (OptionDrawBoundingPoly)
            {
                g.DrawLine(BoundingPolyPen, spline.EntryPoint, spline.Control1);
                g.DrawLine(BoundingPolyPen, spline.Control1, spline.Control2);
                g.DrawLine(BoundingPolyPen, spline.Control2, spline.ExitPoint);
                g.DrawLine(BoundingPolyPen, spline.EntryPoint, spline.ExitPoint);
            }


            // Sample point
            PointF sample = spline.EvalBezier(t);
            if (OptionDrawSamplePoint)
            {
                g.FillEllipse(SamplePointBrush, sample.X - 2, sample.Y - 2, 4, 4);
            }


            // Tangent line
            if (OptionDrawTangent)
            {
                PointF diff = spline.EvalBezierDiff(t);
                if (diff.X == 0.0f)
                {
                    g.DrawLine(TangentPen, sample.X, 0, sample.X, g.ClipBounds.Height);
                }
                else
                {
                    float slope = diff.Y / diff.X;
                    float offset = sample.Y - (slope * sample.X);

                    g.DrawLine(TangentPen, 0, offset, g.ClipBounds.Width, ((float)g.ClipBounds.Width * slope) + offset);
                }
            }


            // Normal vector
            if (OptionDrawNormal)
            {
                PointF rawdiff = spline.EvalBezierDiff(t);
                PointF diff = new PointF(-rawdiff.Y, rawdiff.X);

                float length = (float)Math.Sqrt(diff.X * diff.X + diff.Y * diff.Y);
                diff.X /= length;
                diff.Y /= length;

                diff.X *= 20.0f;
                diff.Y *= 20.0f;

                g.DrawLine(NormalPen, sample.X, sample.Y, sample.X - diff.X, sample.Y - diff.Y);
            }


            // Acceleration vector
            if (OptionDrawAcceleration)
            {
                PointF diff2 = spline.EvalBezierSecondDiff(t);

                float length = (float)Math.Sqrt(diff2.X * diff2.X + diff2.Y * diff2.Y);
                diff2.X /= length;
                diff2.Y /= length;

                diff2.X *= 20.0f;
                diff2.Y *= 20.0f;

                g.DrawLine(AccelVecPen, sample.X, sample.Y, sample.X + diff2.X, sample.Y + diff2.Y);
            }
        }

        private void DrawPoint(Graphics g, PointF p)
        {
            g.FillEllipse(ControlPointBrush, p.X - 2, p.Y - 2, 4, 4);
        }

    }
}
