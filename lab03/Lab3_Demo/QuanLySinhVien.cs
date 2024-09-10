using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Demo
{
    public delegate int SoSanh(object sinhVien1, object sinhVien2);

    public class QuanLySinhVien
    {
        public List<SinhVien> DanhSach;

        public SinhVien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }

        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }

        public void DocTuFile()
        {
            string fileName = "DanhSachSinhVien.csv";
            string t = "";
            string[] s;
            SinhVien sinhVien;
            StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                sinhVien = new SinhVien();
                s = t.Split(';');
                sinhVien.MaSo = s[0];
                sinhVien.HoTen = s[1];
                sinhVien.NgaySinh = DateTime.Parse(s[2]);
                sinhVien.DiaChi = s[3];
                sinhVien.Lop = s[4];
                sinhVien.GioiTinh = (s[5] == "1" ? true : false);
                string[] chuyenNganh = s[6].Split(',');
                foreach (var item in chuyenNganh)
                {
                    sinhVien.ChuyenNganh.Add(item.Trim());
                }
                this.Them(sinhVien);
                sinhVien.Hinh = s[7];
            }
        }

        public bool Sua(SinhVien sinhVien, object obj, SoSanh soSanh)
        {
            int count  = DanhSach.Count;
            for (int i = 0; i < count; i++)
            {
                if (soSanh(obj, this[i]) == 0)
                {
                    this[i] = sinhVien;
                    return true;
                }
            }
            return false;
        }

        public bool Sua(SinhVien sinhVien, SinhVien sinhVienSua)
        {
            for (int i = 0; i < DanhSach.Count; i++)
            {
                if (DanhSach[i].MaSo == sinhVien.MaSo)
                {
                    DanhSach[i] = sinhVienSua;
                    return true;
                }
            }
            return false;
        }

        public void Them(SinhVien sinhVien)
        {
            DanhSach.Add(sinhVien);
        }

        public SinhVien Tim(object obj, SoSanh soSanh)
        {
            SinhVien sinhVien = null;
            foreach (SinhVien item in DanhSach)
            {
                if (soSanh(obj, item) == 0)
                {
                    sinhVien = item;
                }
            }
            return sinhVien;
        }

        public void Xoa(object obj, SoSanh soSanh)
        {
            int i = DanhSach.Count - 1;
            for (; i >= 0; i--)
            {
                if (soSanh(obj, this[i]) == 0)
                {
                    this.DanhSach.RemoveAt(i);
                }
            }
        }

        public void Xoa(string maSo) => DanhSach.RemoveAll(r => r.MaSo == maSo);

        public SinhVien GetItemByID(string maSo)
        {
            SinhVien sinhVien = DanhSach.Find(f => f.MaSo == maSo);
            return sinhVien;
        }
    }
}