
namespace Baker_10_4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxEmpPos = new System.Windows.Forms.TextBox();
            this.txtBoxEmpDep = new System.Windows.Forms.TextBox();
            this.txtBoxEmpId = new System.Windows.Forms.TextBox();
            this.txtBoxEmpName = new System.Windows.Forms.TextBox();
            this.lstBoxDisp = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(35, 236);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "ADD";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(377, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 102);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxEmpPos);
            this.groupBox1.Controls.Add(this.txtBoxEmpDep);
            this.groupBox1.Controls.Add(this.txtBoxEmpId);
            this.groupBox1.Controls.Add(this.txtBoxEmpName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 205);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter employee data:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstBoxDisp);
            this.groupBox2.Location = new System.Drawing.Point(269, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 205);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select an Employee:";
            // 
            // txtBoxEmpPos
            // 
            this.txtBoxEmpPos.Location = new System.Drawing.Point(94, 169);
            this.txtBoxEmpPos.Name = "txtBoxEmpPos";
            this.txtBoxEmpPos.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEmpPos.TabIndex = 3;
            // 
            // txtBoxEmpDep
            // 
            this.txtBoxEmpDep.Location = new System.Drawing.Point(94, 127);
            this.txtBoxEmpDep.Name = "txtBoxEmpDep";
            this.txtBoxEmpDep.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEmpDep.TabIndex = 4;
            // 
            // txtBoxEmpId
            // 
            this.txtBoxEmpId.Location = new System.Drawing.Point(94, 79);
            this.txtBoxEmpId.Name = "txtBoxEmpId";
            this.txtBoxEmpId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEmpId.TabIndex = 5;
            // 
            // txtBoxEmpName
            // 
            this.txtBoxEmpName.Location = new System.Drawing.Point(94, 36);
            this.txtBoxEmpName.Name = "txtBoxEmpName";
            this.txtBoxEmpName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEmpName.TabIndex = 6;
            // 
            // lstBoxDisp
            // 
            this.lstBoxDisp.FormattingEnabled = true;
            this.lstBoxDisp.Location = new System.Drawing.Point(6, 19);
            this.lstBoxDisp.Name = "lstBoxDisp";
            this.lstBoxDisp.Size = new System.Drawing.Size(246, 173);
            this.lstBoxDisp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "idNumber:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Position:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 370);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxEmpPos;
        private System.Windows.Forms.TextBox txtBoxEmpDep;
        private System.Windows.Forms.TextBox txtBoxEmpId;
        private System.Windows.Forms.TextBox txtBoxEmpName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstBoxDisp;
    }
}

