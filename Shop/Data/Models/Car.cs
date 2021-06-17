using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Car
    {
        public int id { set; get; }
        public string name { set; get; }
        public string shortDesc { set; get; } //небольшое описание 
        public string longDesc { set; get; } //длинное описание 
        public string img { set; get; } //url адрес изображения
        public ushort price { set; get; } // Цена
        public bool isFavorite { set; get; }// Изображение товара на первых страницах
        public bool available { set; get; } // Наличие и колличество товаров
        public int categoryID { set; get; } // Прикрепление товара к катекориям по ID
        public virtual Category Category { set; get; }


    }
}
