using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Products.Application.Common.Interfaces;
using Products.Application.Common.Models;
using Products.Application.Repositories.BrandRepository.Interface;
using Products.Application.Repositories.BrandRepository.Service;
using Products.Application.Repositories.CardRepository.Interface;
using Products.Application.Repositories.PerfumeRepository.Interface;
using Products.Application.Repositories.PerfumeRepository.Service;
using Products.Application.Repositories.CardRepository.Service;
using Products.Entities;
using Products.Infrastructure.DataLayer;
using Products.Infrastructure.Identity;
using RESTfulWebAPI.Filters;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(o => o.Filters.Add(new ExceptionFilter()))
                .AddXmlDataContractSerializerFormatters()
                .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddDbContext<ProductDbContext>(options =>
{
    
    options.UseSqlServer("Server=DESKTOP-G5I7932\\SQLEXPRESS;Database=ProductWebApi;Trusted_Connection=True;");

    if (builder.Environment.IsDevelopment())
    {
        options.EnableSensitiveDataLogging();
        options.EnableDetailedErrors();
        options.LogTo(Console.WriteLine,
           new[] { DbLoggerCategory.Database.Command.Name },
           LogLevel.Information);
    }
});
builder.Services.AddCors(x =>
{
    x.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:7009");
        policy.AllowAnyMethod();
        policy.AllowAnyHeader();
    });
});


builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ProductDbContext>();

builder.Services.AddScoped<IIdentityService, IdentityService>();
builder.Services.AddScoped<IProductDbContext, ProductDbContext>();
builder.Services.AddScoped<IPerfumeService, PerfumeService>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<ICardService, CardService>();

builder.Services.AddScoped<IPerfumeService,PerfumeService>();  
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Product", Version = "v1" });

    var securityScheme = new OpenApiSecurityScheme()
    {
        BearerFormat = "JWT",
        Scheme = "bearer",
        Name = "Authorization",
        Description = "JWT Authorization header using the Bearer token",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http
    };

    c.AddSecurityDefinition("Bearer", securityScheme);

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[] {}
        }
    });
});

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.CreateMap<Perfume, PerfumeModelDto>();
    mc.CreateMap<PerfumeModelDto, Perfume>();
    mc.CreateMap<Brand, BrandModelDto>();
    mc.CreateMap<BrandModelDto, Brand>();
    mc.CreateMap<CardModelDto, Card>();
    mc.CreateMap<Card, CardModelDto>();
    mc.CreateMap<CardItemModelDto, CardItem>();
    mc.CreateMap<CardItem, CardItemModelDto>();
    mc.CreateMap<CardItem, CardItemDto>();
    mc.CreateMap<CardItemDto, CardItem>();
    mc.CreateMap<Card, CardDto>();
    mc.CreateMap<CardDto, Card>();
});

IMapper mapper = mapperConfig.CreateMapper();

builder.Services.AddSingleton(mapper);
builder.Services.AddCors(options => options.AddPolicy("DefaultCorsPolicy", policy =>
{
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader();
}));
builder.Services.AddAuthentication(option =>
{
    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x => {
    x.RequireHttpsMetadata = true;
    x.SaveToken = true;
    x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = false,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetValue<string>("SecretKey")))
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors("DefaultCorsPolicy");

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoint =>
{
    endpoint.MapControllers();
});

app.Run();
