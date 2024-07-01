namespace WeatherApp
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
            this.label_city_country = new System.Windows.Forms.Label();
            this.label_temp = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label_windspeed = new System.Windows.Forms.Label();
            this.label_pressure = new System.Windows.Forms.Label();
            this.label_humidity = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_winddeg = new System.Windows.Forms.Label();
            this.label_visibility = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_city_country
            // 
            this.label_city_country.AutoSize = true;
            this.label_city_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_city_country.Location = new System.Drawing.Point(12, 128);
            this.label_city_country.Name = "label_city_country";
            this.label_city_country.Size = new System.Drawing.Size(256, 36);
            this.label_city_country.TabIndex = 1;
            this.label_city_country.Text = "Страна и город";
            // 
            // label_temp
            // 
            this.label_temp.AutoSize = true;
            this.label_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_temp.Location = new System.Drawing.Point(12, 177);
            this.label_temp.Name = "label_temp";
            this.label_temp.Size = new System.Drawing.Size(202, 32);
            this.label_temp.TabIndex = 4;
            this.label_temp.Text = "Температура";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(416, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(356, 246);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label_windspeed
            // 
            this.label_windspeed.AutoSize = true;
            this.label_windspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_windspeed.Location = new System.Drawing.Point(12, 276);
            this.label_windspeed.Name = "label_windspeed";
            this.label_windspeed.Size = new System.Drawing.Size(236, 32);
            this.label_windspeed.TabIndex = 5;
            this.label_windspeed.Text = "Скорость ветра";
            // 
            // label_pressure
            // 
            this.label_pressure.AutoSize = true;
            this.label_pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pressure.Location = new System.Drawing.Point(12, 364);
            this.label_pressure.Name = "label_pressure";
            this.label_pressure.Size = new System.Drawing.Size(213, 32);
            this.label_pressure.TabIndex = 6;
            this.label_pressure.Text = "Атм давление";
            // 
            // label_humidity
            // 
            this.label_humidity.AutoSize = true;
            this.label_humidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_humidity.Location = new System.Drawing.Point(12, 226);
            this.label_humidity.Name = "label_humidity";
            this.label_humidity.Size = new System.Drawing.Size(169, 32);
            this.label_humidity.TabIndex = 7;
            this.label_humidity.Text = "Влажность";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Donetsk",
            "Makiivka",
            "Yenakiieve",
            "Volnovakha",
            "Horlivka"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 39);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Выберите город";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_winddeg
            // 
            this.label_winddeg.AutoSize = true;
            this.label_winddeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_winddeg.Location = new System.Drawing.Point(12, 322);
            this.label_winddeg.Name = "label_winddeg";
            this.label_winddeg.Size = new System.Drawing.Size(294, 32);
            this.label_winddeg.TabIndex = 11;
            this.label_winddeg.Text = "Направление ветра";
            // 
            // label_visibility
            // 
            this.label_visibility.AutoSize = true;
            this.label_visibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_visibility.Location = new System.Drawing.Point(12, 409);
            this.label_visibility.Name = "label_visibility";
            this.label_visibility.Size = new System.Drawing.Size(169, 32);
            this.label_visibility.TabIndex = 12;
            this.label_visibility.Text = "Видимость";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_visibility);
            this.Controls.Add(this.label_winddeg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_humidity);
            this.Controls.Add(this.label_pressure);
            this.Controls.Add(this.label_windspeed);
            this.Controls.Add(this.label_temp);
            this.Controls.Add(this.label_city_country);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_city_country;
        private System.Windows.Forms.Label label_temp;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label_windspeed;
        private System.Windows.Forms.Label label_pressure;
        private System.Windows.Forms.Label label_humidity;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_winddeg;
        private System.Windows.Forms.Label label_visibility;
    }
}

