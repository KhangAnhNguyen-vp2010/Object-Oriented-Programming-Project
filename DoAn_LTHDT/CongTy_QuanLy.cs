using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DoAn_LTHDT
{
    public class CongTy_QuanLy
    {
        List<TaiKhoan> listTK = new List<TaiKhoan>();

        public List<TaiKhoan> ListTK
        {
            get { return listTK; }
            set { listTK = value; }
        }

        public void nhapXML(string duongDan)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(duongDan);
            listTK.Clear();
            // add Khach truoc
            XmlNodeList nodes = doc.SelectNodes("CongTy/Khach_List/TaiKhoan_Khach");
            foreach (XmlNode node in nodes)
            {
                TK_Khach b;
                string tk = node["Username"].InnerText;
                string mk = node["Password"].InnerText;
                int sdt = int.Parse(node["SDT"].InnerText);
                int tt = int.Parse(node["TrangThai"].InnerText);
                string lk = node["LoaiKhach"].InnerText;
                b = new TK_Khach(tk, mk, sdt, tt, lk);
                listTK.Add(b);
            }

            XmlNodeList nodelist = doc.SelectNodes("CongTy/TaiXe_List/TaiKhoan_TaiXe");
            foreach (XmlNode node in nodelist)
            {
                TK_TaiXe a;
                string tk = node["Username"].InnerText;
                string mk = node["Password"].InnerText;
                int sdt = int.Parse(node["SDT"].InnerText);
                int tt = int.Parse(node["TrangThai"].InnerText);
                int loai = int.Parse(node["Loai"].InnerText);
                string ms = node["MaSo"].InnerText;
                string ten = node["Ten"].InnerText;
                string kh = node["KhachHang"].InnerText;
                string start = node["DiaChiDon"].InnerText;
                string end = node["DiaChiDen"].InnerText;
                double kc = double.Parse(node["KhoangCach"].InnerText);
                int gd = int.Parse(node["GioDon"].InnerText);
                string nd = node["NgayDi"].InnerText;

                if (loai == 1)
                {
                    a = new XeGanMay(tk, mk, sdt, tt, ms, ten,"Xe gan may", kh, start, end, kc, gd, nd);
                }
                else if (loai == 2)
                {
                    int cn = int.Parse(node["ChoNgoi"].InnerText);
                    a = new Xe_OTo(tk, mk, sdt, tt, ms, ten,"Xe O to", kh, start, end, kc, gd, nd, cn);
                }
                else
                {
                    int trongtai = int.Parse(node["TrongTai"].InnerText);
                    a = new Xe_OTo_Tai(tk, mk, sdt, tt, ms, ten,"Xe O to Tai", kh, start, end, kc, gd, nd, trongtai);
                }

                listTK.Add(a);
            }
        }

        public void xuatDS()
        {
            Console.WriteLine("<<<<<<<DANH SACH CAC TAI KHOAN>>>>>>>");
            foreach (TaiKhoan tk in listTK)
            {
                Console.WriteLine("-----------------------------------------------------------------");
                tk.xuat();
            }
        }

        public void dang_Nhap_TK()
        {
            Console.Write("Hay nhap ten tai khoan (username) ma ban muon goi:");
            string a = Console.ReadLine();
            Console.Write("Nhap mat khau (password) cua nguoi do:");
            string b = Console.ReadLine();
            foreach (TaiKhoan tk in listTK)
            {
                if (tk.Username.Equals(a) || tk.Pass.Equals(b))
                {
                    Console.WriteLine("Dang nhap thanh cong");
                    tk.TrangThai = 1;
                    return;
                }
            }
            Console.WriteLine("Tai khoan hoac mat khau khong trung khop!");
            Console.WriteLine("Hoac khong co tai khoan nao ton tai trong danh sach!");
        }

        public void goi_TaiXe()
        {
            Console.WriteLine("Hanh khach nao muon goi tai xe???");
            Console.Write("Hanh khach:");
            string a = Console.ReadLine();
            List<TK_Khach> khach = listTK.OfType<TK_Khach>().ToList().Where(t => t.Username == a && t.TrangThai==1).ToList();
            if (khach.Count()==0)
            {
                Console.WriteLine("Khong co username khach nao ton tai trong danh sach hoac trang thai cua ho dang offline!!!");
                return;
            }
            Console.Write("Ban muon goi tai xe nao? Hay nhap ten (username) cua ho:");
            string b = Console.ReadLine();
            List<TK_TaiXe> tx = listTK.OfType<TK_TaiXe>().ToList();
            foreach (TK_TaiXe item in tx)
            {
                if (item.Username.Equals(b) && item.TrangThai==1)
                {
                    Console.WriteLine("Goi thanh cong!!!");
                    return;
                }
            }
            Console.WriteLine("Username tai xe khong ton tai hoac cac tai xe van chua online!!!");
        }
    }
}
