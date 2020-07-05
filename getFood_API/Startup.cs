using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using AutoMapper;
using getFood_API.Database;
using getFood_API.Filters;
using getFood_API.Security;
using getFood_API.Services;
using getFood_API.Services.Dostava;
using getFood_API.Services.Favoriti;
using getFood_API.Services.Izlazi;
using getFood_API.Services.Kartica;
using getFood_API.Services.Korisnik;
using getFood_API.Services.KorisnikRestoran;
using getFood_API.Services.Kuponi;
using getFood_API.Services.Meni;
using getFood_API.Services.MeniProdukti;
using getFood_API.Services.Narudzba;
using getFood_API.Services.NarudzbaStavke;
using getFood_API.Services.Produkti;
using getFood_API.Services.ProduktiSastojci;
using getFood_API.Services.Recommender;
using getFood_API.Services.Restoran;
using getFood_API.Services.Rezervacije;
using getFood_API.Services.Sastojci;
using getFood_API.Services.Status;
using getFood_Model;
using getFood_Model.Requests;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;


namespace getFood_API
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
            services.AddAutoMapper(typeof(Startup));
          

            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API V1", Version = "v1" });

                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "basic"
                                }
                            },
                            new string[] {}
                    }
                });
            });




            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthHandler>("BasicAuthentication", null); //autentifikacija

          
            services.AddScoped<IKorisnikServis, KorisnikServis>();
            services.AddScoped<ICRUDService<MSastojci, SastojciSearchRequest, SastojciUpsertRequest, SastojciUpsertRequest>, SastojciServis>();
            services.AddScoped<ICRUDService<MProdukti, ProduktiSearchRequest, ProduktiUpsertRequest, ProduktiUpsertRequest>, ProduktiServis>();
            services.AddScoped<ICRUDService<MRestoran, RestoranSearchRequest, RestoranUpsertRequest, RestoranUpsertRequest>, RestoranServis>();
            services.AddScoped<ICRUDService<MMeni, MeniSearchRequest, MeniUpsertRequest, MeniUpsertRequest>, MeniServis>();
            services.AddScoped<ICRUDService<MReview, ReviewSearchRequest, ReviewUpsertRequest, ReviewUpsertRequest>, ReviewServis>();
            services.AddScoped<ICRUDService<MRezervacije, RezervacijeSearchRequest, RezervacijeUpsertRequest, RezervacijeUpsertRequest>, RezervacijeServis>();
            services.AddScoped<ICRUDService<MNarudzba, NarudzbaSearchRequest, NarudzbaUpsertRequest, NarudzbaUpsertRequest>, NarudzbaService>();
            services.AddScoped<ICRUDService<MNarudzbaStavke, NarudzbaStavkeSearchRequest, NarudzbaStavkeUpsertRequest, NarudzbaStavkeUpsertRequest>, NarudzbaStavkeService>();
            services.AddScoped<ICRUDService<MDostava, DostavaSearchRequest, DostavaUpsertRequest, DostavaUpsertRequest>, DostavaService>();
            services.AddScoped<ICRUDService<MKartica, KarticaSearchRequest, KarticaUpsertRequest, KarticaUpsertRequest>, KarticaService>();
            services.AddScoped<ICRUDService<MIzlaz, IzlazSearchRequest, IzlazUpsertRequest, IzlazUpsertRequest>, IzlazService>();
            services.AddScoped<ICRUDService<MIzlazStavke, IzlazStavkeSearchRequest, IzlazStavkeUpsertRequest, IzlazStavkeUpsertRequest>, IzlazStavkeService>();
            services.AddScoped<ICRUDService<MFavoriti, FavoritiSearchRequest, FavoritiUpsertRequest, FavoritiUpsertRequest>, FavoritiService>();
            services.AddScoped<ICRUDService<MKuponi, KuponiSearchRequest, KuponiUpsertRequest, KuponiUpsertRequest>, KuponiService>();
           

            services.AddScoped<IService<MProduktiSastojci, ProduktiSastojciSearchRequest>, ProduktiSastojciServis>();

            services.AddScoped<IService<MMeniProdukti, MeniProduktiSearchRequest>, MeniProduktiServis>();
           
            services.AddScoped<IService<MKuhinja, object>, KuhinjaServis>();
            services.AddScoped<IService<MStatus, object>, StatusServis>();
            services.AddScoped<IService<MUloga, object>, UlogaServis>();
            services.AddScoped<IService<MKorisnikUloga, object>, KorisnikUlogaServis>();
            services.AddScoped<IService<MKorisnikRestoran, KorisnikRestoranSearchRequest>, KorisnikRestoranService>();
            services.AddScoped<ICRUDService<MKategorija,object, object, object>, KategorijaServis>();
            services.AddScoped<ICRUDService<MKuhinja,object, object, object>, KuhinjaServis>();
            

            var connection = @"Server=.;Database=140071;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<getFoodContext>(options => options.UseSqlServer(connection));
          
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
            
            app.UseSwagger();//dodano

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");

            }); //dodano
            app.UseAuthentication();

            //app.UseHttpsRedirection();
            app.UseMvc();



        }
    }
}
