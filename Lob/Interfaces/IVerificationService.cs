namespace Lob.Interfaces
{
    public interface IVerificationService<T, V>
    {
        T Verify(V model);
    }
}
