
namespace KursLabTRPK.Controller
{
    partial class Service_book
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_Search_Book = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Form_AKT = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbNumberPhone = new CueTextBox();
            this.tbDriveLicense = new CueTextBox();
            this.tbFIO = new CueTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbMileage = new CueTextBox();
            this.tbEngine = new CueTextBox();
            this.tbVINNumber = new CueTextBox();
            this.tbGosNumber = new CueTextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.tbMark = new CueTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.bAddTO = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Search_Book,
            this.ToolStripMenuItem_Form_AKT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_Search_Book
            // 
            this.toolStripMenuItem_Search_Book.Name = "toolStripMenuItem_Search_Book";
            this.toolStripMenuItem_Search_Book.Size = new System.Drawing.Size(200, 24);
            this.toolStripMenuItem_Search_Book.Text = "Найти сервисную книжку";
            this.toolStripMenuItem_Search_Book.Click += new System.EventHandler(this.toolStripMenuItem_Search_Book_Click);
            // 
            // ToolStripMenuItem_Form_AKT
            // 
            this.ToolStripMenuItem_Form_AKT.Name = "ToolStripMenuItem_Form_AKT";
            this.ToolStripMenuItem_Form_AKT.Size = new System.Drawing.Size(153, 24);
            this.ToolStripMenuItem_Form_AKT.Text = "Сформировать акт";
            this.ToolStripMenuItem_Form_AKT.Click += new System.EventHandler(this.ToolStripMenuItem_Form_AKT_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbNumberPhone);
            this.panel2.Controls.Add(this.tbDriveLicense);
            this.panel2.Controls.Add(this.tbFIO);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(524, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 262);
            this.panel2.TabIndex = 17;
            // 
            // tbNumberPhone
            // 
            this.tbNumberPhone.Cue = "";
            this.tbNumberPhone.Location = new System.Drawing.Point(247, 130);
            this.tbNumberPhone.Name = "tbNumberPhone";
            this.tbNumberPhone.ReadOnly = true;
            this.tbNumberPhone.Size = new System.Drawing.Size(203, 22);
            this.tbNumberPhone.TabIndex = 10;
            // 
            // tbDriveLicense
            // 
            this.tbDriveLicense.Cue = "";
            this.tbDriveLicense.Location = new System.Drawing.Point(247, 100);
            this.tbDriveLicense.Name = "tbDriveLicense";
            this.tbDriveLicense.ReadOnly = true;
            this.tbDriveLicense.Size = new System.Drawing.Size(203, 22);
            this.tbDriveLicense.TabIndex = 9;
            // 
            // tbFIO
            // 
            this.tbFIO.Cue = "";
            this.tbFIO.Location = new System.Drawing.Point(247, 69);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.ReadOnly = true;
            this.tbFIO.Size = new System.Drawing.Size(204, 22);
            this.tbFIO.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(31, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Водительские права:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(58, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(392, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Информация об владельце автомобиля";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(67, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 22);
            this.label13.TabIndex = 2;
            this.label13.Text = "ФИО владельца:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(69, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 22);
            this.label15.TabIndex = 4;
            this.label15.Text = "Номер телефона:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbMileage);
            this.panel1.Controls.Add(this.tbEngine);
            this.panel1.Controls.Add(this.tbVINNumber);
            this.panel1.Controls.Add(this.tbGosNumber);
            this.panel1.Controls.Add(this.dateTime);
            this.panel1.Controls.Add(this.tbMark);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(11, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 262);
            this.panel1.TabIndex = 16;
            // 
            // tbMileage
            // 
            this.tbMileage.Cue = "";
            this.tbMileage.Location = new System.Drawing.Point(234, 209);
            this.tbMileage.Name = "tbMileage";
            this.tbMileage.ReadOnly = true;
            this.tbMileage.Size = new System.Drawing.Size(204, 22);
            this.tbMileage.TabIndex = 13;
            // 
            // tbEngine
            // 
            this.tbEngine.Cue = "";
            this.tbEngine.Location = new System.Drawing.Point(234, 185);
            this.tbEngine.Name = "tbEngine";
            this.tbEngine.ReadOnly = true;
            this.tbEngine.Size = new System.Drawing.Size(204, 22);
            this.tbEngine.TabIndex = 12;
            // 
            // tbVINNumber
            // 
            this.tbVINNumber.Cue = "";
            this.tbVINNumber.Location = new System.Drawing.Point(235, 159);
            this.tbVINNumber.Name = "tbVINNumber";
            this.tbVINNumber.ReadOnly = true;
            this.tbVINNumber.Size = new System.Drawing.Size(204, 22);
            this.tbVINNumber.TabIndex = 11;
            // 
            // tbGosNumber
            // 
            this.tbGosNumber.Cue = "";
            this.tbGosNumber.Location = new System.Drawing.Point(234, 131);
            this.tbGosNumber.Name = "tbGosNumber";
            this.tbGosNumber.ReadOnly = true;
            this.tbGosNumber.Size = new System.Drawing.Size(204, 22);
            this.tbGosNumber.TabIndex = 10;
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "yyyy";
            this.dateTime.Enabled = false;
            this.dateTime.Location = new System.Drawing.Point(235, 99);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(204, 22);
            this.dateTime.TabIndex = 9;
            // 
            // tbMark
            // 
            this.tbMark.Cue = "";
            this.tbMark.Location = new System.Drawing.Point(235, 68);
            this.tbMark.Name = "tbMark";
            this.tbMark.ReadOnly = true;
            this.tbMark.Size = new System.Drawing.Size(204, 22);
            this.tbMark.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(98, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Год выпуска:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(147, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Пробег:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(97, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Информация об автомобиле";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(59, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Объем двигателя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(147, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Марка:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "VIN номер автомобиля:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Гос. номер автомобиля:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(313, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Сервисная книжка автомобиля";
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.mileage,
            this.date_event,
            this.typeTO,
            this.masterFIO});
            this.Table.Location = new System.Drawing.Point(12, 463);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(939, 248);
            this.Table.TabIndex = 18;
            this.Table.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GetTOHistory);
            // 
            // number
            // 
            this.number.HeaderText = "№";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 50;
            // 
            // mileage
            // 
            this.mileage.HeaderText = "Пробег";
            this.mileage.MinimumWidth = 6;
            this.mileage.Name = "mileage";
            this.mileage.ReadOnly = true;
            this.mileage.Width = 125;
            // 
            // date_event
            // 
            this.date_event.HeaderText = "Дата проведения";
            this.date_event.MinimumWidth = 6;
            this.date_event.Name = "date_event";
            this.date_event.ReadOnly = true;
            this.date_event.Width = 150;
            // 
            // typeTO
            // 
            this.typeTO.HeaderText = "Тип ТО";
            this.typeTO.MinimumWidth = 6;
            this.typeTO.Name = "typeTO";
            this.typeTO.ReadOnly = true;
            this.typeTO.Width = 125;
            // 
            // masterFIO
            // 
            this.masterFIO.HeaderText = "ФИО мастера приемщика";
            this.masterFIO.MinimumWidth = 6;
            this.masterFIO.Name = "masterFIO";
            this.masterFIO.ReadOnly = true;
            this.masterFIO.Width = 200;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(388, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(311, 33);
            this.label10.TabIndex = 19;
            this.label10.Text = "Список проведенных ТО";
            // 
            // bAddTO
            // 
            this.bAddTO.Font = new System.Drawing.Font("Dungeon", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddTO.Location = new System.Drawing.Point(11, 367);
            this.bAddTO.Name = "bAddTO";
            this.bAddTO.Size = new System.Drawing.Size(365, 74);
            this.bAddTO.TabIndex = 20;
            this.bAddTO.Text = "Добавить новый Технический осмотр";
            this.bAddTO.UseVisualStyleBackColor = true;
            this.bAddTO.Click += new System.EventHandler(this.bAddTO_Click);
            // 
            // Service_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 723);
            this.Controls.Add(this.bAddTO);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Service_book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сервисная книжка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Service_book_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Search_Book;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Form_AKT;
        private System.Windows.Forms.Panel panel2;
        private CueTextBox tbNumberPhone;
        private CueTextBox tbDriveLicense;
        private CueTextBox tbFIO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private CueTextBox tbMileage;
        private CueTextBox tbEngine;
        private CueTextBox tbVINNumber;
        private CueTextBox tbGosNumber;
        private System.Windows.Forms.DateTimePicker dateTime;
        private CueTextBox tbMark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bAddTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn mileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_event;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterFIO;
    }
}