
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors();
builder.Services.AddControllers();
//builder.Services.AddControllers(option => option.ReturnHttpNotAcceptable = true );
//builder.Services.AddControllers(option => option.ReturnHttpNotAcceptable = true).AddXmlDataContractSerializerFormatters();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddTransient<ISupplierBO, SupplierBO>();
builder.Services.AddTransient<ISupplierCore, SupplierCore>();
builder.Services.AddSingleton<Microsoft.AspNetCore.StaticFiles.FileExtensionContentTypeProvider>();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DomainDbContext>(x => x.UseSqlServer(connectionString));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(x => x
           .AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader());

app.UseHttpsRedirection();

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
