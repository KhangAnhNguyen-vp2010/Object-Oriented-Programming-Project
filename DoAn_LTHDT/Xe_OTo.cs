using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTHDT
{
    public class Xe_OTo:ChuyenXe
    {
        private int choNgoi;

        public int ChoNgoi
        {
            get { return choNgoi; }
            set {
                if (value == 4 || value == 7)
                {
                    choNgoi = value;
                }
                else choNgoi = 4;
            }
        }

        public Xe_OTo(string u, string p, int s, int tt, string ms, string ten, string ht, string kh, string start, string end, double kc, int gd, string nd, int cn)
            : base(u, p, s, tt, ms, ten, ht, kh, start, end, kc, gd, nd)
        {
            ChoNgoi = cn;
        }

        public override double tinhTien()
        {
            double phuThu = KhoangCach * 500;
            if (choNgoi==4)
            {
                if (KhoangCach<=2)
                {
                    return KhoangCach*7500 + phuThu;
                }
                else if (KhoangCach<=7)
                {
                    return 15000 + (KhoangCach-2)*2400 + phuThu;
                }
                else
                {
                    return 27000 + 8000 + phuThu;
                }
            }
            else
            {
                if (KhoangCach <= 2)
                {
                    return KhoangCach*8500 + phuThu;
                }
                else if (KhoangCach <= 7)
                {
                    return 17000 + (KhoangCach-2)*3000 + phuThu;
                }
                else
                {
                    return 32000 + 10000 + phuThu;
                }
            }
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Tien xe:{0}", tinhTien());
        }
    }
}
