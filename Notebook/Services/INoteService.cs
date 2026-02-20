using Notebook.Models;

namespace Notebook.Services
{
    public interface INoteService
    {
        Task<List<Note>> GetAllAsync();
        Task<Note> AddAsync(Note note);
        Task<bool> UpdateAsync(int id, Note note);
        Task<bool> DeleteAsync(int id);
    }
}
