namespace Mvp.Models.Repositories.Contracts
{
    public interface IActorRepository
    {
        void Add(Actor model);
        void Edit(Actor model);
        void Delete(int id);

        IEnumerable<Actor> GetAll();
        IEnumerable<Actor> GetByValue(string value);
    }
}
