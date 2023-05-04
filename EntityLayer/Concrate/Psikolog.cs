using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Psikolog
    {
        public string PsikologName { get; set; }

        public string PsikologSurname { get; set; }

        public int PsikologID { get; set; }

        public int PsikologTC { get; set; }

        public int PsikologDT { get; set; }

        public string PsikologPassword { get; set; }

        public string PsikologMail { get; set; }

        public string PsikologCinsiyet { get; set; }

        public string PsikologImage { get; set; }

        public string PsikologAbout { get; set; }

        public string PsikologYorum { get; set; }

        public bool PsikologStatus { get; set; }

        public List<Blog> Blogs {get; set;}


    }
}
