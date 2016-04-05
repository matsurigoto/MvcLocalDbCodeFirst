﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ConnectStringCodeFirst.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext()
        {
            Database.SetInitializer<StudentDbContext>(null);
        }

        public DbSet<StudentProfile> StudentProfile { get; set; }
        public DbSet<Score> Score { get; set; }
    }

    [Table("StudentProfile")]
    public class StudentProfile
    {
        [Key]
        public Guid guid { get; set; }
        public string Id { get; set; }
        public string Name   { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Message { get; set; }
    }

    [Table("Score")]
    public class Score
    {
        [Key]
        public Guid guid { get; set; }
        public string English { get; set; }
        public string Chinese { get; set; }
        public string Math { get; set; }
    }
}