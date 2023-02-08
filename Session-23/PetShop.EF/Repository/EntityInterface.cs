using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repository {
    public interface EntityInterface<TEntity> {

        IList<TEntity> GetAll();
        TEntity? GetByID(int id);
        void Add(TEntity entity);
        void Update(int id,TEntity entity);   
        void Delete(int id);
    }
}
