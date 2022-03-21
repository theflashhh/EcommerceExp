﻿using HepsiBurada.Domain;
using Microsoft.EntityFrameworkCore;

namespace HepsiBurada.Data.Context
{
    public class HepsiBuradaContext : DbContext
    {
        public HepsiBuradaContext(DbContextOptions<HepsiBuradaContext> options) : base(options)
        {

        }

        public DbSet<ProductRequestDto> Products { get; set; }
        public DbSet<OrderRequestDto> Orders { get; set; }
        public DbSet<CampaignRequestDto> CampaignRequestDto { get; set; }
        public DbSet<AppTime> AppTimes { get; set; }
    }
}