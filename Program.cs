// See https://aka.ms/new-console-template for more information

string routeFile = "./assets/rutas.txt";    

List<Route> routes = fileReader.GetRouteList(routeFile);
fileReader.PrintRouteList(routes);

