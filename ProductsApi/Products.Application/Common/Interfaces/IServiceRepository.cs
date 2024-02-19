using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Common.Interfaces
{
    public interface IServiceRepository<T>
    {
        //Od ova ke nasleduvaat site repositorija
        //Zatoa sto imame operacii so baza i sakame da gi napravime async metodite, response sekogas treba da e Task
        Task<T> Get(Guid id); //T ke vrati nekoja klasa

        Task<List<T>> GetAll();

        Task<string> Delete(Guid id);

        Task<string> Add(T entity, string Id);
        
    }
}
