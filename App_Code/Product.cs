using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{ XMLServices xml = new XMLServices();
    public Product()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public List<Product> getProducts(string path)
    {
        return xml.getProducts(path);
    }

    public Product(int _productID, string _title, double _price, int _inventory, string _imgPath, bool _avail)
    {
        id = _productID;
        title = _title;
        price = _price;
        inventory = _inventory;
        imagePath = _imgPath;
        available = _avail;
    }

    private bool available;

    public bool Available
    {
        get { return available; }
        set { available = value; }
    }

    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    private string title;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    //public double discount(bool b)
    //{
    //    if (b)
    //    {
    //        return 0.2;
    //    }
    //    else
    //    {
    //        return 0.5;
    //    }
    //}

    //public int insertNewProduct(int category, string title, string imgPath, double price, int inventory)
    //{

    //    return db.insertProduct(category, title, imgPath, price, inventory);
    //}

    private string imagePath;

    public string ImagePath
    {
        get { return imagePath; }
        set { imagePath = value; }
    }

    //public DataTable getAllSales(string input)
    //{
    //    return db.getAllSales(input);
    //}

    private double price;

    //public void updateInventory(int id, int inventory)
    //{
    //    db.updateInventory(id, inventory);
    //}

    //public List<Product> getProductsList()
    //{
    //    DataTable dt = getAllProducts();
    //    List<Product> ls = new List<Product>();

    //    foreach (DataRow row in dt.Rows)
    //    {
    //        if (!Convert.ToBoolean(row[6].ToString()))
    //        {
    //            continue;
    //        }
    //        Product p = new Product(int.Parse(row[0].ToString()), row[2].ToString(), double.Parse(row[4].ToString()), int.Parse(row[5].ToString()), row[3].ToString(), Convert.ToBoolean(row[6].ToString()));
    //        ls.Add(p);
    //    }
    //    return ls;
    //}

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    private int inventory;

    public int Inventory
    {
        get { return inventory; }
        set { inventory = value; }
    }

    //public void insertSale(int id, double price, int inventory, string userName, DateTime date, int paymentMethod)
    //{
    //    db.insertSale(id, price, inventory, userName, date, paymentMethod);
    //}

    public Category category = new Category();

    //private Dictionary<string, string> attributes;

    //public Dictionary<string, string> Attributes
    //{
    //    get { return attributes; }
    //    set { attributes = value; }
    //}


    //public Product(int _categoryId, int _id, string _title, string _imagePath, double _price, int _inventory, Dictionary<string, string> _attr)
    //{
    //    category.Id = _categoryId;
    //    Id = _id;
    //    Title = _title;
    //    ImagePath = _imagePath;
    //    Price = _price;
    //    Inventory = _inventory;
    //    Attributes = _attr;

    //}

    //public int checkAvaiable(string inventory, int id)
    //{
    //    return db.checkAvaiable(inventory, id);
    //}

    //public void updateProduct(string id, string inventory, bool available)
    //{
    //    db.updateProduct(id, inventory, available);
    //}

    //public Product getProduct(int productId)
    //{
    //    //call the method getProduct from DBService
    //    return null;
    //}

    //public DataTable getAllProducts()
    //{
    //    return db.GetAllProducts();
    //}


}