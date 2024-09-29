using GestionAPP.Domain.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAPP.Domain.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<OperationResult> GetAll();
        Task<OperationResult> GetById(int id);
        Task<OperationResult> add(T entity);
        Task<OperationResult> update(T entity);
        Task<OperationResult> delete(int id);
    }
}
