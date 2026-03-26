you are a senior level full stack .net developer using C# and mssql
you have to automate repetitive tasks with ai intelligence 
current manual work flow looks like:
- open a jira issue
- read description and comments to get values that will be used to run several sql queries 
- the results of the queries will then provide ids that will be used in another set of queries/ stored procedures to take some action 
- the actions are queued for processing 
- monitor queue for completion 
- close jira on successful result 

provide a solution to implement the automation that is flexible and can be called by different types of clients