namespace GUIPicture
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            sepiaImg = new PictureBox();
            threshImg = new PictureBox();
            grayImg = new PictureBox();
            negImg = new PictureBox();
            defImg = new PictureBox();
            openFileDialog = new OpenFileDialog();
            loadButton = new Button();
            procesButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sepiaImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)threshImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grayImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)negImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)defImg).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // sepiaImg
            // 
            sepiaImg.BackColor = SystemColors.ControlText;
            sepiaImg.Location = new Point(578, 81);
            sepiaImg.Name = "sepiaImg";
            sepiaImg.Size = new Size(200, 200);
            sepiaImg.SizeMode = PictureBoxSizeMode.Zoom;
            sepiaImg.TabIndex = 1;
            sepiaImg.TabStop = false;
            // 
            // threshImg
            // 
            threshImg.BackColor = SystemColors.ControlText;
            threshImg.Location = new Point(823, 81);
            threshImg.Name = "threshImg";
            threshImg.Size = new Size(200, 200);
            threshImg.SizeMode = PictureBoxSizeMode.Zoom;
            threshImg.TabIndex = 2;
            threshImg.TabStop = false;
            // 
            // grayImg
            // 
            grayImg.BackColor = SystemColors.ControlText;
            grayImg.Location = new Point(823, 331);
            grayImg.Name = "grayImg";
            grayImg.Size = new Size(200, 200);
            grayImg.SizeMode = PictureBoxSizeMode.Zoom;
            grayImg.TabIndex = 3;
            grayImg.TabStop = false;
            // 
            // negImg
            // 
            negImg.BackColor = SystemColors.ControlText;
            negImg.Location = new Point(578, 331);
            negImg.Name = "negImg";
            negImg.Size = new Size(200, 200);
            negImg.SizeMode = PictureBoxSizeMode.Zoom;
            negImg.TabIndex = 4;
            negImg.TabStop = false;
            // 
            // defImg
            // 
            defImg.BackColor = SystemColors.ControlText;
            defImg.Location = new Point(71, 81);
            defImg.Name = "defImg";
            defImg.Size = new Size(450, 450);
            defImg.SizeMode = PictureBoxSizeMode.Zoom;
            defImg.TabIndex = 5;
            defImg.TabStop = false;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // loadButton
            // 
            loadButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            loadButton.Location = new Point(71, 558);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(450, 45);
            loadButton.TabIndex = 6;
            loadButton.Text = "LOAD";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // procesButton
            // 
            procesButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            procesButton.Location = new Point(578, 558);
            procesButton.Name = "procesButton";
            procesButton.Size = new Size(445, 45);
            procesButton.TabIndex = 7;
            procesButton.Text = "PROCESSING";
            procesButton.UseVisualStyleBackColor = true;
            procesButton.Click += procesButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1131, 709);
            Controls.Add(procesButton);
            Controls.Add(loadButton);
            Controls.Add(defImg);
            Controls.Add(negImg);
            Controls.Add(grayImg);
            Controls.Add(threshImg);
            Controls.Add(sepiaImg);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sepiaImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)threshImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)grayImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)negImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)defImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox sepiaImg;
        private PictureBox threshImg;
        private PictureBox grayImg;
        private PictureBox negImg;
        private PictureBox defImg;
        private OpenFileDialog openFileDialog;
        private Button loadButton;
        private Button procesButton;
    }
}
