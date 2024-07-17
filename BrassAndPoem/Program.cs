//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name =  "Trumpet",
        Price = 20M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name =  "Tuba",
        Price = 30M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name =  "French Horn",
        Price = 15M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name =  "The Complete Poems of Emily Dickinson",
        Price = 18M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name =  "Leaves of Grass",
        Price = 25M,
        ProductTypeId = 2
    },
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 

List<ProductType> ProductTypes = new List<ProductType>()
{
    new ProductType()
    {
        Title = "Brass Instruments",
        Id = 1
    },
    new ProductType()
    {
        Title = "Poetry Books",
        Id = 2
    }
};

//put your greeting here
string greeting = @"Welcome to Brass & Poem
Your one-stop shop for all your Brass instrument and Poetry Book needs!";
Console.WriteLine(greeting);

//implement your loop here
DisplayMenu();

void DisplayMenu()
{
    string choice = null;
    while (choice != "5")
    {
        Console.WriteLine(@"Choose an Option:
1. Display All Products
2. Delete a Product
3. Add a New Product
4. Update the Product Properties
5. Exit");

            choice = Console.ReadLine();
            if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else if (choice == "1")
            {
                DisplayAllProducts();
            }
            else if (choice == "2")
            {
                DeleteProduct();
            }
            else if (choice == "3")
            {
                AddProduct();
            }
            else if (choice == "4")
            {
                UpdateProduct();
            }
            else
            {
                Console.WriteLine("Please select an option");
            }
    }
}

void DisplayAllProducts()
{
    Console.WriteLine("Products for sale");
    foreach (Product product in products) 
    {
        Console.WriteLine($"{product.Name}:   Price: ${product.Price}   Type: {(product.ProductTypeId == 1 ? "Brass Instrument" : "Poetry Book")}"); 
    }
}

void DeleteProduct()
{
    string choice = null;

    while (choice != "0")
    {
        try
        {
            Console.WriteLine("0. Goodbye");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].Name}");
            }
            choice = Console.ReadLine();
            products.RemoveAt(Int32.Parse(choice) - 1);
        }
        catch
        {
            break;
        }
    }
}
void AddProduct()
{
        Console.WriteLine("Please input the product name");
        string productName = Console.ReadLine();
        Console.WriteLine("Please input the price");
        decimal productPrice = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Please input the product type. Input 1 for brass instruments and 2 for poetry books.");
        int prouductType = Int32.Parse(Console.ReadLine());

        Product newProduct = new Product
        {
            Name = productName,
            Price = productPrice,
            ProductTypeId = prouductType
        };

        products.Add(newProduct);
        Console.WriteLine($"{newProduct.Name} has been added for sale for {newProduct.Price} dollars");
    }

void UpdateProduct()
{
    Console.WriteLine("Please select product to update:");

    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name}");
    }

    Product chosenProduct = null;

    while (chosenProduct == null)
    {
        Console.WriteLine("Please enter a product number: ");
        try
        {
            int response = int.Parse(Console.ReadLine().Trim());

            chosenProduct = products[response - 1];
        }
        catch (FormatException)
        {
            Console.WriteLine("Please type only integers!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Please choose an existing item only!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("Do better!");
        }
    }

    Console.WriteLine(@$"You chose:
    {chosenProduct.Name} which costs {chosenProduct.Price} dollars and is a {(chosenProduct.ProductTypeId == 1 ? "Brass Instrument" : "Poetry Book")}");

    Console.WriteLine(@"Please choose a detail to edit:
        1. Name
        2. Price
        3. Product Type ID");

    int index = products.IndexOf(chosenProduct);

    int choice = int.Parse(Console.ReadLine());
    if (choice == 1)
    {
        Console.WriteLine("Please enter the new name");
        string newName = Console.ReadLine();
        if (string.IsNullOrEmpty(newName)) 
        {
            newName = products[index].Name;
        }
        products[index].Name = newName;
    }
    else if (choice == 2)
    {
        Console.WriteLine("Please enter the new price");

        decimal newPrice;
        bool isInputValid = decimal.TryParse(Console.ReadLine(), out newPrice);

        if (!isInputValid)
        {
            newPrice = products[index].Price; 
        }
        products[index].Price = newPrice;
    }
    else if (choice == 3)
    {
        Console.WriteLine(@"Please enter new Product Type ID: 
                Input 1 for brass instruments or 
                2 for poetry books");

        int newId;
        bool isInputValid = int.TryParse(Console.ReadLine(), out newId);

        if (!isInputValid)
        {
            newId = products[index].ProductTypeId;
        }
            products[index].ProductTypeId = newId;
    }
}

// don't move or change this!
public partial class Program { }