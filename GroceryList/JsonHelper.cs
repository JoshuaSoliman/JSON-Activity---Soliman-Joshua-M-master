using GroceryList;
using System.Text.Json;

public static class JsonHelper
{
    public static async Task<List<Product>> ReadJsonFromFileAsync(string path)
    {
        if (!File.Exists(path)) return new List<Product>();

        string json = await File.ReadAllTextAsync(path);
        return JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
    }

    public static async Task WriteJsonToFileAsync(string path, List<Product> products)
    {
        string json = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
        Directory.CreateDirectory(Path.GetDirectoryName(path)); // Ensure directory exists
        await File.WriteAllTextAsync(path, json);
    }
}
