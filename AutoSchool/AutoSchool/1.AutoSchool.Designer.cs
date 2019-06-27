namespace AutoSchool
{
    partial class AutoSchool
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.students_b = new System.Windows.Forms.Button();
            this.teachers_b = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // students_b
            // 
            this.students_b.Location = new System.Drawing.Point(301, 15);
            this.students_b.Name = "students_b";
            this.students_b.Size = new System.Drawing.Size(200, 30);
            this.students_b.TabIndex = 0;
            this.students_b.Text = "1. УЧЕНИКИ";
            this.students_b.UseVisualStyleBackColor = true;
            this.students_b.Click += new System.EventHandler(this.students_b_lkm);
            // 
            // teachers_b
            // 
            this.teachers_b.Location = new System.Drawing.Point(301, 51);
            this.teachers_b.Name = "teachers_b";
            this.teachers_b.Size = new System.Drawing.Size(200, 30);
            this.teachers_b.TabIndex = 2;
            this.teachers_b.Text = "3. КАДРЫ";
            this.teachers_b.UseVisualStyleBackColor = true;
            this.teachers_b.Click += new System.EventHandler(this.teachers_b_lkm);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(301, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "4. АВТОПАРК";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(301, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "7. ФИНАНСЫ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(301, 159);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 30);
            this.button5.TabIndex = 5;
            this.button5.Text = "6. НОРМАТИВНЫЕ ДОКУМЕНТЫ";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(301, 123);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 30);
            this.button6.TabIndex = 7;
            this.button6.Text = "5. ПОДРАЗДЕЛЕНИЯ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(301, 231);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 30);
            this.button7.TabIndex = 8;
            this.button7.Text = "8. ОТЧЕТЫ";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(301, 267);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(200, 30);
            this.button11.TabIndex = 12;
            this.button11.Text = "9. СПРАВОЧНИК";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(301, 303);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 30);
            this.button8.TabIndex = 13;
            this.button8.Text = "10. СМС_рассылка";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(301, 339);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(200, 30);
            this.button9.TabIndex = 15;
            this.button9.Text = "БЛАНКИ";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(301, 375);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(200, 30);
            this.button10.TabIndex = 17;
            this.button10.Text = "ЛИТЕРАТУРА";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // AutoSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.teachers_b);
            this.Controls.Add(this.students_b);
            this.IsMdiContainer = true;
            this.Name = "AutoSchool";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button students_b;
        private System.Windows.Forms.Button teachers_b;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

