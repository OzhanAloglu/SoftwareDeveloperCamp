using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IProductService,ProductManager>(); //Birisi senden IProductService isterse ona ProductManager ver
builder.Services.AddSingleton<IProductDal,EfProductDal>();       //Birisi senden IProductDal isterse ona EfProductDal ver.

//i�inde data yoksa kullan�l�r.  ////// AOP i�in Autofac kullan�lacak. Bu kullan�m .Net in kendi kullan�m�.



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
