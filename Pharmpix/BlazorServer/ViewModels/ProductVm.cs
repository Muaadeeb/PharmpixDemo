using System.ComponentModel.DataAnnotations;

namespace BlazorServer.ViewModels;

public class ProductVm
{
    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    [Range(0.01, 10000.00, ErrorMessage = "Price must be between 0.01 and 10000.00")]
    public decimal Price { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Description cannot be longer than 100 characters")]
    public string Description { get; set; } = string.Empty;
}
