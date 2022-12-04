using DomainLayer.Entities;


namespace ServiceLayer.Services.Interfaces
{
    public interface ILibraryService
    {
        Library Create(Library library);

        Library Update(int id , Library library);
        void Delete(int id);
        
        Library GetById(int? id);
        Library GetByName(int id);
        List<Library> GetAll();

    }
}
