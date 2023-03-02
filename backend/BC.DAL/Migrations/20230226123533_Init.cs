using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BC.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Cover = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Reviewer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Content", "Cover", "Genre", "Title" },
                values: new object[,]
                {
                    { 1, "Alfonzo Herzog", "laboriosam", "https://picsum.photos/640/480/?image=61", "Electronic", "We need to parse the online USB transmitter!" },
                    { 2, "Laura Leannon", "nobis", "https://picsum.photos/640/480/?image=749", "Reggae", "The IB program is down, hack the neural program so we can hack the IB program!" },
                    { 3, "Green Zboncak", "Nemo occaecati sed ut explicabo quia dignissimos consequatur cumque.\nPlaceat iusto ut ullam est aliquid omnis et nihil.\nUnde assumenda mollitia blanditiis rerum eos autem sit rerum quibusdam.", "https://picsum.photos/640/480/?image=597", "Metal", "Use the neural ADP bandwidth, then you can parse the neural bandwidth!" },
                    { 4, "Dedric Turcotte", "Debitis est eos.", "https://picsum.photos/640/480/?image=852", "Pop", "You can't input the matrix without parsing the open-source AGP matrix!" },
                    { 5, "Julius Hackett", "Nostrum consequatur dolores eveniet fugit a quia dolores rem ut.", "https://picsum.photos/640/480/?image=78", "Hip Hop", "You can't compress the capacitor without transmitting the redundant ADP capacitor!" },
                    { 6, "Reanna Kohler", "autem", "https://picsum.photos/640/480/?image=551", "Soul", "The XSS circuit is down, back up the multi-byte circuit so we can back up the XSS circuit!" },
                    { 7, "Lukas Gulgowski", "Eius vitae ducimus omnis.", "https://picsum.photos/640/480/?image=551", "World", "We need to synthesize the online FTP protocol!" },
                    { 8, "Kameron Boyer", "nostrum", "https://picsum.photos/640/480/?image=622", "Rock", "You can't navigate the matrix without copying the multi-byte COM matrix!" },
                    { 9, "Delaney Medhurst", "Quasi aliquid aperiam temporibus doloribus inventore et. Modi non est temporibus cum officiis sed eos. Natus ut non soluta quia fugit illo dolores. Officiis est exercitationem natus illo omnis eum qui accusantium similique.", "https://picsum.photos/640/480/?image=3", "Hip Hop", "We need to program the mobile SMS firewall!" },
                    { 10, "Felton Stanton", "Cum aut nihil occaecati voluptatem. Libero in voluptatem. Voluptas quia eos qui aliquam rerum exercitationem excepturi. Numquam facilis laborum qui id. Laudantium architecto earum doloribus.", "https://picsum.photos/640/480/?image=654", "Electronic", "Use the redundant JBOD system, then you can index the redundant system!" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "BookId", "Score" },
                values: new object[,]
                {
                    { 1, 6, (byte)2 },
                    { 2, 8, (byte)1 },
                    { 3, 6, (byte)3 },
                    { 4, 4, (byte)1 },
                    { 5, 9, (byte)1 },
                    { 6, 5, (byte)1 },
                    { 7, 5, (byte)1 },
                    { 8, 4, (byte)2 },
                    { 9, 5, (byte)5 },
                    { 10, 3, (byte)2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "Message", "Reviewer" },
                values: new object[,]
                {
                    { 1, 5, "aut", "Roxanne93" },
                    { 2, 4, "distinctio", "Luz_Kemmer" },
                    { 3, 7, "Ea doloribus quidem dignissimos aut incidunt dicta doloribus.\nFugiat distinctio consectetur quidem ipsa illum eos neque est ut.\nVoluptatem ut itaque.\nSapiente fuga nihil repellat nobis voluptas mollitia iusto.\nFuga perferendis quis vel fugit enim placeat ad eligendi architecto.", "Gage.Feeney" },
                    { 4, 4, "autem", "Jazmin.OKeefe" },
                    { 5, 5, "Explicabo quam cum reprehenderit nulla nobis quia.", "Aubrey8" },
                    { 6, 9, "nemo", "Trever_Stiedemann" },
                    { 7, 5, "Rerum qui molestiae omnis laboriosam totam id. Dolores illo sint maxime temporibus eos ratione. Necessitatibus nihil eligendi esse assumenda qui non expedita. Iste similique rerum quo non et aspernatur nemo. Ullam non ad quaerat dolor sed id.", "Bill91" },
                    { 8, 5, "Omnis commodi delectus. Ea totam deleniti mollitia voluptatum ut et fuga quos. Ut rem quia quos. Veritatis vitae et quis temporibus. Est totam sint. Dolorem sit doloribus excepturi architecto reiciendis quasi numquam est ex.", "Vidal31" },
                    { 9, 2, "Hic aut deserunt.\nExpedita dolores optio iste omnis corrupti aperiam maiores excepturi.\nEius quia quia cupiditate.\nSint vel nostrum qui animi molestiae porro molestiae.", "Shayna34" },
                    { 10, 6, "repudiandae", "Kavon.Fisher79" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_Title_Author",
                table: "Books",
                columns: new[] { "Title", "Author" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_BookId",
                table: "Ratings",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
