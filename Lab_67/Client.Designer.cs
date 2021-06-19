
using System;
using System.Windows.Forms;

namespace lab67
{
    partial class Client
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
            this.PassportEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DriverIcense = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PlaceOfResidenceEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FullNameEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.PhoneNumberEdit = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.ClientGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PassportEdit
            // 
            this.PassportEdit.Location = new System.Drawing.Point(485, 20);
            this.PassportEdit.Margin = new System.Windows.Forms.Padding(2);
            this.PassportEdit.Name = "PassportEdit";
            this.PassportEdit.Size = new System.Drawing.Size(148, 20);
            this.PassportEdit.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Passport";
            // 
            // DriverIcense
            // 
            this.DriverIcense.Location = new System.Drawing.Point(485, 58);
            this.DriverIcense.Margin = new System.Windows.Forms.Padding(2);
            this.DriverIcense.Name = "DriverIcense";
            this.DriverIcense.Size = new System.Drawing.Size(148, 20);
            this.DriverIcense.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Driver\'s_icense";
            // 
            // PlaceOfResidenceEdit
            // 
            this.PlaceOfResidenceEdit.Location = new System.Drawing.Point(109, 55);
            this.PlaceOfResidenceEdit.Margin = new System.Windows.Forms.Padding(2);
            this.PlaceOfResidenceEdit.Name = "PlaceOfResidenceEdit";
            this.PlaceOfResidenceEdit.Size = new System.Drawing.Size(148, 20);
            this.PlaceOfResidenceEdit.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Place of residence";
            // 
            // FullNameEdit
            // 
            this.FullNameEdit.Location = new System.Drawing.Point(109, 20);
            this.FullNameEdit.Margin = new System.Windows.Forms.Padding(2);
            this.FullNameEdit.Name = "FullNameEdit";
            this.FullNameEdit.Size = new System.Drawing.Size(148, 20);
            this.FullNameEdit.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Full name";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.CustomFormat = "yyyy-MM-dd";
            this.DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfBirth.Location = new System.Drawing.Point(109, 90);
            this.DateOfBirth.Margin = new System.Windows.Forms.Padding(2);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(148, 20);
            this.DateOfBirth.TabIndex = 50;
            // 
            // PhoneNumberEdit
            // 
            this.PhoneNumberEdit.Location = new System.Drawing.Point(485, 90);
            this.PhoneNumberEdit.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneNumberEdit.Name = "PhoneNumberEdit";
            this.PhoneNumberEdit.Size = new System.Drawing.Size(148, 20);
            this.PhoneNumberEdit.TabIndex = 90;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(662, 226);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(99, 32);
            this.updateButton.TabIndex = 79;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(662, 190);
            this.insertButton.Margin = new System.Windows.Forms.Padding(2);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(99, 32);
            this.insertButton.TabIndex = 78;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(662, 263);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 32);
            this.deleteButton.TabIndex = 93;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ClientGrid
            // 
            this.ClientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClientGrid.Location = new System.Drawing.Point(13, 123);
            this.ClientGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ClientGrid.Name = "ClientGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ClientGrid.RowHeadersWidth = 49;
            this.ClientGrid.RowTemplate.Height = 24;
            this.ClientGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientGrid.Size = new System.Drawing.Size(622, 228);
            this.ClientGrid.TabIndex = 77;
            this.ClientGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGrid_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Date of birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 92;
            this.label6.Text = "Phone number";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 374);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassportEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DriverIcense);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlaceOfResidenceEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FullNameEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.PhoneNumberEdit);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.ClientGrid);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        #endregion

        private System.Windows.Forms.TextBox PassportEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DriverIcense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PlaceOfResidenceEdit;
        private System.Windows.Forms.TextBox PhoneNumberEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FullNameEdit;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView ClientGrid;
        private Label label3;
        private Label label6;
    }
}