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

		}
	}
}

