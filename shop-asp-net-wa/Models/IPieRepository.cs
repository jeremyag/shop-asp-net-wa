namespace shop_asp_net_wa.Models;

public interface IPieRepository
{
    IEnumerable<Pie> AllPies { get; }
    IEnumerable<Pie> PiesOfTheWeek { get; }
    Pie? GetPieById(int pieId);
}
