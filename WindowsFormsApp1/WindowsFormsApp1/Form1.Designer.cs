namespace WindowsFormsApp1
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.savePeople = new System.Windows.Forms.Button();
            this.FIOtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SpecialCombo = new System.Windows.Forms.ComboBox();
            this.DoljCombo = new System.Windows.Forms.ComboBox();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.searchDate = new System.Windows.Forms.DateTimePicker();
            this.searchPeople = new System.Windows.Forms.Button();
            this.searchDoljcombo = new System.Windows.Forms.ComboBox();
            this.searchTextFio = new System.Windows.Forms.TextBox();
            this.searchComboSpecial = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // savePeople
            // 
            this.savePeople.Location = new System.Drawing.Point(15, 192);
            this.savePeople.Name = "savePeople";
            this.savePeople.Size = new System.Drawing.Size(256, 54);
            this.savePeople.TabIndex = 0;
            this.savePeople.Text = "button1";
            this.savePeople.UseVisualStyleBackColor = true;
            this.savePeople.Click += new System.EventHandler(this.savePeople_Click);
            // 
            // FIOtext
            // 
            this.FIOtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOtext.Location = new System.Drawing.Point(15, 28);
            this.FIOtext.Name = "FIOtext";
            this.FIOtext.Size = new System.Drawing.Size(256, 23);
            this.FIOtext.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Специальность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата найма";
            // 
            // SpecialCombo
            // 
            this.SpecialCombo.FormattingEnabled = true;
            this.SpecialCombo.Items.AddRange(new object[] {
            "ИТ разработчик",
            "Java раб",
            "C# раб"});
            this.SpecialCombo.Location = new System.Drawing.Point(15, 74);
            this.SpecialCombo.Name = "SpecialCombo";
            this.SpecialCombo.Size = new System.Drawing.Size(256, 21);
            this.SpecialCombo.TabIndex = 12;
            // 
            // DoljCombo
            // 
            this.DoljCombo.FormattingEnabled = true;
            this.DoljCombo.Items.AddRange(new object[] {
            "Программист",
            "Бухгалтер",
            "Менеджер",
            "Начальник отдела"});
            this.DoljCombo.Location = new System.Drawing.Point(15, 122);
            this.DoljCombo.Name = "DoljCombo";
            this.DoljCombo.Size = new System.Drawing.Size(256, 21);
            this.DoljCombo.TabIndex = 13;
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(15, 166);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(256, 20);
            this.DateTime.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DateTime);
            this.panel1.Controls.Add(this.savePeople);
            this.panel1.Controls.Add(this.DoljCombo);
            this.panel1.Controls.Add(this.FIOtext);
            this.panel1.Controls.Add(this.SpecialCombo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 262);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.searchDate);
            this.panel2.Controls.Add(this.searchPeople);
            this.panel2.Controls.Add(this.searchDoljcombo);
            this.panel2.Controls.Add(this.searchTextFio);
            this.panel2.Controls.Add(this.searchComboSpecial);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 267);
            this.panel2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "ФИО";
            // 
            // searchDate
            // 
            this.searchDate.Location = new System.Drawing.Point(15, 169);
            this.searchDate.Name = "searchDate";
            this.searchDate.Size = new System.Drawing.Size(256, 20);
            this.searchDate.TabIndex = 23;
            // 
            // searchPeople
            // 
            this.searchPeople.Location = new System.Drawing.Point(15, 195);
            this.searchPeople.Name = "searchPeople";
            this.searchPeople.Size = new System.Drawing.Size(256, 54);
            this.searchPeople.TabIndex = 15;
            this.searchPeople.Text = "button2";
            this.searchPeople.UseVisualStyleBackColor = true;
            // 
            // searchDoljcombo
            // 
            this.searchDoljcombo.FormattingEnabled = true;
            this.searchDoljcombo.Location = new System.Drawing.Point(15, 125);
            this.searchDoljcombo.Name = "searchDoljcombo";
            this.searchDoljcombo.Size = new System.Drawing.Size(256, 21);
            this.searchDoljcombo.TabIndex = 22;
            // 
            // searchTextFio
            // 
            this.searchTextFio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextFio.Location = new System.Drawing.Point(15, 31);
            this.searchTextFio.Name = "searchTextFio";
            this.searchTextFio.Size = new System.Drawing.Size(256, 23);
            this.searchTextFio.TabIndex = 16;
            // 
            // searchComboSpecial
            // 
            this.searchComboSpecial.FormattingEnabled = true;
            this.searchComboSpecial.Location = new System.Drawing.Point(15, 77);
            this.searchComboSpecial.Name = "searchComboSpecial";
            this.searchComboSpecial.Size = new System.Drawing.Size(256, 21);
            this.searchComboSpecial.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Специальность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Дата найма";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Должность";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(308, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 535);
            this.panel3.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 552);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button savePeople;
        private System.Windows.Forms.TextBox FIOtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SpecialCombo;
        private System.Windows.Forms.ComboBox DoljCombo;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker searchDate;
        private System.Windows.Forms.Button searchPeople;
        private System.Windows.Forms.ComboBox searchDoljcombo;
        private System.Windows.Forms.TextBox searchTextFio;
        private System.Windows.Forms.ComboBox searchComboSpecial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
    }
}

