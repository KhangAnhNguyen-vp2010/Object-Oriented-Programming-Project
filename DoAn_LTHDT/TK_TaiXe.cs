using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTHDT
{
    public abstract class TK_TaiXe:TaiKhoan
    {
        private string maSo, tenTX, hinhThuc;

        public string MaSo
        {
            get { return maSo; }
            set { maSo = value; }
        }

        public string TenTX
        {
            get { return tenTX; }
            set { tenTX = value; }
        }

        public string HinhThuc
        {
            get { return hinhThuc; }
            set { hinhThuc = value; }
        }

        public TK_TaiXe(string u, string p, int s, int tt, string ms, string ten, string ht)
            : base(u, p, s, tt)
        {
            MaSo = ms;
            TenTX = ten;
            HinhThuc = ht;
        }

        public abstract double tinhTien();
        
        public override void xuat()
        {
            Console.WriteLine("TAI KHOAN TAI XE");
            base.xuat();
            Console.WriteLine("Ma so:{0} - Ten:{1} - Hinh thuc:{2}", maSo, tenTX, hinhThuc);
        }
    }
}
