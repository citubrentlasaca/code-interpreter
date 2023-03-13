namespace CODE_Interpreter
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
            this.inputtxt = new System.Windows.Forms.TextBox();
            this.outputtxt = new System.Windows.Forms.TextBox();
            this.runbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputtxt
            // 
            this.inputtxt.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputtxt.Location = new System.Drawing.Point(12, 12);
            this.inputtxt.Multiline = true;
            this.inputtxt.Name = "inputtxt";
            this.inputtxt.Size = new System.Drawing.Size(525, 487);
            this.inputtxt.TabIndex = 0;
            // 
            // outputtxt
            // 
            this.outputtxt.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputtxt.Location = new System.Drawing.Point(552, 12);
            this.outputtxt.Multiline = true;
            this.outputtxt.Name = "outputtxt";
            this.outputtxt.ReadOnly = true;
            this.outputtxt.Size = new System.Drawing.Size(525, 487);
            this.outputtxt.TabIndex = 1;
            // 
            // runbtn
            // 
            this.runbtn.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runbtn.Location = new System.Drawing.Point(12, 505);
            this.runbtn.Name = "runbtn";
            this.runbtn.Size = new System.Drawing.Size(1065, 43);
            this.runbtn.TabIndex = 2;
            this.runbtn.Text = "Run";
            this.runbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 560);
            this.Controls.Add(this.runbtn);
            this.Controls.Add(this.outputtxt);
            this.Controls.Add(this.inputtxt);
            this.Name = "Form1";
            this.Text = "CODE Interpreter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputtxt;
        private System.Windows.Forms.TextBox outputtxt;
        private System.Windows.Forms.Button runbtn;
    }
}

