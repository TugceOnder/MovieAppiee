using MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApi.Domain;
using MovieAppie.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class CreateCategoryHandler
    {
        private readonly MovieContext _context;

        public CreateCategoryHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handele(CreateCategoryCommand command)
        {
            _context.Categories.Add(new Category
            {
                CategoryName = command.CategoryName
            }); 
            await _context.SaveChangesAsync();

        }
    }
}
