

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string routeFile = "./assets/rutas.txt";
string cityFile = "./assets/ciudades.txt";

List<Route> routes = fileReader.GetRouteList(routeFile);
List<string> cities = fileReader.GetCityList(routeFile);

