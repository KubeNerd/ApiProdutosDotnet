namespace ApiProdutosDotnet.Models;

public class Product 
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty; // No .NET 6, strings podem ser nulas por padrão. Isso evita problemas de nullability.
    public decimal Price { get; set; }

}