//using System;
//using Microsoft.EntityFrameworkCore.Migrations;

//namespace backend.migrations
//{
//    public partial class fifth : Migration
//    {
//        protected override void up(migrationbuilder migrationbuilder)
//        {
//            migrationbuilder.insertdata(
//                table: "clothing",
//                columns: new[] { "idclothing", "createdat", "deletedat", "description", "idbodypart", "idclothingtype", "idpattern", "iduser", "name" },
//                values: new object[] { 8, new datetime(2018, 9, 10, 0, 0, 0, 0, datetimekind.unspecified), new datetime(2019, 12, 10, 0, 0, 0, 0, datetimekind.unspecified), "desc", 1, 2, 1, 2, "t-shirt-3 " });

//            migrationbuilder.insertdata(
//                table: "clothing",
//                columns: new[] { "idclothing", "createdat", "deletedat", "description", "idbodypart", "idclothingtype", "idpattern", "iduser", "name" },
//                values: new object[] { 9, new datetime(2018, 9, 10, 0, 0, 0, 0, datetimekind.unspecified), new datetime(2019, 12, 10, 0, 0, 0, 0, datetimekind.unspecified), "desc", 1, 2, 1, 2, "t-shirt-4 " });
//        }

//        protected override void down(migrationbuilder migrationbuilder)
//        {
//            migrationbuilder.deletedata(
//                table: "clothing",
//                keycolumn: "idclothing",
//                keyvalue: 8);

//            migrationbuilder.deletedata(
//                table: "clothing",
//                keycolumn: "idclothing",
//                keyvalue: 9);
//        }
//    }
//}
