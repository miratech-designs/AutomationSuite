namespace Core;

public interface IIntentExtractor
{
    Task<ExtractedIntent> ExtractAsync(string content);
}

public class ExtractedIntent
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public string Action { get; set; } = "";
}
