
namespace CalculatorUI
{
    partial class CalculatorUI
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(287, 58);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(199, 20);
            this.firstNumberTextBox.TabIndex = 0;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(287, 105);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(192, 20);
            this.secondNumberTextBox.TabIndex = 1;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(287, 234);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(186, 20);
            this.resultTextBox.TabIndex = 2;
            this.resultTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1st number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "2nd number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "final result";
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(287, 151);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(75, 23);
            this.sum.TabIndex = 6;
            this.sum.Text = "sum";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(398, 151);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(75, 23);
            this.mul.TabIndex = 7;
            this.mul.Text = "mul";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.button2_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(287, 196);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 23);
            this.sub.TabIndex = 8;
            this.sub.Text = "sub";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(398, 196);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(75, 23);
            this.Div.TabIndex = 9;
            this.Div.Text = "Div";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // CalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Name = "CalculatorUI";
            this.Text = "CalculatorUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button Div;
    }
}

