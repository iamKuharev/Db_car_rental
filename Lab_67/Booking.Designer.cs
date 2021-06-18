
namespace lab67
{
    partial class Boocking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PaymentMethod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idClientEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idCarsEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DurationFrom = new System.Windows.Forms.DateTimePicker();
            this.DurationTo = new System.Windows.Forms.DateTimePicker();
            this.Pledge = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.BoockingGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoockingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.Location = new System.Drawing.Point(117, 68);
            this.PaymentMethod.Margin = new System.Windows.Forms.Padding(2);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(141, 20);
            this.PaymentMethod.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Payment method";
            // 
            // idClientEdit
            // 
            this.idClientEdit.Location = new System.Drawing.Point(642, 18);
            this.idClientEdit.Margin = new System.Windows.Forms.Padding(2);
            this.idClientEdit.Name = "idClientEdit";
            this.idClientEdit.Size = new System.Drawing.Size(24, 20);
            this.idClientEdit.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "idClient";
            // 
            // idCarsEdit
            // 
            this.idCarsEdit.Location = new System.Drawing.Point(642, 65);
            this.idCarsEdit.Margin = new System.Windows.Forms.Padding(2);
            this.idCarsEdit.Name = "idCarsEdit";
            this.idCarsEdit.Size = new System.Drawing.Size(24, 20);
            this.idCarsEdit.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "id Cars";
            // 
            // DurationFrom
            // 
            this.DurationFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DurationFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DurationFrom.Location = new System.Drawing.Point(117, 19);
            this.DurationFrom.Name = "DurationFrom";
            this.DurationFrom.Size = new System.Drawing.Size(141, 20);
            this.DurationFrom.TabIndex = 76;
            // 
            // DurationTo
            // 
            this.DurationTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DurationTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DurationTo.Location = new System.Drawing.Point(353, 19);
            this.DurationTo.Name = "DurationTo";
            this.DurationTo.Size = new System.Drawing.Size(141, 20);
            this.DurationTo.TabIndex = 75;
            // 
            // Pledge
            // 
            this.Pledge.Location = new System.Drawing.Point(353, 72);
            this.Pledge.Name = "Pledge";
            this.Pledge.Size = new System.Drawing.Size(141, 20);
            this.Pledge.TabIndex = 77;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(582, 229);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 32);
            this.deleteButton.TabIndex = 68;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(582, 176);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(99, 32);
            this.updateButton.TabIndex = 67;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(582, 122);
            this.insertButton.Margin = new System.Windows.Forms.Padding(2);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(99, 32);
            this.insertButton.TabIndex = 66;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // BoockingGrid
            // 
            this.BoockingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BoockingGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.BoockingGrid.Location = new System.Drawing.Point(11, 113);
            this.BoockingGrid.Margin = new System.Windows.Forms.Padding(2);
            this.BoockingGrid.Name = "BoockingGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BoockingGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.BoockingGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.BoockingGrid.RowTemplate.Height = 24;
            this.BoockingGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BoockingGrid.Size = new System.Drawing.Size(550, 167);
            this.BoockingGrid.TabIndex = 65;
            this.BoockingGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BoockingGrid_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Pledge";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "duration from";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "duration to";
            // 
            // Boocking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 291);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PaymentMethod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idClientEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idCarsEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DurationTo);
            this.Controls.Add(this.DurationFrom);
            this.Controls.Add(this.Pledge);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.BoockingGrid);
            this.Name = "Boocking";
            this.Text = "Boocking";
            this.Load += new System.EventHandler(this.Boocking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoockingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PaymentMethod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idClientEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idCarsEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pledge;
        public System.Windows.Forms.DateTimePicker DurationFrom;
        public System.Windows.Forms.DateTimePicker DurationTo;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.DataGridView BoockingGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}