// See https://aka.ms/new-console-template for more information

string routeFile = "./assets/rutas.txt";
string cityFile = "./assets/ciudades.txt";

List<Route> routes = fileReader.GetRouteList(routeFile);
List<string> cities = fileReader.GetCityList(cityFile);
// fileReader.PrintRouteList(routes);

Random random = new Random();
List<string> usedCities = new List<string>();
List<Route> solutionData = new List<Route>();
string currentCity = "";

int cost = -1;
int distance = -1;
while (cost > 1035 || distance > 13885 || (cost == -1 && distance == -1))
{
    currentCity = cities[random.Next(0, cities.Count())];
    usedCities = new List<string>
    {
        currentCity
    };
    cost = 0;
    distance = 0;
    solutionData = new List<Route>();
    while (usedCities.Count != cities.Count + 1)
    {
        if (usedCities.Count != cities.Count)
        {
            Route currentRoute = routes.Where(x => x.FirstCity.Equals(currentCity) && !usedCities.Contains(x.SecondCity)).ToList().OrderBy(x => x.Price).First();
            usedCities.Add(currentRoute.SecondCity);
            cost += currentRoute.Price;
            distance += currentRoute.Distance;
            currentCity = currentRoute.SecondCity;
            solutionData.Add(currentRoute);
        }
        else
        {
            Route currentRoute = routes.Where(x => x.FirstCity.Equals(currentCity) && x.SecondCity.Equals(usedCities[0])).ToList().OrderBy(x => x.Price).First();
            usedCities.Add(currentRoute.SecondCity);
            cost += currentRoute.Price;
            distance += currentRoute.Distance;
            currentCity = currentRoute.SecondCity;
            solutionData.Add(currentRoute);
        }
    }

    Console.WriteLine("-----------------------------------------");
    Console.WriteLine(cost);
    Console.WriteLine(distance);
    Console.WriteLine("-----------------------------------------");

    fileReader.WriteData(solutionData);
}

