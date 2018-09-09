﻿using indeed.com.models;
using indeed.com.repository.dto;
using Microsoft.EntityFrameworkCore;
using System;

namespace indeed.com.repository
{
    public class SQLiteContext: DbContext 
    {
        DbSet<JobInfo> Jobs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite("Filename=parserDb.sqlite");
            base.OnConfiguring(builder);
        }
    }
}
