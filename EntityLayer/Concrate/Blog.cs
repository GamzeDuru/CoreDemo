using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EntityLayer.Concrate
{
    public class Blog
    {
        public int BlogID { get; set; }
        public bool BlogStatus { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogCreateDate { get; set; }
        public  string BlogImage { get; set; }

        public int PsikologID { get; set; }
        public Psikolog Psikolog { get; set; }

    }
}
