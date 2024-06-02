using AutoMapper;
using CreateApi;
using PracticumServer.Api.MiddleWares;
using restfull.core.Mapping;
using restfull.core.Repositories;
using restfull.core.Services;
using restfull.service;
using restfull.data.Repository;
using restfull.service;
using System.Text.Json.Serialization;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IGuestService, GuestService>();
builder.Services.AddScoped<IGeuestRepository, GuestRepository>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped< IRoomRepository, RoomRepository>();
builder.Services.AddScoped<IInvetationSrevice, InvetationService>();
builder.Services.AddScoped<IInvetationRepository, InvetationRepository>();
//builder.Services.AddSingleton<DataContext>();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddAutoMapper(typeof(MappingProfile));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();
app.UseShabbat();
app.MapControllers();

app.Run();

