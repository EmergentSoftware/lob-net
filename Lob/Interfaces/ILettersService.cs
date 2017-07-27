using Lob.Data;
using Lob.Models;

namespace Lob.Interfaces
{
    public interface ILettersService
    {
        Letter Create(Letter letter);
        Letter Retrieve(string id);
        LetterCancellation Cancel(string id);
    }
}
