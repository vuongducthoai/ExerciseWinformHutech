using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (dgvStudent.Columns.Count == 0)
            {
                dgvStudent.Columns.Add("StudentID", "Mã số sinh viên");
                dgvStudent.Columns.Add("FullName", "Họ và Tên");
                dgvStudent.Columns.Add("Gender", "Giới tính");
                dgvStudent.Columns.Add("AverageScore", "Điểm trung bình");
                dgvStudent.Columns.Add("Faculty", "Khoa");
            }

            if (cmbFaculty != null && cmbFaculty.Items.Count > 0)
            {
                cmbFaculty.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Danh sách Khoa chưa được khởi tạo hoặc rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int GetSelectedRow(string studentID)
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
            {
                dgvStudent.Rows[selectedRow].Cells[0].Value = txtStudentID.Text;
                dgvStudent.Rows[selectedRow].Cells[1].Value = txtFullName.Text;
                dgvStudent.Rows[selectedRow].Cells[2].Value = optFemale.Checked ? "Nữ" : "Nam";
                dgvStudent.Rows[selectedRow].Cells[3].Value = float.Parse(txtAverageScore.Text).ToString();
                dgvStudent.Rows[selectedRow].Cells[4].Value = cmbFaculty.Text;

            }

        }



        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
         
                
                    // Kiểm tra các trường bắt buộc
                    if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                        string.IsNullOrWhiteSpace(txtFullName.Text) ||
                        string.IsNullOrWhiteSpace(txtAverageScore.Text))
                    {
                        throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên!");
                    }

                    // Kiểm tra điểm trung bình có hợp lệ không
                    if (!float.TryParse(txtAverageScore.Text, out float averageScore))
                    {
                        throw new Exception("Điểm trung bình phải là một số hợp lệ!");
                    }

                    int selectedRow = GetSelectedRow(txtStudentID.Text);

                    if (selectedRow == -1) // Thêm mới
                    {
                        selectedRow = dgvStudent.Rows.Add();
                        InsertUpdate(selectedRow);
                        MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else // Cập nhật
                    {
                        InsertUpdate(selectedRow);
                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtStudentID.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy MSSV cần xóa!");
                }
                else
                {
                    // Xác nhận xóa
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        // Xóa dòng đã chọn
                        dgvStudent.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
