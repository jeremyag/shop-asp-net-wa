namespace shop_asp_net_wa.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public List<Pie>? Pies { get; set; }
}
