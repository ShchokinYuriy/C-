
namespace lr1
{
public class Product
{
    private string name;
    private decimal price;
    private int quantity;

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Назва товару не може бути порожньою.");
            name = value;
            LastUpdated = DateTime.Now;
        }
    }

    public decimal Price
    {
        get => price;
        set
        {
            if (value < 0)
                throw new ArgumentException("Ціна не може бути меншою за 0.");
            price = value;
            LastUpdated = DateTime.Now;
        }
    }

    public int Quantity => quantity;

    public decimal TotalValue => price * quantity;

    public DateTime LastUpdated { get; private set; }

    public Product(string name, decimal price, int quantity)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Назва товару не може бути порожньою.");
        if (price < 0)
            throw new ArgumentException("Ціна не може бути меншою за 0.");
        if (quantity < 0)
            throw new ArgumentException("Кількість не може бути меншою за 0.");

        this.name = name;
        this.price = price;
        this.quantity = quantity;
        LastUpdated = DateTime.Now;
    }
    public void Restock(int amount)
    {
        if (amount <= 0) throw new ArgumentException("Кількість повинна бути додатною.");

        quantity += amount;
        LastUpdated = DateTime.Now;
    }
    public void Sell(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Кількість для продажу повинна бути додатною.");
            return;
        }

        if (amount > quantity)
        {
            Console.WriteLine("Недостатньо товару на складі!");
        }
        else
        {
            quantity -= amount;
            LastUpdated = DateTime.Now;
        }
    }
    public string GetInfo()
    {
        return $"Товар: {name}, Ціна: {price} грн, Кількість: {quantity}, Загальна вартість: {TotalValue} грн";
    }
}
}
