using System;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using System.Collections.Generic;

public class Startup
{
	
	public void ConfigureServices(IServiceCollection services)	
	{
		services.AddMvc();
	}
	
	public void Configure(IApplicationBuilder app)
	{
		app.UseDeveloperExceptionPage();
		app.UseStaticFiles();
		app.UseMvc(routes =>
            {
                routes.MapRoute("default", "api/{controller}/{action}/{id?}",
                    new Dictionary<string, object> {
						{"controller","Home"}, 
						{"action","Index" }
					});
            });
	}
}

public class HomeController : Controller
{
	public string Index()
	{
		return "Hello, World!";
	}
}

