using System;
namespace HelloNoteApp.Commands
{
	public class CreateNoteCommand : ICommand
	{

		private readonly AppDbContext _dbContext;

		public CreateNoteCommand(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public void Execute()
		{

			Console.WriteLine("Provide a title for your note:");
			var title = Console.ReadLine();

			Console.WriteLine("Add the content for your note:");
			var content = Console.ReadLine();

			var note = new Note()
			{
				Title = title,
				Content = content
			};

			_dbContext.Notes.Add(note);

			_dbContext.SaveChanges();

			Console.WriteLine("Your note was created successfully!");

		}
	}
}

