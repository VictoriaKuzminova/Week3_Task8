using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            res_textBox.Text = "";
            string str="";
            //Проверка на пустоту
            try
            {
                str = start_textBox.Text;
                if (String.IsNullOrWhiteSpace(str))
                {
                    MessageBox.Show("Строка пустая");
                    return;
                }
            }
            catch { }
            string res = Regex.Replace(str, @"([а-я]+)|([А-Я]+)", "");
            res_textBox.Text+="Результат: " + res;
        }
    }
}
