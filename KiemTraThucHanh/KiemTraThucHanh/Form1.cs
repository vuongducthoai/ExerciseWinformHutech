using KiemTraThucHanh.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraThucHanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                XetNghiemContextDB context = new XetNghiemContextDB();
                groupBox2.Enabled = false;
                List<CONGTY> listCongTys = context.CONGTies.ToList();
                List<NHANVIEN> listNhanViens = context.NHANVIENs.ToList();
                BindGrid(listNhanViens);
                FillCongTyCombobox(listCongTys);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
        private void FillCongTyCombobox(List<CONGTY> listCongTys)
        {
            this.cmbCty.DataSource = listCongTys;
            this.cmbCty.DisplayMember = "TenCty";
            this.cmbCty.ValueMember = "MaCty";
        }

        private void BindGrid(List<NHANVIEN> listNhanViens)
        {
            dgvNhanVien.Rows.Clear();
            foreach (var item in listNhanViens)
            {
                int index = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[index].Cells[0].Value = item.ID;
                dgvNhanVien.Rows[index].Cells[1].Value = item.HoTen;
                dgvNhanVien.Rows[index].Cells[2].Value = item.SoLanXN;
                if(item.AmTinh == false)
                {
                    dgvNhanVien.Rows[index].Cells[3].Value = "+";
                } else
                {
                    dgvNhanVien.Rows[index].Cells[3].Value = "Âm Tính";
                }
              
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaNV.Text))
                {
                    MessageBox.Show("Vui lòng nhập CCCD hoặc CMND.");
                    return;
                }

                if (txtMaNV.Text.Length != 12 && txtMaNV.Text.Length != 9)
                {
                    MessageBox.Show("CCCD hoặc CMND phải có 12 hoặc 9 ký tự.");
                    return;
                }

                if (!txtMaNV.Text.All(char.IsDigit))
                {
                    MessageBox.Show("ID chỉ là các ký tự số.");
                    return;
                }

                XetNghiemContextDB context = new XetNghiemContextDB();
                var nhanVien = context.NHANVIENs.FirstOrDefault(nv => nv.ID == txtMaNV.Text);

                if (nhanVien == null)
                {
                    groupBox2.Enabled = true;

                    txtHoTen.Text = "";
                    txtSLXN.ReadOnly = true;
                    txtSLXN.Text = "1";
                    rbtAm.Checked = true;
                    rbtDuong.Checked = false;
                    cmbCty.SelectedIndex = 0;
                }
                else
                {
                    groupBox2.Enabled = true;

                    txtHoTen.Text = nhanVien.HoTen;
                    txtSLXN.ReadOnly = true;
                    txtSLXN.Text = (nhanVien.SoLanXN + 1).ToString();
                    if (nhanVien.AmTinh == true)
                    {
                        rbtAm.Checked = true;
                        rbtDuong.Checked = false;
                    }
                    else
                    {
                        rbtAm.Checked = false;
                        rbtDuong.Checked = true;
                    }
                    cmbCty.SelectedValue = nhanVien.MaCty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                XetNghiemContextDB context = new XetNghiemContextDB();
                var nhanVien = context.NHANVIENs.FirstOrDefault(nv => nv.ID == txtMaNV.Text);

                if (nhanVien == null)
                {
                    NHANVIEN newNhanVien = new NHANVIEN
                    {
                        ID = txtMaNV.Text,
                        HoTen = txtHoTen.Text,
                        SoLanXN = 1,
                        AmTinh = rbtAm.Checked,
                        MaCty = cmbCty.SelectedValue.ToString(),
                    };
                    context.NHANVIENs.Add(newNhanVien);
                    context.SaveChanges();

                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    nhanVien.HoTen = txtHoTen.Text;
                    nhanVien.SoLanXN += 1;
                    nhanVien.AmTinh = rbtAm.Checked;
                    nhanVien.MaCty = cmbCty.SelectedValue.ToString();
                    context.SaveChanges();

                    MessageBox.Show("Cập nhật thành công!");
                }

                BindGrid(context.NHANVIENs.ToList());

                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void ResetForm()
        {
            groupBox2.Enabled = false;
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtSLXN.Text = "";
            rbtAm.Checked = true;
            rbtDuong.Checked = false;
            cmbCty.SelectedIndex = 0;
        }

        private void filterNVDT_Click(object sender, EventArgs e)
        {
            try
            {
                XetNghiemContextDB context = new XetNghiemContextDB();

                var listNhanVienDuongTinh = context.NHANVIENs.Where(nv => nv.AmTinh == false).ToList();

                if (listNhanVienDuongTinh.Count > 0)
                {
                    BindGrid(listNhanVienDuongTinh);
                }
                else
                {
                    MessageBox.Show("Không có nhân viên dương tính.");
                    dgvNhanVien.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }


        private void filterCtyTest_Click(object sender, EventArgs e)
        {
            try
            {
                XetNghiemContextDB context = new XetNghiemContextDB();

                var danhSachCongTy = context.CONGTies
                    .Where(cty =>
                        context.NHANVIENs.Count(nv => nv.MaCty == cty.MaCty) >= cty.SLNV)
                    .Select(cty => new
                    {
                        cty.TenCty
                    })
                    .ToList();

                if (danhSachCongTy.Count > 0)
                {
                    string danhSach = string.Join("\n", danhSachCongTy.Select((cty, index) => $"{index + 1}. {cty.TenCty}"));
                    MessageBox.Show($"Các Công Ty đã test đủ theo yêu cầu:\n{danhSach}");
                }
                else
                {
                    MessageBox.Show("Không có công ty nào đã test đủ theo yêu cầu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                filterCtyTest_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                    filterCtyTest_Click(sender, e);
            }
        }
    }
}
