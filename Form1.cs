using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;


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
        Mat imgMainCopy = new Mat();
        Mat blackImg = new Mat();
        Mat binaryMask = new Mat();

        int idx = 0;
        int actualX = 0;
        int actualY = 0;

        List<string> yoloText = new List<string>();
        string[] folderContents;
        string fileName = "";
        string outFilename;

        bool draw = true;
        bool IsMouseDown = false;

        OpenCvSharp.Point StartLocation;
        List<OpenCvSharp.Point[]> lastSetPoints = new List<OpenCvSharp.Point[]>();

        Pen drawingPen;
        Graphics pictureBoxGraphics;

        private void btn_browseFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderContents = Directory.GetFileSystemEntries(folderBrowserDialog1.SelectedPath, "*.jpg");
                tb_outputPath.Text = folderBrowserDialog1.SelectedPath;
                fileName = Path.GetFileName(folderContents[idx]);
                outFilename = fileName.Remove(fileName.Length - 4);

                if (File.Exists(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt"))
                {
                    tb_Status.Text = "PROCESSED";
                    tb_Status.BackColor = Color.Green;
                    tb_Status.ForeColor = Color.White;
                }
                else
                {
                    tb_Status.Text = "UNPROCESSED";
                    tb_Status.BackColor = Color.Red;
                    tb_Status.ForeColor = Color.White;
                }

                tb_filename.Text = fileName;
                imgMain = new Mat(folderContents[idx]);
                imgMain.CopyTo(imgMainCopy);
                blackImg = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
                binaryMask = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
                pb_imgDisplay.Image = imgMain.ToBitmap();
                pb_imgDisplay.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }
        
        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (idx > 0)
            {
                btn_saveFinalText.PerformClick();
                idx--;
                fileName = Path.GetFileName(folderContents[idx]);
                tb_filename.Text = fileName;
                outFilename = fileName.Remove(fileName.Length - 4);

                if (File.Exists(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt"))
                {
                    tb_Status.Text = "PROCESSED";
                    tb_Status.BackColor = Color.Green;
                    tb_Status.ForeColor = Color.White;
                }
                else
                {
                    tb_Status.Text = "UNPROCESSED";
                    tb_Status.BackColor = Color.Red;
                    tb_Status.ForeColor = Color.White;
                }

                btn_ReadAnnot.Text = "Polygon Off";
                btn_ReadAnnot.BackColor = Color.Red;
                tb_saveStatus.Clear();
                tb_saveStatus.BackColor = Color.White;
                
                imgMain = new Mat(folderContents[idx]);
                imgMain.CopyTo(imgMainCopy);
                blackImg = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
                binaryMask = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
                pb_imgDisplay.Image = imgMain.ToBitmap();
                pb_imgDisplay.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (idx < folderContents.Length - 1)
            {
                btn_saveFinalText.PerformClick();
                idx++;
                fileName = Path.GetFileName(folderContents[idx]);
                tb_filename.Text = fileName;
                outFilename = fileName.Remove(fileName.Length - 4);

                if (File.Exists(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt"))
                {
                    tb_Status.Text = "PROCESSED";
                    tb_Status.BackColor = Color.Green;
                    tb_Status.ForeColor = Color.White;
                }
                else
                {
                    tb_Status.Text = "UNPROCESSED";
                    tb_Status.BackColor = Color.Red;
                    tb_Status.ForeColor = Color.White;
                }

                btn_ReadAnnot.Text = "Polygon Off";
                btn_ReadAnnot.BackColor = Color.Red;
                tb_saveStatus.Clear();
                tb_saveStatus.BackColor = Color.White;
                
                imgMain = new Mat(folderContents[idx]);
                imgMain.CopyTo(imgMainCopy);
                blackImg = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
                binaryMask = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
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
            try
            {
                if (draw && IsMouseDown)
                {
                    OpenCvSharp.Point currentPoint = new OpenCvSharp.Point(e.X, e.Y);

                    pictureBoxGraphics.DrawLine(drawingPen, StartLocation.X, StartLocation.Y, currentPoint.X, currentPoint.Y);
                    StartLocation = currentPoint;
                    double scaleX = (double)imgMain.Width / pb_imgDisplay.Size.Width;
                    double scaleY = (double)imgMain.Height / pb_imgDisplay.Size.Height;
                    actualX = (int)(e.X * scaleX);
                    actualY = (int)(e.Y * scaleY);
                    if (rb_lowCrack.Checked)
                        Cv2.Circle(imgMain, new OpenCvSharp.Point(actualX, actualY), (int)nud_brushSize.Value, Scalar.Green, -1);
                    else if (rb_modCrack.Checked)
                        Cv2.Circle(imgMain, new OpenCvSharp.Point(actualX, actualY), (int)nud_brushSize.Value, Scalar.Yellow, -1);
                    else if (rb_highCrack.Checked)
                        Cv2.Circle(imgMain, new OpenCvSharp.Point(actualX, actualY), (int)nud_brushSize.Value, Scalar.Red, -1);

                    Cv2.Circle(blackImg, new OpenCvSharp.Point(actualX, actualY), (int)nud_brushSize.Value, Scalar.White, -1);
                    if (cb_saveMask.Checked)
                        Cv2.Circle(binaryMask, new OpenCvSharp.Point(actualX, actualY), (int)nud_brushSize.Value, Scalar.White, -1);
                    pb_imgDisplay.Image = imgMain.ToBitmap();
                    pb_imgDisplay.Invalidate();
                    GC.Collect();
                }
            }
            catch (Exception exc)
            {
                btn_saveFinalText.PerformClick();
                pb_imgDisplay.Image = imgMain.ToBitmap();
                Console.WriteLine(exc.Message);
                //MessageBox.Show(exc.Message);
            }
        }

        private void pb_imgDisplay_MouseUp(object sender, MouseEventArgs e)
        {
            if (draw && IsMouseDown)
            {
                //pb_imgDisplay.Image = imgMain.ToBitmap();
                IsMouseDown = false;
                btn_saveSingle.Enabled = true;
                btn_saveSingle.PerformClick();
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
            this.Focus();
            pictureBoxGraphics = pb_imgDisplay.CreateGraphics();
            timer1.Start();
        }

        private void checkRadioButtonStatus()
        {
            if (rb_lowCrack.Checked)
            {
                nud_brushSize.Value = 4;
                drawingPen = new Pen(Color.Green, (int)nud_brushSize.Value);
            }
            else if (rb_modCrack.Checked)
            {
                nud_brushSize.Value = 5;
                drawingPen = new Pen(Color.Yellow, (int)nud_brushSize.Value);
            }
            else if (rb_highCrack.Checked)
            {
                nud_brushSize.Value = 6;
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
            try
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
                lastSetPoints.Add(finalPoints);
                foreach (var finalPoint in finalPoints)
                {
                    int pixelX = finalPoint.X;
                    int pixelY = finalPoint.Y;
                    double finalX = (double)pixelX / imgMain.Width;
                    double finalY = (double)pixelY / imgMain.Height;

                    yoloTxtToWrite = yoloTxtToWrite + " " + finalX.ToString() + " " + finalY.ToString();
                }
                yoloText.Add(yoloTxtToWrite);
                blackImg = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
                btn_saveSingle.Enabled = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_saveFinalText_Click(object sender, EventArgs e)
        {
            try
            {
                if (yoloText.Count > 0)
                {
                    tb_saveStatus.BackColor = Color.OrangeRed;
                    tb_saveStatus.ForeColor = Color.White;
                    tb_saveStatus.Text = "Saving...";


                    if (!File.Exists(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt"))
                    {
                        using (StreamWriter writer = new StreamWriter(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt"))
                        {
                            foreach (string line in yoloText)
                            {
                                writer.WriteLine(line);
                            }
                        }
                    }
                    else
                    {
                        using (StreamWriter writer = new StreamWriter(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt", true))
                        {
                            foreach (string line in yoloText)
                            {
                                writer.WriteLine(line);
                            }
                        }
                    }
                    yoloText = new List<string>();
                    lastSetPoints = new List<OpenCvSharp.Point[]>();
                    tb_saveStatus.BackColor = Color.Green;
                    tb_saveStatus.ForeColor = Color.White;
                    tb_saveStatus.Text = "Saved!";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Focus();
            switch (e.KeyChar)
            {
                case 'a':
                    btn_previous.PerformClick();
                    break;
                case 'd':
                    btn_next.PerformClick();
                    break;
                case 'b':
                    btn_Brush.PerformClick();
                    break;
                case 'o':
                    btn_browseFolder.PerformClick();
                    break;
                case 's':
                    btn_saveFinalText.PerformClick();
                    break;
                case 'r':
                    btn_removeRecent.PerformClick();
                    break;
                case 'z':
                    rb_lowCrack.Checked = true;
                    break;
                case 'x':
                    rb_modCrack.Checked = true;
                    break;
                case 'c':
                    rb_highCrack.Checked = true;
                    break;
                case 't':
                    btn_ReadAnnot.PerformClick();
                    break;
            }
        }

        private void tb_outputPath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_outputPath.Text.Length > 5)
                {
                    btn_previous.Enabled = true;
                    btn_next.Enabled = true;
                    btn_browseFolder.Enabled = true;
                    btn_Brush.Enabled = true;
                    btn_saveFinalText.Enabled = true;
                    btn_removeRecent.Enabled = true;
                }
                else
                {
                    btn_previous.Enabled = false;
                    btn_next.Enabled = false;
                    btn_browseFolder.Enabled = false;
                    btn_Brush.Enabled = false;
                    btn_saveFinalText.Enabled = false;
                    btn_removeRecent.Enabled = false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_removeRecent_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the previous annotation?", "Warning!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    if (yoloText.Count > 0)
                    {
                        foreach (var singlePoint in lastSetPoints[yoloText.Count - 1])
                        {
                            int X = singlePoint.X;
                            int Y = singlePoint.Y;

                            Vec3b pixelValue = imgMainCopy.Get<Vec3b>(Y, X);
                            imgMain.Set(Y, X, new Vec3b(0, 0, 0));
                        }
                        yoloText.RemoveAt(yoloText.Count - 1);
                        lastSetPoints.RemoveAt(yoloText.Count - 1);
                    }
                    pb_imgDisplay.Image = imgMain.ToBitmap();
                    if (btn_ReadAnnot.Text == "Polygon On")
                    {
                        btn_ReadAnnot.PerformClick();
                        Thread.Sleep(100);
                        btn_ReadAnnot.PerformClick();
                    }
                    else if (btn_ReadAnnot.Text == "Polygon Off")
                    {
                        btn_ReadAnnot.PerformClick();
                    }
                }
                catch (Exception exc) 
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            { }
        }

        private void btn_ReadAnnot_Click(object sender, EventArgs e)
        {
            if (btn_ReadAnnot.Text == "Polygon Off")
            {
                if (File.Exists(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt"))
                {
                    btn_ReadAnnot.Text = "Polygon On";
                    btn_ReadAnnot.BackColor = Color.Green;
                    string[] lines = File.ReadAllLines(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt");
                    foreach (string line in lines)
                    {
                        string[] values = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        int classID = int.Parse(values[0]);
                        values = values.Skip(1).ToArray();
                        List<OpenCvSharp.Point> pointsList = new List<OpenCvSharp.Point>();
                        List<List<OpenCvSharp.Point>> ListOfListOfPoint = new List<List<OpenCvSharp.Point>>();

                        for (int i = 0; i < values.Length; i += 2)
                        {
                            int xVal = (int)(Convert.ToDouble(values[i]) * imgMain.Width);
                            int yVal = (int)(Convert.ToDouble(values[i + 1]) * imgMain.Height);
                            pointsList.Add(new OpenCvSharp.Point(xVal, yVal));
                        }

                        OpenCvSharp.Point[] pointsArray = pointsList.ToArray();
                        ListOfListOfPoint.Add(pointsList);
                        if (classID == 0)
                            Cv2.Polylines(imgMain, ListOfListOfPoint, true, Scalar.Green, 1);
                        else if (classID == 1)
                            Cv2.Polylines(imgMain, ListOfListOfPoint, true, Scalar.Orange, 1);
                        else if (classID == 2)
                            Cv2.Polylines(imgMain, ListOfListOfPoint, true, Scalar.Red, 1);
                    }
                    //Cv2.NamedWindow("Out", WindowMode.Normal);
                    //Cv2.ImShow("Out", imgMain);
                    pb_imgDisplay.Image = imgMain.ToBitmap();
                }                
            }
            else if (btn_ReadAnnot.Text == "Polygon On")
            {
                btn_ReadAnnot.Text = "Polygon Off";
                btn_ReadAnnot.BackColor = Color.Red;
                pb_imgDisplay.Image = imgMainCopy.ToBitmap();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btn_saveFinalText.PerformClick();
        }
    }
}
