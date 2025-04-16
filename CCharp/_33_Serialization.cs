using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CCharp;

public class _33_Serialization
{

   public static void Ex01()
   {
      ///SERIALIZATION
      ///* Is the process of converting an object into a stream of bytes or
      ///  a text format (JSON, XML), that can be stored, transmitted, or reconstructed later.
      ///* The reverse process, [DESERIALIZATION] converting them back into an object.
      ///
      ///WHY SERIALIZATION ?
      ///- Presistence: Save objects to file or database
      ///- Communication: Send data over networks (API requests/responses)
      ///- Cashing: Store complex objects in memory or disk.
      ///- Cloning: Deep-copy objects by serializing or deserializing.
      ///

      var user = new User2 { Id = 1, Name = "Ahmed" };

      // serialize to JSON
      string json = JsonSerializer.Serialize(user);
      Console.WriteLine(json);

      User2 deserialize = JsonSerializer.Deserialize<User2>(json);
      Console.WriteLine($"Deserialize: {deserialize.Id} ~ {deserialize}");

   }

   public static void Ex02()
   {
      var users = new List<User2>
      {
         new User2 { Id = 1, Name = "Alice" },
         new User2 { Id = 2, Name = "Bob" }
      };

      // Serialize
      string json = JsonSerializer.Serialize(users);
      Console.WriteLine(json);

      // Deserialize
      var deserialized = JsonSerializer.Deserialize<List<User2>>(json);
      foreach (User2 user in deserialized)
      {
         Console.WriteLine(user.Name);
      }
   }

   public static void Ex03()
   {
      var user = new User3 { Id = 1, Name = "Ahmed", Password = "secret" };

      // Serialize with options
      JsonSerializerOptions options = new JsonSerializerOptions
      {
         WriteIndented = true // Pretty-print
      };

      string json = JsonSerializer.Serialize(user, options);
      Console.WriteLine(json);
   }

   public static async Task Ex04()
   {
      var user = new User2 { Id = 1, Name = "Ahmed" };

      // Serialize async to file
      using (FileStream stream = File.Create("user2.json"))
      {
         await JsonSerializer.SerializeAsync(stream, user);
      }

      // Deserialize async from file
      using (FileStream stream = File.OpenRead("user2.json"))
      {
         var deserialized = await JsonSerializer.DeserializeAsync<User2>(stream);

         Console.WriteLine($"Deserialized: {deserialized.Name}");
      }
   }

   public static void Ex05()
   {
      try
      {
         string invalidJson = "{ \"Id\": 1, \"Name\": }"; // Malformed
         var user = JsonSerializer.Deserialize<User2>(invalidJson);
      }
      catch (JsonException ex)
      {
         Console.WriteLine($"Error: {ex.Message}");
      }
   }

   private static string SerializeToXmlString(Employee4 e1)
   {
      var result = "";

      var xmlSerializer = new XmlSerializer(e1.GetType());

      using (var sw = new StringWriter())
      {
         using(var xmlWriter = XmlWriter.Create(sw, new XmlWriterSettings { Indent = true}))
         {
            xmlSerializer.Serialize(xmlWriter, e1);

            result = sw.ToString();
         }
      }

      return result;
   }
   public static void Ex06()
   {
      var e1 = new Employee4
      {
         Id = 1,
         FName = "Ahmed",
         LName = "Issam",
         Skills = { "C#", "LINQ", "EF Core", "API" }
      };

      var xmlContent = SerializeToXmlString(e1);

      Console.WriteLine(xmlContent);
   }

}


class User2
{
   public int Id { get; set; }
   public string Name { get; set; }
}

public class User3
{
   public int Id { get; set; }
   public string Name { get; set; }
   [JsonIgnore] // Skip this property
   public string Password { get; set; }
}

public class Employee4
{
   public int Id { get; set; }
   public string FName { get; set; }
   public string LName { get; set; }
   public List<string> Skills { get; set; } = [];
}

