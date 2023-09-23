using Microsoft.EntityFrameworkCore;

namespace shop_asp_net_wa.Models;

public class PieRepository : IPieRepository
{
    private readonly ShopDbContext _shopDbContext;

    public PieRepository(ShopDbContext shopDbContext)
    {
        _shopDbContext = shopDbContext;
    }

    public IEnumerable<Pie> AllPies
    {
        get
        {
            return _shopDbContext.Pies.Include(c => c.Category);
        }
    }

    public IEnumerable<Pie> PiesOfTheWeek
    {
        get
        {
            return _shopDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
        }
    }

    public Pie? GetPieById(int pieId)
    {
        return _shopDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
    }
}
