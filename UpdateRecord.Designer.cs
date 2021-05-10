
namespace Trenirovochka2
{
    partial class UpdateRecord
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
            this.UpdateRecordButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.moneyBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UpdateRecordButton
            // 
            this.UpdateRecordButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateRecordButton.Location = new System.Drawing.Point(171, 373);
            this.UpdateRecordButton.Name = "UpdateRecordButton";
            this.UpdateRecordButton.Size = new System.Drawing.Size(466, 65);
            this.UpdateRecordButton.TabIndex = 0;
            this.UpdateRecordButton.Text = "Изменить";
            this.UpdateRecordButton.UseVisualStyleBackColor = true;
            this.UpdateRecordButton.Click += new System.EventHandler(this.UpdateRecordButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(188, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название монеты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(214, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата";
            // 
            // numberBox
            // 
            this.numberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberBox.Location = new System.Drawing.Point(320, 65);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(98, 41);
            this.numberBox.TabIndex = 4;
            // 
            // moneyBox
            // 
            this.moneyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyBox.Location = new System.Drawing.Point(320, 123);
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.Size = new System.Drawing.Size(317, 41);
            this.moneyBox.TabIndex = 5;
            // 
            // dateBox
            // 
            this.dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateBox.Location = new System.Drawing.Point(320, 179);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(98, 41);
            this.dateBox.TabIndex = 6;
            // 
            // UpdateRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.moneyBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateRecordButton);
            this.Name = "UpdateRecord";
            this.Text = "UpdateRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateRecordButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox moneyBox;
        private System.Windows.Forms.TextBox dateBox;
    }
}