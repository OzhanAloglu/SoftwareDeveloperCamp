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

//içinde data yoksa kullanýlýr.  ////// AOP için Autofac kullanýlacak. Bu kullaným .Net in kendi kullanýmý.



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
