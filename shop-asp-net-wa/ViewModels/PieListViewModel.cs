using shop_asp_net_wa.Models;

namespace shop_asp_net_wa.ViewModels;

public class PieListViewModel
{
    public IEnumerable<Pie> Pies { get; }
    public string? CurrentCategory { get; }
    public PieListViewModel(IEnumerable<Pie> pies, string? currentCategory)
    {
        Pies = pies;
        CurrentCategory = currentCategory;
    }
}
