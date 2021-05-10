
namespace Trenirovochka2
{
    partial class MainMenu
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NewUserButton = new System.Windows.Forms.Button();
            this.NewRecordButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.backAuthoButton = new System.Windows.Forms.Button();
            this.deleteBox = new System.Windows.Forms.TextBox();
            this.findBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(368, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название монеты";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // NewUserButton
            // 
            this.NewUserButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewUserButton.Location = new System.Drawing.Point(386, 12);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(498, 50);
            this.NewUserButton.TabIndex = 1;
            this.NewUserButton.Text = "Добавить нового пользователя";
            this.NewUserButton.UseVisualStyleBackColor = true;
            this.NewUserButton.Click += new System.EventHandler(this.NewUserButton_Click);
            // 
            // NewRecordButton
            // 
            this.NewRecordButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewRecordButton.Location = new System.Drawing.Point(386, 68);
            this.NewRecordButton.Name = "NewRecordButton";
            this.NewRecordButton.Size = new System.Drawing.Size(498, 50);
            this.NewRecordButton.TabIndex = 2;
            this.NewRecordButton.Text = "Добавить новую запись";
            this.NewRecordButton.UseVisualStyleBackColor = true;
            this.NewRecordButton.Click += new System.EventHandler(this.NewRecordButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.Location = new System.Drawing.Point(386, 124);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(498, 50);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Обновить запись";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(578, 219);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(306, 50);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Удалить запись";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.Location = new System.Drawing.Point(578, 289);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(306, 50);
            this.FindButton.TabIndex = 5;
            this.FindButton.Text = "Поиск по номеру";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // backAuthoButton
            // 
            this.backAuthoButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backAuthoButton.Location = new System.Drawing.Point(386, 388);
            this.backAuthoButton.Name = "backAuthoButton";
            this.backAuthoButton.Size = new System.Drawing.Size(498, 50);
            this.backAuthoButton.TabIndex = 6;
            this.backAuthoButton.Text = "Вернуться к авторизации";
            this.backAuthoButton.UseVisualStyleBackColor = true;
            this.backAuthoButton.Click += new System.EventHandler(this.backAuthoButton_Click);
            // 
            // deleteBox
            // 
            this.deleteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBox.Location = new System.Drawing.Point(436, 220);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(100, 49);
            this.deleteBox.TabIndex = 7;
            // 
            // findBox
            // 
            this.findBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findBox.Location = new System.Drawing.Point(436, 290);
            this.findBox.Name = "findBox";
            this.findBox.Size = new System.Drawing.Size(100, 49);
            this.findBox.TabIndex = 8;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.findBox);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.backAuthoButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.NewRecordButton);
            this.Controls.Add(this.NewUserButton);
            this.Controls.Add(this.listView1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button NewUserButton;
        private System.Windows.Forms.Button NewRecordButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button backAuthoButton;
        private System.Windows.Forms.TextBox deleteBox;
        private System.Windows.Forms.TextBox findBox;
    }
}