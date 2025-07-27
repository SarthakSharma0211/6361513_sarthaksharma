var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();     // Required for Swagger
builder.Services.AddSwaggerGen();              // Required for Swagger

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();                          // Enables middleware to serve Swagger
    app.UseSwaggerUI();                        // Swagger UI endpoint
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
