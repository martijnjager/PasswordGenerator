namespace PasswordGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSymbols = new System.Windows.Forms.CheckBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length of password";
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(171, 13);
            this.nudLength.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(120, 20);
            this.nudLength.TabIndex = 1;
            this.nudLength.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Include symbols (e.g. @#$% )";
            // 
            // cbSymbols
            // 
            this.cbSymbols.AutoSize = true;
            this.cbSymbols.Checked = true;
            this.cbSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSymbols.Location = new System.Drawing.Point(171, 49);
            this.cbSymbols.Name = "cbSymbols";
            this.cbSymbols.Size = new System.Drawing.Size(15, 14);
            this.cbSymbols.TabIndex = 3;
            this.cbSymbols.UseVisualStyleBackColor = true;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(16, 81);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(620, 20);
            this.tbResult.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(642, 81);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate ";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 106);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.cbSymbols);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudLength);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbSymbols;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnGenerate;
    }
}

