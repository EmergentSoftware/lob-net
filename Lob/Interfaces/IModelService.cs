using Lob.Models;

namespace Lob.Interfaces
{
    public interface IModelService<T>
    {
        T Create(T model);
        T Retrieve(string id);
        Cancellation Cancel(string id);
        ModelList<T> List(int limit, int offset);
    }
}
