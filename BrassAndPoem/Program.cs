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

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }