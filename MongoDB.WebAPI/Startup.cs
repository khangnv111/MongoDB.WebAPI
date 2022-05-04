using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MongoDB.WebAPI.Command.BookStore;
using MongoDB.WebAPI.Command.Comment;
using MongoDB.WebAPI.Command.Transaction;
using MongoDB.WebAPI.Data;
using MongoDB.WebAPI.Models;
using MongoDB.WebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDB.WebAPI
{
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MongoDB.WebAPI", Version = "v1" });
            });

            #region Config
            // comment config
            var connectionStr = Configuration.GetSection("ConnectionStrings");
            services.Configure<ConnectionString>(connectionStr);
            #endregion

            #region DataContext
            services.AddSingleton<IMongoDbContext, MongoDbContext>();
            #endregion

            #region Repository
            services.AddSingleton<ICommentRepository, CommentRepository>();
            services.AddSingleton<IBookStoreRepository, BookStoreRepository>();

            services.AddSingleton<ITransactionRepository, TransactionRepository>();
            #endregion

            #region Command
            services.AddSingleton<GetCommentListCommand>();
            services.AddSingleton<GetListBookStoreCommand>();

            services.AddSingleton<GetListTransactionCommand>();
            #endregion

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MongoDB.WebAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
