var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.research_aspire_ApiService>("apiservice");

builder.AddProject<Projects.research_aspire_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
