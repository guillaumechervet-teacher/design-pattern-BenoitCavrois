using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.OrientedObject.Infrastructure
{
    public class BasketService
    {
        public Domain.Basket GetBasket(IList<BasketLineArticle>basketLineArticles)
        {
            Domain.Basket basket = new Domain.Basket(basketLineArticles);
            return basket;
        }
    }
}
