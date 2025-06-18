using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;


class NobelEconomics
{
    static void Main()
    {
        string json = File.ReadAllText("nobel.json");
        var doc = JsonNode.Parse(json);

        foreach (var prize in doc["prizes"].AsArray())
        {
            if (prize["category"]?.ToString() == "economics")
            {
                foreach (var laureate in prize["laureates"].AsArray())
                {
                    Console.WriteLine(laureate["firstname"]);
                }
            }
        }
    }
}
