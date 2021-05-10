
namespace Trenirovochka2
{
    partial class AddNewRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newnameBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.AddNewRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название монеты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(295, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата";
            // 
            // newnameBox
            // 
            this.newnameBox.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newnameBox.Location = new System.Drawing.Point(415, 93);
            this.newnameBox.Name = "newnameBox";
            this.newnameBox.Size = new System.Drawing.Size(318, 45);
            this.newnameBox.TabIndex = 2;
            // 
            // dateBox
            // 
            this.dateBox.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateBox.Location = new System.Drawing.Point(415, 144);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(105, 45);
            this.dateBox.TabIndex = 3;
            // 
            // AddNewRecordButton
            // 
            this.AddNewRecordButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewRecordButton.Location = new System.Drawing.Point(302, 232);
            this.AddNewRecordButton.Name = "AddNewRecordButton";
            this.AddNewRecordButton.Size = new System.Drawing.Size(218, 56);
            this.AddNewRecordButton.TabIndex = 4;
            this.AddNewRecordButton.Text = "Добавить ";
            this.AddNewRecordButton.UseVisualStyleBackColor = true;
            this.AddNewRecordButton.Click += new System.EventHandler(this.AddNewRecordButton_Click);
            // 
            // AddNewRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.AddNewRecordButton);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.newnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewRecord";
            this.Text = "AddNewRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newnameBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Button AddNewRecordButton;
    }
}