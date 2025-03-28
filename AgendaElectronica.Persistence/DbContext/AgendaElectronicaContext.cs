

using AgendaElectronica.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgendaElectronica.Persistence;

public partial class AgendaElectronicaContext : DbContext
{
    public AgendaElectronicaContext(DbContextOptions<AgendaElectronicaContext> options) : base(options)
    {

    }

    #region DbSets

    public DbSet<Contacts> Contactos { get; set; }

    #endregion
}
