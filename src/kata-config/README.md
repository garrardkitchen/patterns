## Configuration Kata

Create a project based on the webapp template enter the following:

```
dotnet new webapp -o src/kata-config
```

Create a folder named `Configuration`

Create class named `MyConfig` in Configuration folder:

```csharp
namespace kata_config
{
    public class MyConfig
    {
        public string Url { get; set; }
        public string Name { get; set; }
    }
}
```

Add the following to appsettings.json:

```json
...
"Myconfig": {
    "Url": "https://www.google.com",
    "Name" :  "Google"
}
...
```

In Startup.cs add the following to the ConfigureServices method

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddRazorPages();
    services.Configure<MyConfig>(options => Configuration.GetSection("MyConfig").Bind(options));   
}
```

Navigate to Index.cshtml.cs and add IOptions<MyConfig> config to the constructor:

```
public readonly IOptions<MyConfig> Config;

public IndexModel(ILogger<IndexModel> logger, IOptions<MyConfig> config)
{
    _logger = logger;
    Config = config;
}
```
__Please not the public accessibility to the `Config` field.__

Finally, to see the MyConfig.Name string value in a page, replace the Index.cshtml contents with this:

```html
@page
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <h1 class="display-4">@Model.Config?.Value.Name</h1>
</div>

```