namespace shop_asp_net_wa.Models;

public interface ICategoryRepository
{
    IEnumerable<Category> AllCategories { get; }
}
