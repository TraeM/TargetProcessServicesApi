using System.Threading.Tasks;

namespace TargetProcess.Services.Base
{
    public interface IUndelete<T>
    {
        Task<T> Undelete(T model);
    }
}