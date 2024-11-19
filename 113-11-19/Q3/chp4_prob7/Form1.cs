using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chp4_prob7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal income;    //收入
            decimal taxrate;   //稅率
            decimal payable;   //應交稅額
             //淨收入

            //以下作答





            if (decimal.TryParse(incomeTextBox.Text, out income))
            {
                // 從這裡開始進行稅率計算
            }
            else
            {
                // 顯示錯誤訊息，告知使用者輸入的不是有效的數字
                MessageBox.Show("請輸入有效的收入數字。");
            }


            decimal tax = 0;

            if (income <= 590000)
            {
                tax = income * 0.05m;  // 5%稅率
            }
            else if (income <= 1330000)
            {
                tax = (income - 590000) * 0.12m + 590000 * 0.05m;  // 12%稅率，並考慮前一個稅級
            }
            else if (income <= 2660000)
            {
                tax = (income - 1330000) * 0.20m + (1330000 - 590000) * 0.12m + 590000 * 0.05m;
            }
            else if (income <= 4980000)
            {
                tax = (income - 2660000) * 0.30m + (2660000 - 1330000) * 0.20m + (1330000 - 590000) * 0.12m + 590000 * 0.05m;
            }
            else
            {
                tax = (income - 4980000) * 0.40m + (4980000 - 2660000) * 0.30m + (2660000 - 1330000) * 0.20m + (1330000 - 590000) * 0.12m + 590000 * 0.05m;
            }

            decimal netIncome = income - tax;

            // 顯示結果
            label2.Text = $"應繳稅額: NT${tax:N2}";
            label3.Text = $"稅後淨收入: NT${netIncome:N2}";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
