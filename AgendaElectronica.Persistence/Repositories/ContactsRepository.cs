

using AgendaElectronica.Domain.Entities;
using AgendaElectronica.Domain.Result;
using AgendaElectronica.Persistence.Baase;
using AgendaElectronica.Persistence.Interfaces;
using System.Runtime.CompilerServices;

namespace AgendaElectronica.Persistence.Repositories
{
    public class ContactsRepository(AgendaElectronicaContext agendacontext) : BaseRepository<Contacts>(agendacontext), IContactsRepository
    {
        private readonly AgendaElectronicaContext _agendaElectronicaContext = agendacontext;

        public List<OperationResult> FindContact(string name)
        {
            throw new NotImplementedException();
        }

        public List<OperationResult> GetContactById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
