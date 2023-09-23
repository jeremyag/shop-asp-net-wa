using shop_asp_net_wa.Models;

namespace shop_asp_net_wa.ViewModels;

public class HomeViewModel
{
    public IEnumerable<Pie> PiesOfTheWeek { get; }

    public HomeViewModel(IEnumerable<Pie> piesOfTheWeek)
    {
        PiesOfTheWeek = piesOfTheWeek;
    }
}
