using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alfa.Models
{
    public class ScreenLocationView
    {
        public Location Location { get; set; }
        public List<ScreenType> ScreenTypes { get; set; }
        public List<ScreenLocation> ScreenLocations { get; set; }
        public ScreenLocation ScreenLocation { get; internal set; }
    }
}
