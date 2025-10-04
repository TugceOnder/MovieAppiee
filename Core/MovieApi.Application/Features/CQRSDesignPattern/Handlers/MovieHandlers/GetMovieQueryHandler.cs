using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.CQRSDesignPattern.Results.CatageoryResults;
using MovieApi.Application.Features.CQRSDesignPattern.Results.MovieResults;
using MovieAppie.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class GetMovieQueryHandler
    {
        private readonly MovieContext _movieContext;

        public GetMovieQueryHandler(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }
        public async Task<List<GetMovieQueryResult>> Handle()
        {
            var values = await _movieContext.Movies.ToListAsync();
            return values.Select(c => new GetMovieQueryResult
            {
           MovieId= c.MovieId,
           CoverImageUrl= c.CoverImageUrl,  
           CreatedYear= c.CreatedYear,
           Description= c.Description,
           Duration= c.Duration,
           Rating= c.Rating,
           ReleaseDate= c.ReleaseDate,
           Status= c.Status,
           Title = c.Title

           
            }).ToList();

        }
    }
}
