using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientForFPGAService
{
    class ProjectInfo
    {
        public ProjectInfo(string name, string lastUpdate, string description, string version)
        {
            Name = name;
            LastUpdate = lastUpdate;
            Description = description;
            Version = version;
        }

        public string Name { get; set; }
        public string LastUpdate { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
    }
}
