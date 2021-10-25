using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class approvement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ce8acf5-da74-4ad8-b5c6-7204444313a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24d613e8-c1cc-4064-af1c-ead99cb3e580");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62c3ca30-8d7f-412c-b0ef-57a0d86eb0d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b86485b-db69-4955-bf83-e97cebfc23ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93855cb8-3c98-45a6-8604-f56883a752cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7c47599-e93a-41ff-b7c6-07bd8c7cdbc1");

            migrationBuilder.DropColumn(
                name: "ApprovedBy",
                table: "RequestHeaders");

            migrationBuilder.DropColumn(
                name: "AskedBy",
                table: "RequestHeaders");

            migrationBuilder.DropColumn(
                name: "CheckedBy",
                table: "RequestHeaders");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "RequestHeaders");

            migrationBuilder.AddColumn<Guid>(
                name: "ApprovedBy",
                table: "RequestItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ApprovedDate",
                table: "RequestItems",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "06bfe8d0-67d0-4f9f-8a2f-1e39336111fa", "3bc5b4ac-03bc-4c64-b021-069bf796810a", "Administrator", "ADMINISTRATOR" },
                    { "c736fe76-f23b-4bd2-84e6-203b1488562b", "6528e24c-5955-414a-abf4-4e69f0ca5628", "Purchaser", "PURCHASER" },
                    { "dee2868f-0d57-4b6a-a0e2-5f6b133b44f2", "dac4891d-c2f4-4f64-9016-c45b72da92da", "StoreMan", "STOREMAN" },
                    { "8fc59b95-b27d-43fd-95c4-beb5809a004b", "196cedf7-5014-4fd6-85c5-c46468c21be4", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "853d5c93-300b-4f72-b9be-1000589b2708", "c6650e18-40da-46c6-9216-336fba37e44f", "FinanceManager", "FINANCEMANAGER" },
                    { "14c8b554-9a50-4e4b-be87-90208066dc40", "a8264e72-b70c-464b-807c-a32a53af9d0c", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06bfe8d0-67d0-4f9f-8a2f-1e39336111fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14c8b554-9a50-4e4b-be87-90208066dc40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "853d5c93-300b-4f72-b9be-1000589b2708");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fc59b95-b27d-43fd-95c4-beb5809a004b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c736fe76-f23b-4bd2-84e6-203b1488562b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dee2868f-0d57-4b6a-a0e2-5f6b133b44f2");

            migrationBuilder.DropColumn(
                name: "ApprovedBy",
                table: "RequestItems");

            migrationBuilder.DropColumn(
                name: "ApprovedDate",
                table: "RequestItems");

            migrationBuilder.AddColumn<Guid>(
                name: "ApprovedBy",
                table: "RequestHeaders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AskedBy",
                table: "RequestHeaders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CheckedBy",
                table: "RequestHeaders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "RequestHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24d613e8-c1cc-4064-af1c-ead99cb3e580", "33cc57c6-5e7b-480a-8c75-616aede09930", "Administrator", "ADMINISTRATOR" },
                    { "7b86485b-db69-4955-bf83-e97cebfc23ba", "b281acc0-bd4f-4588-92e2-e60be31a503d", "Purchaser", "PURCHASER" },
                    { "93855cb8-3c98-45a6-8604-f56883a752cb", "1047556a-75fa-4d64-bac8-1b218871c582", "StoreMan", "STOREMAN" },
                    { "0ce8acf5-da74-4ad8-b5c6-7204444313a3", "b2329e88-1da3-4cdf-a833-66e6de5e3d3d", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "62c3ca30-8d7f-412c-b0ef-57a0d86eb0d9", "429d11a2-4d7b-41a1-b580-fcc8e4a5f8d1", "FinanceManager", "FINANCEMANAGER" },
                    { "e7c47599-e93a-41ff-b7c6-07bd8c7cdbc1", "8d07d5b2-fb02-40f3-bbde-c647784ff782", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }
    }
}
