using System;
using System.Linq;

namespace TreehouseDefense
{
    public class Path
    {
        private readonly MapLocation[] _pathLocations;

        public Path(MapLocation[] pathLocations)
        {
            this._pathLocations = pathLocations;
        }

        public bool IsOnPath(MapLocation mapLocation) => _pathLocations.Contains(mapLocation);
        
    }
}