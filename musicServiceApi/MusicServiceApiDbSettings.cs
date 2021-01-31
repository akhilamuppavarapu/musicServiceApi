using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace musicServiceApi
{
    public class MusicServiceApiDbSettings : IMusicServiceApiDbSettings
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }

    }

    public interface IMusicServiceApiDbSettings
    {
        string ConnectionString { get; set; }

        string DatabaseName { get; set; }
    }

}
