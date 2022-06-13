using System.Collections.ObjectModel;

public record Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; } 
    public string LastFocusedId { get; set; }   
}