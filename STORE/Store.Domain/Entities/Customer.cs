namespace Store.Domain.Entities
{    
    public string Name { get; private set; }
    public string Email { get; private set; }

    public class Customer(string name, string email)
    {
        Name = name;
        Email = email;
    }
}