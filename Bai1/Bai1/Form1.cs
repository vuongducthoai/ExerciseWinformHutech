using Bai1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmStudentManagement : Form
    {
        public frmStudentManagement()
        {
            InitializeComponent();
        }

        private void frmStudentManagement_Load(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                List<Faculty> listFacultys = context.Faculties.ToList();
                List<SinhVien> listSinhVien = context.SinhViens.ToList();
                FillFalcultyCombobox(listFacultys);
                BindGrid(listSinhVien);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cmbFaculty.DataSource = listFalcultys;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }

        private void BindGrid(List<SinhVien> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                dgvStudent.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB db = new StudentContextDB();
                List<SinhVien> studentList = db.SinhViens.ToList();
                if(studentList.Any(s => s.StudentID == txtStudentId.Text))
                {
                    MessageBox.Show("Mã SV đã tồn tại. Vui lòng nhập một mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newSinhVien = new SinhVien
                {
                    StudentID = txtStudentId.Text,
                    FullName = txtFullName.Text,
                    FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString()),
                    AverageScore = double.Parse(txtAverageScore.Text)
                };

                //Thêm sinh viên vào CSDL
                db.SinhViens.Add(newSinhVien);
                db.SaveChanges();

                //Hiển thị lại danh sách sinh viên
                BindGrid(db.SinhViens.ToList());

                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch(Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu:  {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB db = new StudentContextDB();
                List<SinhVien> students = db.SinhViens.ToList();
                var student = students.FirstOrDefault(s => s.StudentID == txtStudentId.Text);

                if (student != null)
                {
                    if (students.Any(s => s.StudentID == txtStudentId.Text && s.StudentID != student.StudentID))
                    {
                        MessageBox.Show("Mã SV đã tồn tại. Vui lòng nhập một mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    student.FullName = txtFullName.Text;
                    student.FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString());
                    student.AverageScore = double.Parse(txtAverageScore.Text);

                    // Cập nhật sinh viên lưu vào CSDL
                    db.SaveChanges();

                    // Hiển thị lại danh sách sinh viên
                    BindGrid(db.SinhViens.ToList());

                    MessageBox.Show("Chỉnh sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Hàm Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB db = new StudentContextDB();
                List<SinhVien> studentList = db.SinhViens.ToList();

                // Tìm kiếm sinh viên có tồn tại trong CSDL hay không
                var student = studentList.FirstOrDefault(s => s.StudentID == txtStudentId.Text);

                if (student != null)
                {
                    // Xóa sinh viên khỏi CSDL
                    db.SinhViens.Remove(student);
                    db.SaveChanges();

                    BindGrid(db.SinhViens.ToList());

                    MessageBox.Show("Sinh viên đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvStudent.Rows[e.RowIndex];
                txtStudentId.Text = selectedRow.Cells[0].Value.ToString();
                txtFullName.Text = selectedRow.Cells[1].Value.ToString();
                cmbFaculty.Text = selectedRow.Cells[2].Value.ToString();
                txtAverageScore.Text = selectedRow.Cells[3].Value.ToString();
               
            }
        }
    }
}