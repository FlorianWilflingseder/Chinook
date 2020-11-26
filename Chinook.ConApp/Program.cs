using System;

namespace Chinook.ConApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Chinook-Marketing!");

			var albums = Logic.Factory.GetAllAlbums();
			var artists = Logic.Factory.GetAllArtists();
			var genre = Logic.Factory.GetAllGenres();
			var customer = Logic.Factory.GetAllCustomers();
			var employee = Logic.Factory.GetAllEmployee();
			var invoice = Logic.Factory.GetAllInvoice();
			var invoiceLine = Logic.Factory.GetAllInvoiceLine();
			var mediaType = Logic.Factory.GetAllMediaType();
			var playlist = Logic.Factory.GetAllPlaylist();
			var playlistTrack = Logic.Factory.GetAllPlaylistTrack();
			var roomData = Logic.Factory.GetAllRoomData();
			var track = Logic.Factory.GetAllTrack();

			var artistStatistics = Report.MarketingReports.GetArtistStatistics();
		}
	}
}
