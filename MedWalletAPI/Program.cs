using MedWallet.Data.InMemory;
using MedWallet.Data.NOSql;
using MedWallet.Data.SqlServer;
using MedWallet.DataModels.Interfaces;
using MedWallet.NHI.Prescriptions;
using MedWallet.NHI.Prescriptions.Interfaces;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var dataSource = builder.Configuration["DataSource"];
if (dataSource == "Sql")
{
    builder.Services.AddSingleton<IUserAccountDataSource, SqlDataSource>();
}
else if (dataSource == "NoSql")
{
    builder.Services.AddSingleton<IUserAccountDataSource, NoSqlDataSource>();
}
else
{
    builder.Services.AddSingleton<IUserAccountDataSource, InMemoryDataSource>();
}

builder.Services.AddSingleton<IPrescriptionDataSource, PrescriptionDataSource>();

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

