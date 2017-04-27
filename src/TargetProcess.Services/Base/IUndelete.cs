using System.Threading.Tasks;

namespace TargetProcess.Base
{
    public interface IUndelete<T>
    {
        Task<T> Undelete(T model);
    }
}