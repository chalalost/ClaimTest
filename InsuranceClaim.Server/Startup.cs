using AutoMapper;
using InsuranceClaim.Server.Data;
using InsuranceClaim.Server.Model;
using InsuranceClaim.Server.Repositories;
using InsuranceClaim.Server.Services;
using Microsoft.EntityFrameworkCore;
using FluentValidation.AspNetCore;
using InsuranceClaim.Server.Validators;

namespace InsuranceClaim.Server
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // In-memory database configuration
            services.AddDbContext<ClaimsDbContext>(options =>
                options.UseInMemoryDatabase("ClaimsDb"));

            // AutoMapper configuration
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });

            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            // FluentValidation
            services.AddControllers()
                    .AddFluentValidation(fv =>
                    {
                        fv.RegisterValidatorsFromAssemblyContaining<ClaimSubmissionDtoValidator>();
                    });

            services.AddScoped<ClaimsRepository>();
            services.AddScoped<ClaimsService>();
            services.AddControllers();

            // CORS configuration
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod());

            });

            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ClaimsDbContext>();
                DataSeeder.Seed(context); // Seed the data
            }

            app.UseRouting();
            app.UseCors(); // Enable CORS

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Insurance Claim System API V1");
            });

            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
