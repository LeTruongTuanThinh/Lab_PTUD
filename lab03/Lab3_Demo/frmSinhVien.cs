using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Demo
{
    public partial class frmSinhVien : Form
    {
        QuanLySinhVien quanLy = new QuanLySinhVien();

        public frmSinhVien()
        {
            InitializeComponent();
        }

        #region Methods

        public SinhVien GetSinhVien()
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.MaSo = mktbMaSo.Text;
            sinhVien.HoTen = txtHoTen.Text;
            sinhVien.NgaySinh = dtpkNgaySinh.Value;
            sinhVien.DiaChi = txtDiaChi.Text;
            sinhVien.Lop = cbLop.Text;
            sinhVien.Hinh = txtHinh.Text;
            sinhVien.GioiTinh = (rdNam.Checked ? true : false);
            int count = clbChuyenNganh.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (clbChuyenNganh.GetItemChecked(i))
                {
                    sinhVien.ChuyenNganh.Add(clbChuyenNganh.Items[i].ToString());
                }
            }
            return sinhVien;
        }

        public SinhVien GetSinhVienListView(ListViewItem lvi)
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.MaSo = lvi.SubItems[0].Text;
            sinhVien.HoTen = lvi.SubItems[1].Text;
            sinhVien.NgaySinh = DateTime.Parse(lvi.SubItems[2].Text);
            sinhVien.DiaChi = lvi.SubItems[3].Text;
            sinhVien.Lop = lvi.SubItems[4].Text;
            sinhVien.GioiTinh = (lvi.SubItems[5].Text.Equals("Nam") ? true : false);
            foreach (var item in lvi.SubItems[6].Text.Split(','))
            {
                sinhVien.ChuyenNganh.Add(item.Trim());
            }
            sinhVien.Hinh = lvi.SubItems[7].Text;
            return sinhVien;
        }

        public void ThietLapThongTin(SinhVien sinhVien)
        {
            this.mktbMaSo.Text = sinhVien.MaSo;
            this.txtHoTen.Text = sinhVien.HoTen;
            this.dtpkNgaySinh.Value = sinhVien.NgaySinh;
            this.txtDiaChi.Text = sinhVien.DiaChi;
            this.cbLop.Text = sinhVien.Lop;
            this.txtHinh.Text = sinhVien.Hinh;
            this.pbPicture.ImageLocation = sinhVien.Hinh;
            if (sinhVien.GioiTinh)
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            int count = clbChuyenNganh.Items.Count;
            for (int i = 0; i < count; i++)
            {
                clbChuyenNganh.SetItemChecked(i, false);
                foreach (var item in sinhVien.ChuyenNganh)
                {
                    if (item.CompareTo(clbChuyenNganh.Items[i].ToString()) == 0)
                    {
                        clbChuyenNganh.SetItemChecked(i, true);
                    }
                }
            }
        }

        // ListView
        public void ThemSinhVien(SinhVien sinhVien)
        {
            ListViewItem lvi = new ListViewItem(sinhVien.MaSo);
            lvi.SubItems.Add(sinhVien.HoTen);
            lvi.SubItems.Add(sinhVien.NgaySinh.ToShortDateString());
            lvi.SubItems.Add(sinhVien.DiaChi);
            lvi.SubItems.Add(sinhVien.Lop);
            lvi.SubItems.Add((sinhVien.GioiTinh == true ? "Nam" : "Nữ"));
            string chuyenNganh = "";
            foreach (var item in sinhVien.ChuyenNganh)
            {
                chuyenNganh += item + ", ";
            }
            lvi.SubItems.Add(chuyenNganh.Substring(0, (chuyenNganh.Length > 2 ? chuyenNganh.Length - 2 : chuyenNganh.Length)));
            lvi.SubItems.Add(sinhVien.Hinh);
            this.lvSinhVien.Items.Add(lvi);
        }

        public void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (var item in quanLy.DanhSach)
            {
                ThemSinhVien(item);
            }
            toolStripStatusLabel1.Text = $"Tổng số Sinh viên: {lvSinhVien.Items.Count}";
        }

        public void SortListView(int type)
        {
            switch (type)
            {
                case 0:
                    quanLy.DanhSach = quanLy.DanhSach.OrderBy(o => o.MaSo).ToList();
                    break;
                case 1:
                    quanLy.DanhSach = quanLy.DanhSach.OrderBy(o => o.HoTen).ToList();
                    break;
                case 2:
                    quanLy.DanhSach = quanLy.DanhSach.OrderBy(o => o.NgaySinh).ToList();
                    break;
                default:
                    break;
            }
            LoadListView();
        }

        public void FindListView(string infor, int type)
        {
            this.lvSinhVien.Items.Clear();
            foreach (var item in quanLy.DanhSach)
            {
                switch (type)
                {
                    case 0:
                        if (item.MaSo.Contains(infor))
                            ThemSinhVien(item);
                        break;
                    case 1:
                        if (item.HoTen.Contains(infor))
                            ThemSinhVien(item);
                        break;
                    case 2:
                        if (item.NgaySinh.ToString().Contains(infor))
                            ThemSinhVien(item);
                        break;
                    default:
                        break;
                }
            }
            toolStripStatusLabel1.Text = $"Tổng số Sinh viên: {lvSinhVien.Items.Count}";
        }

        private void ShowInforBySelectedItem()
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvi = this.lvSinhVien.SelectedItems[0];
                SinhVien sinhVien = GetSinhVienListView(lvi);
                ThietLapThongTin(sinhVien);
            }
        }

        #endregion

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            quanLy = new QuanLySinhVien();
            quanLy.DocTuFile();
            LoadListView();
            if (lvSinhVien.Items.Count > 0)
            {
                ListViewItem lvi = lvSinhVien.Items[0];
                ThietLapThongTin(GetSinhVienListView(lvi));
            }
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowInforBySelectedItem();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = GetSinhVien();
            SinhVien ketQua = quanLy.Tim(sinhVien.MaSo, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
            });
            if (ketQua != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.quanLy.Them(sinhVien);
                this.LoadListView();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (lvSinhVien.Items[i].Checked)
                {
                    quanLy.Xoa(lvSinhVien.Items[i].Text);
                }
            }
            this.LoadListView();
            this.btnMacDinh.PerformClick();
        }

        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sinhVien = obj2 as SinhVien;
            return sinhVien.MaSo.CompareTo(obj1);
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mktbMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.dtpkNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = "";
            this.cbLop.SelectedIndex = 0;
            this.txtHinh.Text = "";
            this.pbPicture.ImageLocation = "";
            this.rdNam.Checked = true;
            int count = clbChuyenNganh.Items.Count;
            for (int i = 0; i < count; i++)
            {
                this.clbChuyenNganh.SetItemChecked(i, false);
            }
            this.clbChuyenNganh.SelectedIndex = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lvSinhVien.SelectedItems[0].Text);

            SinhVien sinhVien = new SinhVien();
            int count = lvSinhVien.Items.Count;
            for (int i = 0; i < lvSinhVien.Items.Count; i++)
            {
                if (lvSinhVien.Items[i].Checked)
                {
                    //sinhVien = quanLy.GetItemByID(lvSinhVien.SelectedItems[0].Text);
                    sinhVien = GetSinhVienListView(lvSinhVien.Items[i]);
                    if (quanLy.Sua(sinhVien, GetSinhVien()))
                    {
                        this.LoadListView();
                    }
                    return;
                }
            }
        }

        private void lvSinhVien_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ShowInforBySelectedItem();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            txtHinh.Text = openFileDialog.FileName;
            pbPicture.ImageLocation = txtHinh.Text;
        }

        private void mởFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnBrowse_Click(this, null);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.btnThem_Click(this, null);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.btnXoa_Click(this, null);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.btnSua_Click(this, null);
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            f.ShowDialog();
            lvSinhVien.Font = f.Font;
        }

        private void màuChữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            lvSinhVien.ForeColor = c.Color;
        }

        private void sắpXếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextOption c = new ContextOption();
            c.gbInfor.Visible = false;
            c.ShowDialog();
            if (c.DialogResult == DialogResult.OK)
            {
                //quanLy = new QuanLySinhVien();
                //quanLy.DocTuFile();
                SortListView(c.type);
            }
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextOption c = new ContextOption();
            c.btnSort.Visible = false;
            c.ShowDialog();
            if (c.DialogResult == DialogResult.OK)
            {
                //quanLy = new QuanLySinhVien();
                //quanLy.DocTuFile();
                FindListView(c.infor, c.type);
            }
        }
    }
}
