using Catalog.Core.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Catalog.Infrastructure.Data;

public class CatalogContext : ICatalogContext
{
    public IMongoCollection<Product> Products { get; set; }

    public IMongoCollection<ProductBrand> Brands { get; set; }

    public IMongoCollection<ProductType> Types { get; set; }

    public CatalogContext(IConfiguration configuration)
    {
        var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:DatabaseSettings"));
        var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

        // get all of collections
        Products = database.GetCollection<Product>(configuration.GetValue<string>("DatabaseName:CollectionName"));
        Types = database.GetCollection<ProductType>(configuration.GetValue<string>("DatabaseName:BrandsCollection"));
        Brands = database.GetCollection<ProductBrand>(configuration.GetValue<string>("DatabaseName:TypesCollection"));

        //seed data
        BrandSeedData.SeedData(Brands);
        TypeSeedData.SeedData(Types);
        ProductSeedData.SeedData(Products);
    }
}
