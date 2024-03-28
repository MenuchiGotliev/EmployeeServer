using EmployeeServer.Core.Repositories;
using EmployeeServer.Data;
using EmployeeServer.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IPositionRepository, PositionRepoisitory>();

builder.Services.AddDbContext<DataContext>();
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

app.UseCors();


app.Run();




//using EmployeeServer.Core.Repositories;
//using EmployeeServer.Core.Services;
//using EmployeeServer.Data;
//using EmployeeServer.Data.Repositories;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers().AddJsonOptions(options =>
//{
//    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
//    options.JsonSerializerOptions.WriteIndented = true;
//});
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
////builder.Services.AddSwaggerGen();

//builder.Services.AddSwaggerGen();


//builder.Services.AddAutoMapper(typeof(MappingProfile));
//builder.Services.AddAutoMapper(typeof(ApiMappingProfile));

//builder.Services.AddScoped<IEmployeeService, EmployeeService>();
//builder.Services.AddScoped<IPositionService, PositionService>();

//builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
//builder.Services.AddScoped<IPositionRepository, PositionRepository>();

//builder.Services.AddDbContext<DataContext>();

////builder.Services.AddSingleton<DataContext>();

//builder.Services.AddCors(opt => opt.AddPolicy("MyPolicy", policy =>
//{
//    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
//}));




//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();
//app.UseCors("MyPolicy");

////app.UseAuthentication();

//app.UseAuthorization();


//app.UseShabbat();

//app.MapControllers();

//app.Run();