using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Iletisim
    {
        public int IletisimID { get; set; }
        public string IletisimUsername { get; set; }
        public string IletisimMail { get; set; }
        public string IletisimSubject { get; set; }
        public string IletisimMessage { get; set; }
        public string IletisimImage { get; set; }
        public DateTime IletisimCreate { get; set; }
        public bool IletisimStatus { get; set; }
    }
}
