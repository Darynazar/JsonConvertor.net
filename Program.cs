using System;
using System.IO;
using Json.Models.NodeJson;
using Json.Services;
using Newtonsoft.Json;

namespace JsonTransformerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Read the node.json file
            string nodeJsonFilePath = "node.json"; // Path to your node.json file
            string nodeJsonContent = File.ReadAllText(nodeJsonFilePath);

            // Step 2: Deserialize the JSON into the NodeJson object
            var nodeJson = JsonConvert.DeserializeObject<NodeJson>(nodeJsonContent);

            if (nodeJson == null)
            {
                Console.WriteLine("Failed to deserialize node.json.");
                return;
            }

            // Step 3: Transform the data
            var transformerService = new JsonTransformerService();
            var schemaJson = transformerService.Transform(nodeJson);

            // Step 4: Serialize the result to JSON
            string schemaJsonContent = JsonConvert.SerializeObject(schemaJson, Formatting.Indented);

            // Step 5: Output the result to a file or console
            string schemaJsonFilePath = "Schema.json"; // Path to save the output
            File.WriteAllText(schemaJsonFilePath, schemaJsonContent);

            Console.WriteLine("Transformation complete! Output saved to Schema.json.");
        }
    }
}