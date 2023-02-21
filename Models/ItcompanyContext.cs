using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ModelEntityDB.Models;

public partial class ItcompanyContext : DbContext
{
    public ItcompanyContext()
    {
    }

    public ItcompanyContext(DbContextOptions<ItcompanyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Tool> Tools { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-PTTNJ3FI;Initial Catalog=ITCompany;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK__Clients__81A2CB81574C9B7A");

            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.ClientName)
                .HasMaxLength(50)
                .HasColumnName("clientName");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK__Company__2D971C4C4CBB3CDF");

            entity.ToTable("Company");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(50);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__F9B8344D12A0940C");

            entity.Property(e => e.DepartmentId).HasColumnName("departmentID");
            entity.Property(e => e.DepartmantName)
                .HasMaxLength(50)
                .HasColumnName("departmantName");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__C134C9A173660DFF");

            entity.ToTable("Employee");

            entity.Property(e => e.EmployeeId).HasColumnName("employeeID");
            entity.Property(e => e.DepartmentId).HasColumnName("departmentID");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(50)
                .HasColumnName("employeeName");
            entity.Property(e => e.HireDate).HasColumnType("date");
            entity.Property(e => e.Salary).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__Employee__depart__49C3F6B7");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.ProjectId).HasName("PK__Projects__11F14D85FCD2EB7C");

            entity.Property(e => e.ProjectId).HasColumnName("projectID");
            entity.Property(e => e.ClienId).HasColumnName("clienID");
            entity.Property(e => e.DepartmentId).HasColumnName("departmentID");
            entity.Property(e => e.EndDate)
                .HasColumnType("date")
                .HasColumnName("endDate");
            entity.Property(e => e.ProjectCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("projectCost");
            entity.Property(e => e.ProjectName)
                .HasMaxLength(50)
                .HasColumnName("projectName");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("startDate");

            entity.HasOne(d => d.Clien).WithMany(p => p.Projects)
                .HasForeignKey(d => d.ClienId)
                .HasConstraintName("FK__Projects__clienI__4D94879B");

            entity.HasOne(d => d.Department).WithMany(p => p.Projects)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__Projects__endDat__4CA06362");
        });

        modelBuilder.Entity<Tool>(entity =>
        {
            entity.HasKey(e => e.ToolId).HasName("PK__Tools__02F0FC1E019949BE");

            entity.Property(e => e.ToolId).HasColumnName("toolID");
            entity.Property(e => e.ToolName)
                .HasMaxLength(50)
                .HasColumnName("toolName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
