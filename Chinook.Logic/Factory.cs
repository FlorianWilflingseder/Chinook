using System.Collections.Generic;

namespace Chinook.Logic
{
	public class Factory
	{
		public static IEnumerable<Contracts.Persistence.IGenre> GetAllGenres()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Genre>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.IArtist> GetAllArtists()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Artist>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.IAlbum> GetAllAlbums()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Album>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.IAlbum> GetAllCustomers()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Album>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.IAlbum> GetAllEmployee()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Album>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.IAlbum> GetAllGenre()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Album>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.IAlbum> GetAllInvoice()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Album>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.IAlbum> GetAllInvoiceLine()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Album>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.IAlbum> GetAllMediaType()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Album>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.IAlbum> GetAllPlaylist()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Album>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.IAlbum> GetAllPlaylistTrack()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Album>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.IAlbum> GetAllRoomData()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Album>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.IAlbum> GetAllTrack()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Album>();

			return result;
		}

	}
}
