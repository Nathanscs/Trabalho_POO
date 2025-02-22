﻿using MediatR;
using ProvaApi.Api.Core.Domain.ProductAgg.Entities;

namespace ProvaApi.Api.Core.Domain.ProductAgg.Events
{
    public class ProdutoCriado : INotification
    {
        public ProdutoCriado(Produto produto)
        {
            Produto = produto;
        }

        public Produto Produto { get; }
    }
}