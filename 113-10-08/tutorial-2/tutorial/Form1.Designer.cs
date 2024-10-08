namespace tutorial
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
            ptxback = new PictureBox();
            ptxfront = new PictureBox();
            顯示背面 = new Button();
            顯示正面 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxfront).BeginInit();
            SuspendLayout();
            // 
            // ptxback
            // 
            ptxback.Image = Properties.Resources.Backface_Blue;
            ptxback.Location = new Point(80, 72);
            ptxback.Name = "ptxback";
            ptxback.Size = new Size(146, 222);
            ptxback.SizeMode = PictureBoxSizeMode.Zoom;
            ptxback.TabIndex = 0;
            ptxback.TabStop = false;
            ptxback.Visible = false;
            // 
            // ptxfront
            // 
            ptxfront.Image = Properties.Resources.Ace_Spades;
            ptxfront.Location = new Point(245, 72);
            ptxfront.Name = "ptxfront";
            ptxfront.Size = new Size(146, 222);
            ptxfront.SizeMode = PictureBoxSizeMode.Zoom;
            ptxfront.TabIndex = 1;
            ptxfront.TabStop = false;
            ptxfront.Visible = false;
            // 
            // 顯示背面
            // 
            顯示背面.Location = new Point(130, 300);
            顯示背面.Name = "顯示背面";
            顯示背面.Size = new Size(96, 48);
            顯示背面.TabIndex = 2;
            顯示背面.Text = "背面";
            顯示背面.UseVisualStyleBackColor = true;
            顯示背面.Click += 顯示背面_Click;
            // 
            // 顯示正面
            // 
            顯示正面.Location = new Point(245, 300);
            顯示正面.Name = "顯示正面";
            顯示正面.Size = new Size(96, 48);
            顯示正面.TabIndex = 3;
            顯示正面.Text = "正面";
            顯示正面.UseVisualStyleBackColor = true;
            顯示正面.Click += 顯示正面_Click;
            // 
            // button1
            // 
            button1.Location = new Point(155, 363);
            button1.Name = "button1";
            button1.Size = new Size(160, 61);
            button1.TabIndex = 4;
            button1.Text = "離開";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(顯示正面);
            Controls.Add(顯示背面);
            Controls.Add(ptxfront);
            Controls.Add(ptxback);
            Name = "Form1";
            Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)ptxback).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxfront).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxback;
        private PictureBox ptxfront;
        private Button 顯示背面;
        private Button 顯示正面;
        private Button button1;
    }
}
