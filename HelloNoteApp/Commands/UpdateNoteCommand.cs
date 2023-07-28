using System;
namespace HelloNoteApp.Commands
{
	public class UpdateNoteCommand : ICommand
	{

		private readonly AppDbContext _dbContext;

		public UpdateNoteCommand(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public void Execute()
		{

			Console.WriteLine("Please provide the title of the note you wish to update:");
			var title = Console.ReadLine();

			var note = _dbContext.Notes.FirstOrDefault(n => n.Title == title);

			if(note != null)
			{

				Console.WriteLine("Please enter the new content for your note:");
				var newContent = Console.ReadLine();

				note.Content = newContent;
				_dbContext.SaveChanges();

				Console.WriteLine("Your note was updated successfully!");

			}
			else
			{
				Console.WriteLine("No note was found with that title.");
			}
		}
	}
}

