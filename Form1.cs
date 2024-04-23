using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using static System.Net.Mime.MediaTypeNames;

namespace Brush_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            drawingPen = new Pen(Color.Green, (int)nud_brushSize.Value);
            drawingPen.StartCap = drawingPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        Mat imgMain = new Mat();
        Mat blackImg = new Mat();

        int idx = 0;
        int actualX = 0;
        int actualY = 0;

        List<string> yoloText = new List<string>();
        string[] folderContents;

        bool draw = false;
        bool IsMouseDown = false;

        OpenCvSharp.Point StartLocation;
        OpenCvSharp.Point EndLocation;

        Pen drawingPen;
        Graphics pictureBoxGraphics;

        private void btn_browseFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderContents = Directory.GetFileSystemEntries(folderBrowserDialog1.SelectedPath);
                imgMain = new Mat(folderContents[idx]);
                blackImg = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
                pb_imgDisplay.Image = imgMain.ToBitmap();
                pb_imgDisplay.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }
        
        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (idx > 0)
            {
                idx--;
                imgMain = new Mat(folderContents[idx]);
                blackImg = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
                pb_imgDisplay.Image = imgMain.ToBitmap();
                pb_imgDisplay.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (idx < folderContents.Length - 1)
            {
                idx++;
                imgMain = new Mat(folderContents[idx]);
                blackImg = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
                pb_imgDisplay.Image = imgMain.ToBitmap();
                pb_imgDisplay.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void pb_imgDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                if (IsMouseDown == false)
                    IsMouseDown = true;
                StartLocation = new OpenCvSharp.Point(e.X, e.Y);
            }
        }

        private void pb_imgDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw && IsMouseDown)
            {
                OpenCvSharp.Point currentPoint = new OpenCvSharp.Point(e.X, e.Y);
                
                pictureBoxGraphics.DrawLine(drawingPen, StartLocation.X, StartLocation.Y, currentPoint.X, currentPoint.Y);
                StartLocation = currentPoint;
                double scaleX = (double)imgMain.Width / pb_imgDisplay.Size.Width;
                double scaleY = (double)imgMain.Height / pb_imgDisplay.Size.Height;
                actualX = (int)(e.X *  scaleX);
                actualY = (int)(e.Y * scaleY);
                if (rb_lowCrack.Checked)
                    Cv2.Circle(imgMain, new OpenCvSharp.Point(actualX, actualY), (int)nud_brushSize.Value, Scalar.Green, -1);
                else if (rb_modCrack.Checked)
                    Cv2.Circle(imgMain, new OpenCvSharp.Point(actualX, actualY), (int)nud_brushSize.Value, Scalar.Yellow, -1);
                else if (rb_highCrack.Checked)
                    Cv2.Circle(imgMain, new OpenCvSharp.Point(actualX, actualY), (int)nud_brushSize.Value, Scalar.Red, -1);
                
                Cv2.Circle(blackImg, new OpenCvSharp.Point(actualX, actualY), (int)nud_brushSize.Value, Scalar.White, -1);
                Cv2.NamedWindow("Put", WindowMode.Normal);
                Cv2.ImShow("Put", blackImg);
                pb_imgDisplay.Image = imgMain.ToBitmap();
            }
        }

        private void pb_imgDisplay_MouseUp(object sender, MouseEventArgs e)
        {
            if (draw && IsMouseDown)
            {
                IsMouseDown = false;
            }
        }

        private void btn_Brush_Click(object sender, EventArgs e)
        {
            if (draw == false)
            {
                draw = true;
                btn_Brush.BackColor = Color.Green;
            }
            else
            {
                draw = false;
                btn_Brush.BackColor = Color.Red;
            }
        }

        private void nud_brushSize_ValueChanged(object sender, EventArgs e)
        {
            drawingPen.Width = (int)nud_brushSize.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxGraphics = pb_imgDisplay.CreateGraphics();
        }

        private void checkRadioButtonStatus()
        {
            if (rb_lowCrack.Checked)
            {
                nud_brushSize.Value = 3;
                drawingPen = new Pen(Color.Green, (int)nud_brushSize.Value);
            }
            else if (rb_modCrack.Checked)
            {
                nud_brushSize.Value = 4;
                drawingPen = new Pen(Color.Yellow, (int)nud_brushSize.Value);
            }
            else if (rb_highCrack.Checked)
            {
                nud_brushSize.Value = 5;
                drawingPen = new Pen(Color.Red, (int)nud_brushSize.Value);
            }
        }

        private void rb_lowCrack_CheckedChanged(object sender, EventArgs e)
        {
            checkRadioButtonStatus();
        }

        private void rb_modCrack_CheckedChanged(object sender, EventArgs e)
        {
            checkRadioButtonStatus();
        }

        private void rb_highCrack_CheckedChanged(object sender, EventArgs e)
        {
            checkRadioButtonStatus();
        }

        private void btn_saveSingle_Click(object sender, EventArgs e)
        {
            string yoloTxtToWrite = "";
            if (rb_lowCrack.Checked)
                yoloTxtToWrite = "0";
            else if (rb_modCrack.Checked)
                yoloTxtToWrite = "1";
            else if (rb_highCrack.Checked)
                yoloTxtToWrite = "2";

            Mat blackImgCopy = new Mat();
            blackImg.CopyTo(blackImgCopy);

            OpenCvSharp.Point[][] points;
            HierarchyIndex[] indices;
            Cv2.FindContours(blackImgCopy, out points, out indices, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            OpenCvSharp.Point[] finalPoints = points[0];
            foreach (var finalPoint in finalPoints)
            {
                int pixelX = finalPoint.X;
                int pixelY = finalPoint.Y;
                double finalX = (double)pixelX / imgMain.Width;
                double finalY = (double)pixelY / imgMain.Height;

                yoloTxtToWrite = yoloTxtToWrite + " " + finalX.ToString() + " " + finalY.ToString();
            }
            yoloText.Add(yoloTxtToWrite);
            //Mat result = new Mat(blackImg.Size(), MatType.CV_8UC3, Scalar.All(0));
            //for (int i = 0; i < points.Length; i++)
            //{
            //    Cv2.DrawContours(result, points, i, Scalar.RandomColor(), thickness: 1);
            //}
            //Cv2.ImShow("Outt", result);

            blackImg = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
        }

        private void btn_saveFinalText_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("testOut.txt"))
            {
                foreach (string line in yoloText)
                {
                    writer.WriteLine(line);
                }
            }
            yoloText = new List<string>();
        }
    }
}
