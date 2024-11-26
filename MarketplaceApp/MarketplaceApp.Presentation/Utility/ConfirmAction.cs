﻿using MarketplaceApp.Data.Models;
using MarketplaceApp.Domain.NewFolder;
using System.Transactions;

namespace MarketplaceApp.Presentation.Utility
{
    public class ConfirmAction
    {
        public static bool Confirm(Product product)
        {
            while (true)
            {
                Console.WriteLine($"Zelite li kupiti proizvod: {product.Name}. \ny/n");
                return ReadInput.CheckConfirmationInput();
            }
        }
        public static bool Confirm(Data.Models.Transaction transaction)
        {
            while (true)
            {
                Console.WriteLine($"Zelite li vratiti proizvod {transaction.Product.Name}. \ny/n");
                return ReadInput.CheckConfirmationInput();
            }
        }
        public static bool Confirm()
        {
            while (true)
            {
                Console.WriteLine($"Zelite li dodati novi proizvod. \ny/n");
                return ReadInput.CheckConfirmationInput();
            }
        }
    }
}
