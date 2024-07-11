using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTHDT
{
    public class Xe_OTo_Tai:ChuyenXe
    {
        private float trongTai;

        public float TrongTai
        {
            get { return trongTai; }
            set { trongTai = value; }
        }

        public Xe_OTo_Tai(string u, string p, int s, int tt, string ms, string ten, string ht, string kh, string start, string end, double kc, int gd, string nd, float cn)
            : base(u, p, s, tt, ms, ten, ht, kh, start, end, kc, gd, nd)
        {
            TrongTai = cn;
        }

        public override double tinhTien()
        {
            double phuThu = KhoangCach * 5000;
            if (trongTai<=3)
            {
                if (KhoangCach<=5)
                {
                    return KhoangCach * 12000 + phuThu;
                }
                else if (KhoangCach <= 10)
                {
                    return 60000 + KhoangCach * 10000 + phuThu;
                }
                else
                {
                    return 140000 + phuThu;
                }
            }
            else
            {
                if (KhoangCach <= 5)
                {
                    return KhoangCach * 14000 + phuThu;
                }
                else if (KhoangCach<=10)
                {
                    return 70000 + KhoangCach * 12000 + phuThu;
                }
                else
                {
                    return 170000 + phuThu;
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
