using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTHDT
{
    public abstract class ChuyenXe:TK_TaiXe
    {
        private string khachHang, batDau, ketThuc;

        public string KetThuc
        {
            get { return ketThuc; }
            set { ketThuc = value; }
        }

        public string BatDau
        {
            get { return batDau; }
            set { batDau = value; }
        }

        public string KhachHang
        {
            get { return khachHang; }
            set { khachHang = value; }
        }
        private double khoangCach;

        public double KhoangCach
        {
            get { return khoangCach; }
            set { khoangCach = value; }
        }
        private int gioDon;
        public int GioDon
        {
            get { return gioDon; }
            set {
                if (value <= 24 && value >= 0)
                {
                    gioDon = value;
                }
                else gioDon = 0;
            }
        }

        private string ngayDi;

        public string NgayDi
        {
          get { return ngayDi; }
          set { ngayDi = value; }
        }

        public ChuyenXe(string u, string p, int s, int tt, string ms, string ten, string ht, string kh, string start, string end, double kc, int gd, string nd)
            : base(u, p, s, tt, ms, ten, ht)
        {
            KhachHang = kh;
            BatDau = start;
            KetThuc = end;
            KhoangCach = kc;
            GioDon = gd;
            NgayDi = nd;
        }
    }
}
