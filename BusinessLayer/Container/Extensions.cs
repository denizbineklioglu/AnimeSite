using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAnimeService, AnimeManager>();
            services.AddScoped<IAnimeDal, EfAnimeDal>();
            services.AddScoped<IAnimeCategoryService, AnimeCategoryManager>();
            services.AddScoped<IAnimeCategoryDal, EfAnimeCategoryDal>();
            services.AddScoped<IAnimeCommentService, AnimeCommentManager>();
            services.AddScoped<IAnimeCommentDal, EfAnimeCommentDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<IEpisodeService, EpisodeManager>();
            services.AddScoped<IEpisodeDal, EfEpisodeDal>();
            services.AddScoped<IEpisodeCommentService, EpisodeCommentManager>();
            services.AddScoped<IEpisodeCommentDal, EfEpisodeCommentDal>();
        }
    }

}
