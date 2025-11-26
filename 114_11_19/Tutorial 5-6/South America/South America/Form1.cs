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

namespace South_America
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 表單建構函式，初始化元件
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 取得國家按鈕的點擊事件處理程式
        /// 用於從檔案讀取南美洲國家並顯示在列表框中
        /// </summary>
        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile; // 宣告 StreamReader 物件以讀取檔案
            string countryName; // 用於存儲每個國家名稱的變數
            try
            {
                inputFile = File.OpenText(@"C:\Users\m303\Desktop\114_1_C_Sharp\114_11_19\Countries_Chinese.txt"); // 開啟檔案
                countriesListBox.Items.Clear(); // 清空列表框中的現有項目

                // 逐行讀取檔案直到結束
                while (!inputFile.EndOfStream)
                {
                    countryName = inputFile.ReadLine(); // 讀取一行國家名稱
                    countriesListBox.Items.Add(countryName); // 將國家名稱添加到列表框中
                }

                inputFile.Close(); // 關閉檔案
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息
                MessageBox.Show("發生錯誤: " + ex.Message);
            }
        }

        /// <summary>
        /// 退出按鈕的點擊事件處理程式
        /// 關閉應用程式表單
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
