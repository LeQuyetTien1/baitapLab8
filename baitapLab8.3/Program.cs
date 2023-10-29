using System;
using System.Collections;
using System.Collections.Generic;

class Product
{
    public int id { get; set; }
    public string name { get; set; }
    public int price { get; set;}
    public Product() { }
    public Product(int id, string name, int price)
    {
        this.id = id;
        this.name = name;
        this.price = price;
    }
    public override string ToString()
    {
        return $"Id: {id}, Name: {name}, Price: {price}";
    }
}
class ProductEnumberable: Product, IEnumerable
{
    List<Product> products = new List<Product>()
    {
        new Product{id=1,name="Ban",price=500000 },
        new Product(2,"Ghe",100000),
        
    };
    public IEnumerator GetEnumerator()
    {
        for(int i=0; i < products.Count; i++)
        {
            yield return products[i];
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        ProductEnumberable products = new ProductEnumberable();
        foreach(var item in products)
        {
            Console.WriteLine(item);
        }
    }
}