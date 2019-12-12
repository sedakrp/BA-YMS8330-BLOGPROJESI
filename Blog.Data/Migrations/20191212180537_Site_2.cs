using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Data.Migrations
{
    public partial class Site_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 12, 12, 18, 5, 36, 304, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 12, 12, 18, 5, 36, 306, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 12, 12, 18, 5, 36, 306, DateTimeKind.Utc));

            migrationBuilder.InsertData(
                table: "Sites",
                columns: new[] { "Id", "Copyright", "Desctription", "Slogan", "Title" },
                values: new object[] { 1, "içerik hırsızlığına hayıııırrrr...", ".......", "Sayfama Hoşgeldiniz...", "Seda Körpe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 12, 12, 18, 5, 36, 306, DateTimeKind.Utc));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sites",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 12, 12, 18, 1, 17, 303, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 12, 12, 18, 1, 17, 304, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 12, 12, 18, 1, 17, 304, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 12, 12, 18, 1, 17, 305, DateTimeKind.Utc));
        }
    }
}
