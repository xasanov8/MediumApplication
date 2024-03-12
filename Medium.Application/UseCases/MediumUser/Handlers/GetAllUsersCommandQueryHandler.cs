﻿using AutoMapper;
using MediatR;
using Medium.Application.Abstactions;
using Medium.Application.UseCases.MediumUser.Queries;
using Medium.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.UseCases.MediumUser.Handlers
{
    public class GetAllUsersCommandQueryHandler : IRequestHandler<GetAllUsersCommmandQuery, List<User>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        public GetAllUsersCommandQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<User>> Handle(GetAllUsersCommmandQuery request, CancellationToken cancellationToken)
        {
            var users = await _context.Users.ToListAsync();

            return users;
        }
    }
}
