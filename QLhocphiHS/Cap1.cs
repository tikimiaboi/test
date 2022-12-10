using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truonghoc
{
    class Cap1 : ThongTinHocSinh
    {

        protected override int tienhocphi()
        {
            return 1000000;
        }
        public Cap1()
        { }
        public Cap1(string _mshs, string _hoten, int _namsinh)
        {
            mshs = _mshs;
            hoten = _hoten;
            namsinh = _namsinh;
            
        }
        public Cap1(Cap1 h)
        {
            mshs = h.mshs;
            hoten = h.hoten;
            namsinh = h.namsinh;

        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($" Tien Hoc Phi:{tienhocphi()}");
        }
    }
}
