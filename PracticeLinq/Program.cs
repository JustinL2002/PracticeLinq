List<string> games = new List<string>();
games.Add("GTA");
games.Add("Valorant");
games.Add("DOTA");
games.Add("CSGO");
games.Add("Elden Ring");

games.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));