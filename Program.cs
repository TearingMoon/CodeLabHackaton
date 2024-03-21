

// See https://aka.ms/new-console-template for more information

string routeFile = "./assets/rutas.txt";
string cityFile = "./assets/ciudades.txt";

List<Route> routes = fileReader.GetRouteList(routeFile);
List<string> cities = fileReader.GetRouteList(cityFile);
fileReader.PrintRouteList(routes);
