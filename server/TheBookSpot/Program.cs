using FluentValidation.AspNetCore;
using TheBookSpot.Extensions;

namespace TheBookSpot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.ConfigureSqlServerContext(builder.Configuration);
            builder.Services.ConfigureRepositories();

            builder.Services.AddAutoMapper(typeof(Program).Assembly);
            builder.Services.
                AddFluentValidation(options => options.RegisterValidatorsFromAssemblyContaining<Program>());

            builder.Services.AddControllersWithViews()
                    .AddNewtonsoftJson(options =>
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                );

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //app.ConfigureExceptionHandler();

            app.UseAuthorization();

            app.MapControllers();


            app.Run();
        }
    }
}