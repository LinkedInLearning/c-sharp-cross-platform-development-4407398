using System;
namespace HelloNoteApp.Commands
{
	public class SearchNoteCommand : ICommand
	{

		private readonly AppDbContext _dbContext;

		public SearchNoteCommand(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public void Execute()
		{

			Console.WriteLine("Please provide a keyword to search for in the notes:");
			var keyword = Console.ReadLine();

			var notesQuery = _dbContext.Notes.Where(n => n.Title.Contains(keyword) || n.Content.Contains(keyword));

			var notes = notesQuery.ToList();

			if(notes.Any())
			{

				foreach(var note in notes)
				{
					Console.WriteLine($"Title: {note.Title}");
					Console.WriteLine($"Content: {note.Content}");
					Console.WriteLine("----------------------------");
				}

			}
			else
			{
				Console.WriteLine("No notes found with the provided keyword.");
			}
		}
	}
}

