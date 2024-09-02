using System;
using System.ComponentModel.DataAnnotations;

namespace skinet.API.DTOs;

public class CreateProductDto
{

    [Required] public string Name { get; set; } = String.Empty;
    [Required] public string Description { get; set; } = String.Empty;
    [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero")] public decimal Price { get; set; }
    [Required] public string PictureUrl { get; set; } = String.Empty;
    [Required] public string Type { get; set; } = String.Empty;
    [Required] public string Brand { get; set; } = String.Empty;
    [Range(1, int.MaxValue, ErrorMessage = "Quantity in stock must be at least 1")] public int QuantityInStock { get; set; }
}
