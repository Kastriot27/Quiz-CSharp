namespace WindowsFormsApp4
{
    partial class Quizz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quizz));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblScoreText = new System.Windows.Forms.Label();
            this.btnAns4 = new System.Windows.Forms.Button();
            this.btnAns3 = new System.Windows.Forms.Button();
            this.btnAns2 = new System.Windows.Forms.Button();
            this.btnAns1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnQuit);
            this.groupBox1.Controls.Add(this.lblQuestion);
            this.groupBox1.Controls.Add(this.lblScoreText);
            this.groupBox1.Controls.Add(this.btnAns4);
            this.groupBox1.Controls.Add(this.btnAns3);
            this.groupBox1.Controls.Add(this.btnAns2);
            this.groupBox1.Controls.Add(this.btnAns1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(2, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 626);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(856, 519);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(88, 34);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(195, 208);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(576, 58);
            this.lblQuestion.TabIndex = 6;
            // 
            // lblScoreText
            // 
            this.lblScoreText.AutoSize = true;
            this.lblScoreText.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreText.ForeColor = System.Drawing.Color.Tomato;
            this.lblScoreText.Location = new System.Drawing.Point(288, 20);
            this.lblScoreText.Name = "lblScoreText";
            this.lblScoreText.Size = new System.Drawing.Size(170, 36);
            this.lblScoreText.TabIndex = 4;
            this.lblScoreText.Text = "Score 0/10";
            // 
            // btnAns4
            // 
            this.btnAns4.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAns4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns4.Location = new System.Drawing.Point(515, 462);
            this.btnAns4.Name = "btnAns4";
            this.btnAns4.Size = new System.Drawing.Size(216, 47);
            this.btnAns4.TabIndex = 3;
            this.btnAns4.Tag = "0";
            this.btnAns4.Text = "Answer 4";
            this.btnAns4.UseVisualStyleBackColor = false;
            this.btnAns4.Click += new System.EventHandler(this.checkAnswer);
            // 
            // btnAns3
            // 
            this.btnAns3.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAns3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns3.Location = new System.Drawing.Point(515, 368);
            this.btnAns3.Name = "btnAns3";
            this.btnAns3.Size = new System.Drawing.Size(216, 47);
            this.btnAns3.TabIndex = 2;
            this.btnAns3.Tag = "0";
            this.btnAns3.Text = "Answer 3";
            this.btnAns3.UseVisualStyleBackColor = false;
            this.btnAns3.Click += new System.EventHandler(this.checkAnswer);
            // 
            // btnAns2
            // 
            this.btnAns2.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAns2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns2.Location = new System.Drawing.Point(220, 462);
            this.btnAns2.Name = "btnAns2";
            this.btnAns2.Size = new System.Drawing.Size(216, 47);
            this.btnAns2.TabIndex = 1;
            this.btnAns2.Tag = "0";
            this.btnAns2.Text = "Answer 2";
            this.btnAns2.UseVisualStyleBackColor = false;
            this.btnAns2.Click += new System.EventHandler(this.checkAnswer);
            // 
            // btnAns1
            // 
            this.btnAns1.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAns1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns1.Location = new System.Drawing.Point(220, 368);
            this.btnAns1.Name = "btnAns1";
            this.btnAns1.Size = new System.Drawing.Size(216, 47);
            this.btnAns1.TabIndex = 0;
            this.btnAns1.Tag = "0";
            this.btnAns1.Text = "Answer 1";
            this.btnAns1.UseVisualStyleBackColor = false;
            this.btnAns1.Click += new System.EventHandler(this.checkAnswer);
            // 
            // Quizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 616);
            this.Controls.Add(this.groupBox1);
            this.Name = "Quizz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quizz";
            this.Load += new System.EventHandler(this.Quizz_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblScoreText;
        private System.Windows.Forms.Button btnAns4;
        private System.Windows.Forms.Button btnAns3;
        private System.Windows.Forms.Button btnAns2;
        private System.Windows.Forms.Button btnAns1;
    }
}