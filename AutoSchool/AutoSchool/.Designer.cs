﻿namespace AutoSchool
{
    partial class Students
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
            this.studentcard_b = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentcard_b
            // 
            this.studentcard_b.Location = new System.Drawing.Point(281, 49);
            this.studentcard_b.Name = "studentcard_b";
            this.studentcard_b.Size = new System.Drawing.Size(200, 30);
            this.studentcard_b.TabIndex = 0;
            this.studentcard_b.Text = "1.1.КАРТОЧКА УЧАЩЕГОСЯ";
            this.studentcard_b.UseVisualStyleBackColor = true;
            this.studentcard_b.Click += new System.EventHandler(this.studentcard_b_lkm);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "1.2. УЧЕБНЫЕ ГРУППЫ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(281, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "ДОКУМЕНТЫ НА ВЫПУСК";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(281, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "ПЕЧАТНЫЕ ФОРМЫ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.studentcard_b);
            this.Name = "Students";
            this.Text = "1. УЧЕНИКИ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studentcard_b;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}