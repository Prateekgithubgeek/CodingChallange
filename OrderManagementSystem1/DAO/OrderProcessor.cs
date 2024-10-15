using dao;

using entity;

using exception;

using System.Collections.Generic;

namespace dao
{
    public class OrderProcessor : IOrderManagementRepository
    {
        public void CreateOrder(User user, List<Product> products)
        {
            // Logic to create an order
        }

        public void CancelOrder(int userId, int orderId)
        {
            // Logic to cancel an order
        }

        public void CreateProduct(User user, Product product)
        {
            // Logic to create a product
        }

        public void CreateUser(User user)
        {
            // Logic to create a user
        }

        public List<Product> GetAllProducts()
        {
            // Logic to retrieve all products
            return new List<Product>();
        }

        public List<Product> GetOrderByUser(User user)
        {
            // Logic to get orders by user
            return new List<Product>();
        }
    }
}
