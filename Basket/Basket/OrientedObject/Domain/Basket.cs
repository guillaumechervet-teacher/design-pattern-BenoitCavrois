using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.OrientedObject.Domain
{
    public class Basket
    {
        private List<BasketLineArticle> articles { get; set; }

        private int id { get; set; }

        public Basket(List<BasketLineArticle> articles)
        {
            this.articles = articles;
        }
    }
}
