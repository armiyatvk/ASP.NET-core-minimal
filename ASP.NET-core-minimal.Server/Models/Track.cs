using System.Text.Json.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace MusicPlaylist.Server.Models;

public class Track
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Artist { get; set; }

    //navigation properties
    public int PlaylistId { get; set; }

    //since playlist needs track and track need playlist, it's a circular relationship, which json doen't like, that why we used JsonIgnore here
    [JsonIgnore]
    public Playlist Playlist { get; set; }
}