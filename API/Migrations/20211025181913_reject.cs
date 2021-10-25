using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class reject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b7d9f8e-40c8-41db-9468-0e0c8ea118c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2555386f-8cef-4eea-9505-0d279ccb9f6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b2fddbd-4338-481f-9904-8c519dc498e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "957168f0-4cf9-4826-9670-5a8ad1ceaa40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5d0b599-74db-425b-9a0e-41c3fe679197");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6595322-8482-4c2c-b084-bbf2235bef42");

            migrationBuilder.AddColumn<string>(
                name: "RejectBy",
                table: "RequestItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "RejectDate",
                table: "RequestItems",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28971e07-6c4e-40df-910f-057fc9d0cd5b", "20b712a4-7a3c-4df3-b937-9ac3b0d3d72f", "Administrator", "ADMINISTRATOR" },
                    { "0fa25baa-eecb-4b83-a9f6-e41def8e7725", "af26d15e-c17c-4846-9c15-a175feded6a0", "Purchaser", "PURCHASER" },
                    { "fb9acd3a-83a3-4f27-b441-540406a1a313", "9ea8b1a1-98b7-4643-a560-52f7d3749439", "StoreMan", "STOREMAN" },
                    { "34a17897-a123-4ecd-931b-6716ee46e4bc", "effa7194-1c31-48ec-a3d8-d625048a32d6", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "f416b2c2-078d-40c2-8c38-22426bd2a141", "60af1af4-cc13-4946-a3de-49735956deeb", "FinanceManager", "FINANCEMANAGER" },
                    { "081db2e8-7517-46c5-b234-532c691ccd58", "a89806b0-d457-41b4-b2f1-0ea2ace31d00", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "081db2e8-7517-46c5-b234-532c691ccd58");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fa25baa-eecb-4b83-a9f6-e41def8e7725");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28971e07-6c4e-40df-910f-057fc9d0cd5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34a17897-a123-4ecd-931b-6716ee46e4bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f416b2c2-078d-40c2-8c38-22426bd2a141");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb9acd3a-83a3-4f27-b441-540406a1a313");

            migrationBuilder.DropColumn(
                name: "RejectBy",
                table: "RequestItems");

            migrationBuilder.DropColumn(
                name: "RejectDate",
                table: "RequestItems");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b7d9f8e-40c8-41db-9468-0e0c8ea118c4", "f137716d-09af-4a62-96ff-22825bba5078", "Administrator", "ADMINISTRATOR" },
                    { "d6595322-8482-4c2c-b084-bbf2235bef42", "f95a4cf9-819e-426d-a03d-a1dcc5c90e5c", "Purchaser", "PURCHASER" },
                    { "957168f0-4cf9-4826-9670-5a8ad1ceaa40", "32ff71b8-4015-467e-889c-8d989cd6b08e", "StoreMan", "STOREMAN" },
                    { "a5d0b599-74db-425b-9a0e-41c3fe679197", "7d93b736-432b-40ca-898c-4c80593ed975", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "2b2fddbd-4338-481f-9904-8c519dc498e8", "a2aab41d-eb52-4e25-a779-38dee2a5a349", "FinanceManager", "FINANCEMANAGER" },
                    { "2555386f-8cef-4eea-9505-0d279ccb9f6f", "ce72340a-0683-43d8-a830-9ef7b67c7aa2", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }
    }
}
