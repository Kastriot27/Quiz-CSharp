
namespace WindowsFormsApp4
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPhotoQuizz = new System.Windows.Forms.Button();
            this.btnQuizz = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnmini = new System.Windows.Forms.Button();
            this.btnx = new System.Windows.Forms.Button();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblslcity = new System.Windows.Forms.Label();
            this.lblunknown = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.p1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnPhotoQuizz);
            this.panel1.Controls.Add(this.btnQuizz);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 408);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = global::WindowsFormsApp4.Properties.Resources._1;
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.mobile_app_icon_logo_designs_20;
            this.pictureBox1.Location = new System.Drawing.Point(61, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnPhotoQuizz
            // 
            this.btnPhotoQuizz.FlatAppearance.BorderSize = 0;
            this.btnPhotoQuizz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhotoQuizz.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhotoQuizz.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPhotoQuizz.Location = new System.Drawing.Point(0, 275);
            this.btnPhotoQuizz.Name = "btnPhotoQuizz";
            this.btnPhotoQuizz.Size = new System.Drawing.Size(199, 49);
            this.btnPhotoQuizz.TabIndex = 3;
            this.btnPhotoQuizz.Text = "Photo Quizz";
            this.btnPhotoQuizz.UseVisualStyleBackColor = true;
            this.btnPhotoQuizz.Click += new System.EventHandler(this.btnPhotoQuizz_Click);
            // 
            // btnQuizz
            // 
            this.btnQuizz.FlatAppearance.BorderSize = 0;
            this.btnQuizz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuizz.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuizz.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuizz.Location = new System.Drawing.Point(0, 205);
            this.btnQuizz.Name = "btnQuizz";
            this.btnQuizz.Size = new System.Drawing.Size(199, 49);
            this.btnQuizz.TabIndex = 2;
            this.btnQuizz.Text = "Quizz";
            this.btnQuizz.UseVisualStyleBackColor = true;
            this.btnQuizz.Click += new System.EventHandler(this.btnQuizz_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.Location = new System.Drawing.Point(0, 140);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(199, 49);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnmini);
            this.panel2.Controls.Add(this.btnx);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 31);
            this.panel2.TabIndex = 1;
            // 
            // btnmini
            // 
            this.btnmini.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnmini.FlatAppearance.BorderSize = 0;
            this.btnmini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmini.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmini.ForeColor = System.Drawing.Color.Gray;
            this.btnmini.Location = new System.Drawing.Point(135, 0);
            this.btnmini.Name = "btnmini";
            this.btnmini.Size = new System.Drawing.Size(30, 31);
            this.btnmini.TabIndex = 1;
            this.btnmini.Text = "_";
            this.btnmini.UseVisualStyleBackColor = false;
            this.btnmini.Click += new System.EventHandler(this.btnmini_Click);
            // 
            // btnx
            // 
            this.btnx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnx.FlatAppearance.BorderSize = 0;
            this.btnx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnx.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx.ForeColor = System.Drawing.Color.Gray;
            this.btnx.Location = new System.Drawing.Point(161, 0);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(30, 31);
            this.btnx.TabIndex = 0;
            this.btnx.Text = "X";
            this.btnx.UseVisualStyleBackColor = false;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Items.AddRange(new object[] {
            "Mitrovice",
            "Prishtine",
            "Peje",
            "Gjakove",
            "Gjilan",
            "Ferizaj"});
            this.cboCity.Location = new System.Drawing.Point(267, 116);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(98, 21);
            this.cboCity.TabIndex = 2;
            this.cboCity.SelectedIndexChanged += new System.EventHandler(this.cboCity_SelectedIndexChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(218, 114);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(36, 23);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City:";
            // 
            // lblslcity
            // 
            this.lblslcity.AutoSize = true;
            this.lblslcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblslcity.Location = new System.Drawing.Point(206, 205);
            this.lblslcity.Name = "lblslcity";
            this.lblslcity.Size = new System.Drawing.Size(106, 20);
            this.lblslcity.TabIndex = 4;
            this.lblslcity.Text = "Selected City:";
            // 
            // lblunknown
            // 
            this.lblunknown.AutoSize = true;
            this.lblunknown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblunknown.Location = new System.Drawing.Point(347, 205);
            this.lblunknown.Name = "lblunknown";
            this.lblunknown.Size = new System.Drawing.Size(18, 20);
            this.lblunknown.TabIndex = 5;
            this.lblunknown.Text = "?";
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(1, 142);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(8, 46);
            this.p1.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 408);
            this.Controls.Add(this.lblunknown);
            this.Controls.Add(this.lblslcity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPhotoQuizz;
        private System.Windows.Forms.Button btnQuizz;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnmini;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblslcity;
        private System.Windows.Forms.Label lblunknown;
        private System.Windows.Forms.Panel p1;
    }
}