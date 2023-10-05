namespace API.Entities;

public class AppUser
{
    // EF will recognize this as the primary key
    // Can also use [Key] attribute
    public int Id { get; set; }

    
    public string UserName { get; set; }

    public byte[] PasswordHash { get; set; }

    public byte[] PasswordSalt { get; set; }
}
