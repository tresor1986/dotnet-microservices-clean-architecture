using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.Application.Responses
{
    public record class ShoppingCartResponse
    {
        public string UserName { get; init; }
        public List<ShoppingCartItemResponse> Items { get; init; }

        public ShoppingCartResponse()
        {
            UserName = string.Empty;
            Items = new List<ShoppingCartItemResponse>();
        }

        // contructeur avec username seulement
        public ShoppingCartResponse(string userName)
              : this(userName, new List<ShoppingCartItemResponse>())
        {
            
        }
        // total constructeur
        public ShoppingCartResponse(string userName, List<ShoppingCartItemResponse> items)
        {
            userName = userName ?? string.Empty;
            items = items ?? new List<ShoppingCartItemResponse>();
        }

        public decimal TotalPrice => Items.Sum(item => item.Price * item.Quantity);
    }
}
