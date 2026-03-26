using Core;

namespace Infrastructure;

public class OpenAiIntentExtractor : IIntentExtractor
{
    public Task<ExtractedIntent> ExtractAsync(string content)
    {
        // mocked AI for production scaffold
        return Task.FromResult(new ExtractedIntent
        {
            OrderId = 12345,
            CustomerId = 999,
            Action = "reprocess_order"
        });
    }
}
