
CREATE TABLE Workflows (
    Id INT PRIMARY KEY,
    Name NVARCHAR(200),
    Definition NVARCHAR(MAX)
);

CREATE TABLE WorkflowExecutions (
    Id INT IDENTITY PRIMARY KEY,
    CorrelationId NVARCHAR(100),
    Status NVARCHAR(50),
    CreatedAt DATETIME DEFAULT GETDATE()
);
