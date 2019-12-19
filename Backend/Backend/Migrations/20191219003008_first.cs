using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "BodyPart",
            //    columns: table => new
            //    {
            //        IdBodyPart = table.Column<int>(nullable: false),
            //        Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("BodyPart_pk", x => x.IdBodyPart);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ClothingPurpose",
            //    columns: table => new
            //    {
            //        IdClothingPurpose = table.Column<int>(nullable: false),
            //        Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("ClothingPurpose_pk", x => x.IdClothingPurpose);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ClothingSet",
            //    columns: table => new
            //    {
            //        IdClothingSet = table.Column<int>(nullable: false),
            //        Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
            //        Description = table.Column<string>(unicode: false, maxLength: 512, nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
            //        UpdatedAt = table.Column<DateTime>(type: "date", nullable: false),
            //        DeletedAt = table.Column<DateTime>(type: "date", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("ClothingSet_pk", x => x.IdClothingSet);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ClothingType",
            //    columns: table => new
            //    {
            //        IdClothingType = table.Column<int>(nullable: false),
            //        Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("ClothingType_pk", x => x.IdClothingType);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Color",
            //    columns: table => new
            //    {
            //        IdColor = table.Column<int>(nullable: false),
            //        Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("Color_pk", x => x.IdColor);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Pattern",
            //    columns: table => new
            //    {
            //        IdPattern = table.Column<int>(nullable: false),
            //        Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("Pattern_pk", x => x.IdPattern);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Tags",
            //    columns: table => new
            //    {
            //        IdTag = table.Column<int>(nullable: false),
            //        Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("Tags_pk", x => x.IdTag);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Trip",
            //    columns: table => new
            //    {
            //        IdTrip = table.Column<int>(nullable: false),
            //        Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
            //        Start = table.Column<DateTime>(type: "date", nullable: false),
            //        End = table.Column<DateTime>(type: "date", nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
            //        DeletedAt = table.Column<DateTime>(type: "date", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("Trip_pk", x => x.IdTrip);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "User",
            //    columns: table => new
            //    {
            //        IdUser = table.Column<int>(nullable: false),
            //        FirstName = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
            //        LastName = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
            //        Email = table.Column<string>(unicode: false, maxLength: 254, nullable: false),
            //        Password = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
            //        Salt = table.Column<string>(unicode: false, maxLength: 512, nullable: false),
            //        AvatarUrl = table.Column<string>(unicode: false, maxLength: 512, nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
            //        DeletedAt = table.Column<DateTime>(type: "date", nullable: false),
            //        LastLogin = table.Column<DateTime>(type: "date", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("User_pk", x => x.IdUser);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ClothingSetPicture",
            //    columns: table => new
            //    {
            //        IdClothingSetPicture = table.Column<int>(nullable: false),
            //        Title = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
            //        ImageUrl = table.Column<string>(unicode: false, maxLength: 512, nullable: false),
            //        IdClothingSet = table.Column<int>(nullable: false),
            //        IdClothingPurpose = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("ClothingSetPicture_pk", x => x.IdClothingSetPicture);
            //        table.ForeignKey(
            //            name: "ClothingSetPicture_ClothingPurpose",
            //            column: x => x.IdClothingPurpose,
            //            principalTable: "ClothingPurpose",
            //            principalColumn: "IdClothingPurpose",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "ClothingSetPicture_ClothingSet",
            //            column: x => x.IdClothingSet,
            //            principalTable: "ClothingSet",
            //            principalColumn: "IdClothingSet",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ClothingSet_Tag",
            //    columns: table => new
            //    {
            //        IdTag = table.Column<int>(nullable: false),
            //        IdClothingSet = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("ClothingSet_Tag_pk", x => x.IdTag);
            //        table.ForeignKey(
            //            name: "Table_19_ClothingSet",
            //            column: x => x.IdClothingSet,
            //            principalTable: "ClothingSet",
            //            principalColumn: "IdClothingSet",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "Table_19_Tags",
            //            column: x => x.IdTag,
            //            principalTable: "Tags",
            //            principalColumn: "IdTag",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Clothing",
            //    columns: table => new
            //    {
            //        IdClothing = table.Column<int>(nullable: false),
            //        Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
            //        IdClothingType = table.Column<int>(nullable: false),
            //        Description = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
            //        CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
            //        DeletedAt = table.Column<DateTime>(type: "date", nullable: false),
            //        IdBodyPart = table.Column<int>(nullable: false),
            //        IdPattern = table.Column<int>(nullable: false),
            //        IdUser = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("Clothing_pk", x => x.IdClothing);
            //        table.ForeignKey(
            //            name: "Clothing_BodyPart",
            //            column: x => x.IdBodyPart,
            //            principalTable: "BodyPart",
            //            principalColumn: "IdBodyPart",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "Clothing_ClothingType",
            //            column: x => x.IdClothingType,
            //            principalTable: "ClothingType",
            //            principalColumn: "IdClothingType",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "Clothing_Pattern",
            //            column: x => x.IdPattern,
            //            principalTable: "Pattern",
            //            principalColumn: "IdPattern",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "Clothing_User",
            //            column: x => x.IdUser,
            //            principalTable: "User",
            //            principalColumn: "IdUser",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Suitcase",
            //    columns: table => new
            //    {
            //        IdSuitcase = table.Column<int>(nullable: false),
            //        Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
            //        IdUser = table.Column<int>(nullable: false),
            //        IdTrip = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("Suitcase_pk", x => x.IdSuitcase);
            //        table.ForeignKey(
            //            name: "Suitcase_Trip",
            //            column: x => x.IdTrip,
            //            principalTable: "Trip",
            //            principalColumn: "IdTrip",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "Suitcase_User",
            //            column: x => x.IdUser,
            //            principalTable: "User",
            //            principalColumn: "IdUser",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Clothing_Color",
            //    columns: table => new
            //    {
            //        Clothing_IdClothing = table.Column<int>(nullable: false),
            //        Color_IdColor = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("Clothing_Color_pk", x => new { x.Clothing_IdClothing, x.Color_IdColor });
            //        table.ForeignKey(
            //            name: "Table_22_Clothing",
            //            column: x => x.Clothing_IdClothing,
            //            principalTable: "Clothing",
            //            principalColumn: "IdClothing",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "Table_22_Color",
            //            column: x => x.Color_IdColor,
            //            principalTable: "Color",
            //            principalColumn: "IdColor",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Clothing_Tag",
            //    columns: table => new
            //    {
            //        IdClothing = table.Column<int>(nullable: false),
            //        IdTag = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("Clothing_Tag_pk", x => new { x.IdClothing, x.IdTag });
            //        table.ForeignKey(
            //            name: "Clothing_Tag_Clothing",
            //            column: x => x.IdClothing,
            //            principalTable: "Clothing",
            //            principalColumn: "IdClothing",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "Clothing_Tag_Tags",
            //            column: x => x.IdTag,
            //            principalTable: "Tags",
            //            principalColumn: "IdTag",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ClothingPicture",
            //    columns: table => new
            //    {
            //        IdClothingPicture = table.Column<int>(nullable: false),
            //        Title = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
            //        ImageUrl = table.Column<string>(unicode: false, maxLength: 512, nullable: false),
            //        IdClothin = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("ClothingPicture_pk", x => x.IdClothingPicture);
            //        table.ForeignKey(
            //            name: "Picture_Clothing",
            //            column: x => x.IdClothin,
            //            principalTable: "Clothing",
            //            principalColumn: "IdClothing",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ClothingPurpose_Clothing",
            //    columns: table => new
            //    {
            //        IdClothingPurpose = table.Column<int>(nullable: false),
            //        IdClothing = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("ClothingPurpose_Clothing_pk", x => new { x.IdClothingPurpose, x.IdClothing });
            //        table.ForeignKey(
            //            name: "ClothingPurpose_Clothing_Clothing",
            //            column: x => x.IdClothing,
            //            principalTable: "Clothing",
            //            principalColumn: "IdClothing",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "ClothingPurpose_Clothing_ClothingPurpose",
            //            column: x => x.IdClothingPurpose,
            //            principalTable: "ClothingPurpose",
            //            principalColumn: "IdClothingPurpose",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ClothingSet_Clothing",
            //    columns: table => new
            //    {
            //        IdClothing = table.Column<int>(nullable: false),
            //        IdClothingSet = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("ClothingSet_Clothing_pk", x => new { x.IdClothing, x.IdClothingSet });
            //        table.ForeignKey(
            //            name: "ClothingSet_Clothing_Clothing",
            //            column: x => x.IdClothing,
            //            principalTable: "Clothing",
            //            principalColumn: "IdClothing",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "ClothingSet_Clothing_ClothingSet",
            //            column: x => x.IdClothingSet,
            //            principalTable: "ClothingSet",
            //            principalColumn: "IdClothingSet",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Clothing_Suitcase",
            //    columns: table => new
            //    {
            //        IdSuitcase = table.Column<int>(nullable: false),
            //        IdClothing = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("Clothing_Suitcase_pk", x => new { x.IdSuitcase, x.IdClothing });
            //        table.ForeignKey(
            //            name: "Clothing_Suitcase_Clothing",
            //            column: x => x.IdClothing,
            //            principalTable: "Clothing",
            //            principalColumn: "IdClothing",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "Clothing_Suitcase_Suitcase",
            //            column: x => x.IdSuitcase,
            //            principalTable: "Suitcase",
            //            principalColumn: "IdSuitcase",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Clothing_IdBodyPart",
            //    table: "Clothing",
            //    column: "IdBodyPart");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Clothing_IdClothingType",
            //    table: "Clothing",
            //    column: "IdClothingType");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Clothing_IdPattern",
            //    table: "Clothing",
            //    column: "IdPattern");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Clothing_IdUser",
            //    table: "Clothing",
            //    column: "IdUser");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Clothing_Color_Color_IdColor",
            //    table: "Clothing_Color",
            //    column: "Color_IdColor");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Clothing_Suitcase_IdClothing",
            //    table: "Clothing_Suitcase",
            //    column: "IdClothing");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Clothing_Tag_IdTag",
            //    table: "Clothing_Tag",
            //    column: "IdTag");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ClothingPicture_IdClothin",
            //    table: "ClothingPicture",
            //    column: "IdClothin");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ClothingPurpose_Clothing_IdClothing",
            //    table: "ClothingPurpose_Clothing",
            //    column: "IdClothing");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ClothingSet_Clothing_IdClothingSet",
            //    table: "ClothingSet_Clothing",
            //    column: "IdClothingSet");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ClothingSet_Tag_IdClothingSet",
            //    table: "ClothingSet_Tag",
            //    column: "IdClothingSet");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ClothingSetPicture_IdClothingPurpose",
            //    table: "ClothingSetPicture",
            //    column: "IdClothingPurpose");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ClothingSetPicture_IdClothingSet",
            //    table: "ClothingSetPicture",
            //    column: "IdClothingSet");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Suitcase_IdTrip",
            //    table: "Suitcase",
            //    column: "IdTrip");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Suitcase_IdUser",
            //    table: "Suitcase",
            //    column: "IdUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Clothing_Color");

            //migrationBuilder.DropTable(
            //    name: "Clothing_Suitcase");

            //migrationBuilder.DropTable(
            //    name: "Clothing_Tag");

            //migrationBuilder.DropTable(
            //    name: "ClothingPicture");

            //migrationBuilder.DropTable(
            //    name: "ClothingPurpose_Clothing");

            //migrationBuilder.DropTable(
            //    name: "ClothingSet_Clothing");

            //migrationBuilder.DropTable(
            //    name: "ClothingSet_Tag");

            //migrationBuilder.DropTable(
            //    name: "ClothingSetPicture");

            //migrationBuilder.DropTable(
            //    name: "Color");

            //migrationBuilder.DropTable(
            //    name: "Suitcase");

            //migrationBuilder.DropTable(
            //    name: "Clothing");

            //migrationBuilder.DropTable(
            //    name: "Tags");

            //migrationBuilder.DropTable(
            //    name: "ClothingPurpose");

            //migrationBuilder.DropTable(
            //    name: "ClothingSet");

            //migrationBuilder.DropTable(
            //    name: "Trip");

            //migrationBuilder.DropTable(
            //    name: "BodyPart");

            //migrationBuilder.DropTable(
            //    name: "ClothingType");

            //migrationBuilder.DropTable(
            //    name: "Pattern");

            //migrationBuilder.DropTable(
            //    name: "User");
        }
    }
}
