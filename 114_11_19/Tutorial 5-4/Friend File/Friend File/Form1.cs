using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Friend_File
{
    public partial class Form1 : Form
    {
        private int count = 1; // 成員(全域)變數，保持計數器的值
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            //int count = 1; //區域變數，每次按鈕點擊時都會重設計數器
            StreamWriter outputFile;
            try
            {
                outputFile = File.AppendText(@"C:\Users\m303\Desktop\Friends.txt");
                outputFile.WriteLine(count + ": " + nameTextBox.Text);
                outputFile.Close();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
            nameTextBox.Text = "";
            nameTextBox.Focus();
            count++;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
