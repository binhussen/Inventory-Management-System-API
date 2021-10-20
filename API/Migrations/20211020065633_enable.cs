using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class enable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33c36851-0b83-452b-958e-aa7e3aa94b68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cd88934-a1fa-4ac3-baa7-21d220154057");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57f7ee13-8d24-4807-9708-929bfbcac5f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b8ca985-da25-45be-a0d8-0f044ea263b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b96826b3-93ce-4198-b2d1-7b17d800c383");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc0c9aa7-3722-4dda-989a-19de1e59558a");

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "239f7ea7-53e6-4415-beeb-33d98b59b731", "7d285888-622a-49c3-b405-54410dd151eb", "Administrator", "ADMINISTRATOR" },
                    { "a5537d12-1d55-43a3-a5ea-4926aa3f4b6f", "36d973d4-1d3f-4883-9972-1ab932e2365f", "Purchaser", "PURCHASER" },
                    { "76e93672-b323-40f1-a17e-ab135d6d6656", "99c145c5-a4b9-4183-94ad-bfc827c39796", "StoreMan", "STOREMAN" },
                    { "d05e087a-fdc9-4903-9196-ed56b41f567c", "0b02202c-2ac0-458e-b38b-43b2fb1ea051", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "c7f5c3ab-6bc1-409d-8a6c-c5f5a7ed5592", "8c1ab39f-5cad-48db-955e-3324b4a9d07e", "FinanceManager", "FINANCEMANAGER" },
                    { "7d27dd72-0b3f-48af-b03b-d469cf3ce851", "5a168349-d9d6-4e7f-ac9f-0640bfe41c42", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "239f7ea7-53e6-4415-beeb-33d98b59b731");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76e93672-b323-40f1-a17e-ab135d6d6656");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d27dd72-0b3f-48af-b03b-d469cf3ce851");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5537d12-1d55-43a3-a5ea-4926aa3f4b6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7f5c3ab-6bc1-409d-8a6c-c5f5a7ed5592");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d05e087a-fdc9-4903-9196-ed56b41f567c");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33c36851-0b83-452b-958e-aa7e3aa94b68", "588c39c8-f06f-443c-83e5-d1cfb4db74cc", "Administrator", "ADMINISTRATOR" },
                    { "b96826b3-93ce-4198-b2d1-7b17d800c383", "f50fee06-d89e-4c5e-9906-a00e9bb2993e", "Purchaser", "PURCHASER" },
                    { "5b8ca985-da25-45be-a0d8-0f044ea263b0", "330ccc4e-c3d9-4d6f-84cb-a8e375cc13fb", "StoreMan", "STOREMAN" },
                    { "fc0c9aa7-3722-4dda-989a-19de1e59558a", "b84904be-460b-4196-a34e-a793c40b9df5", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "3cd88934-a1fa-4ac3-baa7-21d220154057", "a9f34084-2275-412b-8767-79c4e64daf25", "FinanceManager", "FINANCEMANAGER" },
                    { "57f7ee13-8d24-4807-9708-929bfbcac5f0", "dd704767-b53b-4559-bc81-db2554c94c25", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }
    }
}
