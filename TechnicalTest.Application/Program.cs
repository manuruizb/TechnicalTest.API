using TechnicalTest.Application;
using TechnicalTest.Domain;
using TechnicalTest.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<DocumentTypeService>();
builder.Services.AddScoped<IDocumentTypeRepository, DocumentTypeRepository>();
builder.Services.AddScoped<CountryService>();
builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<EmployeeService>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<AreaService>();
builder.Services.AddScoped<IAreaRepository, AreaRepository>();
builder.Services.AddScoped<SubAreaService>();
builder.Services.AddScoped<ISubAreaRepository, SubAreaRepository>();

builder.Services.AddScoped<IDataAccessRepository, GenericRepository>();

builder.Services.AddCors(o => o.AddPolicy("CustomPolicyCors", builder =>
{
    builder.AllowAnyMethod()
                       .AllowAnyHeader()
                       .SetIsOriginAllowed((host) => true)
                       .AllowCredentials();
}));

builder.Services.AddControllers();
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

app.UseCors("CustomPolicyCors");

app.UseAuthorization();

app.MapControllers();

app.Run();
