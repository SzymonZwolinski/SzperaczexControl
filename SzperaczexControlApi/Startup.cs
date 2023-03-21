using Autofac;
using SzperaczexControlInfrastructure.IOC;

namespace MS.Cart.Api;

public class Startup
{
	public void ConfigureServices(IServiceCollection services)
	{
		services.AddControllers();
	}

	public void ConfigureContainer(ContainerBuilder builder)
	{
		builder.RegisterModule(new ContainerModule());
	}

	// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
	public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
	{
		if (env.IsDevelopment())
			app.UseDeveloperExceptionPage();
		else
			// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
			app.UseHsts();

		app.UseHttpsRedirection();
		app.UseAuthentication();
		app.UseRouting();
		app.UseAuthorization();


		app.UseEndpoints(endpoints =>
		{
			endpoints.MapGet("/", context => context.Response.WriteAsync("SzperaczexControlApi"));
			endpoints.MapControllers();
		});
	}
}