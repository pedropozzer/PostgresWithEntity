using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityOnPostgres2
{
    [System.Xml.Serialization.XmlRoot("ArtistAlbums")]
    public class ArtistAlbums
    {
        public string Artist { get; set; }
        public long Albuns { get; set; }
    }
}
