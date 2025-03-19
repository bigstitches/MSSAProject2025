using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Linq;

namespace WeekTen
{
    class WeekTenHWTwo
    {
        public class Fairy
        {
            public string Name { get; set; }
            public string Magic { get; set; }
            public DateTime Birthday { get; set; }
        }

        public static void MakeJSONFairy()
        {
            Fairy tinkerbell = new Fairy() { Name = "Tinkerbell", Magic = "Tinker", Birthday = DateTime.Now };
            Fairy silverMist = new Fairy() { Name = "SilverMist", Magic = "Water", Birthday = new DateTime(2025, 3, 18, 14, 30, 0) };
            Fairy greyCloud = new Fairy() { Name = "Grey Cloud", Magic = "Water", Birthday = new DateTime(1955, 3, 18, 14, 30, 0) };
            Fairy rosetta = new Fairy() { Name = "Rosetta", Magic = "Garden", Birthday = new DateTime(2024, 3, 17, 14, 30, 0) };
            Fairy fawn = new Fairy() { Name = "Fawn", Magic = "Animal", Birthday = new DateTime(2025, 3, 15, 14, 30, 0) };
            Fairy vidia = new Fairy() { Name = "Vidia", Magic = "Tinker", Birthday = new DateTime(2006, 3, 12, 14, 30, 0) };

            List<Fairy> fairies = new List<Fairy>() { tinkerbell, silverMist, rosetta, fawn, vidia, greyCloud };

            string json = JsonSerializer.Serialize(fairies, new JsonSerializerOptions() { WriteIndented = true });

            // Write the JSON to a text file in the current directory
            string filePath = "fairies.json";

            try
            {
                File.WriteAllText(filePath, json);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            string jsonOUT = File.ReadAllText(filePath);

            try
            {
                // Deserialize the JSON into a list of Fairy objects
                List<Fairy> fairiesOUT = JsonSerializer.Deserialize<List<Fairy>>(jsonOUT);

                // Find the fairy with water magic
                foreach (var f in fairiesOUT.Where<Fairy>(f => f.Magic != null && f.Magic == "Water"))
                {
                    Console.WriteLine($"Fairy with Water Magic:\nName: {f.Name}, Birthday: {f.Birthday.ToString()}");  
                }

            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
