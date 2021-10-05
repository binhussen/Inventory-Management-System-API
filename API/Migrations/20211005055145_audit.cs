using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class audit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75eb7914-b53f-410f-b618-e82b2b78220d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d3a5c77-7bf0-4384-9f45-699905debf10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae4f165c-9e12-466d-bbd9-8ec382ecb88f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4ba2b5a-4d07-48b2-8637-161d72453c41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd714947-01a3-4133-b0c7-f6c09d61c904");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef4908cf-dbb3-44d0-b636-2bb48c5ba437");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "StoreItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "StoreItems",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByUser",
                table: "StoreItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDate",
                table: "StoreItems",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "StoreHeaders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "StoreHeaders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByUser",
                table: "StoreHeaders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDate",
                table: "StoreHeaders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "RequestItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "RequestItems",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByUser",
                table: "RequestItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDate",
                table: "RequestItems",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "RequestHeaders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "RequestHeaders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByUser",
                table: "RequestHeaders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDate",
                table: "RequestHeaders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Employees",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByUser",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDate",
                table: "Employees",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDate",
                table: "Companies",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByUser",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ModifiedDate",
                table: "Companies",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "AspNetRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "UserId" },
                values: new object[,]
                {
                    { "b53e1faf-e2cd-42b8-9971-7a31cc49e22e", "db405c22-3b89-48f3-8f14-bc338dfb3a06", "Administrator", "ADMINISTRATOR", null },
                    { "d15b87d7-de3d-4045-816b-a46c38773e82", "c5d8034c-b153-494f-9381-ffe440926f7c", "Purchaser", "PURCHASER", null },
                    { "5068c2a5-f209-4c7c-b9fa-67ac9bab11d5", "7da7aae6-49fc-4056-a6ac-10e3b90694c8", "StoreMan", "STOREMAN", null },
                    { "16f94ee5-f49a-4f25-bd38-ba8c4b80b751", "4da10746-c90e-4dbb-a773-657a7c8dda19", "DepartmentHead", "DEPARTMENTHEAD", null },
                    { "42f54630-69a0-4392-b3f1-4df0ddb4a7e6", "5d141978-9349-4258-97a1-86f97c56ce96", "FinanceManager", "FINANCEMANAGER", null },
                    { "045bc82b-523c-43cb-ab42-4b20e38a56c6", "3a99060f-0a78-497e-9295-55620981edb8", "ProcurementManager", "PROCUREMENTMANAGER", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_UserId",
                table: "AspNetRoles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_UserId",
                table: "AspNetRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_UserId",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_UserId",
                table: "AspNetRoles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "045bc82b-523c-43cb-ab42-4b20e38a56c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16f94ee5-f49a-4f25-bd38-ba8c4b80b751");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42f54630-69a0-4392-b3f1-4df0ddb4a7e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5068c2a5-f209-4c7c-b9fa-67ac9bab11d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b53e1faf-e2cd-42b8-9971-7a31cc49e22e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d15b87d7-de3d-4045-816b-a46c38773e82");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "StoreItems");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "StoreItems");

            migrationBuilder.DropColumn(
                name: "ModifiedByUser",
                table: "StoreItems");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "StoreItems");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "StoreHeaders");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "StoreHeaders");

            migrationBuilder.DropColumn(
                name: "ModifiedByUser",
                table: "StoreHeaders");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "StoreHeaders");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "RequestItems");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "RequestItems");

            migrationBuilder.DropColumn(
                name: "ModifiedByUser",
                table: "RequestItems");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "RequestItems");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "RequestHeaders");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "RequestHeaders");

            migrationBuilder.DropColumn(
                name: "ModifiedByUser",
                table: "RequestHeaders");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "RequestHeaders");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ModifiedByUser",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ModifiedByUser",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AspNetRoles");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ef4908cf-dbb3-44d0-b636-2bb48c5ba437", "f46e8921-8ebe-4cbc-a86b-cde4e7710f2f", "Administrator", "ADMINISTRATOR" },
                    { "dd714947-01a3-4133-b0c7-f6c09d61c904", "f8f39c4f-e5f4-414f-ba1e-4acd355e2d4e", "Purchaser", "PURCHASER" },
                    { "ae4f165c-9e12-466d-bbd9-8ec382ecb88f", "19f7b117-3516-4ecd-8a15-d420d00a54b4", "StoreMan", "STOREMAN" },
                    { "9d3a5c77-7bf0-4384-9f45-699905debf10", "a76797db-b22e-41a0-82b9-253643161dd0", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "c4ba2b5a-4d07-48b2-8637-161d72453c41", "3c1de7a6-978b-4e58-b5fd-2b5e9fc6c32a", "FinanceManager", "FINANCEMANAGER" },
                    { "75eb7914-b53f-410f-b618-e82b2b78220d", "d8d2a846-9583-4a4d-9751-8744890ad0b6", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }
    }
}
