using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class approves : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1aadd3ab-8a0c-4ebf-a548-093b6122bc4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ff27e82-8f0f-4518-b630-0118aba8adae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "689938a8-2996-4d8c-afe8-284b04588db0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a31f557-5021-4d98-8346-7da48003add6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b140522d-9c71-4940-ba24-f26f86d49341");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cce206f4-e8a4-43ad-9ccd-3e16efd67fda");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "RequestItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "DistributeBy",
                table: "RequestItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DistributeDate",
                table: "RequestItems",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "BudgetBy",
                table: "RequestHeaders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "DistributeBy",
                table: "RequestItems");

            migrationBuilder.DropColumn(
                name: "DistributeDate",
                table: "RequestItems");

            migrationBuilder.AlterColumn<Guid>(
                name: "ApprovedBy",
                table: "RequestItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "BudgetBy",
                table: "RequestHeaders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cce206f4-e8a4-43ad-9ccd-3e16efd67fda", "8dc5beee-04a0-4e3f-96f0-24487066f278", "Administrator", "ADMINISTRATOR" },
                    { "b140522d-9c71-4940-ba24-f26f86d49341", "221c0715-bc31-48fb-9e10-9b658cda8f79", "Purchaser", "PURCHASER" },
                    { "1aadd3ab-8a0c-4ebf-a548-093b6122bc4a", "f6c089ce-50a2-45be-b3c7-20544592e986", "StoreMan", "STOREMAN" },
                    { "4ff27e82-8f0f-4518-b630-0118aba8adae", "6b82a3f6-9453-402d-a13e-76e4f1708eb0", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "7a31f557-5021-4d98-8346-7da48003add6", "8da8049c-439b-4537-bf78-c6c76fc26b56", "FinanceManager", "FINANCEMANAGER" },
                    { "689938a8-2996-4d8c-afe8-284b04588db0", "2d8f6821-f3e9-45a0-b6a2-ae008721e7da", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }
    }
}
