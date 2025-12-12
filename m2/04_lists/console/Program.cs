namespace console;

class Program
{
    
        string[] characters =
            { "Pac-Man", "Samus", "Crash Bandicoot", "Spyro the Dragon", "Donkey Kong", "Mario",
            "Luigi", "Astro", "Solid Snake", "Master Chief", "Kratos", "Sonic the Hedgehog", "Link" }


        List<string> characterlist = new List<string>();
        
        characterlist.Add("Link");
        for (int i = 0; i < characters.Length; i++) {characterlist.Add(characters) };

        Console.WriteLine(characterlist);
    
}
