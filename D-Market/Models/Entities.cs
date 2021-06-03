using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D_Market.Models
{
  
    
    /// <summary>
    /// клиетские таблицы
    /// </summary>
    public class Customer
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Nickname { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(30)]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public double Money { get; set; }

        public string Logo { get; set; }

        public int OrderAmount { get; set; }
    }
    public class Order
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public int ShopID { get; set; }
        [Required]
        public int ProductID { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
    }

    public class CustomerTransactions
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public int TransactionTypeID { get; set; }
        [Required]
        public double Money { get; set; }
        public string Text { get; set; }
    }



    /// <summary>
    /// ТИПЫ ТРАНЗАКЦИЙ
    /// </summary>
    public class TransactionTypes
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Type { get; set; }
    }


    /// <summary>
    /// ВЛАДЕЛЬЦЫ И МАГАЗИНЫ
    /// </summary>
    public class Seller
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Nickname { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(30)]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public List<Shop> Shops { get; set; }
    }
    public class Shop
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Title{ get; set; }
        [Required]
        [MinLength(50)]
        [MaxLength(2000)]
        public string Description{ get; set; }
        public double Money { get; set; }
        
        public int OrderAmount { get; set; }
        public double Rating { get; set; }
        public string Logo { get; set; }
        public List<Product> Products { get; set; }

    }
    public class ShopWarehouse
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int ShopID { get; set; }
        [Required]
        public int ProductID { get; set; }
        [Required]
        [Range(0,1000000)]
        public int Quantity { get; set; }

    }
    public class ShopTransactions
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int ShopID { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public int TransactionTypeID { get; set; }
        [Required]
        public double Money { get; set; }
        public string Text { get; set; }
    }

    /// <summary>
    /// Товары и категории
    /// </summary>
    public class Product
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Title { get; set; }
        [Required]        
        public double Price { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public ProductCategory ProductCategoryID { get; set; }

        public string Logo { get; set; }
    }
    public class ProductCategory
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(70)]
        public string Title { get; set; }
    }
}
