using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumber1.Text) || string.IsNullOrWhiteSpace(txtNumber2.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ số vào các ô.");
                    return;
                }
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);
                float result = number1 + number2;
                txtAnswer.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnSub_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtNumber1.Text) || string.IsNullOrWhiteSpace(txtNumber2.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ số vào các ô.");
                    return;
                }
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);
                float result = number1 - number2;
                txtAnswer.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnMul_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtNumber1.Text) || string.IsNullOrWhiteSpace(txtNumber2.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ số vào các ô.");
                    return;
                }
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);
                float result = number1 * number2;
                txtAnswer.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đầu vào
                if (string.IsNullOrWhiteSpace(txtNumber1.Text) || string.IsNullOrWhiteSpace(txtNumber2.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ số vào các ô.");
                    return;
                }

                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);

                // Kiểm tra chia cho 0
                if (number2 == 0)
                {
                    MessageBox.Show("Không thể chia cho 0.");
                    return;
                }

                float result = number1 / number2;
                txtAnswer.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
           }
        }
    }
}
