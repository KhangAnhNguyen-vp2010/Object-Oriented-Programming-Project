using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTHDT
{
    public class TaiKhoan
    {
        private string username, pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private int sdt, trangThai;

        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public int Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public TaiKhoan(string u, string p, int s, int tt)
        {
            Username = u;
            Pass = p;
            Sdt = s;
            TrangThai = tt;
        }

        string bienDoi_Status()
        {
            if (trangThai == 0)
            {
                return "offline";
            }
            else return "online";
        }

        public virtual void xuat()
        {
            Console.WriteLine("Tai khoan:{0} - Pass:{1} - Phone:{2} - Status:{3}", username, pass, sdt, bienDoi_Status());
        }
    }
}
