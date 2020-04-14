namespace ReflexorGUI
{
    partial class Game1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game1));
            this.button1 = new System.Windows.Forms.Button();
            this.TimerOdPritiska = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.slikaShreka = new System.Windows.Forms.PictureBox();
            this.TimerOdShreka = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.slikaShreka)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(306, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "REDI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimerOdPritiska
            // 
            this.TimerOdPritiska.Interval = 1;
            this.TimerOdPritiska.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // slikaShreka
            // 
            this.slikaShreka.Image = ((System.Drawing.Image)(resources.GetObject("slikaShreka.Image")));
            this.slikaShreka.Location = new System.Drawing.Point(206, 90);
            this.slikaShreka.Name = "slikaShreka";
            this.slikaShreka.Size = new System.Drawing.Size(362, 198);
            this.slikaShreka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slikaShreka.TabIndex = 1;
            this.slikaShreka.TabStop = false;
            // 
            // TimerOdShreka
            // 
            this.TimerOdShreka.Interval = 1;
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.slikaShreka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Game1";
            this.Text = "Igra";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slikaShreka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer TimerOdPritiska;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox slikaShreka;
        private System.Windows.Forms.Timer TimerOdShreka;
    }
}