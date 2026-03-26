using System.Collections.Generic;

namespace Core;

public class WorkflowContext
{
    public Dictionary<string, object> Data { get; set; } = new();
    public string CorrelationId { get; set; } = Guid.NewGuid().ToString();
}
