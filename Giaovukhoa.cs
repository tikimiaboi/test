using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVC
{
    class Giaovukhoa : Khoa
    {
        public Giaovukhoa(string _mvc, string _tvc, int _namsinh, string _gioitinh, double _hsl, int _tn,int _hsql)
        {
            mvc = _mvc;
            tvc = _tvc;
            namsinh = _namsinh;
            string gioitinh = _gioitinh;
            hsl = _hsl;
            tn = _tn;
            hsql = _hsql;
            
        }
        protected int hsql;
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Ho so quan li:");
            hsql = int.Parse(Console.ReadLine());
        }
        public override double Luong()
        {
            return hsl * luongcoban * 0.8;
        }

        public override char XepLoai()
        {
            if (hsql == 0)
                return 'A';
            else if (hsql == 1)
                return 'B';
            else if (hsql == 2)
                return 'C';
            else
                return 'D';
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"\t\t\t  Xep Loai:{XepLoai()}\t\t Luong:{Luong()}");
        }
    }
}
