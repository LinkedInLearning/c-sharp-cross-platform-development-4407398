using System;
namespace HelloNoteApp.Commands
{
	public class DeleteNoteCommand : ICommand
	{

		private readonly AppDbContext _dbContext;

		public DeleteNoteCommand(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public void Execute()
		{

			Console.WriteLine("Please provide the title of the note you wish to delete:");
			var title = Console.ReadLine();

			var note = _dbContext.Notes.FirstOrDefault(n => n.Title == title);

			if(note != null)
			{

				_dbContext.Notes.Remove(note);
				_dbContext.SaveChanges();

				Console.WriteLine("Your note was deleted successfully!");

			}
			else
			{
				Console.WriteLine("No note was found with that title.");
			}

		}
	}
}

