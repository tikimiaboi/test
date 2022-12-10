using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truonghoc
{
    abstract class ThongTinHocSinh
    {
        protected string mshs, hoten;
        protected int namsinh;
        protected abstract int tienhocphi();

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap Ma So Hoc Sinh:");
            mshs = Console.ReadLine();
            Console.WriteLine("Nhap Ho Ten Hoc Sinh:");
            hoten = Console.ReadLine();
            Console.WriteLine("Nhap Nam Sinh:");
            namsinh = int.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        { Console.WriteLine($"\n Ma So Hoc Sinh:{mshs}\t Ho Ten:{hoten}\t Nam Sinh:{namsinh}"); }


    }
}
