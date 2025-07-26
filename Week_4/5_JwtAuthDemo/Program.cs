using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Step 1: Add CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

// Step 2: Add Controllers
builder.Services.AddControllers();

// Step 3: JWT Authentication Configuration
string securityKey = "mysuperdupersecretkeyforjwttokenauth1234";
var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "mySystem",
        ValidAudience = "myUsers",
        IssuerSigningKey = symmetricSecurityKey
    };
});

// Add Authorization
builder.Services.AddAuthorization();

var app = builder.Build();

// Step 4: Enable Middleware
app.UseCors();                // Enable CORS
app.UseAuthentication();      // Enable JWT Auth
app.UseAuthorization();       // Enable Role Checking

app.MapControllers();

app.Run();
