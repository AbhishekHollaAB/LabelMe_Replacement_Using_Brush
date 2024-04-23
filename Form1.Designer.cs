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
            ((System.ComponentModel.ISupportInitialize)(this.pb_imgDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_brushSize)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_lowCrack
            // 
            this.rb_lowCrack.AutoSize = true;
            this.rb_lowCrack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_lowCrack.Location = new System.Drawing.Point(1255, 327);
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
            this.rb_modCrack.Location = new System.Drawing.Point(1255, 359);
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
            this.rb_highCrack.Location = new System.Drawing.Point(1255, 388);
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
            this.label1.Location = new System.Drawing.Point(469, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brush Annotation To YOLO ";
            // 
            // btn_browseFolder
            // 
            this.btn_browseFolder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browseFolder.Location = new System.Drawing.Point(1255, 224);
            this.btn_browseFolder.Name = "btn_browseFolder";
            this.btn_browseFolder.Size = new System.Drawing.Size(120, 75);
            this.btn_browseFolder.TabIndex = 6;
            this.btn_browseFolder.Text = "Browse Folder";
            this.btn_browseFolder.UseVisualStyleBackColor = true;
            this.btn_browseFolder.Click += new System.EventHandler(this.btn_browseFolder_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.Location = new System.Drawing.Point(1192, 224);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(57, 75);
            this.btn_previous.TabIndex = 7;
            this.btn_previous.Text = "<";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(1381, 224);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(57, 75);
            this.btn_next.TabIndex = 12;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // pb_imgDisplay
            // 
            this.pb_imgDisplay.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pb_imgDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_imgDisplay.Location = new System.Drawing.Point(0, 0);
            this.pb_imgDisplay.Name = "pb_imgDisplay";
            this.pb_imgDisplay.Size = new System.Drawing.Size(1097, 747);
            this.pb_imgDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_imgDisplay.TabIndex = 13;
            this.pb_imgDisplay.TabStop = false;
            this.pb_imgDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_imgDisplay_MouseDown);
            this.pb_imgDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_imgDisplay_MouseMove);
            this.pb_imgDisplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_imgDisplay_MouseUp);
            // 
            // btn_Brush
            // 
            this.btn_Brush.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Brush.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Brush.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Brush.Location = new System.Drawing.Point(1209, 429);
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
            this.nud_brushSize.Location = new System.Drawing.Point(1344, 457);
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
            3,
            0,
            0,
            0});
            this.nud_brushSize.ValueChanged += new System.EventHandler(this.nud_brushSize_ValueChanged);
            // 
            // btn_saveSingle
            // 
            this.btn_saveSingle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveSingle.Location = new System.Drawing.Point(1273, 534);
            this.btn_saveSingle.Name = "btn_saveSingle";
            this.btn_saveSingle.Size = new System.Drawing.Size(114, 78);
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
            this.panel1.Size = new System.Drawing.Size(1111, 738);
            this.panel1.TabIndex = 17;
            // 
            // btn_saveFinalText
            // 
            this.btn_saveFinalText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveFinalText.Location = new System.Drawing.Point(1273, 642);
            this.btn_saveFinalText.Name = "btn_saveFinalText";
            this.btn_saveFinalText.Size = new System.Drawing.Size(114, 78);
            this.btn_saveFinalText.TabIndex = 18;
            this.btn_saveFinalText.Text = "Save Final Text";
            this.btn_saveFinalText.UseVisualStyleBackColor = true;
            this.btn_saveFinalText.Click += new System.EventHandler(this.btn_saveFinalText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 830);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

