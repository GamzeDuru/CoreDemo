using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repostories
{
    public class BlogRepostory : IBlogDal
    {
        Context c = new Context();

        public void AddBlog(Blog blog)
        {
            c.Add(blog);
            c.SaveChanges();
           
        }

        public void Delete(Blog blog)
        {
            c.Remove(blog);
            c.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            c.Remove(blog);
            c.SaveChanges();
           
        }

        public Blog GetById(int id)
        {
            return c.Blogs.Find(id);
           
        }

        public List<Blog> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAllBlog()
        {
            return c.Blogs.ToList();
        }

        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            c.Update(blog);
            c.SaveChanges();
           
        }
    }
}
