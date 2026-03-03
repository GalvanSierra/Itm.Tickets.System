using Itm.Booking.Api.DTOs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.MapGet("/api/events/{id}", (int id) =>
{
    // Lógica para obtener la lista de eventos
});

app.MapPost("/api/events/reserve", () =>
{
    // Lógica para reservar un evento
});

app.MapPost("/api/events/release", () =>
{
    // Lógica para liberar una reserva de evento
});


app.Run();
