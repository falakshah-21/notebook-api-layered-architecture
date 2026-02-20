using Microsoft.AspNetCore.Mvc;
using Notebook.Models;
using Notebook.Services;

namespace Notebook.Controllers
{
    [ApiController]
    [Route("notes")]
    public class NotesController : ControllerBase
    {
        private readonly INoteService _noteService;

        public NotesController(INoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Note>>> GetNotes()
        {
            var notes = await _noteService.GetAllAsync();
            return Ok(notes);
        }

        [HttpPost]
        public async Task<ActionResult<Note>> AddNote(Note note)
        {
            var createdNote = await _noteService.AddAsync(note);
            return Created("", createdNote);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateNote(int id, Note note)
        {
            var result = await _noteService.UpdateAsync(id, note);
            if (!result) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteNote(int id)
        {
            var result = await _noteService.DeleteAsync(id);
            if (!result) return NotFound();

            return NoContent();
        }

    }
}
