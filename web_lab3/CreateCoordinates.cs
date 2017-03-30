using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace web_lab3
{
    class GetCoordinates
    {
        public async Task<Geoposition> GetCoordinates()
        {
            Geolocator geolocator = new Geolocator();
            Geolocator.DesiredAccuracy = PositionAccuracy.High;
        }
    }
}
