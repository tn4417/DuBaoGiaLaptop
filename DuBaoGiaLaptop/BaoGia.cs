using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuBaoGiaLaptop
{
    public class BaoGia
    {
        double _khoangCach, _gia;

        public double KhoangCach
        {
            get { return _khoangCach; }
            set { _khoangCach = value; }
        }

        public double Gia
        {
            get { return _gia; }
            set { _gia = value; }
        }

        public BaoGia(double khoangcach, double gia)
        {
            this.KhoangCach = khoangcach;
            this.Gia = gia;
        }
    }
}
