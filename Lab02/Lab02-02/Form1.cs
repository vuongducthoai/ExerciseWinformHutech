using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int svNam = 0;
        private int svNu = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFaculty.SelectedIndex = 0;
            txtNam.Text = "0";
            txtNu.Text = "0";

        }

        private int GetSeletedRow(string studentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                var cellValue = dgvStudent.Rows[i].Cells[0].Value;
                if (cellValue != null && cellValue.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }


        private void InsertUpdate(int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = txtStudentID.Text;
            dgvStudent.Rows[selectedRow].Cells[1].Value = txtFullName.Text;
            dgvStudent.Rows[selectedRow].Cells[2].Value = optFemale.Checked ? "Nữ" : "Nam";
            dgvStudent.Rows[selectedRow].Cells[3].Value = float.Parse(txtAverageScore.Text).ToString();
            dgvStudent.Rows[selectedRow].Cells[4].Value = cmbFaculty.Text;
            UpdateGenderCount();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSeletedRow(txtStudentID.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy MSSV cần xóa!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);
                    UpdateGenderCount();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void UpdateGenderCount()
        {
            svNam = 0;
            svNu = 0;

            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                if (row.Cells[2].Value != null) 
                {
                    string gender = row.Cells[2].Value.ToString();
                    if (gender == "Nam")
                    {
                        svNam++;
                    }
                    else if (gender == "Nữ")
                    {
                        svNu++;
                    }
                }
            }

            txtNam.Text = svNam.ToString();
            txtNu.Text = svNu.ToString();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentID.Text == "" || txtFullName.Text == "" || txtAverageScore.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên!");
                }
                int selectedRow = GetSeletedRow(txtStudentID.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvStudent.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvStudent.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgvStudent.Rows[e.RowIndex];

                    txtStudentID.Text = selectedRow.Cells[0].Value?.ToString() ?? "";
                    txtFullName.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
                    if (selectedRow.Cells[2].Value?.ToString() == "Nữ")
                    {
                        optFemale.Checked = true;
                    }
                    else
                    {
                        optMale.Checked = true;
                    }
                    txtAverageScore.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
                    cmbFaculty.Text = selectedRow.Cells[4].Value?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lấy dữ liệu từ DataGridView: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}