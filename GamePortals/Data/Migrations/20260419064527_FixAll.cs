using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GamePortals.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "GameId", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, "Най-добрата игра на FromSoftware. Предизвикателна и красива!", 1, 5, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 2, "Трудна ми е, но светът е невероятен за изследване.", 1, 4, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 3, "Гералт е легенда. Историята е ненадмината.", 2, 5, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 4, "Любимото ми RPG. Вече я превъртам за трети път.", 2, 5, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 5, "Артур Морган е най-великият персонаж. Графиката е топ.", 3, 5, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 6, "Малко е бавна, но реализмът е на друго ниво.", 3, 4, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 7, "Кратос и Атреус са невероятен екип. Бойната система е брутална.", 4, 5, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 8, "Епичен завършек на скандинавската сага!", 4, 5, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 9, "Най-красивата игра за самураи. Пътят на призрака е велик.", 5, 5, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 10, "Страхотна атмосфера и много добър арт стил.", 5, 4, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 11, "След ъпдейтите играта стана това, което обещаваха.", 6, 4, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 12, "Найт Сити ме погълна. Невероятна киберпънк атмосфера.", 6, 5, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 13, "Огромна игра. Космосът е интересен, макар и малко празен.", 7, 4, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 14, "Типична игра на Bethesda. Има своите минуси.", 7, 3, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 15, "Сбъдната мечта за всеки фен на Хари Потър.", 8, 5, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 16, "Хогуортс е направен перфектно. Магията е навсякъде.", 8, 4, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 17, "Шедьовър. Свободата на избор тук е нереална.", 9, 5, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 18, "Най-доброто D&D преживяване пред екрана.", 9, 5, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 19, "Машините са още по-големи и опасни. Алой е супер.", 10, 4, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 20, "Графично това е най-доброто на пазара в момента.", 10, 5, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 21, "Мултиплейърът е същият, кампанията е кратка.", 11, 3, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 22, "Става за постреляне вечер с приятели.", 11, 4, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 23, "Пълно разочарование. Къде са класовете?", 12, 2, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 24, "Има проблясъци, но Battlefield 4 беше по-добра.", 12, 3, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 25, "Rip and Tear! Най-бързият и добър шутър.", 13, 5, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 26, "Доста е напрегната, но музиката те държи в ритъм.", 13, 4, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 27, "Ново име, същата игра. Микротранзакциите дразнят.", 14, 3, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 28, "За футболни фенове е задължителна всяка година.", 14, 4, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 29, "Геймплеят е добър, но MyCareer е доста скъп режим.", 15, 4, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 30, "Анимациите са супер, но всичко е за пари.", 15, 3, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 31, "Най-добрата рейсинг игра с отворен свят.", 16, 5, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 32, "Мексико е красиво, а колите са стотици.", 16, 5, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 33, "Арт стилът е свеж. Гонките с полицията са на ниво.", 17, 4, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 34, "Добър опит за промяна, но историята е слаба.", 17, 3, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 35, "Още само един ход... и стана 4 сутринта.", 18, 5, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 36, "Най-добрата стратегия. Можеш да я играеш вечно.", 18, 5, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 37, "Става за убиване на време, но трябват много DLC-та.", 19, 3, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 38, "Обожавам да строя къщи и да развивам семейства.", 19, 5, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 39, "Технологично чудо. Да летиш над града си е уникално.", 20, 5, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 40, "Изисква сериозна машина, но изглежда реално.", 20, 4, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 41, "Перфектен римейк. Леон е по-голям пич от всякога.", 21, 5, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 42, "Класически хорър, направен по модерен начин.", 21, 5, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 43, "Звуковият дизайн ще ви побърка. Много страшно!", 22, 5, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 44, "Космосът никога не е бил толкова зловещ.", 22, 4, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 45, "Класика за креативност. Безкрайни възможности.", 23, 4, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 46, "Играта, която никога не омръзва. Лего на стероиди.", 23, 5, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 47, "Чисто забавление. Дизайнът на нивата е гениален.", 24, 5, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 48, "Най-добрата Марио игра досега.", 24, 5, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" },
                    { 49, "Най-доброто ко-оп изживяване. Задължително се играе с двама.", 25, 5, "c40bf468-5336-4f66-afc7-33e3ef06df38" },
                    { 50, "Механиките се сменят постоянно. Невероятна история.", 25, 5, "05ce0276-a737-4cfb-be2c-12f5f627c4e7" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
