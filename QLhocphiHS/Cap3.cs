using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truonghoc
{
    class Cap3 : ThongTinHocSinh
    {
        private string phanban;

        public Cap3()
        { }
        public Cap3(string _mshs, string _hoten, int _namsinh,string _phanban)
        {
            mshs = _mshs;
            hoten = _hoten;
            namsinh = _namsinh;
            phanban = _phanban;

        }
        public Cap3(Cap3 h)
        {
            mshs = h.mshs;
            hoten = h.hoten;
            namsinh = h.namsinh;
            phanban = h.phanban;

        }
        public string PhanBan
        {
            get { return phanban; }
            set
            {
                if (value == "tu nhien" ||value=="Tu nhien"||value=="Tu Nhien"|| value == "xa hoi"||value=="Xa hoi"||value=="Xa Hoi")
                    phanban = value;
                else
                    Console.WriteLine("Sai Du Lieu !!!");
            }
        }

        protected override int tienhocphi()
        {
            if (PhanBan == "tu nhien"|| PhanBan=="Tu nhien"||PhanBan=="Tu Nhien")
                return 1500000;
            else
                return 1200000;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Chon Ban:");
            PhanBan = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($" Tien Hoc Phi:{tienhocphi()}\t Lop Hoc Da Chon:{PhanBan}");
        }
    }
}

