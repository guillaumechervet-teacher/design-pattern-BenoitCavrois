using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.OrientedObject.Infrastructure
{
    public interface IArticleDatabase
    {
        ArticleDatabase GetArticle(string id);
    }
}