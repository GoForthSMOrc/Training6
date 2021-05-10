
namespace Trenirovochka2
{
    partial class AddNewUser
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
            this.AddNewUserButton = new System.Windows.Forms.Button();
            this.newlogBox = new System.Windows.Forms.TextBox();
            this.newpassBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(196, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(176, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // AddNewUserButton
            // 
            this.AddNewUserButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewUserButton.Location = new System.Drawing.Point(241, 368);
            this.AddNewUserButton.Name = "AddNewUserButton";
            this.AddNewUserButton.Size = new System.Drawing.Size(329, 70);
            this.AddNewUserButton.TabIndex = 2;
            this.AddNewUserButton.Text = "Добавить";
            this.AddNewUserButton.UseVisualStyleBackColor = true;
            this.AddNewUserButton.Click += new System.EventHandler(this.AddNewUserButton_Click);
            // 
            // newlogBox
            // 
            this.newlogBox.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newlogBox.Location = new System.Drawing.Point(358, 103);
            this.newlogBox.Name = "newlogBox";
            this.newlogBox.Size = new System.Drawing.Size(315, 45);
            this.newlogBox.TabIndex = 3;
            // 
            // newpassBox
            // 
            this.newpassBox.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newpassBox.Location = new System.Drawing.Point(358, 158);
            this.newpassBox.Name = "newpassBox";
            this.newpassBox.Size = new System.Drawing.Size(315, 45);
            this.newpassBox.TabIndex = 4;
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newpassBox);
            this.Controls.Add(this.newlogBox);
            this.Controls.Add(this.AddNewUserButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewUser";
            this.Text = "AddNewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddNewUserButton;
        private System.Windows.Forms.TextBox newlogBox;
        private System.Windows.Forms.TextBox newpassBox;
    }
}