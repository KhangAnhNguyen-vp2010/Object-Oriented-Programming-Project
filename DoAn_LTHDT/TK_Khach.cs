using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTHDT
{
    public class TK_Khach:TaiKhoan
    {
        private string loai;

        public string Loai
        {
            get { return loai; }
            set { loai = value; }
        }


        public TK_Khach(string u, string p, int s, int tt, string l)
            : base(u, p, s, tt)
        {
            Loai = l;
        }

        public override void xuat()
        {
            Console.WriteLine("TAI KHOAN KHACH:");
            base.xuat();
            Console.WriteLine("Loai khach:{0}", loai);
        }
    }
}
