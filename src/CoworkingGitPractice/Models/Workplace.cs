namespace CoworkingGitPractice.Models;

public class Workplace
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Type { get; set; }
    public bool IsAvailable { get; set; }

    public Workplace(int id, string code, string type, bool isAvailable)
    {
        Id = id;
        Code = code;
        Type = type;
        IsAvailable = isAvailable;
    }
}
