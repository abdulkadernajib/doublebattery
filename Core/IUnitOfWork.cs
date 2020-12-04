using System.Threading.Tasks;

namespace doublebattery.Persistence
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}