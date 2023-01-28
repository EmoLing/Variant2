namespace Variant2
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
            this.number1Box = new System.Windows.Forms.TextBox();
            this.number2Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Number2Label = new System.Windows.Forms.Label();
            this.butPlus = new System.Windows.Forms.Button();
            this.butMinus = new System.Windows.Forms.Button();
            this.butMultiple = new System.Windows.Forms.Button();
            this.butDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1Box
            // 
            this.number1Box.Location = new System.Drawing.Point(12, 39);
            this.number1Box.Name = "number1Box";
            this.number1Box.Size = new System.Drawing.Size(100, 23);
            this.number1Box.TabIndex = 0;
            this.number1Box.Text = "0";
            this.number1Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number1Box_KeyPress);
            // 
            // number2Box
            // 
            this.number2Box.Location = new System.Drawing.Point(118, 39);
            this.number2Box.Name = "number2Box";
            this.number2Box.Size = new System.Drawing.Size(100, 23);
            this.number2Box.TabIndex = 1;
            this.number2Box.Text = "0";
            this.number2Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number2Box_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number1";
            // 
            // Number2Label
            // 
            this.Number2Label.AutoSize = true;
            this.Number2Label.Location = new System.Drawing.Point(118, 21);
            this.Number2Label.Name = "Number2Label";
            this.Number2Label.Size = new System.Drawing.Size(57, 15);
            this.Number2Label.TabIndex = 3;
            this.Number2Label.Text = "Number2";
            // 
            // butPlus
            // 
            this.butPlus.Location = new System.Drawing.Point(12, 95);
            this.butPlus.Name = "butPlus";
            this.butPlus.Size = new System.Drawing.Size(75, 23);
            this.butPlus.TabIndex = 4;
            this.butPlus.Text = "+";
            this.butPlus.UseVisualStyleBackColor = true;
            this.butPlus.Click += new System.EventHandler(this.butPlus_Click);
            // 
            // butMinus
            // 
            this.butMinus.Location = new System.Drawing.Point(109, 95);
            this.butMinus.Name = "butMinus";
            this.butMinus.Size = new System.Drawing.Size(75, 23);
            this.butMinus.TabIndex = 5;
            this.butMinus.Text = "-";
            this.butMinus.UseVisualStyleBackColor = true;
            this.butMinus.Click += new System.EventHandler(this.butMinus_Click);
            // 
            // butMultiple
            // 
            this.butMultiple.Location = new System.Drawing.Point(12, 124);
            this.butMultiple.Name = "butMultiple";
            this.butMultiple.Size = new System.Drawing.Size(75, 23);
            this.butMultiple.TabIndex = 6;
            this.butMultiple.Text = "*";
            this.butMultiple.UseVisualStyleBackColor = true;
            this.butMultiple.Click += new System.EventHandler(this.butMultiple_Click);
            // 
            // butDivide
            // 
            this.butDivide.Location = new System.Drawing.Point(109, 124);
            this.butDivide.Name = "butDivide";
            this.butDivide.Size = new System.Drawing.Size(75, 23);
            this.butDivide.TabIndex = 7;
            this.butDivide.Text = "/";
            this.butDivide.UseVisualStyleBackColor = true;
            this.butDivide.Click += new System.EventHandler(this.butDivide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 299);
            this.Controls.Add(this.butDivide);
            this.Controls.Add(this.butMultiple);
            this.Controls.Add(this.butMinus);
            this.Controls.Add(this.butPlus);
            this.Controls.Add(this.Number2Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number2Box);
            this.Controls.Add(this.number1Box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox number1Box;
        private TextBox number2Box;
        private Label label1;
        private Label Number2Label;
        private Button butPlus;
        private Button butMinus;
        private Button butMultiple;
        private Button butDivide;
    }
}