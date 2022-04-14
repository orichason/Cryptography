using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColumnarTranspositionCipher
{
    public partial class Form1 : Form
    {
        Font labelFont = new Font("Comic Sans MS", 20);
        Size labelSize = new Size(50, 50);



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Label label1 = CreateLabel(x: 0, y: 0);
            //Label label2 = CreateLabel(x: 51, y: 0);
            //Label label3 = CreateLabel(x: 0, y: 51);
            //Label label4 = CreateLabel(x: 51, y: 51);

            //Controls.Add(label1);
            //Controls.Add(label2);
            //Controls.Add(label3);
            //Controls.Add(label4);


        }

        private Label CreateLabel(int x, int y, string message)
        {
            Label label = new Label();
            label.Location = new Point(x, y);
            label.BackColor = Color.Black;
            label.Size = labelSize;
            label.Text = message;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.ForeColor = Color.Yellow;
            label.Font = labelFont;


            Controls.Add(label);

            return label;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            int length = MessageTextBox.Text.Length;
            int key = 8;    // TODO: Have a textbox for key 

            int rows = (int)Math.Ceiling(length / (double)key);

            Label[,] encryptLabels = new Label[rows, key];

            int messageIndex = 0;

            int x = 0;
            int y = 0;

            string message = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < key; j++)
                {
                    //Check if the current character is a space, then treat it as $
                    //And if messageIndex is past the length of your string use *

                    if (messageIndex >= length)
                    {
                        encryptLabels[i, j] = CreateLabel(x, y, "*");
                    }

                    else if (MessageTextBox.Text[messageIndex] == ' ')
                    {
                        encryptLabels[i, j] = CreateLabel(x, y, "$");
                    }

                    else
                    {
                        encryptLabels[i, j] = CreateLabel(x, y, $"{MessageTextBox.Text[messageIndex]}");
                    }

                    x += 70;

                    messageIndex++;
                }

                x = 0;
                y += 70;
            }

            for (int i = 0; i < key; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (encryptLabels[j, i].Text == "*")
                    {
                        message += ' ';
                    }

                    else if (encryptLabels[j, i].Text == "$")
                    {
                        message += ' ';
                    }

                    else
                    {
                        message += encryptLabels[j, i].Text;
                    }
                }


            }

            EncryptedMessageBox.Text = message;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            int messageIndex = 0;

            int x = 0;
            int y = 0;

            int length = DecryptTextBox.Text.Length;
            int key = int.Parse(KeyBox.Text);

            int rows = (int)Math.Ceiling(length / (double)key);

            Label[,] decryptLabels = new Label[key, rows];

            for (int i = 0; i < key; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (messageIndex >= length || DecryptTextBox.Text[messageIndex] == ' ')
                    {
                        decryptLabels[i, j] = CreateLabel(x, y, " ");
                    }

                    //else if (DecryptTextBox.Text[messageIndex] == ' ')
                    //{
                    //    decryptLabels[i, j] = CreateLabel(x, y, "$");
                    //}

                    else
                    {
                        decryptLabels[i, j] = CreateLabel(x, y, $"{DecryptTextBox.Text[messageIndex]}");
                    }

                    y += 70;

                    messageIndex++;
                }

                x += 70;
                y = 0;
            }

        }

    }
}
