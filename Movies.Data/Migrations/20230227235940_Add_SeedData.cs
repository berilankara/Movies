using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movies.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 59, 40, 89, DateTimeKind.Utc).AddTicks(8189),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 13, 42, 0, 444, DateTimeKind.Utc).AddTicks(360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Genres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 59, 40, 89, DateTimeKind.Utc).AddTicks(6879),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 13, 42, 0, 443, DateTimeKind.Utc).AddTicks(8226));

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Crime", null },
                    { 2, "Drama", null },
                    { 3, "Biography", null },
                    { 4, "History", null },
                    { 5, "Comedy", null },
                    { 6, "Romance", null },
                    { 7, "Adventure", null },
                    { 8, "Western", null },
                    { 9, "Action", null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "ReleaseDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.", "The Godfather", new DateTime(1973, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", "Schindler's List", new DateTime(1994, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "The jury in a New York City murder trial is frustrated by a single member whose skeptical caution forces them to more carefully consider the evidence before jumping to a hasty verdict.", "12 Angry Men", new DateTime(1960, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "When an open-minded Jewish waiter and his son become victims of the Holocaust, he uses a perfect mixture of will, humor, and imagination to protect his son from the dangers around their camp.", "La vita è bella", new DateTime(1999, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.", "Il buono, il brutto, il cattivo", new DateTime(1969, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.", "The Shawshank Redemption", new DateTime(1995, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "A struggling salesman takes custody of his son as he's poised to begin a life-changing professional career.", "The Pursuit of Happyness", new DateTime(2007, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "Farmers from a village exploited by bandits hire a veteran samurai for protection, who gathers six other samurai to join him.", "Shichinin no samurai", new DateTime(1954, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, "After he becomes a quadriplegic from a paragliding accident, an aristocrat hires a young man from the projects to be his caregiver.", "Intouchables", new DateTime(2012, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, "The emotive journey of a former schoolteacher who writes letters for illiterate people, and a young boy whose mother has just died, as they search for the father he never knew.", "Central do Brasil", new DateTime(1999, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, "The drug-induced utopias of four Coney Island people are shattered when their addictions run deep.", "Requiem for a Dream", new DateTime(2000, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "MovieGenres",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 2, 4 },
                    { 5, 4 },
                    { 6, 4 },
                    { 7, 5 },
                    { 8, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 3, 7 },
                    { 2, 8 },
                    { 9, 8 },
                    { 2, 9 },
                    { 3, 9 },
                    { 5, 9 },
                    { 2, 10 },
                    { 2, 11 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 13, 42, 0, 444, DateTimeKind.Utc).AddTicks(360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 59, 40, 89, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Genres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 13, 42, 0, 443, DateTimeKind.Utc).AddTicks(8226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 59, 40, 89, DateTimeKind.Utc).AddTicks(6879));
        }
    }
}
