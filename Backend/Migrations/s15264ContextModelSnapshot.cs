﻿// <auto-generated />
using System;
using Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend.Migrations
{
    [DbContext(typeof(s15264Context))]
    partial class s15264ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Backend.Models.BodyPart", b =>
                {
                    b.Property<int>("IdBodyPart");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("IdBodyPart")
                        .HasName("BodyPart_pk");

                    b.ToTable("BodyPart");

                    b.HasData(
                        new
                        {
                            IdBodyPart = 1,
                            Name = "Chest"
                        });
                });

            modelBuilder.Entity("Backend.Models.Clothing", b =>
                {
                    b.Property<int>("IdClothing");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("date");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int>("IdBodyPart");

                    b.Property<int>("IdClothingType");

                    b.Property<int>("IdPattern");

                    b.Property<int>("IdUser");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("IdClothing")
                        .HasName("Clothing_pk");

                    b.HasIndex("IdBodyPart");

                    b.HasIndex("IdClothingType");

                    b.HasIndex("IdPattern");

                    b.HasIndex("IdUser");

                    b.ToTable("Clothing");

                    b.HasData(
                        new
                        {
                            IdClothing = 1,
                            CreatedAt = new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "desc",
                            IdBodyPart = 1,
                            IdClothingType = 1,
                            IdPattern = 1,
                            IdUser = 1,
                            Name = "Shirt-1 "
                        },
                        new
                        {
                            IdClothing = 2,
                            CreatedAt = new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "desc",
                            IdBodyPart = 1,
                            IdClothingType = 1,
                            IdPattern = 1,
                            IdUser = 1,
                            Name = "Shirt-2 "
                        },
                        new
                        {
                            IdClothing = 3,
                            CreatedAt = new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "desc",
                            IdBodyPart = 1,
                            IdClothingType = 1,
                            IdPattern = 1,
                            IdUser = 1,
                            Name = "Shirt-3 "
                        },
                        new
                        {
                            IdClothing = 4,
                            CreatedAt = new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "desc",
                            IdBodyPart = 1,
                            IdClothingType = 1,
                            IdPattern = 1,
                            IdUser = 1,
                            Name = "Shirt-4 "
                        },
                        new
                        {
                            IdClothing = 5,
                            CreatedAt = new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "desc",
                            IdBodyPart = 1,
                            IdClothingType = 1,
                            IdPattern = 1,
                            IdUser = 1,
                            Name = "Shirt-5 "
                        },
                        new
                        {
                            IdClothing = 6,
                            CreatedAt = new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "desc",
                            IdBodyPart = 1,
                            IdClothingType = 2,
                            IdPattern = 1,
                            IdUser = 1,
                            Name = "T-Shirt-1 "
                        },
                        new
                        {
                            IdClothing = 7,
                            CreatedAt = new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "desc",
                            IdBodyPart = 1,
                            IdClothingType = 2,
                            IdPattern = 1,
                            IdUser = 1,
                            Name = "T-Shirt-2 "
                        },
                        new
                        {
                            IdClothing = 8,
                            CreatedAt = new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "desc",
                            IdBodyPart = 1,
                            IdClothingType = 2,
                            IdPattern = 1,
                            IdUser = 2,
                            Name = "T-Shirt-3 "
                        },
                        new
                        {
                            IdClothing = 9,
                            CreatedAt = new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "desc",
                            IdBodyPart = 1,
                            IdClothingType = 2,
                            IdPattern = 1,
                            IdUser = 2,
                            Name = "T-Shirt-4 "
                        });
                });

            modelBuilder.Entity("Backend.Models.ClothingColor", b =>
                {
                    b.Property<int>("ClothingIdClothing")
                        .HasColumnName("Clothing_IdClothing");

                    b.Property<int>("ColorIdColor")
                        .HasColumnName("Color_IdColor");

                    b.HasKey("ClothingIdClothing", "ColorIdColor")
                        .HasName("Clothing_Color_pk");

                    b.HasIndex("ColorIdColor");

                    b.ToTable("Clothing_Color");
                });

            modelBuilder.Entity("Backend.Models.ClothingPicture", b =>
                {
                    b.Property<int>("IdClothingPicture");

                    b.Property<int>("IdClothin");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(512)
                        .IsUnicode(false);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("IdClothingPicture")
                        .HasName("ClothingPicture_pk");

                    b.HasIndex("IdClothin");

                    b.ToTable("ClothingPicture");
                });

            modelBuilder.Entity("Backend.Models.ClothingPurpose", b =>
                {
                    b.Property<int>("IdClothingPurpose");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("IdClothingPurpose")
                        .HasName("ClothingPurpose_pk");

                    b.ToTable("ClothingPurpose");
                });

            modelBuilder.Entity("Backend.Models.ClothingPurposeClothing", b =>
                {
                    b.Property<int>("IdClothingPurpose");

                    b.Property<int>("IdClothing");

                    b.HasKey("IdClothingPurpose", "IdClothing")
                        .HasName("ClothingPurpose_Clothing_pk");

                    b.HasIndex("IdClothing");

                    b.ToTable("ClothingPurpose_Clothing");
                });

            modelBuilder.Entity("Backend.Models.ClothingSet", b =>
                {
                    b.Property<int>("IdClothingSet");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("date");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(512)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("date");

                    b.HasKey("IdClothingSet")
                        .HasName("ClothingSet_pk");

                    b.ToTable("ClothingSet");
                });

            modelBuilder.Entity("Backend.Models.ClothingSetClothing", b =>
                {
                    b.Property<int>("IdClothing");

                    b.Property<int>("IdClothingSet");

                    b.HasKey("IdClothing", "IdClothingSet")
                        .HasName("ClothingSet_Clothing_pk");

                    b.HasIndex("IdClothingSet");

                    b.ToTable("ClothingSet_Clothing");
                });

            modelBuilder.Entity("Backend.Models.ClothingSetPicture", b =>
                {
                    b.Property<int>("IdClothingSetPicture");

                    b.Property<int>("IdClothingPurpose");

                    b.Property<int>("IdClothingSet");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(512)
                        .IsUnicode(false);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("IdClothingSetPicture")
                        .HasName("ClothingSetPicture_pk");

                    b.HasIndex("IdClothingPurpose");

                    b.HasIndex("IdClothingSet");

                    b.ToTable("ClothingSetPicture");
                });

            modelBuilder.Entity("Backend.Models.ClothingSetTag", b =>
                {
                    b.Property<int>("IdTag");

                    b.Property<int>("IdClothingSet");

                    b.HasKey("IdTag")
                        .HasName("ClothingSet_Tag_pk");

                    b.HasIndex("IdClothingSet");

                    b.ToTable("ClothingSet_Tag");
                });

            modelBuilder.Entity("Backend.Models.ClothingSuitcase", b =>
                {
                    b.Property<int>("IdSuitcase");

                    b.Property<int>("IdClothing");

                    b.HasKey("IdSuitcase", "IdClothing")
                        .HasName("Clothing_Suitcase_pk");

                    b.HasIndex("IdClothing");

                    b.ToTable("Clothing_Suitcase");

                    b.HasData(
                        new
                        {
                            IdSuitcase = 1,
                            IdClothing = 1
                        },
                        new
                        {
                            IdSuitcase = 1,
                            IdClothing = 2
                        },
                        new
                        {
                            IdSuitcase = 1,
                            IdClothing = 3
                        },
                        new
                        {
                            IdSuitcase = 2,
                            IdClothing = 4
                        },
                        new
                        {
                            IdSuitcase = 2,
                            IdClothing = 5
                        },
                        new
                        {
                            IdSuitcase = 2,
                            IdClothing = 6
                        },
                        new
                        {
                            IdSuitcase = 3,
                            IdClothing = 8
                        },
                        new
                        {
                            IdSuitcase = 3,
                            IdClothing = 9
                        });
                });

            modelBuilder.Entity("Backend.Models.ClothingTag", b =>
                {
                    b.Property<int>("IdClothing");

                    b.Property<int>("IdTag");

                    b.HasKey("IdClothing", "IdTag")
                        .HasName("Clothing_Tag_pk");

                    b.HasIndex("IdTag");

                    b.ToTable("Clothing_Tag");
                });

            modelBuilder.Entity("Backend.Models.ClothingType", b =>
                {
                    b.Property<int>("IdClothingType");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("IdClothingType")
                        .HasName("ClothingType_pk");

                    b.ToTable("ClothingType");

                    b.HasData(
                        new
                        {
                            IdClothingType = 1,
                            Name = "Shirt"
                        },
                        new
                        {
                            IdClothingType = 2,
                            Name = "T-Shirt"
                        });
                });

            modelBuilder.Entity("Backend.Models.Color", b =>
                {
                    b.Property<int>("IdColor");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("IdColor")
                        .HasName("Color_pk");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("Backend.Models.Pattern", b =>
                {
                    b.Property<int>("IdPattern");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("IdPattern")
                        .HasName("Pattern_pk");

                    b.ToTable("Pattern");

                    b.HasData(
                        new
                        {
                            IdPattern = 1,
                            Name = "Check "
                        });
                });

            modelBuilder.Entity("Backend.Models.Suitcase", b =>
                {
                    b.Property<int>("IdSuitcase");

                    b.Property<int>("IdTrip");

                    b.Property<int>("IdUser");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("IdSuitcase")
                        .HasName("Suitcase_pk");

                    b.HasIndex("IdTrip");

                    b.HasIndex("IdUser");

                    b.ToTable("Suitcase");

                    b.HasData(
                        new
                        {
                            IdSuitcase = 1,
                            IdTrip = 1,
                            IdUser = 1,
                            Name = "Suitcase-1 "
                        },
                        new
                        {
                            IdSuitcase = 2,
                            IdTrip = 2,
                            IdUser = 1,
                            Name = "Suitcase-2 "
                        },
                        new
                        {
                            IdSuitcase = 3,
                            IdTrip = 3,
                            IdUser = 2,
                            Name = "Suitcase-3 "
                        });
                });

            modelBuilder.Entity("Backend.Models.Tags", b =>
                {
                    b.Property<int>("IdTag");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("IdTag")
                        .HasName("Tags_pk");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Backend.Models.Trip", b =>
                {
                    b.Property<int>("IdTrip");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("date");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("date");

                    b.Property<DateTime>("End")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime>("Start")
                        .HasColumnType("date");

                    b.HasKey("IdTrip")
                        .HasName("Trip_pk");

                    b.ToTable("Trip");

                    b.HasData(
                        new
                        {
                            IdTrip = 1,
                            CreatedAt = new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            End = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Trip-1 ",
                            Start = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdTrip = 2,
                            CreatedAt = new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            End = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Trip-2 ",
                            Start = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdTrip = 3,
                            CreatedAt = new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            End = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Trip-3 ",
                            Start = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Backend.Models.User", b =>
                {
                    b.Property<int>("IdUser");

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasMaxLength(512)
                        .IsUnicode(false);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("date");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(254)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("date");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasMaxLength(512)
                        .IsUnicode(false);

                    b.HasKey("IdUser")
                        .HasName("User_pk");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            IdUser = 1,
                            AvatarUrl = "url",
                            CreatedAt = new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "qwert@gmail.com",
                            FirstName = "Artur",
                            LastLogin = new DateTime(2019, 12, 10, 10, 30, 50, 0, DateTimeKind.Unspecified),
                            LastName = "Pendragon",
                            Password = "1234",
                            Salt = "wtf"
                        },
                        new
                        {
                            IdUser = 2,
                            AvatarUrl = "url",
                            CreatedAt = new DateTime(2018, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "asdf@gmail.com",
                            FirstName = "Sherlock",
                            LastLogin = new DateTime(2019, 12, 10, 10, 30, 50, 0, DateTimeKind.Unspecified),
                            LastName = "Holmes",
                            Password = "1234",
                            Salt = "wtf"
                        });
                });

            modelBuilder.Entity("Backend.Models.Clothing", b =>
                {
                    b.HasOne("Backend.Models.BodyPart", "IdBodyPartNavigation")
                        .WithMany("Clothing")
                        .HasForeignKey("IdBodyPart")
                        .HasConstraintName("Clothing_BodyPart");

                    b.HasOne("Backend.Models.ClothingType", "IdClothingTypeNavigation")
                        .WithMany("Clothing")
                        .HasForeignKey("IdClothingType")
                        .HasConstraintName("Clothing_ClothingType");

                    b.HasOne("Backend.Models.Pattern", "IdPatternNavigation")
                        .WithMany("Clothing")
                        .HasForeignKey("IdPattern")
                        .HasConstraintName("Clothing_Pattern");

                    b.HasOne("Backend.Models.User", "IdUserNavigation")
                        .WithMany("Clothing")
                        .HasForeignKey("IdUser")
                        .HasConstraintName("Clothing_User");
                });

            modelBuilder.Entity("Backend.Models.ClothingColor", b =>
                {
                    b.HasOne("Backend.Models.Clothing", "ClothingIdClothingNavigation")
                        .WithMany("ClothingColor")
                        .HasForeignKey("ClothingIdClothing")
                        .HasConstraintName("Table_22_Clothing");

                    b.HasOne("Backend.Models.Color", "ColorIdColorNavigation")
                        .WithMany("ClothingColor")
                        .HasForeignKey("ColorIdColor")
                        .HasConstraintName("Table_22_Color");
                });

            modelBuilder.Entity("Backend.Models.ClothingPicture", b =>
                {
                    b.HasOne("Backend.Models.Clothing", "IdClothinNavigation")
                        .WithMany("ClothingPicture")
                        .HasForeignKey("IdClothin")
                        .HasConstraintName("Picture_Clothing");
                });

            modelBuilder.Entity("Backend.Models.ClothingPurposeClothing", b =>
                {
                    b.HasOne("Backend.Models.Clothing", "IdClothingNavigation")
                        .WithMany("ClothingPurposeClothing")
                        .HasForeignKey("IdClothing")
                        .HasConstraintName("ClothingPurpose_Clothing_Clothing");

                    b.HasOne("Backend.Models.ClothingPurpose", "IdClothingPurposeNavigation")
                        .WithMany("ClothingPurposeClothing")
                        .HasForeignKey("IdClothingPurpose")
                        .HasConstraintName("ClothingPurpose_Clothing_ClothingPurpose");
                });

            modelBuilder.Entity("Backend.Models.ClothingSetClothing", b =>
                {
                    b.HasOne("Backend.Models.Clothing", "IdClothingNavigation")
                        .WithMany("ClothingSetClothing")
                        .HasForeignKey("IdClothing")
                        .HasConstraintName("ClothingSet_Clothing_Clothing");

                    b.HasOne("Backend.Models.ClothingSet", "IdClothingSetNavigation")
                        .WithMany("ClothingSetClothing")
                        .HasForeignKey("IdClothingSet")
                        .HasConstraintName("ClothingSet_Clothing_ClothingSet");
                });

            modelBuilder.Entity("Backend.Models.ClothingSetPicture", b =>
                {
                    b.HasOne("Backend.Models.ClothingPurpose", "IdClothingPurposeNavigation")
                        .WithMany("ClothingSetPicture")
                        .HasForeignKey("IdClothingPurpose")
                        .HasConstraintName("ClothingSetPicture_ClothingPurpose");

                    b.HasOne("Backend.Models.ClothingSet", "IdClothingSetNavigation")
                        .WithMany("ClothingSetPicture")
                        .HasForeignKey("IdClothingSet")
                        .HasConstraintName("ClothingSetPicture_ClothingSet");
                });

            modelBuilder.Entity("Backend.Models.ClothingSetTag", b =>
                {
                    b.HasOne("Backend.Models.ClothingSet", "IdClothingSetNavigation")
                        .WithMany("ClothingSetTag")
                        .HasForeignKey("IdClothingSet")
                        .HasConstraintName("Table_19_ClothingSet");

                    b.HasOne("Backend.Models.Tags", "IdTagNavigation")
                        .WithOne("ClothingSetTag")
                        .HasForeignKey("Backend.Models.ClothingSetTag", "IdTag")
                        .HasConstraintName("Table_19_Tags");
                });

            modelBuilder.Entity("Backend.Models.ClothingSuitcase", b =>
                {
                    b.HasOne("Backend.Models.Clothing", "IdClothingNavigation")
                        .WithMany("ClothingSuitcase")
                        .HasForeignKey("IdClothing")
                        .HasConstraintName("Clothing_Suitcase_Clothing");

                    b.HasOne("Backend.Models.Suitcase", "IdSuitcaseNavigation")
                        .WithMany("ClothingSuitcase")
                        .HasForeignKey("IdSuitcase")
                        .HasConstraintName("Clothing_Suitcase_Suitcase");
                });

            modelBuilder.Entity("Backend.Models.ClothingTag", b =>
                {
                    b.HasOne("Backend.Models.Clothing", "IdClothingNavigation")
                        .WithMany("ClothingTag")
                        .HasForeignKey("IdClothing")
                        .HasConstraintName("Clothing_Tag_Clothing");

                    b.HasOne("Backend.Models.Tags", "IdTagNavigation")
                        .WithMany("ClothingTag")
                        .HasForeignKey("IdTag")
                        .HasConstraintName("Clothing_Tag_Tags");
                });

            modelBuilder.Entity("Backend.Models.Suitcase", b =>
                {
                    b.HasOne("Backend.Models.Trip", "IdTripNavigation")
                        .WithMany("Suitcase")
                        .HasForeignKey("IdTrip")
                        .HasConstraintName("Suitcase_Trip");

                    b.HasOne("Backend.Models.User", "IdUserNavigation")
                        .WithMany("Suitcase")
                        .HasForeignKey("IdUser")
                        .HasConstraintName("Suitcase_User");
                });
#pragma warning restore 612, 618
        }
    }
}
