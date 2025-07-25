namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            txtTot = new TextBox();
            txtAvg = new TextBox();
            txtGrd = new TextBox();
            label12 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtEng = new TextBox();
            txtHis = new TextBox();
            txtSci = new TextBox();
            txtMaths = new TextBox();
            txtIct = new TextBox();
            txtIndex = new TextBox();
            txtName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtEng);
            groupBox1.Controls.Add(txtHis);
            groupBox1.Controls.Add(txtSci);
            groupBox1.Controls.Add(txtMaths);
            groupBox1.Controls.Add(txtIct);
            groupBox1.Controls.Add(txtIndex);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(82, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(661, 518);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student's GPA";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(83, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(143, 451);
            button1.Name = "button1";
            button1.Size = new Size(91, 33);
            button1.TabIndex = 20;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTot);
            groupBox2.Controls.Add(txtAvg);
            groupBox2.Controls.Add(txtGrd);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(383, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 187);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Result";
            // 
            // txtTot
            // 
            txtTot.Location = new Point(78, 43);
            txtTot.Name = "txtTot";
            txtTot.Size = new Size(107, 29);
            txtTot.TabIndex = 17;
            // 
            // txtAvg
            // 
            txtAvg.Location = new Point(78, 78);
            txtAvg.Name = "txtAvg";
            txtAvg.Size = new Size(107, 29);
            txtAvg.TabIndex = 18;
            txtAvg.TextChanged += textBox9_TextChanged;
            // 
            // txtGrd
            // 
            txtGrd.Location = new Point(78, 113);
            txtGrd.Name = "txtGrd";
            txtGrd.Size = new Size(107, 29);
            txtGrd.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(6, 118);
            label12.Name = "label12";
            label12.Size = new Size(47, 17);
            label12.TabIndex = 19;
            label12.Text = "Grade";
            label12.Click += label12_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 49);
            label10.Name = "label10";
            label10.Size = new Size(41, 17);
            label10.TabIndex = 17;
            label10.Text = "Total";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(6, 83);
            label11.Name = "label11";
            label11.Size = new Size(61, 17);
            label11.TabIndex = 18;
            label11.Text = "Average";
            // 
            // txtEng
            // 
            txtEng.Location = new Point(209, 403);
            txtEng.Name = "txtEng";
            txtEng.Size = new Size(107, 29);
            txtEng.TabIndex = 15;
            // 
            // txtHis
            // 
            txtHis.Location = new Point(209, 368);
            txtHis.Name = "txtHis";
            txtHis.Size = new Size(107, 29);
            txtHis.TabIndex = 14;
            // 
            // txtSci
            // 
            txtSci.Location = new Point(209, 333);
            txtSci.Name = "txtSci";
            txtSci.Size = new Size(107, 29);
            txtSci.TabIndex = 13;
            // 
            // txtMaths
            // 
            txtMaths.Location = new Point(209, 296);
            txtMaths.Name = "txtMaths";
            txtMaths.Size = new Size(107, 29);
            txtMaths.TabIndex = 12;
            txtMaths.TextChanged += textBox4_TextChanged;
            // 
            // txtIct
            // 
            txtIct.Location = new Point(209, 261);
            txtIct.Name = "txtIct";
            txtIct.Size = new Size(107, 29);
            txtIct.TabIndex = 11;
            txtIct.TextChanged += textBox3_TextChanged;
            // 
            // txtIndex
            // 
            txtIndex.Location = new Point(428, 123);
            txtIndex.Name = "txtIndex";
            txtIndex.Size = new Size(155, 29);
            txtIndex.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(428, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(155, 29);
            txtName.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(83, 409);
            label9.Name = "label9";
            label9.Size = new Size(81, 17);
            label9.TabIndex = 8;
            label9.Text = "English Lit.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(83, 375);
            label8.Name = "label8";
            label8.Size = new Size(55, 17);
            label8.TabIndex = 7;
            label8.Text = "History";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(83, 340);
            label7.Name = "label7";
            label7.Size = new Size(61, 17);
            label7.TabIndex = 6;
            label7.Text = "Science";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(83, 303);
            label6.Name = "label6";
            label6.Size = new Size(92, 17);
            label6.TabIndex = 5;
            label6.Text = "Mathematics";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(83, 268);
            label5.Name = "label5";
            label5.Size = new Size(31, 17);
            label5.TabIndex = 4;
            label5.Text = "ICT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label4.Location = new Point(232, 228);
            label4.Name = "label4";
            label4.Size = new Size(51, 18);
            label4.TabIndex = 3;
            label4.Text = "Marks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label3.Location = new Point(83, 228);
            label3.Name = "label3";
            label3.Size = new Size(70, 18);
            label3.TabIndex = 2;
            label3.Text = "Subjects";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(302, 131);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 1;
            label2.Text = "Index";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 95);
            label1.Name = "label1";
            label1.Size = new Size(101, 17);
            label1.TabIndex = 0;
            label1.Text = "Student Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(881, 562);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtIndex;
        private TextBox txtName;
        private Label label9;
        private GroupBox groupBox2;
        private Label label12;
        private Label label10;
        private Label label11;
        private TextBox txtEng;
        private TextBox txtHis;
        private TextBox txtSci;
        private TextBox txtMaths;
        private TextBox txtIct;
        private TextBox txtTot;
        private TextBox txtAvg;
        private TextBox txtGrd;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
