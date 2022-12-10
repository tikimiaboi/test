using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truonghoc
{
    class Program
    {
        static void Main(string[] args)
        {
            //ThongTinHocSinh hss = new Cap1("03", "DinhDinh", 2003);
            //ThongTinHocSinh hss2 = new Cap2("04", "BaoBao", 2007, "Lop Chon");
            //ThongTinHocSinh hss3 = new Cap3("05", "DaiVi", 2000, "Xa hoi");
            //hss.Xuat();
            //hss2.Xuat();
            //hss3.Xuat();
            //ThongTinHocSinh hs = new Cap1();
            //hs.Nhap();
            //hs.Xuat();
            //ThongTinHocSinh hs2 = new Cap2();
            //hs2.Nhap();
            //hs2.Xuat();
            //ThongTinHocSinh hs3 = new Cap3();
            //hs3.Nhap();
            //hs3.Xuat();
            DSThongTinHocSinh ds = new DSThongTinHocSinh();
            ds.Nhapds("D:\\C#\\baick\\bai1\\bai1\\TTHS.xml");
            ds.Xuatds();
            Console.ReadLine();
        }
    }
}
