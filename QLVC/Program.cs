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
            ds.Nhapds("visual studio 2015 dung xoa\\QLVC\\QLVC\\khoa.xml");
            ds.Xuatds();
            Console.ReadLine();
        }
    }
}
