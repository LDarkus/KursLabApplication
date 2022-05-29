
namespace KursLabTRPK.Controller
{
    partial class Search_service_book
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
            this.tbNumber_Book = new CueTextBox();
            this.cbCriterion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bSearch_Book = new System.Windows.Forms.Button();
            this.bAddNewBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNumber_Book
            // 
            this.tbNumber_Book.Cue = "Введите номер";
            this.tbNumber_Book.Location = new System.Drawing.Point(58, 132);
            this.tbNumber_Book.Name = "tbNumber_Book";
            this.tbNumber_Book.Size = new System.Drawing.Size(217, 22);
            this.tbNumber_Book.TabIndex = 0;
            // 
            // cbCriterion
            // 
            this.cbCriterion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriterion.FormattingEnabled = true;
            this.cbCriterion.Items.AddRange(new object[] {
            "По Гос. номеру",
            "По VIN номеру"});
            this.cbCriterion.Location = new System.Drawing.Point(58, 102);
            this.cbCriterion.Name = "cbCriterion";
            this.cbCriterion.Size = new System.Drawing.Size(217, 24);
            this.cbCriterion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите критерий поиска";
            // 
            // bSearch_Book
            // 
            this.bSearch_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSearch_Book.Location = new System.Drawing.Point(58, 170);
            this.bSearch_Book.Name = "bSearch_Book";
            this.bSearch_Book.Size = new System.Drawing.Size(217, 51);
            this.bSearch_Book.TabIndex = 3;
            this.bSearch_Book.Text = "Найти книжку";
            this.bSearch_Book.UseVisualStyleBackColor = true;
            this.bSearch_Book.Click += new System.EventHandler(this.bSearch_Book_Click);
            // 
            // bAddNewBook
            // 
            this.bAddNewBook.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddNewBook.Location = new System.Drawing.Point(58, 227);
            this.bAddNewBook.Name = "bAddNewBook";
            this.bAddNewBook.Size = new System.Drawing.Size(217, 51);
            this.bAddNewBook.TabIndex = 4;
            this.bAddNewBook.Text = "Создать новую книжку";
            this.bAddNewBook.UseVisualStyleBackColor = true;
            this.bAddNewBook.Click += new System.EventHandler(this.bAddNewBook_Click);
            // 
            // Search_service_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 355);
            this.Controls.Add(this.bAddNewBook);
            this.Controls.Add(this.bSearch_Book);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCriterion);
            this.Controls.Add(this.tbNumber_Book);
            this.Name = "Search_service_book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск сервисной книжки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Search_service_book_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CueTextBox tbNumber_Book;
        private System.Windows.Forms.ComboBox cbCriterion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSearch_Book;
        private System.Windows.Forms.Button bAddNewBook;
    }
}