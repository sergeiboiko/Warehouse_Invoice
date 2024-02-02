namespace Invoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.invoice_number_label = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sender_company_name_label = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.waybill_date_picker = new System.Windows.Forms.DateTimePicker();
            this.sender_phone_number_label = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sender_email_label = new System.Windows.Forms.TextBox();
            this.sender_adress_label = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.warehouse_name_label = new System.Windows.Forms.TextBox();
            this.recipient_email_label = new System.Windows.Forms.TextBox();
            this.recipient_adress_label = new System.Windows.Forms.TextBox();
            this.recipient_phone_number_label = new System.Windows.Forms.TextBox();
            this.recipient_company_name_label = new System.Windows.Forms.TextBox();
            this.total_label = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.notes_label = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_of_podukts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units_of_measurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save_table = new System.Windows.Forms.Button();
            this.print_table = new System.Windows.Forms.Button();
            this.add_row_button = new System.Windows.Forms.Button();
            this.delete_row_button = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рахунок-фактура на склад №";
            // 
            // invoice_number_label
            // 
            this.invoice_number_label.BackColor = System.Drawing.SystemColors.Control;
            this.invoice_number_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoice_number_label.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.invoice_number_label.ForeColor = System.Drawing.SystemColors.InfoText;
            this.invoice_number_label.Location = new System.Drawing.Point(350, 16);
            this.invoice_number_label.MaxLength = 6;
            this.invoice_number_label.Name = "invoice_number_label";
            this.invoice_number_label.Size = new System.Drawing.Size(83, 36);
            this.invoice_number_label.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата:";
            // 
            // sender_company_name_label
            // 
            this.sender_company_name_label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sender_company_name_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sender_company_name_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sender_company_name_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.sender_company_name_label.Location = new System.Drawing.Point(17, 147);
            this.sender_company_name_label.Name = "sender_company_name_label";
            this.sender_company_name_label.Size = new System.Drawing.Size(275, 20);
            this.sender_company_name_label.TabIndex = 5;
            this.sender_company_name_label.Text = "Назва компанії";
            this.sender_company_name_label.TextChanged += new System.EventHandler(this.sender_company_name_label_TextChanged);
            this.sender_company_name_label.Enter += new System.EventHandler(this.sender_company_name_label_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Відомості про відправника:";
            // 
            // waybill_date_picker
            // 
            this.waybill_date_picker.CalendarFont = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waybill_date_picker.CalendarForeColor = System.Drawing.SystemColors.WindowFrame;
            this.waybill_date_picker.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.waybill_date_picker.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waybill_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.waybill_date_picker.Location = new System.Drawing.Point(17, 89);
            this.waybill_date_picker.Name = "waybill_date_picker";
            this.waybill_date_picker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.waybill_date_picker.Size = new System.Drawing.Size(108, 22);
            this.waybill_date_picker.TabIndex = 6;
            this.waybill_date_picker.Value = new System.DateTime(2024, 1, 31, 0, 0, 0, 0);
            // 
            // sender_phone_number_label
            // 
            this.sender_phone_number_label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sender_phone_number_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sender_phone_number_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sender_phone_number_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.sender_phone_number_label.Location = new System.Drawing.Point(17, 173);
            this.sender_phone_number_label.Name = "sender_phone_number_label";
            this.sender_phone_number_label.Size = new System.Drawing.Size(275, 20);
            this.sender_phone_number_label.TabIndex = 7;
            this.sender_phone_number_label.Text = "(380)-XXX-XXX-XX-XX";
            this.sender_phone_number_label.TextChanged += new System.EventHandler(this.sender_phone_number_label_TextChanged);
            this.sender_phone_number_label.Enter += new System.EventHandler(this.sender_phone_number_label_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 10.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(348, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Відомості про одержувача:";
            // 
            // sender_email_label
            // 
            this.sender_email_label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sender_email_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sender_email_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sender_email_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.sender_email_label.Location = new System.Drawing.Point(17, 225);
            this.sender_email_label.Name = "sender_email_label";
            this.sender_email_label.Size = new System.Drawing.Size(275, 20);
            this.sender_email_label.TabIndex = 13;
            this.sender_email_label.Text = "Email";
            this.sender_email_label.TextChanged += new System.EventHandler(this.sender_email_label_TextChanged);
            this.sender_email_label.Enter += new System.EventHandler(this.sender_email_label_Enter);
            // 
            // sender_adress_label
            // 
            this.sender_adress_label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sender_adress_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sender_adress_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sender_adress_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.sender_adress_label.Location = new System.Drawing.Point(17, 199);
            this.sender_adress_label.Name = "sender_adress_label";
            this.sender_adress_label.Size = new System.Drawing.Size(275, 20);
            this.sender_adress_label.TabIndex = 12;
            this.sender_adress_label.Text = "Адреса";
            this.sender_adress_label.TextChanged += new System.EventHandler(this.sender_adress_label_TextChanged);
            this.sender_adress_label.Enter += new System.EventHandler(this.sender_adress_label_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 10.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(13, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Список вантажів:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 10.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(348, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 64;
            this.label7.Text = "Склад";
            // 
            // warehouse_name_label
            // 
            this.warehouse_name_label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.warehouse_name_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warehouse_name_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warehouse_name_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.warehouse_name_label.Location = new System.Drawing.Point(352, 89);
            this.warehouse_name_label.Name = "warehouse_name_label";
            this.warehouse_name_label.Size = new System.Drawing.Size(275, 20);
            this.warehouse_name_label.TabIndex = 65;
            this.warehouse_name_label.Text = "Назва складу";
            this.warehouse_name_label.TextChanged += new System.EventHandler(this.warehouse_name_label_TextChanged);
            this.warehouse_name_label.Enter += new System.EventHandler(this.warehouse_name_label_Enter);
            this.warehouse_name_label.Leave += new System.EventHandler(this.warehouse_name_label_Leave);
            // 
            // recipient_email_label
            // 
            this.recipient_email_label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.recipient_email_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recipient_email_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipient_email_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.recipient_email_label.Location = new System.Drawing.Point(352, 225);
            this.recipient_email_label.Name = "recipient_email_label";
            this.recipient_email_label.Size = new System.Drawing.Size(275, 20);
            this.recipient_email_label.TabIndex = 69;
            this.recipient_email_label.Text = "Email";
            this.recipient_email_label.TextChanged += new System.EventHandler(this.recipient_email_label_TextChanged);
            this.recipient_email_label.Enter += new System.EventHandler(this.recipient_email_label_Enter);
            // 
            // recipient_adress_label
            // 
            this.recipient_adress_label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.recipient_adress_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recipient_adress_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipient_adress_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.recipient_adress_label.Location = new System.Drawing.Point(352, 199);
            this.recipient_adress_label.Name = "recipient_adress_label";
            this.recipient_adress_label.Size = new System.Drawing.Size(275, 20);
            this.recipient_adress_label.TabIndex = 68;
            this.recipient_adress_label.Text = "Адреса";
            this.recipient_adress_label.TextChanged += new System.EventHandler(this.recipient_adress_label_TextChanged);
            this.recipient_adress_label.Enter += new System.EventHandler(this.recipient_adress_label_Enter);
            // 
            // recipient_phone_number_label
            // 
            this.recipient_phone_number_label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.recipient_phone_number_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recipient_phone_number_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipient_phone_number_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.recipient_phone_number_label.Location = new System.Drawing.Point(352, 173);
            this.recipient_phone_number_label.Name = "recipient_phone_number_label";
            this.recipient_phone_number_label.Size = new System.Drawing.Size(275, 20);
            this.recipient_phone_number_label.TabIndex = 67;
            this.recipient_phone_number_label.Text = "(380)-XXX-XXX-XX-XX";
            this.recipient_phone_number_label.TextChanged += new System.EventHandler(this.recipient_phone_number_label_TextChanged);
            this.recipient_phone_number_label.Enter += new System.EventHandler(this.recipient_phone_number_label_Enter);
            // 
            // recipient_company_name_label
            // 
            this.recipient_company_name_label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.recipient_company_name_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recipient_company_name_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipient_company_name_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.recipient_company_name_label.Location = new System.Drawing.Point(352, 147);
            this.recipient_company_name_label.Name = "recipient_company_name_label";
            this.recipient_company_name_label.Size = new System.Drawing.Size(275, 20);
            this.recipient_company_name_label.TabIndex = 66;
            this.recipient_company_name_label.Text = "Назва компанії";
            this.recipient_company_name_label.TextChanged += new System.EventHandler(this.recipient_company_name_label_TextChanged);
            this.recipient_company_name_label.Enter += new System.EventHandler(this.recipient_company_name_label_Enter);
            // 
            // total_label
            // 
            this.total_label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.total_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.total_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.total_label.Location = new System.Drawing.Point(107, 506);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(226, 20);
            this.total_label.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 10.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Підсумок:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 10.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(13, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 72;
            this.label8.Text = "*Нотатки";
            // 
            // notes_label
            // 
            this.notes_label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.notes_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notes_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notes_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.notes_label.Location = new System.Drawing.Point(17, 566);
            this.notes_label.Name = "notes_label";
            this.notes_label.Size = new System.Drawing.Size(226, 20);
            this.notes_label.TabIndex = 73;
            this.notes_label.Text = "Чим ви хочете поділитися?";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_name,
            this.Number_of_podukts,
            this.Units_of_measurement,
            this.Weight,
            this.Volume});
            this.dataGridView1.Location = new System.Drawing.Point(17, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 172);
            this.dataGridView1.TabIndex = 74;
            // 
            // Product_name
            // 
            this.Product_name.HeaderText = "Опис продукту";
            this.Product_name.Name = "Product_name";
            this.Product_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Product_name.Width = 216;
            // 
            // Number_of_podukts
            // 
            this.Number_of_podukts.HeaderText = "К-ть";
            this.Number_of_podukts.Name = "Number_of_podukts";
            this.Number_of_podukts.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Number_of_podukts.Width = 75;
            // 
            // Units_of_measurement
            // 
            this.Units_of_measurement.HeaderText = "Одиниці виміру";
            this.Units_of_measurement.Name = "Units_of_measurement";
            this.Units_of_measurement.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Units_of_measurement.Width = 75;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Вага(кг)";
            this.Weight.Name = "Weight";
            this.Weight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Volume
            // 
            this.Volume.HeaderText = "Об\'єм (м3)";
            this.Volume.Name = "Volume";
            this.Volume.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // save_table
            // 
            this.save_table.Location = new System.Drawing.Point(633, 361);
            this.save_table.Name = "save_table";
            this.save_table.Size = new System.Drawing.Size(119, 23);
            this.save_table.TabIndex = 75;
            this.save_table.Text = "Збереження таблиці";
            this.save_table.UseVisualStyleBackColor = true;
            this.save_table.Click += new System.EventHandler(this.save_table_Click);
            // 
            // print_table
            // 
            this.print_table.Location = new System.Drawing.Point(633, 390);
            this.print_table.Name = "print_table";
            this.print_table.Size = new System.Drawing.Size(119, 23);
            this.print_table.TabIndex = 76;
            this.print_table.Text = "Друк таблиці";
            this.print_table.UseVisualStyleBackColor = true;
            // 
            // add_row_button
            // 
            this.add_row_button.Location = new System.Drawing.Point(633, 303);
            this.add_row_button.Name = "add_row_button";
            this.add_row_button.Size = new System.Drawing.Size(119, 23);
            this.add_row_button.TabIndex = 77;
            this.add_row_button.Text = "Додавання рядка";
            this.add_row_button.UseVisualStyleBackColor = true;
            this.add_row_button.Click += new System.EventHandler(this.add_row_button_Click);
            // 
            // delete_row_button
            // 
            this.delete_row_button.Location = new System.Drawing.Point(633, 332);
            this.delete_row_button.Name = "delete_row_button";
            this.delete_row_button.Size = new System.Drawing.Size(119, 23);
            this.delete_row_button.TabIndex = 78;
            this.delete_row_button.Text = "Видалення рядка";
            this.delete_row_button.UseVisualStyleBackColor = true;
            this.delete_row_button.Click += new System.EventHandler(this.delete_row_button_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(17, 361);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(735, 150);
            this.dataGridView2.TabIndex = 79;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 613);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.delete_row_button);
            this.Controls.Add(this.add_row_button);
            this.Controls.Add(this.print_table);
            this.Controls.Add(this.save_table);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.notes_label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.recipient_email_label);
            this.Controls.Add(this.recipient_adress_label);
            this.Controls.Add(this.recipient_phone_number_label);
            this.Controls.Add(this.recipient_company_name_label);
            this.Controls.Add(this.warehouse_name_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sender_email_label);
            this.Controls.Add(this.sender_adress_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sender_phone_number_label);
            this.Controls.Add(this.waybill_date_picker);
            this.Controls.Add(this.sender_company_name_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.invoice_number_label);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox invoice_number_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sender_company_name_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker waybill_date_picker;
        private System.Windows.Forms.TextBox sender_phone_number_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sender_email_label;
        private System.Windows.Forms.TextBox sender_adress_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox warehouse_name_label;
        private System.Windows.Forms.TextBox recipient_email_label;
        private System.Windows.Forms.TextBox recipient_adress_label;
        private System.Windows.Forms.TextBox recipient_phone_number_label;
        private System.Windows.Forms.TextBox recipient_company_name_label;
        private System.Windows.Forms.TextBox total_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox notes_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button save_table;
        private System.Windows.Forms.Button print_table;
        private System.Windows.Forms.Button add_row_button;
        private System.Windows.Forms.Button delete_row_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_of_podukts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units_of_measurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

