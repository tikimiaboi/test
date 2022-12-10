using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Truonghoc
{
    class DSThongTinHocSinh
    {
        List<ThongTinHocSinh> lst = new List<ThongTinHocSinh>();
        public void Nhapds(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(@"D:\C#\baick\bai1\bai1\TTHS.xml");
            XmlNodeList nodelist = read.SelectNodes("ThongTinHocSinhs/ThongTinHocSinh");
            foreach (XmlNode node in nodelist)
            {
                ThongTinHocSinh tths;
                string Lop = node["Lop"].InnerText;
                string Mshs = node["Mshs"].InnerText;
                string hoten = node["hoten"].InnerText;
               
                int NamSinh = int.Parse(node["NamSinh"].InnerText);
                
                if (Lop == "Cap1")
                    tths = new Cap1(Mshs,hoten,NamSinh);
                else if (Lop == "Cap2")
                {
                    string lp =node["lp"].InnerText;
                    tths = new Cap2(Mshs,hoten,NamSinh,lp);
                }
                else
                {
                    string PhanBan = node["PhanBan"].InnerText;
                    tths = new Cap3(Mshs,hoten,NamSinh,PhanBan);
                }
                lst.Add(tths);
            }

        }
        public void Xuatds()
        {
            foreach (ThongTinHocSinh h in lst)
            {
                h.Xuat();
            }
        }
    }
}

