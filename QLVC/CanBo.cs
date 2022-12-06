using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVC
{
    class CanBo : Khoa
    {
        public CanBo(string _mvc, string _tvc, int _namsinh, string _gioitinh, double _hsl, int _tn,double _hscv)
        {
            mvc = _mvc;
            tvc = _tvc;
            namsinh = _namsinh;
            string gioitinh = _gioitinh;
            hsl = _hsl;
            tn = _tn;
            hscv = _hscv;
        }
        protected double hscv;
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("He so chuc vu:");
            hscv = double.Parse(Console.ReadLine());
        }
        public override double Luong()
        {
            return hsl * luongcoban * (1 + hscv);
        }

        public override char XepLoai()
        {
            return 'A';
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Xep Loai:{XepLoai()}\t Luong:{Luong()}");
        }
    }
}
