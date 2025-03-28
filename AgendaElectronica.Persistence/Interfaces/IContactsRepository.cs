using AgendaElectronica.Domain.Entities;
using AgendaElectronica.Domain.Repositories;
using AgendaElectronica.Domain.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaElectronica.Persistence.Interfaces
{
    public interface IContactsRepository : IBaseRepository<Contacts>
    {
        List<OperationResult> FindContact(string name);
        List<OperationResult> GetContactById(int id);
    }
}
