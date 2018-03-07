using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Reticulator
{
	public partial class MainForm : Form
    {


        // Experimentation spline
        BezierSpline Spline;


        // Rendering
        SplineRenderer Render;


        // Cached values for convenience
        float SampleT = 0.5f;


        // Implementation details
        bool LockPointBoxes = false;


        public MainForm()
		{
            Spline = new BezierSpline();
            Render = new SplineRenderer();

			InitializeComponent();

			Viewport.MouseMove += this.Viewport_MouseMove;
			Viewport.Paint += this.Viewport_Paint;

			ResetControlPoints();

			SampleTPicker.Value = (int)(SampleT * 1000);
			TBox.Text = SampleT.ToString();

            FormClosing += (o, args) =>
            {
                Render.Dispose();
                Render = null;
            };
        }

     
        //
        // Render the view and update the status controls
        //
		void Viewport_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			g.Clear(Color.White);

            Render.Render(g, Spline, SampleT);

            UpdateStatusControls();
        }

        private void UpdateControlPointBoxes()
        {
            LockPointBoxes = true;

            EntryPointX.Value = (decimal)Spline.EntryPoint.X;
            EntryPointY.Value = (decimal)Spline.EntryPoint.Y;

            ControlPoint1X.Value = (decimal)Spline.Control1.X;
            ControlPoint1Y.Value = (decimal)Spline.Control1.Y;

            ControlPoint2X.Value = (decimal)Spline.Control2.X;
            ControlPoint2Y.Value = (decimal)Spline.Control2.Y;

            ExitPointX.Value = (decimal)Spline.ExitPoint.X;
            ExitPointY.Value = (decimal)Spline.ExitPoint.Y;

            LockPointBoxes = false;
        }

        private void UpdateStatusControls()
        {
            PointF sample = Spline.EvalBezier(SampleT);
            SampleXBox.Text = sample.X.ToString();
            SampleYBox.Text = sample.Y.ToString();


            PointF diff = Spline.EvalBezierDiff(SampleT);
            SampleDXBox.Text = diff.X.ToString();
            SampleDYBox.Text = diff.Y.ToString();

            DXDYRatioBox.Text = (diff.Y / diff.X).ToString();


            PointF diff2 = Spline.EvalBezierSecondDiff(SampleT);
            SampleD2XBox.Text = diff2.X.ToString();
            SampleD2YBox.Text = diff2.Y.ToString();

            D2XD2YRatioBox.Text = (diff2.Y / diff2.X).ToString();


            // Arclength estimates
            {
                float numerical = Spline.EstimateArcLength_Numerical();
                float bp = Spline.EstimateArcLength_BoundPoly();
                float wbp = Spline.EstimateArcLength_WeightedBoundPoly();

                EstArcLenNumericalBox.Text = numerical.ToString();

                EstArcLenBPBox.Text = bp.ToString();
                EstArcLenBPErrorBox.Text = (bp - numerical).ToString();

                EstArcLenWBPBox.Text = wbp.ToString();
                EstArcLenWBPErrorBox.Text = (wbp - numerical).ToString();
            }
        }

        private void ResetControlPoints()
        {
            Spline.EntryPoint = new PointF(10, 50);
            Spline.Control1 = new PointF(75, 20);
            Spline.Control2 = new PointF(200, 80);
            Spline.ExitPoint = new PointF(250, 330);

            UpdateControlPointBoxes();
        }

        private void Viewport_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            StatusLabelMouseCoordinates.Text = $"Mouse Location: ({e.X}, {e.Y})";


            if(e.Button == MouseButtons.Left)
            {
                int ClickedPoint = 0;

                PointF p = new PointF(e.X, e.Y);
                float mindist = 5e5f;

                float epdist = Utility.Distance(Spline.EntryPoint, p);
                if(epdist < mindist)
                {
                    mindist = epdist;
                    ClickedPoint = 0;
                }

                float c1dist = Utility.Distance(Spline.Control1, p);
                if(c1dist < mindist)
                {
                    mindist = c1dist;
                    ClickedPoint = 1;
                }

                float c2dist = Utility.Distance(Spline.Control2, p);
                if(c2dist < mindist)
                {
                    mindist = c2dist;
                    ClickedPoint = 2;
                }

                float exdist = Utility.Distance(Spline.ExitPoint, p);
                if(exdist < mindist)
                {
                    mindist = exdist;
                    ClickedPoint = 3;
                }

                switch(ClickedPoint)
                {
                case 0: Spline.EntryPoint = p; break;
                case 1: Spline.Control1 = p; break;
                case 2: Spline.Control2 = p; break;
                case 3: Spline.ExitPoint = p; break;
                }

                UpdateControlPointBoxes();
                Viewport.Refresh();
            }
        }

        private void SplineCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Render.OptionDrawSpline = SplineCheckbox.Checked;
            Viewport.Refresh();
        }

        private void BoundingPolyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Render.OptionDrawBoundingPoly = BoundingPolyCheckbox.Checked;
            Viewport.Refresh();
        }

        private void SamplePointCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Render.OptionDrawSamplePoint = SamplePointCheckbox.Checked;
            Viewport.Refresh();
        }

        private void TangentCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Render.OptionDrawTangent = TangentCheckbox.Checked;
            Viewport.Refresh();
        }

        private void AccelVectorCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Render.OptionDrawAcceleration = AccelVectorCheckbox.Checked;
            Viewport.Refresh();
        }

        private void SampleTPicker_Scroll(object sender, EventArgs e)
        {
            SampleT = ((float)(SampleTPicker.Value)) / 1000.0f;
            TBox.Text = SampleT.ToString();

            Viewport.Refresh();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetControlPoints();
            Viewport.Refresh();
        }

        private void EntryPointCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Render.OptionDrawEntryPoint = EntryPointCheckbox.Checked;
            Viewport.Refresh();
        }

        private void ControlPoint1Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Render.OptionDrawControlPoint1 = ControlPoint1Checkbox.Checked;
            Viewport.Refresh();
        }

        private void ControlPoint2Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Render.OptionDrawControlPoint2 = ControlPoint2Checkbox.Checked;
            Viewport.Refresh();
        }

        private void ExitPointCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Render.OptionDrawExitPoint = ExitPointCheckbox.Checked;
            Viewport.Refresh();
        }

        private void EntryPointX_ValueChanged(object sender, EventArgs e)
        {
            if (LockPointBoxes)
                return;

            Spline.EntryPoint.X = (float)EntryPointX.Value;
            Viewport.Refresh();
        }

        private void EntryPointY_ValueChanged(object sender, EventArgs e)
        {
            if (LockPointBoxes)
                return;

            Spline.EntryPoint.Y = (float)EntryPointY.Value;
            Viewport.Refresh();
        }

        private void ControlPoint1X_ValueChanged(object sender, EventArgs e)
        {
            if (LockPointBoxes)
                return;

            Spline.Control1.X = (float)ControlPoint1X.Value;
            Viewport.Refresh();
        }

        private void ControlPoint1Y_ValueChanged(object sender, EventArgs e)
        {
            if (LockPointBoxes)
                return;

            Spline.Control1.Y = (float)ControlPoint1Y.Value;
            Viewport.Refresh();
        }

        private void ControlPoint2X_ValueChanged(object sender, EventArgs e)
        {
            if (LockPointBoxes)
                return;

            Spline.Control2.X = (float)ControlPoint2X.Value;
            Viewport.Refresh();
        }

        private void ControlPoint2Y_ValueChanged(object sender, EventArgs e)
        {
            if (LockPointBoxes)
                return;

            Spline.Control2.Y = (float)ControlPoint2Y.Value;
            Viewport.Refresh();
        }

        private void ExitPointX_ValueChanged(object sender, EventArgs e)
        {
            if (LockPointBoxes)
                return;

            Spline.ExitPoint.X = (float)ExitPointX.Value;
            Viewport.Refresh();
        }

        private void ExitPointY_ValueChanged(object sender, EventArgs e)
        {
            if (LockPointBoxes)
                return;

            Spline.ExitPoint.Y = (float)ExitPointY.Value;
            Viewport.Refresh();
        }

        private void NormalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Render.OptionDrawNormal = NormalCheckBox.Checked;
            Viewport.Refresh();
        }
    }
}

