using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTHDT
{
    class Program
    {
        static void Main(string[] args)
        {
            CongTy_QuanLy ql = new CongTy_QuanLy();
            int chon;
            do
            {
                Console.WriteLine("<<<===$$$===---HE THONG QUAN LY TAI KHOAN---===$$$===>>>");
                Console.WriteLine("1. Dang nhap vao he thong quan ly Tai Khoan");
                Console.WriteLine("0. Thoat chuong trinh!!!");
                Console.WriteLine("<<<==================================================>>>");
                Console.Write("Hay nhap lua chon:");
                chon = int.Parse(Console.ReadLine());
                if (chon==1)
                {
                    int chon1;
                    Console.WriteLine("<<<===Dang nhap voi quyen administrator===>>>");
                    Console.WriteLine("Ban can nhap tai khoan va mat khau moi co the vao dc he thong!!!");
                    Console.WriteLine("Luu y: Nhap sai qua 3 lan se bi out khoi he thong!!!");
                    Console.Write("Nhap Tai Khoan:");
                    string a = Console.ReadLine();
                    Console.Write("Nhap Mat Khau:");
                    string b = Console.ReadLine();
                    int t = 0;
                    while (dangNhap(a,b)==0 && t<2)
                    {
                        Console.WriteLine("Tai khoan hoac Mat khau khong dung! Vui long nhap lai!!");
                        Console.Write("Nhap Tai Khoan:");
                        a = Console.ReadLine();
                        Console.Write("Nhap Mat Khau:");
                        b = Console.ReadLine();
                        t++;
                    }

                    do
                    {
                        menu();
                        Console.Write("Nhap lua chon:");
                        chon1 = int.Parse(Console.ReadLine());

                        if (chon1==1)
                        {
                            Console.WriteLine("Ban da nhap XML!");
                            ql.nhapXML("..\\..\\duLieu.xml");
                        }
                        else if (chon1==2)
                        {
                            ql.xuatDS();
                        }
                        else if (chon1==3)
                        {
                            ql.dang_Nhap_TK();
                        }
                        else if (chon1==4)
                        {
                            ql.goi_TaiXe();
                        }
                    } while (chon1!=0);
                }
            } while (chon!=0);
            Console.ReadKey();
        }
        static int dangNhap(string a, string b)
        {
            int t = 0;
            if (a.Equals("admin123") && b.Equals("123"))
            {
                t = 1;
            }

            return t;
        }

        static void menu()
        {
            Console.WriteLine("==============================MENU===============================");
            Console.WriteLine("1. Nhap XML");
            Console.WriteLine("2. Xuat danh sach cac TAI KHOAN dang duoc quan ly");
            Console.WriteLine("3. Dang nhap vao cac tai khoan trong danh sach");
            Console.WriteLine("4. Thuc hien cac thao tac goi tai xe!");
            Console.WriteLine("0. Dang Xuat!!!");
            Console.WriteLine("=================================================================");
        }
    }
}
