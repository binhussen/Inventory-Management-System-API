using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class check : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "6810128b-0195-4b33-b81d-58907ea1397a", "c9d154e6-93e9-44ce-a953-ad2cf4f20a74", "Administrator", "ADMINISTRATOR" },
                    { "63353ac0-7576-4fbd-b94a-a081df0d5db2", "181abf0c-1059-4e3d-b59c-d732062a760a", "Purchaser", "PURCHASER" },
                    { "fc4af488-2a52-40c5-8e4c-5fdfc322871f", "7db8012d-b3c1-446a-a65c-a1b3ff05ae59", "StoreMan", "STOREMAN" },
                    { "91fa6737-b1df-4e65-834a-73853a66d8e9", "6b914df2-bac1-4acc-96bc-f63d11b73ff7", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "4dbb0579-260e-4d27-818c-36957c0de517", "a922fff4-afd3-47a8-b718-0a4ed1e94b2d", "FinanceManager", "FINANCEMANAGER" },
                    { "642dd6f3-6684-4b42-978e-40f939e05996", "13deea2a-67a2-49ea-a5da-5647073f5bd3", "ProcurementManager", "PROCUREMENTMANAGER" },
                    { "f0c94fe8-7533-402e-a083-98ee8ae524ff", "97e1866d-df1e-4a98-9c4c-dfdecc5b2756", "ReportCreater", "REPORTCREATER" },
                    { "df3aba99-d68a-4d6f-9bdb-d4f8398f58b4", "e5f4c840-6f3e-45c1-8387-f5ce8f511135", "ReportViwer", "REPORTVIWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2642ebc9-6eed-4fc4-9e7b-826505dd1ea3", 0, "1b644a8f - 70ce - 4bdd - 91af - b6a774fe8f15", "admin@gmail.com", false, "Administrator", true, "Administrator", true, null, "ADMIN@GMAIL.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEI / XRI6ZeV4JdZWqf9cO9 + cy + qchgfTNS8pudCb60OwF4Z77U2r7oU0bIT3KSJ0wPA ==", "+251-944-69-69-69", false, "AX4V5FQG663Z44N46VMUANNWRVJRMFHW", false, "Administrator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dbb0579-260e-4d27-818c-36957c0de517");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63353ac0-7576-4fbd-b94a-a081df0d5db2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "642dd6f3-6684-4b42-978e-40f939e05996");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6810128b-0195-4b33-b81d-58907ea1397a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91fa6737-b1df-4e65-834a-73853a66d8e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df3aba99-d68a-4d6f-9bdb-d4f8398f58b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0c94fe8-7533-402e-a083-98ee8ae524ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc4af488-2a52-40c5-8e4c-5fdfc322871f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2642ebc9-6eed-4fc4-9e7b-826505dd1ea3");

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
    }
}
