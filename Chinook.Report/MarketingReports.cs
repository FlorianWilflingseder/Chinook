using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Report
{
	public class MarketingReports
	{
		public static IEnumerable<Contracts.Report.Marketing.IArtistStatistic> GetArtistStatistics()
		{
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



			var result = default(IEnumerable<Contracts.Report.Marketing.IArtistStatistic>);

			return result;
		}
        public static IEnumerable<IArtistStatistic> GetArtistStatistics()
        {
            var artists = Logic.Factory.GetAllArtists();

            var result = default(IEnumerable<IArtistStatistic>);

            return result;
        }

        public static (double avg, ITrackTime max, ITrackTime min) GetTrackTimes()
        {
            ITrack max = tracks.Aggregate((a, b) => a.Miliseconds > b.Miliseconds ? a : b);
            ITrack min = tracks.Aggregate((a, b) => a.Miliseconds < b.Miliseconds ? a : b);
            double avg = tracks.Average(c => c.Miliseconds);

            return (avg, new TrackTime() { Name = max.Name, Seconds = max.Miliseconds / 1000 }, new TrackTime() { Name = min.Name, Seconds = min.Miliseconds / 1000 });
        }

        public static (double avg, IAlbumTime max, IAlbumTime min) GetAlbumTime()
        {
            var new_tracks = (from pl in tracks
                              group pl by pl.AlbumId into trackGroup
                              select new
                              {
                                  AlbumId = trackGroup.Key,
                                  TotalTime = trackGroup.Sum(x => x.Miliseconds) / 1000
                              }).OrderByDescending(c => c.TotalTime);

            var first = new_tracks.First();
            var last = new_tracks.Last();
            double avg = new_tracks.Average(c => c.TotalTime);

            IAlbum top = albums.ToList().Find(a => a.Id == first.AlbumId);
            IAlbum bottom = albums.ToList().Find(a => a.Id == last.AlbumId);

            return (avg, new AlbumTime()
            {
                Name = top.Title,
                Seconds = first.TotalTime
            }, new AlbumTime()
            {
                Name = bottom.Title,
                Seconds = last.TotalTime
            });
        }
    }
}
