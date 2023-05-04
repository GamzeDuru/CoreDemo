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
    public class PsikologRepostory : IPsikologDal
    {
        Context c = new Context();
        public void AddPsikolog(Psikolog psikolog)
        {
            c.Add(psikolog);
            c.SaveChanges();
        }

        public void Delete(Psikolog t)
        {
            throw new NotImplementedException();
        }

        public void DeletePsikolog(Psikolog psikolog)
        {
            c.Remove(psikolog);
            c.SaveChanges();
        }

        public Psikolog GetById(int id)
        {
            return c.Psikologs.Find(id);
            
        }

        public List<Psikolog> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Psikolog t)
        {
            throw new NotImplementedException();
        }

        public List<Psikolog> ListAllPsikolog()
        {
            return c.Psikologs.ToList();
        }

        public void Update(Psikolog t)
        {
            throw new NotImplementedException();
        }

        public void UpdatePsikolog(Psikolog psikolog)
        {
            c.Update(psikolog);
            c.SaveChanges();
        }
    }
}
