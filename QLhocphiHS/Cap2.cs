using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truonghoc
{
    class Cap2 : ThongTinHocSinh
    {

        public string lp;
        public int lophoc
        {
            get
            {
                if (lp == "lop chon"||lp=="Lop chon"||lp=="Lop Chon")
                    return 2000000;
                else
                    return 1000000;
            }
        }
        public Cap2()
        { }
        public Cap2(string _mshs, string _hoten, int _namsinh,string _lp)
        {
            mshs = _mshs;
            hoten = _hoten;
            namsinh = _namsinh;
            lp = _lp;

        }
        public Cap2(Cap2 h)
        {
            mshs = h.mshs;
            hoten = h.hoten;
            namsinh = h.namsinh;
            lp = h.lp;

        }
        protected override int tienhocphi()
        {
            return lophoc;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap Lop Chon hoac Lop Thuong:");
            lp = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($" Tien Hoc Phi:{tienhocphi()}\t Lop Hoc Da Chon:{lp}");
        }
    }
}
