using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositorys {
    public interface ICustomer<TEntity> {
        IList<TEntity> GetAll();
        TEntity? GetByID(int id);
        void Add(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id);
        TEntity? FindCustomerByCardNumber(string cardNumber);
    }
}
