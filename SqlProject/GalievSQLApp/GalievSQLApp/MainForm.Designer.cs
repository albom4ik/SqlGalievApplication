namespace GalievSQLApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.choice = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.MyIcon = new System.Windows.Forms.PictureBox();
            this.Athlete_Transition = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Journal_Label = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.StadiumLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sports_Label = new System.Windows.Forms.Label();
            this.AthleteTableIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyIcon)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AthleteTableIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.choice);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.MyIcon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 120);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(49, 58);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(76, 59);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // choice
            // 
            this.choice.AutoSize = true;
            this.choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.choice.ForeColor = System.Drawing.Color.White;
            this.choice.Location = new System.Drawing.Point(362, 12);
            this.choice.Name = "choice";
            this.choice.Size = new System.Drawing.Size(146, 16);
            this.choice.TabIndex = 4;
            this.choice.Text = "Выберите таблицу";
            this.choice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(771, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 31);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // MyIcon
            // 
            this.MyIcon.Image = ((System.Drawing.Image)(resources.GetObject("MyIcon.Image")));
            this.MyIcon.Location = new System.Drawing.Point(131, 85);
            this.MyIcon.Name = "MyIcon";
            this.MyIcon.Size = new System.Drawing.Size(39, 35);
            this.MyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyIcon.TabIndex = 6;
            this.MyIcon.TabStop = false;
            // 
            // Athlete_Transition
            // 
            this.Athlete_Transition.AutoSize = true;
            this.Athlete_Transition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Athlete_Transition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Athlete_Transition.ForeColor = System.Drawing.Color.White;
            this.Athlete_Transition.Location = new System.Drawing.Point(59, 144);
            this.Athlete_Transition.Name = "Athlete_Transition";
            this.Athlete_Transition.Size = new System.Drawing.Size(98, 16);
            this.Athlete_Transition.TabIndex = 3;
            this.Athlete_Transition.Text = "Спортсмены";
            this.Athlete_Transition.Click += new System.EventHandler(this.Athlete_Transition_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.YellowGreen;
            this.MainPanel.Controls.Add(this.pictureBox4);
            this.MainPanel.Controls.Add(this.Journal_Label);
            this.MainPanel.Controls.Add(this.pictureBox3);
            this.MainPanel.Controls.Add(this.StadiumLabel);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.Sports_Label);
            this.MainPanel.Controls.Add(this.AthleteTableIcon);
            this.MainPanel.Controls.Add(this.pictureBox2);
            this.MainPanel.Controls.Add(this.Athlete_Transition);
            this.MainPanel.Controls.Add(this.CloseLabel);
            this.MainPanel.Controls.Add(this.dataGridView1);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 339);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // Journal_Label
            // 
            this.Journal_Label.AutoSize = true;
            this.Journal_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Journal_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Journal_Label.ForeColor = System.Drawing.Color.White;
            this.Journal_Label.Location = new System.Drawing.Point(59, 348);
            this.Journal_Label.Name = "Journal_Label";
            this.Journal_Label.Size = new System.Drawing.Size(43, 16);
            this.Journal_Label.TabIndex = 14;
            this.Journal_Label.Text = "Учет";
            this.Journal_Label.Click += new System.EventHandler(this.Journal_Label_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 271);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // StadiumLabel
            // 
            this.StadiumLabel.AutoSize = true;
            this.StadiumLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StadiumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StadiumLabel.ForeColor = System.Drawing.Color.White;
            this.StadiumLabel.Location = new System.Drawing.Point(59, 280);
            this.StadiumLabel.Name = "StadiumLabel";
            this.StadiumLabel.Size = new System.Drawing.Size(80, 16);
            this.StadiumLabel.TabIndex = 12;
            this.StadiumLabel.Text = "Стадионы";
            this.StadiumLabel.Click += new System.EventHandler(this.StadiumLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Sports_Label
            // 
            this.Sports_Label.AutoSize = true;
            this.Sports_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sports_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sports_Label.ForeColor = System.Drawing.Color.White;
            this.Sports_Label.Location = new System.Drawing.Point(59, 216);
            this.Sports_Label.Name = "Sports_Label";
            this.Sports_Label.Size = new System.Drawing.Size(101, 16);
            this.Sports_Label.TabIndex = 10;
            this.Sports_Label.Text = "Виды спорта";
            this.Sports_Label.Click += new System.EventHandler(this.Sports_Label_Click);
            // 
            // AthleteTableIcon
            // 
            this.AthleteTableIcon.Image = ((System.Drawing.Image)(resources.GetObject("AthleteTableIcon.Image")));
            this.AthleteTableIcon.Location = new System.Drawing.Point(12, 135);
            this.AthleteTableIcon.Name = "AthleteTableIcon";
            this.AthleteTableIcon.Size = new System.Drawing.Size(39, 39);
            this.AthleteTableIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AthleteTableIcon.TabIndex = 9;
            this.AthleteTableIcon.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 398);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CloseLabel.ForeColor = System.Drawing.Color.White;
            this.CloseLabel.Location = new System.Drawing.Point(59, 412);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(52, 16);
            this.CloseLabel.TabIndex = 7;
            this.CloseLabel.Text = "Выход";
            this.CloseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(164, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(636, 416);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Спортивные заведения";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyIcon)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AthleteTableIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label Athlete_Transition;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label choice;
        private System.Windows.Forms.PictureBox MyIcon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Journal_Label;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label StadiumLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Sports_Label;
        private System.Windows.Forms.PictureBox AthleteTableIcon;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
    }
}