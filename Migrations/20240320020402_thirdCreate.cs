using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoogleRareBe.Migrations
{
    /// <inheritdoc />
    public partial class thirdCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropIndex(
                name: "IX_Posts_TagId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Posts");

            migrationBuilder.CreateTable(
                name: "PostTag",
                columns: table => new
                {
                    PostsId = table.Column<int>(type: "integer", nullable: false),
                    TagsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTag", x => new { x.PostsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_PostTag_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTag_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 3, 19, 21, 4, 2, 60, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 3, 19, 21, 4, 2, 63, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 3, 19, 21, 4, 2, 63, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 19, 21, 4, 2, 63, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 19, 21, 4, 2, 63, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 19, 21, 4, 2, 63, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 19, 21, 4, 2, 63, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublicationDate",
                value: new DateTime(2024, 3, 19, 21, 4, 2, 63, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Ended_on" },
                values: new object[] { new DateTime(2024, 3, 19, 21, 4, 2, 64, DateTimeKind.Local).AddTicks(6355), new DateTime(2024, 3, 19, 21, 4, 2, 64, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Ended_on" },
                values: new object[] { new DateTime(2024, 3, 19, 21, 4, 2, 64, DateTimeKind.Local).AddTicks(6765), new DateTime(2024, 3, 19, 21, 4, 2, 64, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Ended_on" },
                values: new object[] { new DateTime(2024, 3, 19, 21, 4, 2, 64, DateTimeKind.Local).AddTicks(6772), new DateTime(2024, 3, 19, 21, 4, 2, 64, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Ended_on" },
                values: new object[] { new DateTime(2024, 3, 19, 21, 4, 2, 64, DateTimeKind.Local).AddTicks(6777), new DateTime(2024, 3, 19, 21, 4, 2, 64, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_TagsId",
                table: "PostTag",
                column: "TagsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTag");

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Posts",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostId = table.Column<int>(type: "integer", nullable: false),
                    TagId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTags", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "Id", "PostId", "TagId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PublicationDate", "TagId" },
                values: new object[] { new DateTime(2024, 3, 16, 11, 21, 44, 955, DateTimeKind.Local).AddTicks(5046), null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PublicationDate", "TagId" },
                values: new object[] { new DateTime(2024, 3, 16, 11, 21, 44, 955, DateTimeKind.Local).AddTicks(5880), null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PublicationDate", "TagId" },
                values: new object[] { new DateTime(2024, 3, 16, 11, 21, 44, 955, DateTimeKind.Local).AddTicks(5889), null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PublicationDate", "TagId" },
                values: new object[] { new DateTime(2024, 3, 16, 11, 21, 44, 955, DateTimeKind.Local).AddTicks(5891), null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PublicationDate", "TagId" },
                values: new object[] { new DateTime(2024, 3, 16, 11, 21, 44, 955, DateTimeKind.Local).AddTicks(5893), null });

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

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TagId",
                table: "Posts",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id");
        }
    }
}
