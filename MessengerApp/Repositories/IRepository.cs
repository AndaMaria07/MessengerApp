namespace MessengerApp.Repositories
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id);
        ICollection<T> FindAll();
        T FindById(Guid id);
        T FindByIdWithData(Guid id);

    }
}
