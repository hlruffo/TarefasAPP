using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefasApp.Domain.Interfaces.Repositories
{
    /// <summary>
    /// interface generica para construção dos métodos do repositório
    /// </summary>
    public interface IBaseRepository<T>
        where T : class

    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        T GetById(Guid id);
    }
}
