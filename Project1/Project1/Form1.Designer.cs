namespace Project1
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
            this.openXml = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.TextBox();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.saveNewFile = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.third = new System.Windows.Forms.TextBox();
            this.fourth = new System.Windows.Forms.TextBox();
            this.fifth = new System.Windows.Forms.TextBox();
            this.sixth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openXml
            // 
            this.openXml.Location = new System.Drawing.Point(13, 40);
            this.openXml.Name = "openXml";
            this.openXml.Size = new System.Drawing.Size(169, 35);
            this.openXml.TabIndex = 0;
            this.openXml.Text = "Try and Open XML File";
            this.openXml.UseVisualStyleBackColor = true;
            this.openXml.Click += new System.EventHandler(this.openXml_Click);
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(12, 12);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(174, 22);
            this.FileName.TabIndex = 1;
            this.FileName.Text = "pizzaOrder.xml";
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(13, 81);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(232, 299);
            this.textOutput.TabIndex = 2;
            // 
            // saveNewFile
            // 
            this.saveNewFile.Location = new System.Drawing.Point(17, 399);
            this.saveNewFile.Name = "saveNewFile";
            this.saveNewFile.Size = new System.Drawing.Size(169, 35);
            this.saveNewFile.TabIndex = 3;
            this.saveNewFile.Text = "Save New File";
            this.saveNewFile.UseVisualStyleBackColor = true;
            this.saveNewFile.Click += new System.EventHandler(this.saveNewFile_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(352, 415);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(116, 35);
            this.testButton.TabIndex = 4;
            this.testButton.Text = "Test Function";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(356, 387);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(33, 22);
            this.A.TabIndex = 5;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(424, 387);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(33, 22);
            this.B.TabIndex = 6;
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Location = new System.Drawing.Point(400, 390);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(16, 17);
            this.plus.TabIndex = 7;
            this.plus.Text = "+";
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(355, 105);
            this.first.Multiline = true;
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(120, 22);
            this.first.TabIndex = 8;
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(355, 133);
            this.second.Multiline = true;
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(120, 22);
            this.second.TabIndex = 9;
            // 
            // third
            // 
            this.third.Location = new System.Drawing.Point(355, 161);
            this.third.Multiline = true;
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(120, 22);
            this.third.TabIndex = 10;
            // 
            // fourth
            // 
            this.fourth.Location = new System.Drawing.Point(355, 189);
            this.fourth.Multiline = true;
            this.fourth.Name = "fourth";
            this.fourth.Size = new System.Drawing.Size(120, 22);
            this.fourth.TabIndex = 11;
            // 
            // fifth
            // 
            this.fifth.Location = new System.Drawing.Point(355, 217);
            this.fifth.Multiline = true;
            this.fifth.Name = "fifth";
            this.fifth.Size = new System.Drawing.Size(120, 22);
            this.fifth.TabIndex = 12;
            // 
            // sixth
            // 
            this.sixth.Location = new System.Drawing.Point(355, 245);
            this.sixth.Multiline = true;
            this.sixth.Name = "sixth";
            this.sixth.Size = new System.Drawing.Size(120, 22);
            this.sixth.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Phone";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Pizza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Topping1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Topping2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 468);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sixth);
            this.Controls.Add(this.fifth);
            this.Controls.Add(this.fourth);
            this.Controls.Add(this.third);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.saveNewFile);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.openXml);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openXml;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Button saveNewFile;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox third;
        private System.Windows.Forms.TextBox fourth;
        private System.Windows.Forms.TextBox fifth;
        private System.Windows.Forms.TextBox sixth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

