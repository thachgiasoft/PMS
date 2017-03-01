using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMS.Common
{
    public class TuyChon
    {
        private String _giaTri;
        private String _theHien;
        //private String _theHien02;
        //private String _theHien03;

        public String GiaTri
        {
            get { return _giaTri; }
            set { _giaTri = value; }
        }

        public String TheHien
        {
            get { return _theHien; }
            set { _theHien = value; }
        }

        public TuyChon(String gia_tri, String the_hien)
        {
            _giaTri = gia_tri;
            _theHien = the_hien;
        }

        public override string ToString()
        {
            return _theHien;
        }
    }
}
