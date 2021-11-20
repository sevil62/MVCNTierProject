using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.IntRep
{
   public interface IRepository<T> where T:BaseEntity
    {
        //List Commonds

        List<T> GetAll();
        List<T> GetModifieds();
        List<T> GetActives();
        List<T> GetPassives();

        // Modifications Commands

        void Add(T item);
        void Update(T item);
        void Delete(T item);
        void Destroy(T item);



        //Linq Expression
        List<T> Where(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        object Select(Expression<Func<T, object>> exp);

        //Find
        T Find(int id);
    }
}
