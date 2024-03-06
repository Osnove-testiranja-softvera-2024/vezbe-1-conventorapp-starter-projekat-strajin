namespace OTS2023_ConventorApp
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
            this.btnMass = new System.Windows.Forms.RadioButton();
            this.btnLength = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.gbConverterType = new System.Windows.Forms.GroupBox();
            this.gbConverterType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMass
            // 
            this.btnMass.AutoSize = true;
            this.btnMass.Location = new System.Drawing.Point(16, 23);
            this.btnMass.Name = "btnMass";
            this.btnMass.Size = new System.Drawing.Size(50, 17);
            this.btnMass.TabIndex = 1;
            this.btnMass.TabStop = true;
            this.btnMass.Text = "Mass";
            this.btnMass.UseVisualStyleBackColor = true;
            // 
            // btnLength
            // 
            this.btnLength.AutoSize = true;
            this.btnLength.Location = new System.Drawing.Point(16, 46);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(58, 17);
            this.btnLength.TabIndex = 2;
            this.btnLength.TabStop = true;
            this.btnLength.Text = "Length";
            this.btnLength.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(172, 271);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // gbConverterType
            // 
            this.gbConverterType.Controls.Add(this.btnMass);
            this.gbConverterType.Controls.Add(this.btnLength);
            this.gbConverterType.Location = new System.Drawing.Point(26, 12);
            this.gbConverterType.Name = "gbConverterType";
            this.gbConverterType.Size = new System.Drawing.Size(200, 100);
            this.gbConverterType.TabIndex = 8;
            this.gbConverterType.TabStop = false;
            this.gbConverterType.Text = "Converter type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbConverterType);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbConverterType.ResumeLayout(false);
            this.gbConverterType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnMass;
        private System.Windows.Forms.RadioButton btnLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.GroupBox gbConverterType;
    }
}

