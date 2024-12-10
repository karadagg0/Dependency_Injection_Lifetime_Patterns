using Dependency_Injection_Lifetime_Patterns;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserLoginDate,UserLoginDate>();
//builder.Services.AddTransient<IUserLoginDate, UserLoginDate>();
//builder.Services.AddSingleton<IUserLoginDate, UserLoginDate>();

builder.Services.AddSingleton<IUserIdGenerator,UserIdGenerator>();
//builder.Services.AddTransient<IUserIdGenerator, UserIdGenerator>();
//builder.Services.AddSingleton<IUserIdGenerator, UserIdGenerator>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
