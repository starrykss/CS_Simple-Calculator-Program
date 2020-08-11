using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
            resultListView.View = View.Details;
            resultListView.Columns.Add("기록", 240);
        }

        private void add_Click(object sender, EventArgs e)
        {
            // 입력값 오류 처리
            try
            {
                int result = Convert.ToInt32(variable1.Text) + Convert.ToInt32(variable2.Text);
                resultLabel.Text = Convert.ToString(result);
                ListViewItem item = new ListViewItem(variable1.Text + " + " + variable2.Text + " = " + result);
                resultListView.Items.Add(item);
            } catch (Exception)
            {
                resultLabel.Text = "입력 값 오류가 발생했습니다.";
            }
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            // 입력값 오류 처리
            try
            {
                int result = Convert.ToInt32(variable1.Text) - Convert.ToInt32(variable2.Text);
                resultLabel.Text = Convert.ToString(result);
                ListViewItem item = new ListViewItem(variable1.Text + " - " + variable2.Text + " = " + result);
                resultListView.Items.Add(item);
            }
            catch (Exception)
            {
                resultLabel.Text = "입력 값 오류가 발생했습니다.";
            }
        }

        private void multiple_Click(object sender, EventArgs e)
        {
            // 입력값 오류 처리
            try
            {
                int result = Convert.ToInt32(variable1.Text) * Convert.ToInt32(variable2.Text);
                resultLabel.Text = Convert.ToString(result);
                ListViewItem item = new ListViewItem(variable1.Text + " * " + variable2.Text + " = " + result);
                resultListView.Items.Add(item);
            }
            catch (Exception)
            {
                resultLabel.Text = "입력 값 오류가 발생했습니다.";
            }
        }
        private void divide_Click(object sender, EventArgs e)
        {
            // 입력값 오류 처리
            try
            {
                int result = Convert.ToInt32(variable1.Text) / Convert.ToInt32(variable2.Text);
                resultLabel.Text = Convert.ToString(result);
                ListViewItem item = new ListViewItem(variable1.Text + " / " + variable2.Text + " = " + result);
                resultListView.Items.Add(item);
            }
            catch (Exception)
            {
                resultLabel.Text = "입력 값 오류가 발생했습니다.";
            }
        }
    }
}