using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.interfaces
{
    interface ICarsCategory
    {
        //Прописываем функцию которая будет возвращать нам список
        IEnumerable<Category> AllCategories { get; }
    }
}
