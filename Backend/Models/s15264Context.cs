using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using Microsoft.EntityFrameworkCore;


namespace Backend.Models
{
    public partial class s15264Context : DbContext
    {
        public s15264Context()
        {
        }

        public s15264Context(DbContextOptions<s15264Context> options)
            : base(options)
        {
        }

        public virtual DbSet<BodyPart> BodyPart { get; set; }
        public virtual DbSet<Clothing> Clothing { get; set; }
        public virtual DbSet<ClothingColor> ClothingColor { get; set; }
        public virtual DbSet<ClothingPicture> ClothingPicture { get; set; }
        public virtual DbSet<ClothingPurpose> ClothingPurpose { get; set; }
        public virtual DbSet<ClothingPurposeClothing> ClothingPurposeClothing { get; set; }
        public virtual DbSet<ClothingSet> ClothingSet { get; set; }
        public virtual DbSet<ClothingSetClothing> ClothingSetClothing { get; set; }
        public virtual DbSet<ClothingSetPicture> ClothingSetPicture { get; set; }
        public virtual DbSet<ClothingSetTag> ClothingSetTag { get; set; }
        public virtual DbSet<ClothingSuitcase> ClothingSuitcase { get; set; }
        public virtual DbSet<ClothingTag> ClothingTag { get; set; }
        public virtual DbSet<ClothingType> ClothingType { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Pattern> Pattern { get; set; }
        public virtual DbSet<Suitcase> Suitcase { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<Trip> Trip { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s15264;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<BodyPart>(entity =>
            {
                entity.HasKey(e => e.IdBodyPart)
                    .HasName("BodyPart_pk");

                entity.Property(e => e.IdBodyPart).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Clothing>(entity =>
            {
                entity.HasKey(e => e.IdClothing)
                    .HasName("Clothing_pk");

                entity.Property(e => e.IdClothing).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("date");

                entity.Property(e => e.DeletedAt).HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBodyPartNavigation)
                    .WithMany(p => p.Clothing)
                    .HasForeignKey(d => d.IdBodyPart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Clothing_BodyPart");

                entity.HasOne(d => d.IdClothingTypeNavigation)
                    .WithMany(p => p.Clothing)
                    .HasForeignKey(d => d.IdClothingType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Clothing_ClothingType");

                entity.HasOne(d => d.IdPatternNavigation)
                    .WithMany(p => p.Clothing)
                    .HasForeignKey(d => d.IdPattern)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Clothing_Pattern");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Clothing)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Clothing_User");
            });

            modelBuilder.Entity<ClothingColor>(entity =>
            {
                entity.HasKey(e => new { e.ClothingIdClothing, e.ColorIdColor })
                    .HasName("Clothing_Color_pk");

                entity.ToTable("Clothing_Color");

                entity.Property(e => e.ClothingIdClothing).HasColumnName("Clothing_IdClothing");

                entity.Property(e => e.ColorIdColor).HasColumnName("Color_IdColor");

                entity.HasOne(d => d.ClothingIdClothingNavigation)
                    .WithMany(p => p.ClothingColor)
                    .HasForeignKey(d => d.ClothingIdClothing)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Table_22_Clothing");

                entity.HasOne(d => d.ColorIdColorNavigation)
                    .WithMany(p => p.ClothingColor)
                    .HasForeignKey(d => d.ColorIdColor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Table_22_Color");
            });

            modelBuilder.Entity<ClothingPicture>(entity =>
            {
                entity.HasKey(e => e.IdClothingPicture)
                    .HasName("ClothingPicture_pk");

                entity.Property(e => e.IdClothingPicture).ValueGeneratedNever();

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClothinNavigation)
                    .WithMany(p => p.ClothingPicture)
                    .HasForeignKey(d => d.IdClothin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Picture_Clothing");
            });

            modelBuilder.Entity<ClothingPurpose>(entity =>
            {
                entity.HasKey(e => e.IdClothingPurpose)
                    .HasName("ClothingPurpose_pk");

                entity.Property(e => e.IdClothingPurpose).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClothingPurposeClothing>(entity =>
            {
                entity.HasKey(e => new { e.IdClothingPurpose, e.IdClothing })
                    .HasName("ClothingPurpose_Clothing_pk");

                entity.ToTable("ClothingPurpose_Clothing");

                entity.HasOne(d => d.IdClothingNavigation)
                    .WithMany(p => p.ClothingPurposeClothing)
                    .HasForeignKey(d => d.IdClothing)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ClothingPurpose_Clothing_Clothing");

                entity.HasOne(d => d.IdClothingPurposeNavigation)
                    .WithMany(p => p.ClothingPurposeClothing)
                    .HasForeignKey(d => d.IdClothingPurpose)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ClothingPurpose_Clothing_ClothingPurpose");
            });

            modelBuilder.Entity<ClothingSet>(entity =>
            {
                entity.HasKey(e => e.IdClothingSet)
                    .HasName("ClothingSet_pk");

                entity.Property(e => e.IdClothingSet).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("date");

                entity.Property(e => e.DeletedAt).HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnType("date");
            });

            modelBuilder.Entity<ClothingSetClothing>(entity =>
            {
                entity.HasKey(e => new { e.IdClothing, e.IdClothingSet })
                    .HasName("ClothingSet_Clothing_pk");

                entity.ToTable("ClothingSet_Clothing");

                entity.HasOne(d => d.IdClothingNavigation)
                    .WithMany(p => p.ClothingSetClothing)
                    .HasForeignKey(d => d.IdClothing)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ClothingSet_Clothing_Clothing");

                entity.HasOne(d => d.IdClothingSetNavigation)
                    .WithMany(p => p.ClothingSetClothing)
                    .HasForeignKey(d => d.IdClothingSet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ClothingSet_Clothing_ClothingSet");
            });

            modelBuilder.Entity<ClothingSetPicture>(entity =>
            {
                entity.HasKey(e => e.IdClothingSetPicture)
                    .HasName("ClothingSetPicture_pk");

                entity.Property(e => e.IdClothingSetPicture).ValueGeneratedNever();

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClothingPurposeNavigation)
                    .WithMany(p => p.ClothingSetPicture)
                    .HasForeignKey(d => d.IdClothingPurpose)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ClothingSetPicture_ClothingPurpose");

                entity.HasOne(d => d.IdClothingSetNavigation)
                    .WithMany(p => p.ClothingSetPicture)
                    .HasForeignKey(d => d.IdClothingSet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ClothingSetPicture_ClothingSet");
            });

            modelBuilder.Entity<ClothingSetTag>(entity =>
            {
                entity.HasKey(e => e.IdTag)
                    .HasName("ClothingSet_Tag_pk");

                entity.ToTable("ClothingSet_Tag");

                entity.Property(e => e.IdTag).ValueGeneratedNever();

                entity.HasOne(d => d.IdClothingSetNavigation)
                    .WithMany(p => p.ClothingSetTag)
                    .HasForeignKey(d => d.IdClothingSet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Table_19_ClothingSet");

                entity.HasOne(d => d.IdTagNavigation)
                    .WithOne(p => p.ClothingSetTag)
                    .HasForeignKey<ClothingSetTag>(d => d.IdTag)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Table_19_Tags");
            });

            modelBuilder.Entity<ClothingSuitcase>(entity =>
            {
                entity.HasKey(e => new { e.IdSuitcase, e.IdClothing })
                    .HasName("Clothing_Suitcase_pk");

                entity.ToTable("Clothing_Suitcase");

                entity.HasOne(d => d.IdClothingNavigation)
                    .WithMany(p => p.ClothingSuitcase)
                    .HasForeignKey(d => d.IdClothing)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Clothing_Suitcase_Clothing");

                entity.HasOne(d => d.IdSuitcaseNavigation)
                    .WithMany(p => p.ClothingSuitcase)
                    .HasForeignKey(d => d.IdSuitcase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Clothing_Suitcase_Suitcase");
            });

            modelBuilder.Entity<ClothingTag>(entity =>
            {
                entity.HasKey(e => new { e.IdClothing, e.IdTag })
                    .HasName("Clothing_Tag_pk");

                entity.ToTable("Clothing_Tag");

                entity.HasOne(d => d.IdClothingNavigation)
                    .WithMany(p => p.ClothingTag)
                    .HasForeignKey(d => d.IdClothing)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Clothing_Tag_Clothing");

                entity.HasOne(d => d.IdTagNavigation)
                    .WithMany(p => p.ClothingTag)
                    .HasForeignKey(d => d.IdTag)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Clothing_Tag_Tags");
            });

            modelBuilder.Entity<ClothingType>(entity =>
            {
                entity.HasKey(e => e.IdClothingType)
                    .HasName("ClothingType_pk");

                entity.Property(e => e.IdClothingType).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.HasKey(e => e.IdColor)
                    .HasName("Color_pk");

                entity.Property(e => e.IdColor).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pattern>(entity =>
            {
                entity.HasKey(e => e.IdPattern)
                    .HasName("Pattern_pk");

                entity.Property(e => e.IdPattern).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Suitcase>(entity =>
            {
                entity.HasKey(e => e.IdSuitcase)
                    .HasName("Suitcase_pk");

                entity.Property(e => e.IdSuitcase).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTripNavigation)
                    .WithMany(p => p.Suitcase)
                    .HasForeignKey(d => d.IdTrip)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Suitcase_Trip");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Suitcase)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Suitcase_User");
            });

            modelBuilder.Entity<Tags>(entity =>
            {
                entity.HasKey(e => e.IdTag)
                    .HasName("Tags_pk");

                entity.Property(e => e.IdTag).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Trip>(entity =>
            {
                entity.HasKey(e => e.IdTrip)
                    .HasName("Trip_pk");

                entity.Property(e => e.IdTrip).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("date");

                entity.Property(e => e.DeletedAt).HasColumnType("date");

                entity.Property(e => e.End).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Start).HasColumnType("date");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("User_pk");

                entity.Property(e => e.IdUser).ValueGeneratedNever();

                entity.Property(e => e.AvatarUrl)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnType("date");

                entity.Property(e => e.DeletedAt).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastLogin).HasColumnType("date");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    IdUser = 1,
                    FirstName = "Artur",
                    LastName = "Pendragon",
                    Email = "qwert@gmail.com",
                    Password = "1234",
                    Salt = "wtf",
                    AvatarUrl = "url",
                    CreatedAt = new DateTime(2018, 09, 10),
                    DeletedAt = new DateTime(2019, 12, 10),
                    LastLogin = new DateTime(2019, 12, 10, 10, 30, 50)


                }
            );



            modelBuilder.Entity<ClothingType>().HasData(
              new ClothingType
              {
                  IdClothingType = 1,
                  Name = "Shirt"
              }
           );

            modelBuilder.Entity<ClothingType>().HasData(
           new ClothingType
           {
               IdClothingType = 2,
               Name = "T-Shirt"
           }
        );

            modelBuilder.Entity<BodyPart>().HasData(
                new BodyPart
                {
                    IdBodyPart = 1,
                    Name = "Chest"
                }
            );

            modelBuilder.Entity<Pattern>().HasData(
              new Pattern
              {
                  IdPattern = 1,
                  Name = "Check "
              }
          );

            modelBuilder.Entity<Clothing>().HasData(
          new Clothing
          {
              IdClothing = 1,
              Name = "Shirt-1 ",
              IdClothingType = 1,
              Description = "desc",
              CreatedAt = new DateTime(2018, 09, 10),
              DeletedAt = new DateTime(2019, 12, 10),
              IdUser = 1,
              IdBodyPart = 1,
              IdPattern = 1
          }
     );
            modelBuilder.Entity<Clothing>().HasData(
        new Clothing
        {
            IdClothing = 2,
            Name = "Shirt-2 ",
            IdClothingType = 1,
            Description = "desc",
            CreatedAt = new DateTime(2018, 09, 10),
            DeletedAt = new DateTime(2019, 12, 10),
            IdUser = 1,
            IdBodyPart = 1,
            IdPattern = 1
        }
    );

            modelBuilder.Entity<Clothing>().HasData(
        new Clothing
        {
            IdClothing = 3,
            Name = "Shirt-3 ",
            IdClothingType = 1,
            Description = "desc",
            CreatedAt = new DateTime(2018, 09, 10),
            DeletedAt = new DateTime(2019, 12, 10),
            IdUser = 1,
            IdBodyPart = 1,
            IdPattern = 1
        }
   );
            modelBuilder.Entity<Clothing>().HasData(
        new Clothing
        {
            IdClothing = 4,
            Name = "Shirt-4 ",
            IdClothingType = 1,
            Description = "desc",
            CreatedAt = new DateTime(2018, 09, 10),
            DeletedAt = new DateTime(2019, 12, 10),
            IdUser = 1,
            IdBodyPart = 1,
            IdPattern = 1
        }
   );
            modelBuilder.Entity<Clothing>().HasData(
        new Clothing
        {
            IdClothing = 5,
            Name = "Shirt-5 ",
            IdClothingType = 1,
            Description = "desc",
            CreatedAt = new DateTime(2018, 09, 10),
            DeletedAt = new DateTime(2019, 12, 10),
            IdUser = 1,
            IdBodyPart = 1,
            IdPattern = 1
        }
   );

            modelBuilder.Entity<Clothing>().HasData(
        new Clothing
        {
            IdClothing = 6,
            Name = "T-Shirt-1 ",
            IdClothingType = 2,
            Description = "desc",
            CreatedAt = new DateTime(2018, 09, 10),
            DeletedAt = new DateTime(2019, 12, 10),
            IdUser = 1,
            IdBodyPart = 1,
            IdPattern = 1
        }
   );
            modelBuilder.Entity<Clothing>().HasData(
        new Clothing
        {
            IdClothing = 7,
            Name = "T-Shirt-2 ",
            IdClothingType = 2,
            Description = "desc",
            CreatedAt = new DateTime(2018, 09, 10),
            DeletedAt = new DateTime(2019, 12, 10),
            IdUser = 1,
            IdBodyPart = 1,
            IdPattern = 1
        }
   );

            modelBuilder.Entity<User>().HasData(
            new User
            {
                IdUser = 2,
                FirstName = "Sherlock",
                LastName = "Holmes",
                Email = "asdf@gmail.com",
                Password = "1234",
                Salt = "wtf",
                AvatarUrl = "url",
                CreatedAt = new DateTime(2018, 09, 10),
                DeletedAt = new DateTime(2019, 12, 10),
                LastLogin = new DateTime(2019, 12, 10, 10, 30, 50)


            }
        );

            modelBuilder.Entity<Clothing>().HasData(
            new Clothing
            {
               IdClothing = 8,
               Name = "T-Shirt-3 ",
               IdClothingType = 2,
               Description = "desc",
               CreatedAt = new DateTime(2018, 09, 10),
               DeletedAt = new DateTime(2019, 12, 10),
               IdUser = 2,
               IdBodyPart = 1,
               IdPattern = 1
            }
            );
                     modelBuilder.Entity<Clothing>().HasData(
                new Clothing
                {
                    IdClothing = 9,
                    Name = "T-Shirt-4 ",
                    IdClothingType = 2,
                    Description = "desc",
                    CreatedAt = new DateTime(2018, 09, 10),
                    DeletedAt = new DateTime(2019, 12, 10),
                    IdUser = 2,
                    IdBodyPart = 1,
                    IdPattern = 1
                }
           );


            modelBuilder.Entity<Trip>().HasData(
                new Trip
                {
                    IdTrip = 1,
                    Name = "Trip-1 ",
                    Start = new DateTime(2019, 12, 10),
                    End = new DateTime(2019, 12, 10),
                    CreatedAt = new DateTime(2018, 09, 10),
                    DeletedAt = new DateTime(2019, 12, 10)
                }
           );

            modelBuilder.Entity<Trip>().HasData(
                  new Trip
                  {
                      IdTrip = 2,
                      Name = "Trip-2 ",
                      Start = new DateTime(2019, 12, 10),
                      End = new DateTime(2019, 12, 10),
                      CreatedAt = new DateTime(2018, 09, 10),
                      DeletedAt = new DateTime(2019, 12, 10)
                  }
             );

            modelBuilder.Entity<Trip>().HasData(
                new Trip    
                {
                  IdTrip = 3,
                  Name = "Trip-3 ",
                  Start = new DateTime(2019, 12, 10),
                  End = new DateTime(2019, 12, 10),
                  CreatedAt = new DateTime(2018, 09, 10),
                  DeletedAt = new DateTime(2019, 12, 10)
                }
            );

            modelBuilder.Entity<Suitcase>().HasData(
               new Suitcase
               {
                   IdSuitcase = 1,
                   Name = "Suitcase-1 ",
                   IdUser = 1,
                   IdTrip = 1
               }
           );

                modelBuilder.Entity<Suitcase>().HasData(
               new Suitcase
               {
                   IdSuitcase = 2,
                   Name = "Suitcase-2 ",
                   IdUser = 1,
                   IdTrip = 2
               }
           );
                modelBuilder.Entity<Suitcase>().HasData(
               new Suitcase
               {
                   IdSuitcase = 3,
                   Name = "Suitcase-3 ",
                   IdUser = 2,
                   IdTrip = 3
               }
           );
               modelBuilder.Entity<ClothingSuitcase>().HasData(
          new ClothingSuitcase
          {
              IdSuitcase = 1,
              IdClothing = 1
          }
      );
               modelBuilder.Entity<ClothingSuitcase>().HasData(
          new ClothingSuitcase
          {
              IdSuitcase = 1,
              IdClothing = 2
          }
      );
               modelBuilder.Entity<ClothingSuitcase>().HasData(
          new ClothingSuitcase
          {
              IdSuitcase = 1,
              IdClothing = 3
          }
      );
               modelBuilder.Entity<ClothingSuitcase>().HasData(
          new ClothingSuitcase
          {
              IdSuitcase = 2,
              IdClothing = 4
          }
      );
               modelBuilder.Entity<ClothingSuitcase>().HasData(
          new ClothingSuitcase
          {
              IdSuitcase = 2,
              IdClothing = 5
          }
      );
               modelBuilder.Entity<ClothingSuitcase>().HasData(
          new ClothingSuitcase
          {
              IdSuitcase = 2,
              IdClothing = 6
          }
      );
                modelBuilder.Entity<ClothingSuitcase>().HasData(
          new ClothingSuitcase
          {
              IdSuitcase = 3,
              IdClothing = 8
          }
      );
               modelBuilder.Entity<ClothingSuitcase>().HasData(
          new ClothingSuitcase
          {
              IdSuitcase = 3,
              IdClothing = 9
          }
      );





            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
