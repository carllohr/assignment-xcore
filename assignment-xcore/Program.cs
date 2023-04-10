using assignment_xcore.Contexts;
using assignment_xcore.Repositories;
using assignment_xcore.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ArticleService>();
builder.Services.AddScoped<ArticleRepository>();
builder.Services.AddScoped<ArticleAuthorRepository>();
builder.Services.AddScoped<AuthorService>();
builder.Services.AddScoped<AuthorRepository>();
builder.Services.AddScoped<TagRepository>();
builder.Services.AddScoped<ArticleTagRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));

var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
