[![](https://img.shields.io/nuget/v/soenneker.fly.machines.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.fly.machines.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.fly.machines.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.fly.machines.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.fly.machines.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.fly.machines.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.fly.machines.openapiclient/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.fly.machines.openapiclient/actions/workflows/codeql.yml)

# Soenneker.Fly.Machines.OpenApiClient

A Kiota-generated .NET client for the Fly Machines API.

## Installation

```bash
dotnet add package Soenneker.Fly.Machines.OpenApiClient
```

## Create a client

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Fly.Machines.OpenApiClient;

var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://api.machines.dev")
};
httpClient.DefaultRequestHeaders.Authorization =
    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", flyApiToken);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var client = new FlyMachinesOpenApiClient(adapter);
```

The HTTP client supplies authentication, so the Kiota adapter uses `AnonymousAuthenticationProvider` to avoid adding a second authorization mechanism. Use the API root as the base address; generated request builders add `/v1`.

## Make a request

```csharp
var apps = await client.V1.Apps.GetAsync(
    cancellationToken: cancellationToken);
```

Fly Machines operations can create, stop, restart, and destroy infrastructure. Keep tokens in secret storage, grant only the permissions the application needs, and validate application-controlled names and request bodies before sending mutating calls.

The source is generated. Keep application policy and convenience methods outside this package so regeneration does not overwrite them. `Soenneker.Fly.Machines.OpenApiClientUtil` provides cached client construction and authenticated transport reuse.
