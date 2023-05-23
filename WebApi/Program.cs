using Bussiness.Mapping;
using Bussiness.Services;
using DataAccess;
using DataAccess.Repositories;
using DataAccess.UnitOfWorks;
using Entities.Repositories;
using Entities.Services;
using Entities.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(MapProfile));
builder.WebHost.ConfigureKestrel(options => {
    options.ListenAnyIP(5022);
});


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ImageRepository, ImageRepository>();
builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<IHouseRepository, HouseRepository>();
builder.Services.AddScoped<ICommunicationRepository, CommunicationRepository>();
builder.Services.AddScoped<IRequestRepository, RequestRepository>();


builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ImageService, ImageService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IHouseService, HouseService>();
builder.Services.AddScoped<ICommunicationService, CommunicationService>();
builder.Services.AddScoped<IRequestService, RequestService>();

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(
        builder.Configuration.GetConnectionString("SqlConnection"),
        options => options.MigrationsAssembly(
            Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name)
        );
});


var app = builder.Build();


app.UseRouting();

app.UseEndpoints(endpoints => {
    endpoints.MapControllers();
});

app.Run();
