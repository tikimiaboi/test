using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QLVC
{
    class DSKhoa
    {
        List<Khoa> lst = new List<Khoa>();
        public void Nhapds(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(@"D:\visual studio 2015 dung xoa\QLVC\QLVC\khoa.xml");
            XmlNodeList nodelist = read.SelectNodes("Khoas/Khoa");
            foreach (XmlNode node in nodelist)
            {
                Khoa khoa;
                string lop = node["Lop"].InnerText;
                string Mvc = node["Mvc"].InnerText;
                string Tvc = node["Tvc"].InnerText;
                int Ns = int.Parse(node["Ns"].InnerText);
                string Gioitinh = node["Gioitinh"].InnerText;
                double hsl = double.Parse(node["hsl"].InnerText);
                int tn = int.Parse(node["tn"].InnerText);
                if (lop == "GiangVien")
                    khoa = new GiangVien(Mvc, Tvc, Ns, Gioitinh, hsl, tn);
                else if (lop == "Giaovukhoa")
                {
                    int hsql = int.Parse(node["hsql"].InnerText);
                    khoa = new Giaovukhoa(Mvc, Tvc, Ns, Gioitinh, hsl, tn, hsql);
                }
                else
                {
                    double hscv = double.Parse(node["hscv"].InnerText);
                    khoa = new CanBo(Mvc, Tvc, Ns, Gioitinh, hsl, tn, hscv);
                }
                lst.Add(khoa);
            }

        }
        public void Xuatds()
        {
            foreach ( Khoa k in lst)
            {
                k.Xuat();
            }
        }
    }
}
