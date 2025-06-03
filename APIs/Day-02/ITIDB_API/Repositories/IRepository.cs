namespace ITIDB_API.Repositories
{
    public interface IRepository<T>
    {
        List<T>? GetAll();
        T? GetById(int id);
        void DeleteById(int id);
        void Update(T entity);
        void Insert(T entity);
        void Save();
    }
}
