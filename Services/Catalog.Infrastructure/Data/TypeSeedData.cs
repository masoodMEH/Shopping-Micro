using Catalog.Core.Entities;
using MongoDB.Driver;
using System.Text.Json;

namespace Catalog.Infrastructure.Data;

public static class TypeSeedData
{
    public static void SeedData(IMongoCollection<ProductType> collection)
    {
        var existCollection = collection.Find(x => true).Any();
        if (existCollection) return;

        var pathJson = Path.Combine(AppContext.BaseDirectory, "SeedData", "Data", "types.json");

        if (!File.Exists(pathJson))
            throw new Exception($"the seed data of types.json not found at path : {pathJson}");

        var dataText = File.ReadAllText(pathJson);
        var types = JsonSerializer.Deserialize<List<ProductType>>(dataText);

        if (types != null) collection.InsertMany(types);
    }
}
