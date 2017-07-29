using Lob.Models;

namespace Lob.Interfaces
{
    public interface ICancelService
    {
        Cancellation Cancel(string id);
    }
}
