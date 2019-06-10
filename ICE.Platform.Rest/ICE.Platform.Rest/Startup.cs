using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ICE.Platform.Rest
{
    using Core;
    using Platform;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // ICE Platform services

            services.AddTransient<IPlatformDataProvider, PlatformEntityMockProvider>();

            services.AddTransient<IPlatformContext, PlatformContext>();

            foreach (var injectable in Platform.GetInjectableMap())
            {
                services.AddTransient(injectable.Item1, injectable.Item2);
            }

            foreach(var resource in Platform.GetResourceList())
            {
                services.AddTransient(resource, resource);
            }

            services.AddSingleton(typeof(IPlatformResourceFactory), typeof(PlatformResourceFactory));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
