using System;
using Microsoft.EntityFrameworkCore;

namespace HelloNoteApp
{
	public class AppDbContext : DbContext
	{

		public DbSet<Note> Notes { get; set; }

		public string DbPath { get; }

		public AppDbContext()
		{

			var folder = Environment.SpecialFolder.LocalApplicationData;
			var path = Environment.GetFolderPath(folder);

			DbPath = Path.Join(path, "notes.db");

		}

		protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
    }
}

