using ArtistAlbumSongApi.Data;
using Microsoft.EntityFrameworkCore;
//using System.Xml;
//using System.Xml.Serialization;



//using ArtistAlbumSongApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddHttpClient<XmlApiClient>();
builder.Services.AddDbContext<ApiDbContext>(options => options.UseNpgsql(@"Host=localhost;Port=5432;Database=MusicDb;UserId=postgres;Password=ABC1234"));
//use of connection string to connect with the database

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
