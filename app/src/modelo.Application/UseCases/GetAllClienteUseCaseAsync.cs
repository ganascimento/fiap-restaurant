﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using modelo.Application.Models;
using modelo.Domain.Gateways;

namespace modelo.Application.UseCases
{
    public class GetAllClienteUseCaseAsync :IUseCaseAsyncResponse<IEnumerable<ClienteResponse>>
    {
        private readonly IClienteGateway clienteGateway;
        private readonly IMapper mapper;


        public GetAllClienteUseCaseAsync(IClienteGateway clienteGateway, IMapper mapper)
        {
            this.clienteGateway = clienteGateway;
            this.mapper = mapper;

        }

        public async Task<IEnumerable<ClienteResponse>> ExecuteAsync()
        {
            var result = await clienteGateway.GetAllAsync();

            return mapper.Map<IEnumerable<ClienteResponse>>(result);
        }
    }
}
