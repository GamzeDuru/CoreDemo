﻿using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogServices
    {
        void BlogAdd(Blog blog);
        void BlogUpdate(Blog blog);
        void BlogDelete(Blog blog);
        List<Blog> GetList();
        Blog GetById(int id);
    }
}
