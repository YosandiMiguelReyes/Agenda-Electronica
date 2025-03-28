using AgendaElectronica.Domain.Entities;
using AgendaElectronica.Persistence.Interfaces;
using AgendaElectronica.Persistence.Repositories;
using System.Collections.Generic;
using System.Linq;


namespace AgendaElectronica.BusinessLogic.Services
{
    // Servicio para manejar contactos
    public class ContactService
    {
        private readonly IContactsRepository _contactRepository;

        public ContactService(IContactsRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public void AddContact(Contacts contact)
        {
            _contactRepository.Add(contact);
        }

        public void UpdateContact(Contacts contact)
        {
            _contactRepository.Update(contact);
        }

        public void DeleteContact(int id)
        {
            _contactRepository.Delete(id);
        }
    }
}
