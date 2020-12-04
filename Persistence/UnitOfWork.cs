using System.Threading.Tasks;

namespace doublebattery.Persistence
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly DoubleBatteryDbContext context;
        public UnitOfWork(DoubleBatteryDbContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}