## Install template
- dotnet new --install Senner007Corporation.Mvc.Templates::1.0.0
- dotnet new dotnet new Senner007Scaffolding

## To use:
Decorate model foreign key and navigation property with :
- [ScaffoldingOptions("{{Property on relational class}}")]

## TODO :
- Create Nuget package
- Check with many to many relationships
- Update Controller template with error handling 