using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data;
using Controle_Veiculos.Classes.ConexaoBanco;
using Controle_Veiculos.Classes.Model;

namespace Controle_Veiculos.Classes.Persistencia
{
    public class DistanceAPIClasses
    {
        public class GeocodedWaypoint
        {
            public string geocoder_status { get; set; }
            public bool partial_match { get; set; }
            public string place_id { get; set; }
            public List<string> types { get; set; }
        }

        public class Northeast
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class Southwest
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class Bounds
        {
            public Northeast northeast { get; set; }
            public Southwest southwest { get; set; }
        }

        public class Distance
        {
            public string text { get; set; }
            public int value { get; set; }
        }

        public class Duration
        {
            public string text { get; set; }
            public int value { get; set; }
        }

        public class EndLocation
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class StartLocation
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class Distance2
        {
            public string text { get; set; }
            public int value { get; set; }
        }

        public class Duration2
        {
            public string text { get; set; }
            public int value { get; set; }
        }

        public class EndLocation2
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class Polyline
        {
            public string points { get; set; }
        }

        public class StartLocation2
        {
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class Step
        {
            public Distance2 distance { get; set; }
            public Duration2 duration { get; set; }
            public EndLocation2 end_location { get; set; }
            public string html_instructions { get; set; }
            public Polyline polyline { get; set; }
            public StartLocation2 start_location { get; set; }
            public string travel_mode { get; set; }
            public string maneuver { get; set; }
        }

        public class Leg
        {
            public Distance distance { get; set; }
            public Duration duration { get; set; }
            public string end_address { get; set; }
            public EndLocation end_location { get; set; }
            public string start_address { get; set; }
            public StartLocation start_location { get; set; }
            public List<Step> steps { get; set; }
            public List<object> via_waypoint { get; set; }
        }

        public class OverviewPolyline
        {
            public string points { get; set; }
        }

        public class Route
        {
            public Bounds bounds { get; set; }
            public string copyrights { get; set; }
            public List<Leg> legs { get; set; }
            public OverviewPolyline overview_polyline { get; set; }
            public string summary { get; set; }
            public List<object> warnings { get; set; }
            public List<object> waypoint_order { get; set; }
        }

        public class RootObject
        {
            public List<GeocodedWaypoint> geocoded_waypoints { get; set; }
            public List<Route> routes { get; set; }
            public string status { get; set; }
        }

        public bool CalcularDistanciaEDuracao(string origem, string destino, out double distancia, out double duracao)
        {
            bool sucesso = false;
            distancia = duracao = 0;

            try
            {
                string url = string.Format("http://maps.googleapis.com/maps/api/directions/json?origin={0}&destination={1}&sensor=false", origem, destino);
                System.Net.WebRequest request = System.Net.HttpWebRequest.Create(url);
                System.Net.WebResponse response = request.GetResponse();
                using (var reader = new System.IO.StreamReader(response.GetResponseStream()))
                {
                    System.Web.Script.Serialization.JavaScriptSerializer parser = new System.Web.Script.Serialization.JavaScriptSerializer();
                    string responseString = reader.ReadToEnd();
                    RootObject responseData = parser.Deserialize<RootObject>(responseString);
                    if (responseData != null)
                    {
                        double distanciaRetornada = responseData.routes.Sum(r => r.legs.Sum(l => l.distance.value));
                        double duracaoRetornada = responseData.routes.Sum(r => r.legs.Sum(l => l.duration.value));
                        if (distanciaRetornada != 0)
                        {
                            sucesso = true;
                            distancia = distanciaRetornada;
                            duracao = duracaoRetornada;
                        }
                    }
                }
            }
            catch { }

            return sucesso;
        }
    }
}
