/**@author Mikey Dowsett */
// Create a list of countries with medal counts
List<OlympicCountry> countries = new List<OlympicCountry>();
countries.Add(new OlympicCountry("USA", 39, 41, 33));
countries.Add(new OlympicCountry("CHN", 38, 32, 18));
countries.Add(new OlympicCountry("ROC", 20, 28, 23));
countries.Add(new OlympicCountry("GBR", 22, 21, 22));
countries.Add(new OlympicCountry("JPN", 27, 14, 17));
countries.Add(new OlympicCountry("AUS", 17, 7, 22));
countries.Add(new OlympicCountry("ITA", 10, 10, 20));
countries.Add(new OlympicCountry("GER", 10, 11, 16));
countries.Add(new OlympicCountry("NED", 10, 12, 14));
countries.Add(new OlympicCountry("FRA", 10, 12, 11));

// Display countries with 20 or less bronze medals
Console.WriteLine("Countries with <= 20 bronze medals:");
var bronzeTwenty = 
    from country in countries
    where country.Bronze <= 20
    select country;

foreach(OlympicCountry country in bronzeTwenty)
    Console.WriteLine(country);

// Display countries sorted by silver medals
Console.WriteLine("\nCountries sorted by silver medals:");
var silverMedalSort =
    from country in countries
    orderby country.Silver
    select country;

foreach (OlympicCountry country in silverMedalSort)
    Console.WriteLine(country);

// Display countries sorted by gold, then by silver, and then
// by bronze in descending order
Console.WriteLine("\nCountries sorted by gold, silver, " +
"and bronze (Descending):");
var goldMedalSort =
    from country in countries
    orderby country.Gold descending, 
    country.Silver descending, country.Bronze descending
    select country;

foreach (OlympicCountry country in goldMedalSort)
    Console.WriteLine(country);

// Determine the total number of gold medals
Console.WriteLine("\nTotal number of gold medals:");
var golds = from country in countries select country.Gold;
Console.WriteLine($"Total golds: {golds.Sum()}");

// Determine the average number of gold medals per country
Console.WriteLine("\nAverage number of gold medals:");
Console.WriteLine($"Total golds: {golds.Average()}");

// Display the countries beginning with the letter G
Console.WriteLine("\nCountries beginning with G:");
var gCountries =
    from country in countries
    where country.Name.StartsWith('G')
    select country.Name;
foreach(string name in gCountries)
    Console.WriteLine(name);