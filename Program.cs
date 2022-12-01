using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khoa k = new Giaovukhoa();
            //k.Nhap();
            //k.Xuat();
            //Console.ReadLine();
            DSKhoa ds = new DSKhoa();
            ds.Nhapds("D:\\C#\bai1\\QLVC\\khoa.xml");
            ds.Xuatds();
            Console.ReadLine();
        }
    }
}
