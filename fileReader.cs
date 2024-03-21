public static class fileReader
{
    public static List<Route> GetRouteList(string fileName)
    {
        List<Route> routes = new List<Route>();
        foreach (string line in File.ReadLines(fileName))
        {
            string[] data = line.Split(';');
            Route route = new Route(
                firstCity: data[0],
                secondCity: data[1],
                distance: int.Parse(data[2]),
                price: int.Parse(data[3])
                );

            routes.Add(route);
        }

        foreach (Route route in routes)
        {
            Console.WriteLine("First city:" + route.FirstCity 
            + " Second City: " + route.SecondCity 
            + " Distance: " + route.Distance 
            + " Price: " + route.Price);
        }

        return new List<Route>();
    }

    public static List<string> GetCityList(string fileName)
    {
        List<string> cities = new List<string>();
        foreach (string line in File.ReadLines(fileName))
        {
            if(line != "1400")
            {
                string city = line;
                cities.Add(city);
            }
        }

        return new List<string>();
    }
}