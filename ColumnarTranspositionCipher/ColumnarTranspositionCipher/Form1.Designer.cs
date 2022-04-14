
namespace ColumnarTranspositionCipher
{
    partial class Form1
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
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.encrypted = new System.Windows.Forms.Label();
            this.EncryptedMessageBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DecryptTextBox = new System.Windows.Forms.TextBox();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(583, 57);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(169, 20);
            this.MessageTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter message: ";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(583, 83);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 2;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Encrypted Message:";
            // 
            // encrypted
            // 
            this.encrypted.AutoSize = true;
            this.encrypted.Location = new System.Drawing.Point(608, 183);
            this.encrypted.Name = "encrypted";
            this.encrypted.Size = new System.Drawing.Size(0, 13);
            this.encrypted.TabIndex = 4;
            // 
            // EncryptedMessageBox
            // 
            this.EncryptedMessageBox.AutoSize = true;
            this.EncryptedMessageBox.Location = new System.Drawing.Point(589, 170);
            this.EncryptedMessageBox.Name = "EncryptedMessageBox";
            this.EncryptedMessageBox.Size = new System.Drawing.Size(35, 13);
            this.EncryptedMessageBox.TabIndex = 5;
            this.EncryptedMessageBox.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Message:";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(583, 382);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptButton.TabIndex = 8;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Key";
            // 
            // DecryptTextBox
            // 
            this.DecryptTextBox.Location = new System.Drawing.Point(583, 285);
            this.DecryptTextBox.Name = "DecryptTextBox";
            this.DecryptTextBox.Size = new System.Drawing.Size(100, 20);
            this.DecryptTextBox.TabIndex = 10;
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(583, 345);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(100, 20);
            this.KeyBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.DecryptTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EncryptedMessageBox);
            this.Controls.Add(this.encrypted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessageTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label encrypted;
        private System.Windows.Forms.Label EncryptedMessageBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DecryptTextBox;
        private System.Windows.Forms.TextBox KeyBox;
    }
}

