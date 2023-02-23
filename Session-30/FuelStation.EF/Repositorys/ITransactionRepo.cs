using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositorys {
    public interface ITransactionRepo<TEntity> {
        IList<TEntity> GetAll();
        TEntity? GetByID(int id);
        void Add(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id);
        IList<Transaction> GetCustomerTransactions(int id);
    }
}
