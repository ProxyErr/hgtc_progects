
namespace Baker_10_6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbtnAllenHall = new System.Windows.Forms.RadioButton();
            this.rbtnPikeHall = new System.Windows.Forms.RadioButton();
            this.rbtnFarthingHall = new System.Windows.Forms.RadioButton();
            this.rbtnUnivSuites = new System.Windows.Forms.RadioButton();
            this.rbtn7meals = new System.Windows.Forms.RadioButton();
            this.rbtn14meals = new System.Windows.Forms.RadioButton();
            this.rbtnUnlimited = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbtnAllenHall);
            this.groupBox1.Controls.Add(this.rbtnPikeHall);
            this.groupBox1.Controls.Add(this.rbtnFarthingHall);
            this.groupBox1.Controls.Add(this.rbtnUnivSuites);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Dormitories:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rbtn7meals);
            this.groupBox2.Controls.Add(this.rbtn14meals);
            this.groupBox2.Controls.Add(this.rbtnUnlimited);
            this.groupBox2.Location = new System.Drawing.Point(275, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 252);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Meal Plan:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(109, 304);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(106, 58);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(296, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 58);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbtnAllenHall
            // 
            this.rbtnAllenHall.AutoSize = true;
            this.rbtnAllenHall.Location = new System.Drawing.Point(10, 34);
            this.rbtnAllenHall.Name = "rbtnAllenHall";
            this.rbtnAllenHall.Size = new System.Drawing.Size(69, 17);
            this.rbtnAllenHall.TabIndex = 2;
            this.rbtnAllenHall.TabStop = true;
            this.rbtnAllenHall.Text = "Allen Hall";
            this.rbtnAllenHall.UseVisualStyleBackColor = true;
            // 
            // rbtnPikeHall
            // 
            this.rbtnPikeHall.AutoSize = true;
            this.rbtnPikeHall.Location = new System.Drawing.Point(12, 88);
            this.rbtnPikeHall.Name = "rbtnPikeHall";
            this.rbtnPikeHall.Size = new System.Drawing.Size(67, 17);
            this.rbtnPikeHall.TabIndex = 3;
            this.rbtnPikeHall.TabStop = true;
            this.rbtnPikeHall.Text = "Pike Hall";
            this.rbtnPikeHall.UseVisualStyleBackColor = true;
            // 
            // rbtnFarthingHall
            // 
            this.rbtnFarthingHall.AutoSize = true;
            this.rbtnFarthingHall.Location = new System.Drawing.Point(12, 147);
            this.rbtnFarthingHall.Name = "rbtnFarthingHall";
            this.rbtnFarthingHall.Size = new System.Drawing.Size(84, 17);
            this.rbtnFarthingHall.TabIndex = 4;
            this.rbtnFarthingHall.TabStop = true;
            this.rbtnFarthingHall.Text = "Farthing Hall";
            this.rbtnFarthingHall.UseVisualStyleBackColor = true;
            // 
            // rbtnUnivSuites
            // 
            this.rbtnUnivSuites.AutoSize = true;
            this.rbtnUnivSuites.Location = new System.Drawing.Point(10, 199);
            this.rbtnUnivSuites.Name = "rbtnUnivSuites";
            this.rbtnUnivSuites.Size = new System.Drawing.Size(103, 17);
            this.rbtnUnivSuites.TabIndex = 5;
            this.rbtnUnivSuites.TabStop = true;
            this.rbtnUnivSuites.Text = "University Suites";
            this.rbtnUnivSuites.UseVisualStyleBackColor = true;
            // 
            // rbtn7meals
            // 
            this.rbtn7meals.AutoSize = true;
            this.rbtn7meals.Location = new System.Drawing.Point(21, 34);
            this.rbtn7meals.Name = "rbtn7meals";
            this.rbtn7meals.Size = new System.Drawing.Size(108, 17);
            this.rbtn7meals.TabIndex = 6;
            this.rbtn7meals.TabStop = true;
            this.rbtn7meals.Text = "7 meals per week";
            this.rbtn7meals.UseVisualStyleBackColor = true;
            // 
            // rbtn14meals
            // 
            this.rbtn14meals.AutoSize = true;
            this.rbtn14meals.Location = new System.Drawing.Point(21, 103);
            this.rbtn14meals.Name = "rbtn14meals";
            this.rbtn14meals.Size = new System.Drawing.Size(114, 17);
            this.rbtn14meals.TabIndex = 7;
            this.rbtn14meals.TabStop = true;
            this.rbtn14meals.Text = "14 meals per week";
            this.rbtn14meals.UseVisualStyleBackColor = true;
            // 
            // rbtnUnlimited
            // 
            this.rbtnUnlimited.AutoSize = true;
            this.rbtnUnlimited.Location = new System.Drawing.Point(21, 181);
            this.rbtnUnlimited.Name = "rbtnUnlimited";
            this.rbtnUnlimited.Size = new System.Drawing.Size(98, 17);
            this.rbtnUnlimited.TabIndex = 8;
            this.rbtnUnlimited.TabStop = true;
            this.rbtnUnlimited.Text = "Unlimited meals";
            this.rbtnUnlimited.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "$1,500  per semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "$1,600  per semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "$1,800  per semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "$2,500  per semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "$600  per semester";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "$1,200  per semester";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "$1,700  per semester";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 374);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnAllenHall;
        private System.Windows.Forms.RadioButton rbtnPikeHall;
        private System.Windows.Forms.RadioButton rbtnFarthingHall;
        private System.Windows.Forms.RadioButton rbtnUnivSuites;
        private System.Windows.Forms.RadioButton rbtn7meals;
        private System.Windows.Forms.RadioButton rbtn14meals;
        private System.Windows.Forms.RadioButton rbtnUnlimited;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

