using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVC
{
    class GiangVien : Khoa
    {

        public GiangVien(string _mvc, string _tvc, int _namsinh, string _gioitinh,double _hsl,int _tn)
        {
            mvc = _mvc;
            tvc = _tvc;
            namsinh = _namsinh;
           string gioitinh= _gioitinh;
            hsl = _hsl;
            tn = _tn;
        }
        protected int spkh;
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("So san pham ngien cuu khoa hoc:");
            spkh=int.Parse(Console.ReadLine());
        }
        public override double Luong()
        {
            return hsl * luongcoban;
        }

        public override char XepLoai()
        {
            if (spkh >= 3)
                return 'A';
            else if (spkh == 2)
                return 'B';
            else if (spkh == 1)
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
