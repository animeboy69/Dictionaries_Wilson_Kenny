using System;
using System.Collections.Generic;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {

        // Creates a value called topGames
        Dictionary<int, string> topGames = new Dictionary<int, string>();
        topGames.Add(1, "Mortal Kombat 1");
        topGames.Add(2, "Marvel's Spider-Man 2");
        topGames.Add(3, "Hogwarts Legacy");
        topGames.Add(4, "Star Wars Jedi:Survivor");
        topGames.Add(5, "The Legend of Zelda: Tears of the Kingdom");
        topGames.Add(6, "Minecraft");
        topGames.Add(7, "Street Fighter 6");
        topGames.Add(8, "Pizza Tower");
        topGames.Add(9, "Five Nights At Freddy's Security Breach");
        topGames.Add(10, "Dead Space");
        
        // Creates a top ten of the users favorite games to the dictionary 
        foreach (KeyValuePair<int, string> kvp in topGames)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        if (topGames.ContainsKey(1))
        {
            Console.WriteLine($"My favorite game is: {topGames[1]}");
        }
        
        
        // Creates a empty string called result and Implements the TryGetValue method on topGames for the key 11 which is set output to the result strting. 
        string result = "";

        topGames.TryGetValue(11, out result);

        if (result != "")
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("There is no game in the eleventh position");
        }

        if (topGames.ContainsKey(5))
        {
            topGames[5] = "Halo 3 ";
        }

        Console.WriteLine(topGames[5]);


        Hashtable hashTable = new Hashtable(topGames);

        string favGame = (string)hashTable[1];

        Console.WriteLine($"Favorite Game: {favGame}");
        
        // Creates a Hashtable called capitals
        Hashtable capitals = new Hashtable() {
            { "Oklahoma", "Oklahoma City" },
            { "New York", "Albany" },
            { "Texas", "Austin" },
            { "Ohio", "Colombys" },
         };

       
        
        foreach (DictionaryEntry kvp in capitals)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        capitals.Clear();


    }
 }



    
