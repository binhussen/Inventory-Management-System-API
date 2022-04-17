using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class generalize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "424d64f1-271b-4c1e-9b87-843b0d318606", "3cbec4d0-0315-401c-b7ea-aa4a795d24ad", "Administrator", "ADMINISTRATOR" },
                    { "06e743ba-9043-4bd7-83f5-ab61a2304c48", "5adefb5c-bf2e-40aa-87b2-02812bf39af1", "Purchaser", "PURCHASER" },
                    { "9a6ea8d8-3a21-4a70-bb38-2f90589aa8ac", "29445259-a456-4b63-9088-4a87dd3b1ce0", "StoreMan", "STOREMAN" },
                    { "ce6bace9-9a68-4249-b6c6-f7d75de4392b", "03e482f7-36d8-4bde-b22b-6a8585da62bb", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "1b7f55bd-27b5-4a7e-b394-f1b59f360f32", "8599946a-6200-457c-858a-a13b3d6bca06", "FinanceManager", "FINANCEMANAGER" },
                    { "6d5ba3cd-ab9d-4784-ba61-73200eeb5899", "7c6e0795-03f2-4710-bac6-836c929b0cc6", "ProcurementManager", "PROCUREMENTMANAGER" },
                    { "d4a4ab5a-0918-46f5-ae59-d34b7fa55926", "18f51c4e-59ab-4ba2-9d2c-e4f8ad263329", "ReportCreater", "REPORTCREATER" },
                    { "664609b2-e6d7-4833-b2ba-368d30f54439", "d04b1f95-fea2-40db-89ce-3e662312bb8e", "ReportViwer", "REPORTVIWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fa39cdc7-634e-4ef4-9de6-3bd8a0f52085", 0, "1b644a8f - 70ce - 4bdd - 91af - b6a774fe8f15", "admin@gmail.com", false, "Administrator", true, "Administrator", true, null, "ADMIN@GMAIL.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEI / XRI6ZeV4JdZWqf9cO9 + cy + qchgfTNS8pudCb60OwF4Z77U2r7oU0bIT3KSJ0wPA ==", "+251-944-69-69-69", false, "AX4V5FQG663Z44N46VMUANNWRVJRMFHW", false, "Administrator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06e743ba-9043-4bd7-83f5-ab61a2304c48");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b7f55bd-27b5-4a7e-b394-f1b59f360f32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "424d64f1-271b-4c1e-9b87-843b0d318606");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "664609b2-e6d7-4833-b2ba-368d30f54439");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d5ba3cd-ab9d-4784-ba61-73200eeb5899");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a6ea8d8-3a21-4a70-bb38-2f90589aa8ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce6bace9-9a68-4249-b6c6-f7d75de4392b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4a4ab5a-0918-46f5-ae59-d34b7fa55926");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa39cdc7-634e-4ef4-9de6-3bd8a0f52085");

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
    }
}
