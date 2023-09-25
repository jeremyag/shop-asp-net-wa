using shop_asp_net_wa.Models;

namespace shop_asp_net_wa.ViewModels;

public class ShoppingCartViewModel
{
    public IShoppingCart ShoppingCart { get;  }
    public decimal ShoppingCartTotal { get; }
    public ShoppingCartViewModel(IShoppingCart shoppingCart, decimal shoppingCartTotal) { 
        ShoppingCart = shoppingCart;
        ShoppingCartTotal = shoppingCartTotal;
    }
}
