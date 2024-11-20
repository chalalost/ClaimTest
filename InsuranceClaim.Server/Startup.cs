using InsuranceClaim.Server.Data;
using InsuranceClaim.Server.Repositories;
using InsuranceClaim.Server.Services;
using Microsoft.EntityFrameworkCore;

namespace InsuranceClaim.Server
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ClaimsDbContext>(options =>
                options.UseInMemoryDatabase("ClaimsDb"));

            services.AddScoped<ClaimsRepository>();
            services.AddScoped<ClaimsService>();
            services.AddControllers();

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
