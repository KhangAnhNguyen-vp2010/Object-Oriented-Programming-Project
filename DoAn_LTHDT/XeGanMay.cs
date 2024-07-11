using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTHDT
{
    public class XeGanMay:ChuyenXe
    {
        public XeGanMay(string u, string p, int s, int tt, string ms, string ten, string ht, string kh, string start, string end, double kc, int gd, string nd)
            : base(u, p, s, tt, ms, ten, ht, kh, start, end, kc, gd, nd)
        {
            
        }
        public override double tinhTien()
        {
            if (KhoangCach<=2)
            {
                if (GioDon >= 22 && GioDon <= 5)
                {
                    return KhoangCach * 4000 + KhoangCach * 3000;
                }
                else return KhoangCach * 4000;
            }
            else
            {
                if (GioDon >= 22 && GioDon <= 5)
                {
                    return 8000 + ((KhoangCach - 2) * 5000) * 3000;
                }
                else return 8000 + (KhoangCach - 2) * 5000;
            }
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Tien xe:{0}", tinhTien());
        }
    }
}
