﻿using System.Linq;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ProvaApi.Api.Core.Domain.EstoqueAgg.Entities;
using ProvaApi.Api.Core.Domain.ProductAgg.Entities;
using ProvaApi.Api.Core.Domain.Shared.Repositories;
using ProvaApi.Api.Core.Domain.Shared;
using System;

namespace ProvaApi.Api.Core.Infrastructure.Shared
{
    public class PedidoDbContext : DbContext, IUnitOfWork
    {
        private readonly DbContextOptions<PedidoDbContext> options;
        private readonly IMediator _mediator;

        public PedidoDbContext(DbContextOptions<PedidoDbContext> options, IMediator mediator) : base(options)
        {
            this.options = options;
            _mediator = mediator;
        }
        
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<EstoqueItem> EstoqueItens { get; set; }
        
        void IUnitOfWork.SaveChanges()
        {
            var entities = ChangeTracker.Entries<IAggregateRoot>().Select(x => x.Entity).ToList();
            var domainEvents = entities.SelectMany(x => x.GetDomainEvents()).ToList();

            foreach (var entity in entities)
            {
                entity.ClearDomainEvents();
            }

            foreach (var domainEvent in domainEvents)
            {
                _mediator.Publish(domainEvent).GetAwaiter().GetResult();
            }

            base.SaveChanges();
        }
    }
}