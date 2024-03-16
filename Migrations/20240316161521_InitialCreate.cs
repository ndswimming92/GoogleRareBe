using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoogleRareBe.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Author_id = table.Column<int>(type: "integer", nullable: false),
                    Post_id = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Created_on = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostReactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rareUserId = table.Column<int>(type: "integer", nullable: false),
                    postId = table.Column<int>(type: "integer", nullable: false),
                    reactionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostReactions", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Reactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    label = table.Column<string>(type: "text", nullable: false),
                    image_Url = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Follower_id = table.Column<int>(type: "integer", nullable: false),
                    Author_id = table.Column<int>(type: "integer", nullable: false),
                    Created_on = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Ended_on = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: false),
                    PublicImageUrl = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    IsStaff = table.Column<bool>(type: "boolean", nullable: false),
                    Uid = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTypeChangeRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Action = table.Column<string>(type: "text", nullable: false),
                    AdminOneId = table.Column<int>(type: "integer", nullable: false),
                    AdminTwoId = table.Column<int>(type: "integer", nullable: false),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypeChangeRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RareUserId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Approved = table.Column<bool>(type: "boolean", nullable: false),
                    TagId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Label" },
                values: new object[,]
                {
                    { 1, "Sports" },
                    { 2, "Food" },
                    { 3, "Travel" },
                    { 4, "Animals" },
                    { 5, "News" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Author_id", "Content", "Created_on", "Post_id" },
                values: new object[,]
                {
                    { 1, 1, "Howdley Doodley", new DateTime(2024, 3, 16, 11, 15, 20, 889, DateTimeKind.Local).AddTicks(2511), 1 },
                    { 2, 2, "This is a comment that will be changed soon", new DateTime(2024, 3, 16, 11, 15, 20, 891, DateTimeKind.Local).AddTicks(3805), 2 },
                    { 3, 3, "Death metal is really good :)", new DateTime(2024, 3, 16, 11, 15, 20, 891, DateTimeKind.Local).AddTicks(3857), 3 }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "Id", "PostId", "TagId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Approved", "CategoryId", "Content", "ImageUrl", "PublicationDate", "RareUserId", "TagId", "Title" },
                values: new object[,]
                {
                    { 1, true, 1, "that was amazing! I cant belive he hit that kick.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQQaqJLGCMY6GnWpqz1a9uh0FO8yuFsJ5XTJg&usqp=CAU", new DateTime(2024, 3, 16, 11, 15, 20, 892, DateTimeKind.Local).AddTicks(934), 1, null, "oh wow, what a field goal!" },
                    { 2, false, 2, "I went to a restaurant recently and I got this, it was amazing!", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcStxYUb82L3RX5dgbZ_sPnFJGziaA3O3nqMQw&usqp=CAU", new DateTime(2024, 3, 16, 11, 15, 20, 892, DateTimeKind.Local).AddTicks(2216), 2, null, "this food was absolutly amazing!" },
                    { 3, true, 3, "Went to New Zealand recently, so amazing!", "https://uploads.alaska.org/suppliers/activities/K/K2/_690x460_crop_center-center_65_none/full-8431-alaska-rusts-k2-talkeetna.jpg", new DateTime(2024, 3, 16, 11, 15, 20, 892, DateTimeKind.Local).AddTicks(2233), 3, null, "Beautiful mountains" },
                    { 4, true, 4, "we went down to the shelter and got myself a new cat, welcome Slinky!", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nationalgeographic.com%2Fanimals%2Fmammals%2Ffacts%2Fdomestic-cat&psig=AOvVaw1VGG2bBHXaIDXPM2sRgYSO&ust=1710688495265000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCLDFz5aK-YQDFQAAAAAdAAAAABAD", new DateTime(2024, 3, 16, 11, 15, 20, 892, DateTimeKind.Local).AddTicks(2236), 4, null, "I got a new Cat!" },
                    { 5, true, 5, "family comes together to help those in need, what a time for the youth to help out!", "https://i0.wp.com/bcc-newspack.s3.amazonaws.com/uploads/2021/06/060221-Good-News-Shelter-Rogers-Park-ColinBoyle-5-e1623936580193.jpg?fit=1500%2C998&ssl=1", new DateTime(2024, 3, 16, 11, 15, 20, 892, DateTimeKind.Local).AddTicks(2239), 5, null, "Local kids helped at the homeless shelter, neighborhood moral skyrockets!" }
                });

            migrationBuilder.InsertData(
                table: "Reactions",
                columns: new[] { "Id", "image_Url", "label" },
                values: new object[,]
                {
                    { 1, "https://ih1.redbubble.net/image.5328806804.9180/raf,360x360,075,t,fafafa:ca443f4786.jpg", "label1" },
                    { 2, "https://thumbs.dreamstime.com/b/yellow-emoji-icon-crying-emoji-sad-face-emoticon-chat-comment-reaction-emotes-social-media-concept-emotion-vector-eps-212589528.jpg", "label2" },
                    { 3, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.redbubble.com%2Fi%2Fgreeting-card%2Fangry-react-emoji-by-LORRAUN%2F39738117.5MT14&psig=AOvVaw1pJxNNCgUdaRQ_H1PaAKEK&ust=1710690790233000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCMCS64OS-YQDFQAAAAAdAAAAABAD", "label3" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Author_id", "Created_on", "Ended_on", "Follower_id" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 16, 11, 15, 20, 894, DateTimeKind.Local).AddTicks(8834), new DateTime(2024, 3, 16, 11, 15, 20, 894, DateTimeKind.Local).AddTicks(9207), 1 },
                    { 2, 2, new DateTime(2024, 3, 16, 11, 15, 20, 894, DateTimeKind.Local).AddTicks(9523), new DateTime(2024, 3, 16, 11, 15, 20, 894, DateTimeKind.Local).AddTicks(9533), 2 },
                    { 3, 3, new DateTime(2024, 3, 16, 11, 15, 20, 894, DateTimeKind.Local).AddTicks(9537), new DateTime(2024, 3, 16, 11, 15, 20, 894, DateTimeKind.Local).AddTicks(9539), 3 },
                    { 4, 4, new DateTime(2024, 3, 16, 11, 15, 20, 894, DateTimeKind.Local).AddTicks(9541), new DateTime(2024, 3, 16, 11, 15, 20, 894, DateTimeKind.Local).AddTicks(9543), 4 }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Label" },
                values: new object[,]
                {
                    { 1, "NewItem1" },
                    { 2, "NewItem2" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "Bio", "CreatedOn", "FirstName", "IsStaff", "LastName", "PublicImageUrl", "Uid", "email" },
                values: new object[,]
                {
                    { 1, true, "A Mystery Man", new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", true, "Doe", "https://images.saymedia-content.com/.image/t_share/MTgyODcwNDI1NTAyNDkyMDY3/the-mystery-man.jpg", "JD1234MM", "mman@googlerare.com" },
                    { 2, true, "A Mystery Woman", new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", false, "Doe", "https://th.bing.com/th/id/R.e2149e74aa05e6864c45bd9ec1ab773f?rik=fQx6Mc1U%2b6Hl1A&riu=http%3a%2f%2fwww.brookpacelascelles.com%2fproduct-images%2fFullsize%2f9d8ddd3d-3f11-420b-aba6-695eb86f7f9b-1.jpg&ehk=oYOiBFvK5j0fz3qyT1tbBHOvEdDkdEVu4HClA72AO4M%3d&risl=&pid=ImgRaw&r=0", "MJD1234E", "MsJDoe@googlerare.com" },
                    { 3, true, "Actor and Lover of Elanor", new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nick", false, "Cage", "https://epmgaa.media.clients.ellingtoncms.com/img/photos/2019/04/01/S107298446.JPG", "FGT1967GO", "goneis60sec@googlerate.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TagId",
                table: "Posts",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "PostReactions");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "Reactions");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTypeChangeRequests");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
