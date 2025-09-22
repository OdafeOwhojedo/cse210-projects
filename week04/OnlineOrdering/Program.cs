using System;

class Program
{
    static void Main(string[] args)
    {
        //Create  addresses
        Address address1 = new Address("38 Jackson street", "Salt Lake City", "Utah", "USA");
        Address address2 = new Address("451 Perfect Glow street", "Rocky Mountain Town", "CA", "USA");
        Address address3 = new Address("422 Heavenly Bliss street", "Lagos City", "Delta state", "Nigeria");
        Address address4 = new Address("25 Golden Dragon street", "Power Eagle City", "Beijing", "China");

        //Create  customers
        Customer customer1 = new Customer("Eli", "Davis", address1);
        Customer customer2 = new Customer("MaryJane", "Benjamin", address2);
        Customer customer3 = new Customer("Odafe", "Erikevwie", address3);
        Customer customer4 = new Customer("Lucas", "Fred", address4);

        //Create Products
        Product productA = new Product("MD2016", "HP Elite Book 2520", 1500.25m, 3);
        Product productB = new Product("WS5252", "HP Laser Printer and Scanner", 102.00m, 2);
        Product product1 = new Product("CR444", "Dell Vostro", 288.56m, 4);
        Product product2 = new Product("GG-8822", "Dell Latitude", 264.23m, 4);
        Product product3 = new Product("FMD-2121", "HP ProBook", 168.55m, 1);
        Product product4 = new Product("JH2222", "Sharp Laser Printer", 52.85m, 5);
        Product product5 = new Product("DV2020", "Dell XPS", 450.25M, 2);
        Product product6 = new Product("KL", "HP Stream", 25.95m, 7);
        Product product7 = new Product("BM-3401", "Microsoft Bluetooth Mouse", 2.5m, 16);

        //Create an order
        Order order1 = new Order(customer1,productA);
        order1.AddProduct(productA);
        order1.AddProduct(productB);
        order1.AddProduct(product5);
        order1.CalculateTotalAmount();
        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        Order order2 = new Order(customer2, product1);
        order2.AddProduct(product1);
        order2.AddProduct(product2);
        order2.AddProduct(productB);
        order2.CalculateTotalAmount();
        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        Order order3 = new Order(customer3, product1);
        order3.AddProduct(product1);
        order3.AddProduct(product2);
        order3.AddProduct(product4);
        order3.AddProduct(product7);
        order3.AddProduct(productB);
        order3.AddProduct(productA);
        order3.CalculateTotalAmount();
        order3.DisplayPackingLabel();
        order3.DisplayShippingLabel();
        Order order4 = new Order(customer4, productA);
        order4.AddProduct(productA);
        order4.AddProduct(product5);
        order4.AddProduct(product3);
        order4.CalculateTotalAmount();
        order4.DisplayPackingLabel();
        order4.DisplayShippingLabel();
        
    }
}