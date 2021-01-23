using System;
using System.Text;

public class StockItem {

    /// <summary>
    /// Tracks the next ID for a stock item. 
    /// </summary>
    private static int nextID = 0;

    /// <summary>
    /// The information about the stock item.
    /// </summary>
    private string description;

    /// <summary>
    /// The stock item's ID.
    /// </summary>
    private int id;

    /// <summary>
    /// The stock item's price rounded to the rearest cent.
    /// </summary>
    private double price;

    /// <summary>
    /// How many of this stock item's exsit.
    /// </summary>
    private int quantity;

    /// <summary>
    /// The default constructor.
    /// </summary>
    public StockItem() {
        id = nextID++;
    }

    /// <summary>
    /// Overloaded constructor.
    /// </summary>
    public StockItem(string description, double price, int quantity) : this() {
        this.description = description;
        this.price = price;
        this.quantity = quantity;
    }

    /// <summary>
    /// Overloaded to string function to return item's information. 
    /// </summary>
    public override string ToString() {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"Stock Item:");
        builder.AppendLine($"Description: {description}");
        builder.AppendLine($"ID: {id}");
        builder.AppendLine($"Price: {price}$");
        builder.AppendLine($"Quantity: {quantity}");
        return builder.ToString();
    }

    /// <summary>
    /// Retrieves the item's description.
    /// </summary>
    public string GetDescription() {
        return description;
    }

    /// <summary>
    /// Retrieves the item's ID.
    /// </summary>
    public int GetID() {
        return id;
    }

    /// <summary>
    /// Retrieves the item's price.
    /// </summary>
    public double GetPrice() {
        return price;
    }

    /// <summary>
    /// Retrieves the item's quantity.
    /// </summary>
    public int GetQuantity() {
        return quantity;
    }

    /// <summary>
    /// Set the item's price.
    /// </summary>
    public void SetPrice(double amount) {
        price = amount;

        if (amount < 0) {
            throw new Exception("Stock item's price is below zero!");
        }
    }

    /// <summary>
    /// Raises the item's quantity.
    /// </summary>
    public void RaiseQuantity(int amount) {
        quantity += amount;
    }

    /// <summary>
    /// Lowers the item's quantity.
    /// </summary>
    public void LowerQuantity(int amount) {
        quantity -= amount;

        if (quantity < 0) {
            throw new Exception("The item's quantity is below zero!");
        }
    }
}