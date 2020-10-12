using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace asp.net_tutorial.Models
{
    public partial class institutionContext : DbContext
    {
        public institutionContext()
        {
        }

        public institutionContext(DbContextOptions<institutionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Standard> Standard { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentAddress> StudentAddress { get; set; }
        public virtual DbSet<StudentCourse> StudentCourse { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-NT6JKDL7;Database=institution;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("course");

                entity.Property(e => e.CourseId)
                    .HasColumnName("course_id")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CourseName)
                    .HasColumnName("course_name")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Standard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("standard");

                entity.Property(e => e.StandardId)
                    .HasColumnName("standard_id")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.StandardName)
                    .HasColumnName("standard_name")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("student");

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone number")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<StudentAddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("student_address");

                entity.Property(e => e.StudentAddress1)
                    .HasColumnName("student_address")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("student_course");

                entity.Property(e => e.CourseId)
                    .HasColumnName("course_id")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CourseName)
                    .HasColumnName("course-name")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("teacher");

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
