using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleRareBe.Migrations
{
    /// <inheritdoc />
    public partial class secondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 3, 16, 11, 21, 44, 953, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 3, 16, 11, 21, 44, 955, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 3, 16, 11, 21, 44, 955, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 16, 11, 21, 44, 955, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 16, 11, 21, 44, 955, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 16, 11, 21, 44, 955, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 16, 11, 21, 44, 955, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 16, 11, 21, 44, 955, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Ended_on" },
                values: new object[] { new DateTime(2024, 3, 16, 11, 21, 44, 956, DateTimeKind.Local).AddTicks(5187), new DateTime(2024, 3, 16, 11, 21, 44, 956, DateTimeKind.Local).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Ended_on" },
                values: new object[] { new DateTime(2024, 3, 16, 11, 21, 44, 956, DateTimeKind.Local).AddTicks(5642), new DateTime(2024, 3, 16, 11, 21, 44, 956, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Ended_on" },
                values: new object[] { new DateTime(2024, 3, 16, 11, 21, 44, 956, DateTimeKind.Local).AddTicks(5650), new DateTime(2024, 3, 16, 11, 21, 44, 956, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Ended_on" },
                values: new object[] { new DateTime(2024, 3, 16, 11, 21, 44, 956, DateTimeKind.Local).AddTicks(5652), new DateTime(2024, 3, 16, 11, 21, 44, 956, DateTimeKind.Local).AddTicks(5654) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 3, 16, 11, 15, 20, 889, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 3, 16, 11, 15, 20, 891, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 3, 16, 11, 15, 20, 891, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 16, 11, 15, 20, 892, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 16, 11, 15, 20, 892, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 16, 11, 15, 20, 892, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 16, 11, 15, 20, 892, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 16, 11, 15, 20, 892, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Ended_on" },
                values: new object[] { new DateTime(2024, 3, 16, 11, 15, 20, 894, DateTimeKind.Local).AddTicks(8834), new DateTime(2024, 3, 16, 11, 15, 20, 894, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Ended_on" },
                values: new object[] { new DateTime(2024, 3, 16, 11, 15, 20, 894, DateTimeKind.Local).AddTicks(9523), new DateTime(2024, 3, 16, 11, 15, 20, 894, DateTimeKind.Local).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Ended_on" },
                values: new object[] { new DateTime(2024, 3, 16, 11, 15, 20, 894, DateTimeKind.Local).AddTicks(9537), new DateTime(2024, 3, 16, 11, 15, 20, 894, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Ended_on" },
                values: new object[] { new DateTime(2024, 3, 16, 11, 15, 20, 894, DateTimeKind.Local).AddTicks(9541), new DateTime(2024, 3, 16, 11, 15, 20, 894, DateTimeKind.Local).AddTicks(9543) });
        }
    }
}
