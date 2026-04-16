using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GamePortals.Data.Migrations
{
    /// <inheritdoc />
    public partial class FinalSeedConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Екшън" },
                    { 2, "RPG" },
                    { 3, "Приключенски" },
                    { 4, "Хорор" },
                    { 5, "Стратегия" },
                    { 6, "Симулатор" },
                    { 7, "Състезателни" },
                    { 8, "Спортни" },
                    { 9, "Шутър" },
                    { 10, "Платформър" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "GenreId", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Впуснете се в епично приключение из Междуземията, за да разкриете тайните на Елденския пръстен.", 2, "https://image.api.playstation.com/vulcan/ap/rnd/202110/2000/aajm8s7kr9ovSbaS7vS88Lp5.png", 59.99m, "Elden Ring" },
                    { 2, "Гералт от Ривия търси детето от пророчеството в свят, разкъсван от война и чудовища.", 2, "https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/kh4MUIu7DAt9zUzA99Ej848W.png", 29.99m, "The Witcher 3" },
                    { 3, "Епична история за бандити и оцеляване в суровата сърцевина на Америка в края на Дивия запад.", 3, "https://image.api.playstation.com/cdn/UP1004/CUSA03041_00/Hpl5SuOEGREvMraG9D9v6IP8whNxBba9.png", 39.99m, "Red Dead Redemption 2" },
                    { 4, "Кратос и Атреус се впускат в митично пътешествие през деветте свята на скандинавската митология.", 1, "https://image.api.playstation.com/vulcan/ap/rnd/202207/1210/4E9iU7iH9uT163u6R6p4v87C.png", 69.99m, "God of War Ragnarök" },
                    { 5, "Самураят Джин Сакай трябва да изостави традициите, за да защити остров Цушима.", 3, "https://image.api.playstation.com/vulcan/ap/rnd/202106/2322/7YmZ96m7Xz9Bv8pW25v15B1Y.png", 49.99m, "Ghost of Tsushima" },
                    { 6, "Найт Сити е мегаполис, обсебен от власт и модификации на тялото.", 1, "https://image.api.playstation.com/vulcan/ap/rnd/202111/3013/it0mYv9pS90mYv9pS9.png", 44.99m, "Cyberpunk 2077" },
                    { 7, "Първата нова вселена на Bethesda от 25 години насам. Изследвайте космоса.", 2, "https://gaming-cdn.com/images/products/2675/orig/starfield-pc-xbox-series-x-s-game-steam-cover.jpg", 69.99m, "Starfield" },
                    { 8, "Станете ученик в Хогуортс през 1800-те години. Научете магии и се борете срещу тъмни сили.", 2, "https://image.api.playstation.com/vulcan/ap/rnd/202208/0921/ca6v98ghuU5UAs5Zt46SjZ85.png", 59.99m, "Hogwarts Legacy" },
                    { 9, "Парти базирано RPG в света на Dungeons & Dragons.", 2, "https://gaming-cdn.com/images/products/6591/orig/baldur-s-gate-3-pc-mac-game-steam-cover.jpg", 59.99m, "Baldur's Gate 3" },
                    { 10, "Присъединете се към Алой в забранените територии на едно постапокалиптично бъдеще.", 3, "https://image.api.playstation.com/vulcan/ap/rnd/202109/2821/S4Yp7CD7Yp777J9I56Z7mP7O.png", 49.99m, "Horizon Forbidden West" },
                    { 11, "Интензивна военна кампания и емблематичен мултиплейър.", 9, "https://gaming-cdn.com/images/products/14605/orig/call-of-duty-modern-warfare-iii-pc-game-battle-net-cover.jpg", 69.99m, "Call of Duty: MW III" },
                    { 12, "Мащабни битки със 128 играчи в едно несигурно бъдеще.", 9, "https://gaming-cdn.com/images/products/8821/orig/battlefield-2042-pc-game-origin-cover.jpg", 19.99m, "Battlefield 2042" },
                    { 13, "Армиите на ада са превзели Земята. Станете Slayer и ги спрете.", 9, "https://gaming-cdn.com/images/products/2665/orig/doom-eternal-pc-game-steam-cover.jpg", 14.99m, "Doom Eternal" },
                    { 14, "Най-великият футболен симулатор с лицензирани първенства и играчи.", 8, "https://cdn1.epicgames.com/offer/f5397f28734e45c7921356f966144e59/EGS_EASPORTSFC24StandardEdition_EACanada_S2_1200x1600-986f3333333333333333333333333333", 59.99m, "EA Sports FC 24" },
                    { 15, "Доминирайте на баскетболното игрище и изживейте историята на Коби Брайънт.", 8, "https://image.api.playstation.com/vulcan/ap/rnd/202306/2219/336341776ce321f8a85e6837947702f7.png", 49.99m, "NBA 2K24" },
                    { 16, "Огромен отворен свят в Мексико, стотици коли и невероятни състезания.", 7, "https://gaming-cdn.com/images/products/8701/orig/forza-horizon-5-pc-xbox-one-xbox-series-x-s-game-microsoft-store-cover.jpg", 59.99m, "Forza Horizon 5" },
                    { 17, "Улични състезания с уникален визуален стил и преследвания с полицията.", 7, "https://image.api.playstation.com/vulcan/ap/rnd/202209/2717/Z96m7Xz9Bv8pW25v15B1Y.png", 24.99m, "Need for Speed Unbound" },
                    { 18, "Изградете империя, която да издържи изпитанието на времето.", 5, "https://cdn1.epicgames.com/b9340e45700d43fb8e0840134e1c6674/offer/EGS_SidMeiersCivilizationVI_FiraxisGames_S2-1200x1600-2f34731448b30f8c8574188506148679.jpg", 19.99m, "Civilization VI" },
                    { 19, "Създавайте уникални персонажи и контролирайте техния живот.", 6, "https://cdn1.epicgames.com/salesEvent/salesEvent/EGS_TheSims4_ElectronicArts_S2_1200x1600-336341776ce321f8a85e6837947702f7", 0.00m, "The Sims 4" },
                    { 20, "Полетете над целия свят с невероятна прецизност и реализъм.", 6, "https://gaming-cdn.com/images/products/7285/orig/microsoft-flight-simulator-pc-game-xbox-play-anywhere-cover.jpg", 69.99m, "Flight Simulator" },
                    { 21, "Леон Кенеди се впуска в зловеща мисия в Испания.", 4, "https://image.api.playstation.com/vulcan/ap/rnd/202210/0712/V0T9zUzA99Ej848W.png", 59.99m, "Resident Evil 4" },
                    { 22, "Айзък Кларк се бори за оцеляване срещу некроморфи.", 4, "https://image.api.playstation.com/vulcan/ap/rnd/202209/2717/it0mYv9pS9.png", 34.99m, "Dead Space" },
                    { 23, "Стройте, копайте и оцелявайте в безкраен свят от блокове.", 10, "https://image.api.playstation.com/vulcan/img/cfn/11307u649X1pU.png", 24.99m, "Minecraft" },
                    { 24, "Присъединете се към Марио в мащабно 3D приключение из целия свят.", 10, "https://assets.nintendo.com/image/upload/ar_16:9,c_lpad,w_1240/b_white/f_auto/q_auto/ncom/software/switch/70010000000141/desc/c6585140d348e3a47941ca6c243da6a7", 49.99m, "Super Mario Odyssey" },
                    { 25, "Уникално кооперативно приключение за двама играчи.", 10, "https://image.api.playstation.com/vulcan/ap/rnd/202012/0814/9yX9Z9m7Xz9Bv8pW25v15B1Y.png", 15.99m, "It Takes Two" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25);

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
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
