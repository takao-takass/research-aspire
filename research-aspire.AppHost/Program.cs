var builder = DistributedApplication.CreateBuilder(args);

var redis = builder.AddRedis("cache");
var sqlServer = builder.AddSqlServer("sqlserver");

var apiService = builder.AddProject<Projects.research_aspire_ApiService>("apiservice");

builder.AddProject<Projects.research_aspire_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(sqlServer)
    .WithReference(redis)
    .WithReference(apiService);

builder.Build().Run();
