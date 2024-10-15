using System;
using entity;
using dao;
using System.Collections.Generic;

namespace main
{
    class OrderManagement
    {
        static void Main(string[] args)
        {
            IOrderManagementRepository orderProcessor = new OrderProcessor();
            while (true)
            {
                Console.WriteLine("1. Create User");
                Console.WriteLine("2. Create Product");
                Console.WriteLine("3. Cancel Order");
                Console.WriteLine("4. Get All Products");
                Console.WriteLine("5. Get Order By User");
                Console.WriteLine("6. Exit");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            CreateUser(orderProcessor);
                            break;
                        case 2:
                            CreateProduct(orderProcessor);
                            break;
                        case 3:
                            CancelOrder(orderProcessor);
                            break;
                        case 4:
                            GetAllProducts(orderProcessor);
                            break;
                        case 5:
                            GetOrderByUser(orderProcessor);
                            break;
                        case 6:
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine(); // Keeps the console open
        }

        static void CreateUser(IOrderManagementRepository orderProcessor)
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            Console.Write("Enter Role (Admin/User): ");
            string role = Console.ReadLine();

            User newUser = new User { Username = username, Password = password, Role = role };

            try
            {
                orderProcessor.CreateUser(newUser);
                Console.WriteLine("User created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void CreateProduct(IOrderManagementRepository orderProcessor)
        {
            Console.Write("Enter Product Name: ");
            string productName = Console.ReadLine();

            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter Quantity in Stock: ");
            int quantityInStock = int.Parse(Console.ReadLine());

            Console.Write("Enter Type (Electronics/Clothing): ");
            string type = Console.ReadLine();

            Product newProduct = new Product
            {
                ProductName = productName,
                Description = description,
                Price = price,
                QuantityInStock = quantityInStock,
                Type = type
            };

            try
            {
                orderProcessor.CreateProduct(newProduct);
                Console.WriteLine("Product created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void CancelOrder(IOrderManagementRepository orderProcessor)
        {
            Console.Write("Enter User ID: ");
            int userId = int.Parse(Console.ReadLine());

            Console.Write("Enter Order ID: ");
            int orderId = int.Parse(Console.ReadLine());

            try
            {
                orderProcessor.CancelOrder(userId, orderId);
                Console.WriteLine("Order canceled successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void GetAllProducts(IOrderManagementRepository orderProcessor)
        {
            var products = orderProcessor.GetAllProducts();
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.ProductName}, Price: {product.Price}");
            }
        }

        static void GetOrderByUser(IOrderManagementRepository orderProcessor)
        {
            Console.Write("Enter User ID: ");
            int userId = int.Parse(Console.ReadLine());

            var orders = orderProcessor.GetOrderByUser(new User { UserId = userId });
            foreach (var order in orders)
            {
                Console.WriteLine($"Order ID: {order.OrderId}, Products: {string.Join(", ", order.Products)}");
            }
        }
    }
}
