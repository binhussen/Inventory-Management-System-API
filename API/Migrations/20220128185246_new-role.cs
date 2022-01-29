using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class newrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d436ef4-eb26-47e2-acf9-7756f5d91d82");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37e66356-f7a6-469b-a3cd-4ec10bfb4075");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38d7e7aa-0b5a-4925-bdac-e7573a9ce74c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dbdc624-690d-458f-8583-dd3bfd74283d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85020a3d-7615-44de-9817-615a7939152b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0a657f5-9bed-4ad1-b979-b1a605c38243");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80313c3a-e55e-465f-9679-993a0d7f3544");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cd901062-904b-4e55-91a8-8005d78df973", "4431e964-82cf-43c0-80be-88e4e23a5a6c", "Administrator", "ADMINISTRATOR" },
                    { "b8494199-be85-4442-991b-214086aebcee", "8e10c93b-1169-4835-a035-de096ec609c0", "Purchaser", "PURCHASER" },
                    { "48d86725-cb3b-462f-942b-f40e8a8e521a", "116d9054-160b-4ab6-8927-c4ca0738f1fa", "StoreMan", "STOREMAN" },
                    { "887020ef-e33a-4856-a7e1-961b114d77f3", "0cd1b8ea-f063-4381-8497-9590dbcafa74", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "0564d587-6433-42ef-8d7d-5f5335f72699", "3626cea4-488d-4432-a4ae-ac0cf711f853", "FinanceManager", "FINANCEMANAGER" },
                    { "fe506078-964b-4363-aa4c-7565d8a59c12", "80006d07-8c0a-498c-a8b5-cebf56e600e3", "ProcurementManager", "PROCUREMENTMANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "67f9ddeb-60ed-496d-875b-40fcd4fd902d", 0, "1b644a8f - 70ce - 4bdd - 91af - b6a774fe8f15", "admin@gmail.com", false, "Administrator", true, "Administrator", true, null, "ADMIN@GMAIL.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEI / XRI6ZeV4JdZWqf9cO9 + cy + qchgfTNS8pudCb60OwF4Z77U2r7oU0bIT3KSJ0wPA ==", "+251-944-69-69-69", false, "AX4V5FQG663Z44N46VMUANNWRVJRMFHW", false, "Administrator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0564d587-6433-42ef-8d7d-5f5335f72699");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48d86725-cb3b-462f-942b-f40e8a8e521a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "887020ef-e33a-4856-a7e1-961b114d77f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8494199-be85-4442-991b-214086aebcee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd901062-904b-4e55-91a8-8005d78df973");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe506078-964b-4363-aa4c-7565d8a59c12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67f9ddeb-60ed-496d-875b-40fcd4fd902d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37e66356-f7a6-469b-a3cd-4ec10bfb4075", "bad7aecd-3687-4cb6-8ff5-022e52b0a298", "Administrator", "ADMINISTRATOR" },
                    { "2d436ef4-eb26-47e2-acf9-7756f5d91d82", "083f31ee-2bd8-48ea-9c8f-4ee05fe203c6", "Purchaser", "PURCHASER" },
                    { "85020a3d-7615-44de-9817-615a7939152b", "f23c5c51-3199-4761-bbf0-8047c792c2ae", "StoreMan", "STOREMAN" },
                    { "7dbdc624-690d-458f-8583-dd3bfd74283d", "0fee25f4-82b2-4fd5-bacc-d42c30c2710f", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "e0a657f5-9bed-4ad1-b979-b1a605c38243", "4b787a5e-9dd9-4687-9527-92ca05bc6b2d", "FinanceManager", "FINANCEMANAGER" },
                    { "38d7e7aa-0b5a-4925-bdac-e7573a9ce74c", "25b5ec59-8be6-4477-935c-e2946c5737af", "ProcurementManager", "PROCUREMENTMANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "80313c3a-e55e-465f-9679-993a0d7f3544", 0, "1b644a8f - 70ce - 4bdd - 91af - b6a774fe8f15", "admin@gmail.com", false, "Administrator", true, "Administrator", true, null, "ADMIN@GMAIL.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEI / XRI6ZeV4JdZWqf9cO9 + cy + qchgfTNS8pudCb60OwF4Z77U2r7oU0bIT3KSJ0wPA ==", "+251-944-69-69-69", false, "AX4V5FQG663Z44N46VMUANNWRVJRMFHW", false, "Administrator" });
        }
    }
}
