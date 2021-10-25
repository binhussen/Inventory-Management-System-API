using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class budget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "BudgetCode",
                table: "RequestItems");

            migrationBuilder.AddColumn<Guid>(
                name: "BudgetBy",
                table: "RequestHeaders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "BudgetCode",
                table: "RequestHeaders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "BudgetDate",
                table: "RequestHeaders",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "RequestHeaders",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "BudgetBy",
                table: "RequestHeaders");

            migrationBuilder.DropColumn(
                name: "BudgetCode",
                table: "RequestHeaders");

            migrationBuilder.DropColumn(
                name: "BudgetDate",
                table: "RequestHeaders");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "RequestHeaders");

            migrationBuilder.AddColumn<string>(
                name: "BudgetCode",
                table: "RequestItems",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
