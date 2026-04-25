using NicosCardapio.API.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddScoped<ICardapioService, CardapioService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.WithOrigins(
                "https://nicoscardapio-api.onrender.com",
                "http://localhost:5000",
                "https://localhost:7152",
                "http://localhost:7152"
              )
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseCors("AllowAll");
app.MapControllers();

app.Run();
