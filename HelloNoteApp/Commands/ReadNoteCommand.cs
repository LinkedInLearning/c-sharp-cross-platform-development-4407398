using System;
namespace HelloNoteApp.Commands
{
	public class ReadNoteCommand : ICommand
	{

		private readonly AppDbContext _dbContext;

		public ReadNoteCommand(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public void Execute()
		{

			Console.WriteLine("What note do you want to read:");
			var title = Console.ReadLine();

			var note = _dbContext.Notes.FirstOrDefault(n => n.Title == title);

			if(note != null)
			{
				Console.WriteLine($"Title: {note.Title}");
				Console.WriteLine($"Content: {note.Content}");
			}
			else
			{
				Console.WriteLine("No note was found.");
			}

		}
	}
}

