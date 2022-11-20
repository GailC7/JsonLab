using System;
namespace JsonLab.Models
{
	public class Book
	{
		
		public Items[] Items { get; set; }
		
		public Book(Items[] items)
		{
			Items = items;
		}

		public override string ToString()
		{
			string bookString = "";
			bookString += $"{Items[0].VolumeInfo.Title}\n"; 
			bookString += $"{string.Join(" & ", Items[0].VolumeInfo.Authors)}\n";
			bookString += $"\n{Items[0].VolumeInfo.Description}\n\n";
			bookString += $"{Items[0].SelfLink}\n";
			bookString += $"{Items[0].Id}\n\n";

			return bookString;
		}
	
	}
}

