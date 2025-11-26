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

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;  // 宣告輸入檔案物件
            decimal totalSales = 0.0m; // 儲存總銷售額
            decimal currentSales = 0.0m; // 儲存目前讀取的銷售額
            string line; // 儲存讀取的行                        

            try
            {
                inputFile = File.OpenText("Sales.txt");  // 開啟檔案
                salesListBox.Items.Clear(); // 清除清單框內容

                while (!inputFile.EndOfStream)  // 讀取直到檔案結尾
                {
                    if (decimal.TryParse( line = inputFile.ReadLine(), out currentSales) )
                    {
                        salesListBox.Items.Add(line); // 將銷售額加入清單框                     
                        totalSales += currentSales;  // 加到總銷售額
                    }
                    else
                    {
                        MessageBox.Show("無法解析銷售額: " + line);
                        break;
                    }
                }
                inputFile.Close();  // 關閉檔案
                totalLabel.Text = totalSales.ToString("C"); // 顯示總銷售額
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
