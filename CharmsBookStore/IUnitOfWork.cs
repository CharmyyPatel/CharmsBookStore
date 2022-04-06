namespace CharmsBooks
{
    public interface IUnitOfWork
    {
        object Category { get; }

        void Save();
    }
}