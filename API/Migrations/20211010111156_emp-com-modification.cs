using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class empcommodification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "UserId",
                table: "AspNetRoles");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNo",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discribtion",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fax",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNo",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ecadcc98-8b69-414f-bd56-3a2c93466298", "24286d0f-3a56-490e-9663-8143c126797b", "Administrator", "ADMINISTRATOR" },
                    { "627609be-ff47-466f-8d11-5ac2db3b0cce", "fca84f3a-8cff-4529-a796-51687982c47a", "Purchaser", "PURCHASER" },
                    { "510ce613-36b1-4386-a86d-def20a70f27d", "872171c2-f853-4a57-bf16-d637737424d3", "StoreMan", "STOREMAN" },
                    { "2b4f3f14-ad72-4928-bb8f-3e3cfc0e9a96", "4abd149b-197f-4e93-a622-e9accbe5332f", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "440f8117-ec44-404e-8b6e-43eb12a07874", "4cd2c647-e9df-4303-b529-e20d7f995cd9", "FinanceManager", "FINANCEMANAGER" },
                    { "deca47a4-09eb-4e93-a63d-df9bf54f102c", "f55926f9-ea06-469f-b493-0d985a37f5cd", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b4f3f14-ad72-4928-bb8f-3e3cfc0e9a96");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "440f8117-ec44-404e-8b6e-43eb12a07874");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "510ce613-36b1-4386-a86d-def20a70f27d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "627609be-ff47-466f-8d11-5ac2db3b0cce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "deca47a4-09eb-4e93-a63d-df9bf54f102c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecadcc98-8b69-414f-bd56-3a2c93466298");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PhoneNo",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Discribtion",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Fax",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "PhoneNo",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Companies");

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
    }
}
