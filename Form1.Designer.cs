namespace ColorMixerApp_2023_autumn
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
            this.redBox = new System.Windows.Forms.PictureBox();
            this.greenBox = new System.Windows.Forms.PictureBox();
            this.blueBox = new System.Windows.Forms.PictureBox();
            this.numericRed = new System.Windows.Forms.NumericUpDown();
            this.numericGreen = new System.Windows.Forms.NumericUpDown();
            this.numericBlue = new System.Windows.Forms.NumericUpDown();
            this.sliderRed = new System.Windows.Forms.TrackBar();
            this.sliderGreen = new System.Windows.Forms.TrackBar();
            this.sliderBlue = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // redBox
            // 
            this.redBox.Location = new System.Drawing.Point(63, 40);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(200, 200);
            this.redBox.TabIndex = 0;
            this.redBox.TabStop = false;
            // 
            // greenBox
            // 
            this.greenBox.Location = new System.Drawing.Point(331, 40);
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(200, 200);
            this.greenBox.TabIndex = 2;
            this.greenBox.TabStop = false;
            // 
            // blueBox
            // 
            this.blueBox.Location = new System.Drawing.Point(599, 40);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(200, 200);
            this.blueBox.TabIndex = 3;
            this.blueBox.TabStop = false;
            // 
            // numericRed
            // 
            this.numericRed.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericRed.Location = new System.Drawing.Point(63, 281);
            this.numericRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericRed.Name = "numericRed";
            this.numericRed.Size = new System.Drawing.Size(200, 50);
            this.numericRed.TabIndex = 4;
            this.numericRed.ValueChanged += new System.EventHandler(this.numericRed_ValueChanged);
            // 
            // numericGreen
            // 
            this.numericGreen.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericGreen.Location = new System.Drawing.Point(331, 281);
            this.numericGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericGreen.Name = "numericGreen";
            this.numericGreen.Size = new System.Drawing.Size(200, 50);
            this.numericGreen.TabIndex = 5;
            this.numericGreen.ValueChanged += new System.EventHandler(this.numericGreen_ValueChanged);
            // 
            // numericBlue
            // 
            this.numericBlue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericBlue.Location = new System.Drawing.Point(599, 281);
            this.numericBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericBlue.Name = "numericBlue";
            this.numericBlue.Size = new System.Drawing.Size(200, 50);
            this.numericBlue.TabIndex = 6;
            this.numericBlue.ValueChanged += new System.EventHandler(this.numericBlue_ValueChanged);
            // 
            // sliderRed
            // 
            this.sliderRed.Location = new System.Drawing.Point(63, 377);
            this.sliderRed.Maximum = 255;
            this.sliderRed.Name = "sliderRed";
            this.sliderRed.Size = new System.Drawing.Size(200, 45);
            this.sliderRed.TabIndex = 7;
            this.sliderRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliderRed.Scroll += new System.EventHandler(this.sliderRed_Scroll);
            // 
            // sliderGreen
            // 
            this.sliderGreen.Location = new System.Drawing.Point(322, 377);
            this.sliderGreen.Maximum = 255;
            this.sliderGreen.Name = "sliderGreen";
            this.sliderGreen.Size = new System.Drawing.Size(209, 45);
            this.sliderGreen.TabIndex = 8;
            this.sliderGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliderGreen.Scroll += new System.EventHandler(this.sliderGreen_Scroll);
            // 
            // sliderBlue
            // 
            this.sliderBlue.Location = new System.Drawing.Point(599, 377);
            this.sliderBlue.Maximum = 255;
            this.sliderBlue.Name = "sliderBlue";
            this.sliderBlue.Size = new System.Drawing.Size(200, 45);
            this.sliderBlue.TabIndex = 9;
            this.sliderBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliderBlue.Scroll += new System.EventHandler(this.sliderBlue_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 505);
            this.Controls.Add(this.sliderBlue);
            this.Controls.Add(this.sliderGreen);
            this.Controls.Add(this.sliderRed);
            this.Controls.Add(this.numericBlue);
            this.Controls.Add(this.numericGreen);
            this.Controls.Add(this.numericRed);
            this.Controls.Add(this.blueBox);
            this.Controls.Add(this.greenBox);
            this.Controls.Add(this.redBox);
            this.Name = "Form1";
            this.Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox redBox;
        private PictureBox greenBox;
        private PictureBox blueBox;
        private NumericUpDown numericRed;
        private NumericUpDown numericGreen;
        private NumericUpDown numericBlue;
        private TrackBar sliderRed;
        private TrackBar sliderGreen;
        private TrackBar sliderBlue;
    }
}