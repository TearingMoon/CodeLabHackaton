class Route
{
    public string FirstCity { get; set; }
    public string SecondCity { get; set; }
    public int Distance { get; set; }
    public int Price { get; set; }
    public Route(string firstCity, string secondCity, int distance, int price)
    {
        this.FirstCity = firstCity;
        this.SecondCity = secondCity;
        this.Distance = distance;
        this.Price = price;
    }
}