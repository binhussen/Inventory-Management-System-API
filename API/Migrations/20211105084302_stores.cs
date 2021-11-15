using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class stores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0136bc41-82fd-44a9-83d8-bf3944aa90b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38053954-d894-4e27-a595-5828f11a748e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "753a6b4c-befd-44b0-8f1e-4080512124e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0e86b6d-ca7b-4873-865a-e5b9dcfb8e1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ece416d0-f36c-41ed-b092-98328b96761c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee8ecc2b-c819-464c-a593-50ae78296396");

            migrationBuilder.DropColumn(
                name: "AcceptedBy",
                table: "StoreHeaders");

            migrationBuilder.DropColumn(
                name: "CheckedBy",
                table: "StoreHeaders");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "StoreHeaders");

            migrationBuilder.DropColumn(
                name: "InspectedBy",
                table: "StoreHeaders");

            migrationBuilder.DropColumn(
                name: "ReciverId",
                table: "StoreHeaders");

            migrationBuilder.RenameColumn(
                name: "Pox",
                table: "StoreHeaders",
                newName: "StoreBy");

            migrationBuilder.AlterColumn<string>(
                name: "Unit",
                table: "StoreItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "StoreHeaders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "StoreDate",
                table: "StoreHeaders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1fbf24c9-dcee-4376-a42d-2f22c006e797", "00d7f89d-fdbf-482b-856b-e6419c6b0df6", "Administrator", "ADMINISTRATOR" },
                    { "cf7bfa49-42b7-49f5-9411-64c5010fa8db", "46fd3857-2006-41a7-a4e8-9f62f874b2c2", "Purchaser", "PURCHASER" },
                    { "39a16872-c0f4-4611-8b9a-22d0c1779067", "5c555b89-def4-451e-a7df-90a8d2aefe01", "StoreMan", "STOREMAN" },
                    { "d29ceab7-5733-477e-b97b-f8fe337b80d7", "504ecc58-3157-4d90-be79-bb3931b9c2e5", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "a16b401c-2320-40af-9c9f-dfd336826761", "9be5b1b4-47c6-4096-b96b-0e2f9e9ed3eb", "FinanceManager", "FINANCEMANAGER" },
                    { "e65b8fc3-96d9-4d75-b1ca-a216b965f4e3", "1b4c7e37-416f-47b7-8b16-eb778c7d06cb", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fbf24c9-dcee-4376-a42d-2f22c006e797");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39a16872-c0f4-4611-8b9a-22d0c1779067");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a16b401c-2320-40af-9c9f-dfd336826761");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf7bfa49-42b7-49f5-9411-64c5010fa8db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d29ceab7-5733-477e-b97b-f8fe337b80d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65b8fc3-96d9-4d75-b1ca-a216b965f4e3");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "StoreHeaders");

            migrationBuilder.DropColumn(
                name: "StoreDate",
                table: "StoreHeaders");

            migrationBuilder.RenameColumn(
                name: "StoreBy",
                table: "StoreHeaders",
                newName: "Pox");

            migrationBuilder.AlterColumn<int>(
                name: "Unit",
                table: "StoreItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AcceptedBy",
                table: "StoreHeaders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CheckedBy",
                table: "StoreHeaders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "StoreHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "InspectedBy",
                table: "StoreHeaders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ReciverId",
                table: "StoreHeaders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ee8ecc2b-c819-464c-a593-50ae78296396", "a81e5828-9a02-4630-8cc3-a2022002d670", "Administrator", "ADMINISTRATOR" },
                    { "e0e86b6d-ca7b-4873-865a-e5b9dcfb8e1e", "3093867c-6953-4724-88cd-1573905c725d", "Purchaser", "PURCHASER" },
                    { "753a6b4c-befd-44b0-8f1e-4080512124e4", "d5bafe2f-e1d0-4a50-8bf4-30d2aa8aab90", "StoreMan", "STOREMAN" },
                    { "0136bc41-82fd-44a9-83d8-bf3944aa90b5", "dc72e13d-5ce4-45b2-b8bd-7dae668477e1", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "38053954-d894-4e27-a595-5828f11a748e", "db84052c-77e4-4ff6-8de6-a5bff0336ee2", "FinanceManager", "FINANCEMANAGER" },
                    { "ece416d0-f36c-41ed-b092-98328b96761c", "e85b04a9-b30e-4579-9862-cbea46567db9", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }
    }
}
