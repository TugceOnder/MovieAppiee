using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.CQRSDesignPattern.Results.CatageoryResults;
using MovieAppie.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        // categori listesi nasıl gelir 
        private readonly MovieContext _movieContext;

        public GetCategoryQueryHandler(MovieContext context)
        {
            _movieContext = context;
        }
        public  async  Task<List<GetCategoryQueryResult>> Handle()
        {
            var values = await _movieContext.Categories.ToListAsync();
                return values.Select(c => new GetCategoryQueryResult {
                CategoryId = c.CategoryId,
                CategoryName = c.CategoryName, 
                }).ToList();

        }
    }
}
