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
            this.Metronom = new System.Windows.Forms.Timer(this.components);
            this.slikaShreka = new System.Windows.Forms.PictureBox();
            this.PojavljivanjaText = new System.Windows.Forms.Label();
            this.ScoreBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // Metronom
            // 
            this.Metronom.Interval = 10;
            this.Metronom.Tick += new System.EventHandler(this.Metronom_Tick);
            // 
            // slikaShreka
            // 
            this.slikaShreka.Image = ((System.Drawing.Image)(resources.GetObject("slikaShreka.Image")));
            this.slikaShreka.Location = new System.Drawing.Point(206, 90);
            this.slikaShreka.MinimumSize = new System.Drawing.Size(20, 50);
            this.slikaShreka.Name = "slikaShreka";
            this.slikaShreka.Size = new System.Drawing.Size(362, 198);
            this.slikaShreka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slikaShreka.TabIndex = 1;
            this.slikaShreka.TabStop = false;
            // 
            // PojavljivanjaText
            // 
            this.PojavljivanjaText.AutoSize = true;
            this.PojavljivanjaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PojavljivanjaText.Location = new System.Drawing.Point(650, 212);
            this.PojavljivanjaText.Name = "PojavljivanjaText";
            this.PojavljivanjaText.Size = new System.Drawing.Size(64, 25);
            this.PojavljivanjaText.TabIndex = 3;
            this.PojavljivanjaText.Text = "label1";
            // 
            // ScoreBox
            // 
            this.ScoreBox.AutoSize = true;
            this.ScoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ScoreBox.Location = new System.Drawing.Point(451, 53);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(23, 25);
            this.ScoreBox.TabIndex = 4;
            this.ScoreBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(245, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bodovi (milisekunde):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(584, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pojavljivanja Shreka:";
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.PojavljivanjaText);
            this.Controls.Add(this.slikaShreka);
            this.Controls.Add(this.button1);
            this.Name = "Game1";
            this.Text = "Igra";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slikaShreka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer Metronom;
        private System.Windows.Forms.PictureBox slikaShreka;
        private System.Windows.Forms.Label PojavljivanjaText;
        private System.Windows.Forms.Label ScoreBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}