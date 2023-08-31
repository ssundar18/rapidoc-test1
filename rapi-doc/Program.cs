using IGeekFan.AspNetCore.RapiDoc;
using IGeekFan.AspNetCore.RapiDoc.Extra;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.OperationFilter<RapiDocLableOperationFilter>();
    var filePath = Path.Combine(System.AppContext.BaseDirectory, $"{typeof(Program).Assembly.GetName().Name}.xml");
    c.IncludeXmlComments(filePath, true);
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "rapi-doc-demo", Version = "v1" });
});

builder.Services.Configure<RapiDocOptions>(c =>
{
    builder.Configuration.Bind("RapiDoc", c);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseRapiDocUI(c =>
    {
        //c.RoutePrefix = ""; // serve the UI at root
        //c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1 Docs");
        //https://mrin9.github.io/RapiDoc/api.html
        //This Config Higher priority
        c.GenericRapiConfig = new GenericRapiConfig()
        {
            RenderStyle = "read",
            Theme = "light",//light | dark
            SchemaStyle = "table",////tree | table
            ShowMethodInNavBar = "as-colored-text"
        };
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
