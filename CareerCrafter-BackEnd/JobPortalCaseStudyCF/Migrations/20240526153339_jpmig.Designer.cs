﻿// <auto-generated />
using System;
using JobPortalCaseStudyCF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobPortalCaseStudyCF.Migrations
{
    [DbContext(typeof(JobPortalCFContext))]
    [Migration("20240526153339_jpmig")]
    partial class jpmig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JobPortalCaseStudyCF.Models.Application", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ApplicationId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationId"), 1L, 1);

                    b.Property<DateTime>("ApplicationDate")
                        .HasColumnType("datetime")
                        .HasColumnName("ApplicationDate");

                    b.Property<string>("ApplicationStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ApplicationStatus");

                    b.Property<int>("JobSeekerId")
                        .HasColumnType("int")
                        .HasColumnName("JobSeekerId");

                    b.Property<int>("ListingId")
                        .HasColumnType("int")
                        .HasColumnName("ListingId");

                    b.HasKey("ApplicationId");

                    b.HasIndex("JobSeekerId");

                    b.HasIndex("ListingId");

                    b.ToTable("Application", (string)null);

                    b.HasCheckConstraint("CHK_Status", "ApplicationStatus IN ('Confirmed', 'Pending','Cancelled')");
                });

            modelBuilder.Entity("JobPortalCaseStudyCF.Models.Employer", b =>
                {
                    b.Property<int>("EmployerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmployerId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployerId"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("CompanyName");

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ContactPhone");

                    b.Property<string>("CwebsiteUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("CwebsiteUrl");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Email");

                    b.Property<string>("EmployerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("EmployerName");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Gender");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Password");

                    b.Property<DateTime?>("ResetPasswordExpires")
                        .HasColumnType("datetime2")
                        .HasColumnName("ResetPasswordExpires");

                    b.Property<string>("Role")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("Employer")
                        .HasColumnName("Role");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Token");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Username");

                    b.HasKey("EmployerId");

                    b.HasIndex("ContactPhone")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Employer", (string)null);

                    b.HasCheckConstraint("CHK_GENDERS", "Gender IN ('Male', 'Female')");
                });

            modelBuilder.Entity("JobPortalCaseStudyCF.Models.JobListing", b =>
                {
                    b.Property<int>("ListingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ListingId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ListingId"), 1L, 1);

                    b.Property<string>("AboutCompany")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AboutCompany");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("CompanyName");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime")
                        .HasColumnName("Deadline");

                    b.Property<string>("EligibilityCriteria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EligibilityCriteria");

                    b.Property<int>("EmployerId")
                        .HasColumnType("int")
                        .HasColumnName("EmployerId");

                    b.Property<string>("HiringWorkflow")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("HiringWorkflow");

                    b.Property<string>("JobDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("JobDescription");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("JobTitle");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Location");

                    b.Property<DateTime>("PostedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("PostedDate");

                    b.Property<string>("RequiredSkills")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RequiredSkills");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("Salary");

                    b.Property<bool?>("VacancyOfJob")
                        .IsRequired()
                        .HasColumnType("bit")
                        .HasColumnName("VacancyOfJob");

                    b.HasKey("ListingId");

                    b.HasIndex("EmployerId");

                    b.ToTable("JobListing", (string)null);

                    b.HasCheckConstraint("CHK_Salary", "Salary > 0");
                });

            modelBuilder.Entity("JobPortalCaseStudyCF.Models.JobSeeker", b =>
                {
                    b.Property<int>("JobSeekerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("JobSeekerId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobSeekerId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Address");

                    b.Property<decimal?>("CGPA")
                        .HasColumnType("decimal(4,2)")
                        .HasColumnName("CGPA");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("CompanyName");

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ContactPhone");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime")
                        .HasColumnName("DateOfBirth");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Description");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ContactEmail");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime")
                        .HasColumnName("EndDate");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Gender");

                    b.Property<string>("Institute")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Institute");

                    b.Property<string>("JobSeekerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("JobSeekerName");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Password");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Position");

                    b.Property<string>("Qualification")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Qualification");

                    b.Property<DateTime?>("ResetPasswordExpires")
                        .HasColumnType("datetime2")
                        .HasColumnName("ResetPasswordExpires");

                    b.Property<string>("Responsibilities")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Responsibilities");

                    b.Property<string>("Role")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("JobSeeker")
                        .HasColumnName("Role");

                    b.Property<string>("Specialization")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Specialization");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime")
                        .HasColumnName("StartDate");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Token");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Username");

                    b.Property<int?>("Year")
                        .HasColumnType("int")
                        .HasColumnName("Year");

                    b.HasKey("JobSeekerId");

                    b.HasIndex("ContactPhone")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("JobSeeker", (string)null);

                    b.HasCheckConstraint("CHK_CGPA", "CGPA >= 0.0 AND CGPA <= 10.0");

                    b.HasCheckConstraint("CHK_GENDER", "Gender IN ('Male', 'Female')");

                    b.HasCheckConstraint("CHK_Year", "Year >= 1950 AND Year <= 2024");
                });

            modelBuilder.Entity("JobPortalCaseStudyCF.Models.Resume", b =>
                {
                    b.Property<int>("ResumeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ResumeId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResumeId"), 1L, 1);

                    b.Property<int>("JobSeekerId")
                        .HasColumnType("int")
                        .HasColumnName("JobSeekerId");

                    b.Property<string>("ResumeUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ResumeUrl");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Status");

                    b.Property<DateTime>("UploadedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("UploadedDate");

                    b.HasKey("ResumeId");

                    b.HasIndex("JobSeekerId");

                    b.ToTable("Resume", (string)null);

                    b.HasCheckConstraint("CHK_Status", "Status IN ('Active', 'Inactive')", c => c.HasName("CHK_Status1"));
                });

            modelBuilder.Entity("JobPortalCaseStudyCF.Models.Application", b =>
                {
                    b.HasOne("JobPortalCaseStudyCF.Models.JobSeeker", "JobSeeker")
                        .WithMany("Applications")
                        .HasForeignKey("JobSeekerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Application_JobSeeker");

                    b.HasOne("JobPortalCaseStudyCF.Models.JobListing", "Listing")
                        .WithMany("Applications")
                        .HasForeignKey("ListingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Application_JobListing");

                    b.Navigation("JobSeeker");

                    b.Navigation("Listing");
                });

            modelBuilder.Entity("JobPortalCaseStudyCF.Models.JobListing", b =>
                {
                    b.HasOne("JobPortalCaseStudyCF.Models.Employer", "Employer")
                        .WithMany("JobListings")
                        .HasForeignKey("EmployerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_JobListing_Employer");

                    b.Navigation("Employer");
                });

            modelBuilder.Entity("JobPortalCaseStudyCF.Models.Resume", b =>
                {
                    b.HasOne("JobPortalCaseStudyCF.Models.JobSeeker", "JobSeeker")
                        .WithMany("Resumes")
                        .HasForeignKey("JobSeekerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Resume_JobSeeker");

                    b.Navigation("JobSeeker");
                });

            modelBuilder.Entity("JobPortalCaseStudyCF.Models.Employer", b =>
                {
                    b.Navigation("JobListings");
                });

            modelBuilder.Entity("JobPortalCaseStudyCF.Models.JobListing", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("JobPortalCaseStudyCF.Models.JobSeeker", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("Resumes");
                });
#pragma warning restore 612, 618
        }
    }
}
