
namespace lab67
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PolularBrandBtn = new System.Windows.Forms.Button();
            this.CarsToBoockingBtn = new System.Windows.Forms.Button();
            this.toClientBtn = new System.Windows.Forms.Button();
            this.toBoockingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Выполнение SQL-скриптов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Работа с таблицами";
            // 
            // PolularBrandBtn
            // 
            this.PolularBrandBtn.Location = new System.Drawing.Point(507, 60);
            this.PolularBrandBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PolularBrandBtn.Name = "showInsuranceBtn";
            this.PolularBrandBtn.Size = new System.Drawing.Size(121, 47);
            this.PolularBrandBtn.TabIndex = 38;
            this.PolularBrandBtn.Text = "Вывести статистику выбираемых брендов";
            this.PolularBrandBtn.UseVisualStyleBackColor = true;
            this.PolularBrandBtn.Click += new System.EventHandler(this.PolularBrandBtn_Click);
            // 
            // CarsToBoockingBtn
            // 
            this.CarsToBoockingBtn.Location = new System.Drawing.Point(339, 60);
            this.CarsToBoockingBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CarsToBoockingBtn.Name = "showClientsBtn";
            this.CarsToBoockingBtn.Size = new System.Drawing.Size(122, 47);
            this.CarsToBoockingBtn.TabIndex = 37;
            this.CarsToBoockingBtn.Text = "Вывести список забронированных автомобилей автомобили";
            this.CarsToBoockingBtn.UseVisualStyleBackColor = true;
            this.CarsToBoockingBtn.Click += new System.EventHandler(this.CarsToBoockingBtn_Click);
            // 
            // toClientBtn
            // 
            this.toClientBtn.Location = new System.Drawing.Point(11, 60);
            this.toClientBtn.Margin = new System.Windows.Forms.Padding(2);
            this.toClientBtn.Name = "toClientBtn";
            this.toClientBtn.Size = new System.Drawing.Size(124, 47);
            this.toClientBtn.TabIndex = 34;
            this.toClientBtn.Text = "Перейти к Client";
            this.toClientBtn.UseVisualStyleBackColor = true;
            this.toClientBtn.Click += new System.EventHandler(this.toClientBtn_Click);
            // 
            // toBoockingBtn
            // 
            this.toBoockingBtn.Location = new System.Drawing.Point(167, 60);
            this.toBoockingBtn.Margin = new System.Windows.Forms.Padding(2);
            this.toBoockingBtn.Name = "toInsuranceBtn";
            this.toBoockingBtn.Size = new System.Drawing.Size(127, 47);
            this.toBoockingBtn.TabIndex = 33;
            this.toBoockingBtn.Text = "Перейти к бронированию";
            this.toBoockingBtn.UseVisualStyleBackColor = true;
            this.toBoockingBtn.Click += new System.EventHandler(this.toBoockingBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 133);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PolularBrandBtn);
            this.Controls.Add(this.CarsToBoockingBtn);
            this.Controls.Add(this.toClientBtn);
            this.Controls.Add(this.toBoockingBtn);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PolularBrandBtn;
        private System.Windows.Forms.Button CarsToBoockingBtn;
        private System.Windows.Forms.Button toClientBtn;
        private System.Windows.Forms.Button toBoockingBtn;
    }
}

