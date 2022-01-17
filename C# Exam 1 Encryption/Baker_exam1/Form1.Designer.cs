
namespace Baker_exam1
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnCalcLetters = new System.Windows.Forms.Button();
            this.txtBoxUserLetter = new System.Windows.Forms.TextBox();
            this.btnCalcEnc = new System.Windows.Forms.Button();
            this.lstBoxResults = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(2, 9);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(478, 23);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Enter the Letter You want to search:";
            // 
            // btnCalcLetters
            // 
            this.btnCalcLetters.Location = new System.Drawing.Point(273, 55);
            this.btnCalcLetters.Name = "btnCalcLetters";
            this.btnCalcLetters.Size = new System.Drawing.Size(139, 32);
            this.btnCalcLetters.TabIndex = 1;
            this.btnCalcLetters.Text = "Generate";
            this.btnCalcLetters.UseVisualStyleBackColor = true;
            this.btnCalcLetters.Click += new System.EventHandler(this.btnCalcLetters_Click);
            // 
            // txtBoxUserLetter
            // 
            this.txtBoxUserLetter.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBoxUserLetter.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtBoxUserLetter.Location = new System.Drawing.Point(68, 58);
            this.txtBoxUserLetter.Name = "txtBoxUserLetter";
            this.txtBoxUserLetter.Size = new System.Drawing.Size(100, 29);
            this.txtBoxUserLetter.TabIndex = 2;
            // 
            // btnCalcEnc
            // 
            this.btnCalcEnc.Location = new System.Drawing.Point(38, 366);
            this.btnCalcEnc.Name = "btnCalcEnc";
            this.btnCalcEnc.Size = new System.Drawing.Size(118, 36);
            this.btnCalcEnc.TabIndex = 3;
            this.btnCalcEnc.Text = "Encrypt";
            this.btnCalcEnc.UseVisualStyleBackColor = true;
            this.btnCalcEnc.Click += new System.EventHandler(this.btnCalcEnc_Click);
            // 
            // lstBoxResults
            // 
            this.lstBoxResults.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstBoxResults.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxResults.ForeColor = System.Drawing.Color.DarkOrange;
            this.lstBoxResults.FormattingEnabled = true;
            this.lstBoxResults.ItemHeight = 12;
            this.lstBoxResults.Location = new System.Drawing.Point(54, 135);
            this.lstBoxResults.Name = "lstBoxResults";
            this.lstBoxResults.Size = new System.Drawing.Size(358, 184);
            this.lstBoxResults.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(172, 366);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 36);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(304, 366);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(480, 438);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstBoxResults);
            this.Controls.Add(this.btnCalcEnc);
            this.Controls.Add(this.txtBoxUserLetter);
            this.Controls.Add(this.btnCalcLetters);
            this.Controls.Add(this.lblPrompt);
            this.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "Form1";
            this.Text = "EXAM ONE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnCalcLetters;
        private System.Windows.Forms.TextBox txtBoxUserLetter;
        private System.Windows.Forms.Button btnCalcEnc;
        private System.Windows.Forms.ListBox lstBoxResults;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

