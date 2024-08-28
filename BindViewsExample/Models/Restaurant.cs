namespace BindViewsExample.Models;

public class Restaurant
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public bool Open { get; set; }

    public string Speciality { get; set; } = string.Empty;

    public int Review { get; set; }
}
