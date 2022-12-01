using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVC
{
    abstract class Khoa
    {
        protected string mvc, tvc;
        protected int namsinh;
        //protected bool gioitinh;
        public string gioitinh()
        {
            bool nam = true;

            if (nam == true)
            {
                return "nam";
            }
            else
            {
                return "nu";
            }

        }
        protected double hsl;
        protected int tn;
        public static double luongcoban = 1409;
        public abstract char XepLoai();
        public abstract double Luong();
        public double phucaptn()
        {
            if (tn >= 5)
                return tn * 0.1 * hsl * luongcoban;
            else return 0;
        }
        public double ThuNhap()
        {
            char xl = XepLoai();
            if (xl == 'A')
                return Luong() + phucaptn();
            if (xl == 'B')
                return Luong() * 80 / 100 + phucaptn();
            if (xl == 'C')
                return Luong() * 50 / 100 + phucaptn();
            else
                return Luong() * 0 + phucaptn();
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ma vien chuc:");
            mvc = Console.ReadLine();
            Console.WriteLine("Nhap ten vien chuc:");
            tvc = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh:");
            namsinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gioi tinh:");
            string gioitinh = Console.ReadLine();
            Console.WriteLine("Nhap he so luong:");
            hsl = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tham nien:");
            tn = int.Parse(Console.ReadLine());


        }
        public virtual void Xuat()
        {
            Console.WriteLine($" \nMa Vien Chuc:{mvc}\t\t  He So Luong:{hsl}\t Tham Nien:{tn}");
            Console.WriteLine($"Ten Vien Chuc:{tvc}\t  Nam Sinh:{namsinh} \t Gioi Tinh:{gioitinh()}");
        }

    }
}
