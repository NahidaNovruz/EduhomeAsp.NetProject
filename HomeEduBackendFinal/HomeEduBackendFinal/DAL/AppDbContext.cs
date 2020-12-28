﻿using HomeEduBackendFinal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeEduBackendFinal.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<NoticeLeftInfo> NoticeLeftInfos { get; set; } 
        public DbSet<NoticeRightInfo> NoticeRightInfos { get; set; }
        public DbSet<WhyUs> WhyUs { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<UpCommingEvent> UpComingEvents { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}