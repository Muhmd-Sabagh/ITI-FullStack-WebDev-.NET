namespace MyMVCWebApp.Repository
{
    public interface IRepository<T>
    {
        List<T>? GetAll();
        T? GetById(int id);
        void Add(T obj);
        void Update(T obj);
        void DeleteById(int id);
        void Save();
    }
}
