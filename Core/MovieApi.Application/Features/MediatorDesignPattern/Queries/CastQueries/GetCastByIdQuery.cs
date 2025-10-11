using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries
{
    public class GetCastByIdQuery:IRequest<GetCastByIdQuery>
    {
        public GetCastByIdQuery(int castId)
        {
            CastId = castId;
        }

        public int CastId { get; set; }
        
    }
}
