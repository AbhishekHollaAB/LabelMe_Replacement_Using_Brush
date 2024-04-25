namespace Brush_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rb_lowCrack = new System.Windows.Forms.RadioButton();
            this.rb_modCrack = new System.Windows.Forms.RadioButton();
            this.rb_highCrack = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_browseFolder = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.pb_imgDisplay = new System.Windows.Forms.PictureBox();
            this.btn_Brush = new System.Windows.Forms.Button();
            this.nud_brushSize = new System.Windows.Forms.NumericUpDown();
            this.btn_saveSingle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_saveFinalText = new System.Windows.Forms.Button();
            this.tb_saveStatus = new System.Windows.Forms.TextBox();
            this.tb_filename = new System.Windows.Forms.TextBox();
            this.tb_outputPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_removeRecent = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_Status = new System.Windows.Forms.TextBox();
            this.btn_ReadAnnot = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cb_saveMask = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imgDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_brushSize)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_lowCrack
            // 
            this.rb_lowCrack.AutoSize = true;
            this.rb_lowCrack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_lowCrack.Location = new System.Drawing.Point(1108, 299);
            this.rb_lowCrack.Name = "rb_lowCrack";
            this.rb_lowCrack.Size = new System.Drawing.Size(101, 23);
            this.rb_lowCrack.TabIndex = 1;
            this.rb_lowCrack.TabStop = true;
            this.rb_lowCrack.Text = "Low Crack ";
            this.rb_lowCrack.UseVisualStyleBackColor = true;
            this.rb_lowCrack.CheckedChanged += new System.EventHandler(this.rb_lowCrack_CheckedChanged);
            // 
            // rb_modCrack
            // 
            this.rb_modCrack.AutoSize = true;
            this.rb_modCrack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_modCrack.Location = new System.Drawing.Point(1108, 331);
            this.rb_modCrack.Name = "rb_modCrack";
            this.rb_modCrack.Size = new System.Drawing.Size(129, 23);
            this.rb_modCrack.TabIndex = 2;
            this.rb_modCrack.TabStop = true;
            this.rb_modCrack.Text = "Moderate Crack";
            this.rb_modCrack.UseVisualStyleBackColor = true;
            this.rb_modCrack.CheckedChanged += new System.EventHandler(this.rb_modCrack_CheckedChanged);
            // 
            // rb_highCrack
            // 
            this.rb_highCrack.AutoSize = true;
            this.rb_highCrack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_highCrack.Location = new System.Drawing.Point(1108, 360);
            this.rb_highCrack.Name = "rb_highCrack";
            this.rb_highCrack.Size = new System.Drawing.Size(97, 23);
            this.rb_highCrack.TabIndex = 3;
            this.rb_highCrack.TabStop = true;
            this.rb_highCrack.Text = "High Crack";
            this.rb_highCrack.UseVisualStyleBackColor = true;
            this.rb_highCrack.CheckedChanged += new System.EventHandler(this.rb_highCrack_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brush Annotation To YOLO ";
            // 
            // btn_browseFolder
            // 
            this.btn_browseFolder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browseFolder.Location = new System.Drawing.Point(1108, 132);
            this.btn_browseFolder.Name = "btn_browseFolder";
            this.btn_browseFolder.Size = new System.Drawing.Size(120, 75);
            this.btn_browseFolder.TabIndex = 6;
            this.btn_browseFolder.Text = "Browse Folder";
            this.btn_browseFolder.UseVisualStyleBackColor = true;
            this.btn_browseFolder.Click += new System.EventHandler(this.btn_browseFolder_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Enabled = false;
            this.btn_previous.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.Location = new System.Drawing.Point(1075, 132);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(33, 75);
            this.btn_previous.TabIndex = 7;
            this.btn_previous.Text = "<";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Enabled = false;
            this.btn_next.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(1228, 132);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(36, 75);
            this.btn_next.TabIndex = 12;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // pb_imgDisplay
            // 
            this.pb_imgDisplay.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pb_imgDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_imgDisplay.Location = new System.Drawing.Point(3, 0);
            this.pb_imgDisplay.Name = "pb_imgDisplay";
            this.pb_imgDisplay.Size = new System.Drawing.Size(1020, 820);
            this.pb_imgDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_imgDisplay.TabIndex = 13;
            this.pb_imgDisplay.TabStop = false;
            this.pb_imgDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_imgDisplay_MouseDown);
            this.pb_imgDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_imgDisplay_MouseMove);
            this.pb_imgDisplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_imgDisplay_MouseUp);
            // 
            // btn_Brush
            // 
            this.btn_Brush.BackColor = System.Drawing.Color.Green;
            this.btn_Brush.Enabled = false;
            this.btn_Brush.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Brush.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Brush.Location = new System.Drawing.Point(1075, 403);
            this.btn_Brush.Name = "btn_Brush";
            this.btn_Brush.Size = new System.Drawing.Size(114, 78);
            this.btn_Brush.TabIndex = 14;
            this.btn_Brush.Text = "Brush";
            this.btn_Brush.UseVisualStyleBackColor = false;
            this.btn_Brush.Click += new System.EventHandler(this.btn_Brush_Click);
            // 
            // nud_brushSize
            // 
            this.nud_brushSize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_brushSize.Location = new System.Drawing.Point(1191, 431);
            this.nud_brushSize.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nud_brushSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_brushSize.Name = "nud_brushSize";
            this.nud_brushSize.Size = new System.Drawing.Size(81, 26);
            this.nud_brushSize.TabIndex = 15;
            this.nud_brushSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_brushSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nud_brushSize.ValueChanged += new System.EventHandler(this.nud_brushSize_ValueChanged);
            // 
            // btn_saveSingle
            // 
            this.btn_saveSingle.Enabled = false;
            this.btn_saveSingle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveSingle.Location = new System.Drawing.Point(1074, 626);
            this.btn_saveSingle.Name = "btn_saveSingle";
            this.btn_saveSingle.Size = new System.Drawing.Size(98, 78);
            this.btn_saveSingle.TabIndex = 16;
            this.btn_saveSingle.Text = "Save Single";
            this.btn_saveSingle.UseVisualStyleBackColor = true;
            this.btn_saveSingle.Click += new System.EventHandler(this.btn_saveSingle_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pb_imgDisplay);
            this.panel1.Location = new System.Drawing.Point(42, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 820);
            this.panel1.TabIndex = 17;
            // 
            // btn_saveFinalText
            // 
            this.btn_saveFinalText.Enabled = false;
            this.btn_saveFinalText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveFinalText.Location = new System.Drawing.Point(1176, 626);
            this.btn_saveFinalText.Name = "btn_saveFinalText";
            this.btn_saveFinalText.Size = new System.Drawing.Size(96, 78);
            this.btn_saveFinalText.TabIndex = 18;
            this.btn_saveFinalText.Text = "Save Final Text";
            this.btn_saveFinalText.UseVisualStyleBackColor = true;
            this.btn_saveFinalText.Click += new System.EventHandler(this.btn_saveFinalText_Click);
            // 
            // tb_saveStatus
            // 
            this.tb_saveStatus.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_saveStatus.Location = new System.Drawing.Point(1077, 710);
            this.tb_saveStatus.Name = "tb_saveStatus";
            this.tb_saveStatus.ReadOnly = true;
            this.tb_saveStatus.Size = new System.Drawing.Size(195, 32);
            this.tb_saveStatus.TabIndex = 19;
            this.tb_saveStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_filename
            // 
            this.tb_filename.BackColor = System.Drawing.Color.Yellow;
            this.tb_filename.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_filename.Location = new System.Drawing.Point(42, 52);
            this.tb_filename.Name = "tb_filename";
            this.tb_filename.ReadOnly = true;
            this.tb_filename.Size = new System.Drawing.Size(216, 26);
            this.tb_filename.TabIndex = 20;
            this.tb_filename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_outputPath
            // 
            this.tb_outputPath.BackColor = System.Drawing.Color.Yellow;
            this.tb_outputPath.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_outputPath.Location = new System.Drawing.Point(1087, 213);
            this.tb_outputPath.Name = "tb_outputPath";
            this.tb_outputPath.ReadOnly = true;
            this.tb_outputPath.Size = new System.Drawing.Size(177, 22);
            this.tb_outputPath.TabIndex = 23;
            this.tb_outputPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_outputPath.TextChanged += new System.EventHandler(this.tb_outputPath_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1074, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1251, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "d";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1215, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1237, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1211, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "c";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1114, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "b";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1251, 689);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "s";
            // 
            // btn_removeRecent
            // 
            this.btn_removeRecent.Enabled = false;
            this.btn_removeRecent.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeRecent.Location = new System.Drawing.Point(1097, 514);
            this.btn_removeRecent.Name = "btn_removeRecent";
            this.btn_removeRecent.Size = new System.Drawing.Size(171, 45);
            this.btn_removeRecent.TabIndex = 36;
            this.btn_removeRecent.Text = "Remove Recent";
            this.btn_removeRecent.UseVisualStyleBackColor = true;
            this.btn_removeRecent.Click += new System.EventHandler(this.btn_removeRecent_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1139, 544);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 15);
            this.label12.TabIndex = 37;
            this.label12.Text = "r";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.IndianRed;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(1132, 575);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(107, 45);
            this.textBox1.TabIndex = 38;
            this.textBox1.Text = "DO NOT CLICK THIS TWICE IN A ROW";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Status
            // 
            this.tb_Status.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Status.Location = new System.Drawing.Point(839, 3);
            this.tb_Status.Multiline = true;
            this.tb_Status.Name = "tb_Status";
            this.tb_Status.Size = new System.Drawing.Size(411, 73);
            this.tb_Status.TabIndex = 39;
            this.tb_Status.Text = "STATUS";
            this.tb_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ReadAnnot
            // 
            this.btn_ReadAnnot.BackColor = System.Drawing.Color.IndianRed;
            this.btn_ReadAnnot.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReadAnnot.Location = new System.Drawing.Point(1108, 241);
            this.btn_ReadAnnot.Name = "btn_ReadAnnot";
            this.btn_ReadAnnot.Size = new System.Drawing.Size(120, 47);
            this.btn_ReadAnnot.TabIndex = 40;
            this.btn_ReadAnnot.Text = "Polygon Off";
            this.btn_ReadAnnot.UseVisualStyleBackColor = false;
            this.btn_ReadAnnot.Click += new System.EventHandler(this.btn_ReadAnnot_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1163, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "o";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1215, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "t";
            // 
            // timer1
            // 
            this.timer1.Interval = 120000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cb_saveMask
            // 
            this.cb_saveMask.AutoSize = true;
            this.cb_saveMask.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_saveMask.Location = new System.Drawing.Point(1115, 788);
            this.cb_saveMask.Name = "cb_saveMask";
            this.cb_saveMask.Size = new System.Drawing.Size(147, 21);
            this.cb_saveMask.TabIndex = 43;
            this.cb_saveMask.Text = "Save Binary Mask";
            this.cb_saveMask.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 923);
            this.Controls.Add(this.cb_saveMask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ReadAnnot);
            this.Controls.Add(this.tb_Status);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_removeRecent);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_outputPath);
            this.Controls.Add(this.tb_filename);
            this.Controls.Add(this.tb_saveStatus);
            this.Controls.Add(this.btn_saveFinalText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_saveSingle);
            this.Controls.Add(this.nud_brushSize);
            this.Controls.Add(this.btn_Brush);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_browseFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_highCrack);
            this.Controls.Add(this.rb_modCrack);
            this.Controls.Add(this.rb_lowCrack);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brush to YOLO Converter - v2.6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imgDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_brushSize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rb_lowCrack;
        private System.Windows.Forms.RadioButton rb_modCrack;
        private System.Windows.Forms.RadioButton rb_highCrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_browseFolder;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.PictureBox pb_imgDisplay;
        private System.Windows.Forms.Button btn_Brush;
        private System.Windows.Forms.NumericUpDown nud_brushSize;
        private System.Windows.Forms.Button btn_saveSingle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_saveFinalText;
        private System.Windows.Forms.TextBox tb_saveStatus;
        private System.Windows.Forms.TextBox tb_filename;
        private System.Windows.Forms.TextBox tb_outputPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_removeRecent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_Status;
        private System.Windows.Forms.Button btn_ReadAnnot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cb_saveMask;
    }
}

