using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GamePortals.Models;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Game> Games { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<GameUser> GameUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);


        string borkoId = "c40bf468-5336-4f66-afc7-33e3ef06df38";
        string vladoId = "05ce0276-a737-4cfb-be2c-12f5f627c4e7";

        builder.Entity<GameUser>().HasKey(gu => new { gu.UserId, gu.GameId });

        builder.Entity<Genre>().HasData(
            new Genre { Id = 1, Name = "Екшън" },
            new Genre { Id = 2, Name = "RPG" },
            new Genre { Id = 3, Name = "Приключенски" },
            new Genre { Id = 4, Name = "Хорор" },
            new Genre { Id = 5, Name = "Стратегия" },
            new Genre { Id = 6, Name = "Симулатор" },
            new Genre { Id = 7, Name = "Състезателни" },
            new Genre { Id = 8, Name = "Спортни" },
            new Genre { Id = 9, Name = "Шутър" },
            new Genre { Id = 10, Name = "Платформър" }
        );


        builder.Entity<Game>().HasData(
            new Game { Id = 1, Title = "Elden Ring", Price = 59.99m, GenreId = 2, Description = "Впуснете се в епично приключение из Междуземията, за да разкриете тайните на Елденския пръстен.", ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202110/2000/aajm8s7kr9ovSbaS7vS88Lp5.png" },
            new Game { Id = 2, Title = "The Witcher 3", Price = 29.99m, GenreId = 2, Description = "Гералт от Ривия търси детето от пророчеството в свят, разкъсван от война и чудовища.", ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/kh4MUIu7DAt9zUzA99Ej848W.png" },
            new Game { Id = 3, Title = "Red Dead Redemption 2", Price = 39.99m, GenreId = 3, Description = "Епична история за бандити и оцеляване в суровата сърцевина на Америка в края на Дивия запад.", ImageUrl = "https://image.api.playstation.com/cdn/UP1004/CUSA03041_00/Hpl5SuOEGREvMraG9D9v6IP8whNxBba9.png" },
            new Game { Id = 4, Title = "God of War Ragnarök", Price = 69.99m, GenreId = 1, Description = "Кратос и Атреус се впускат в митично пътешествие през деветте свята на скандинавската митология.", ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202207/1210/4E9iU7iH9uT163u6R6p4v87C.png" },
            new Game { Id = 5, Title = "Ghost of Tsushima", Price = 49.99m, GenreId = 3, Description = "Самураят Джин Сакай трябва да изостави традициите, за да защити остров Цушима.", ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202106/2322/7YmZ96m7Xz9Bv8pW25v15B1Y.png" },
            new Game { Id = 6, Title = "Cyberpunk 2077", Price = 44.99m, GenreId = 1, Description = "Найт Сити е мегаполис, обсебен от власт и модификации на тялото.", ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202111/3013/it0mYv9pS90mYv9pS9.png" },
            new Game { Id = 7, Title = "Starfield", Price = 69.99m, GenreId = 2, Description = "Първата нова вселена на Bethesda от 25 години насам. Изследвайте космоса.", ImageUrl = "https://gaming-cdn.com/images/products/2675/orig/starfield-pc-xbox-series-x-s-game-steam-cover.jpg" },
            new Game { Id = 8, Title = "Hogwarts Legacy", Price = 59.99m, GenreId = 2, Description = "Станете ученик в Хогуортс през 1800-те години. Научете магии и се борете срещу тъмни сили.", ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202208/0921/ca6v98ghuU5UAs5Zt46SjZ85.png" },
            new Game { Id = 9, Title = "Baldur's Gate 3", Price = 59.99m, GenreId = 2, Description = "Парти базирано RPG в света на Dungeons & Dragons.", ImageUrl = "https://gaming-cdn.com/images/products/6591/orig/baldur-s-gate-3-pc-mac-game-steam-cover.jpg" },
            new Game { Id = 10, Title = "Horizon Forbidden West", Price = 49.99m, GenreId = 3, Description = "Присъединете се към Алой в забранените територии на едно постапокалиптично бъдеще.", ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202109/2821/S4Yp7CD7Yp777J9I56Z7mP7O.png" },
            new Game { Id = 11, Title = "Call of Duty: MW III", Price = 69.99m, GenreId = 9, Description = "Интензивна военна кампания и емблематичен мултиплейър.", ImageUrl = "https://gaming-cdn.com/images/products/14605/orig/call-of-duty-modern-warfare-iii-pc-game-battle-net-cover.jpg" },
            new Game { Id = 12, Title = "Battlefield 2042", Price = 19.99m, GenreId = 9, Description = "Мащабни битки със 128 играчи в едно несигурно бъдеще.", ImageUrl = "https://gaming-cdn.com/images/products/8821/orig/battlefield-2042-pc-game-origin-cover.jpg" },
            new Game { Id = 13, Title = "Doom Eternal", Price = 14.99m, GenreId = 9, Description = "Армиите на ада са превзели Земята. Станете Slayer и ги спрете.", ImageUrl = "https://gaming-cdn.com/images/products/2665/orig/doom-eternal-pc-game-steam-cover.jpg" },
            new Game { Id = 14, Title = "EA Sports FC 24", Price = 59.99m, GenreId = 8, Description = "Най-великият футболен симулатор с лицензирани първенства и играчи.", ImageUrl = "https://cdn1.epicgames.com/offer/f5397f28734e45c7921356f966144e59/EGS_EASPORTSFC24StandardEdition_EACanada_S2_1200x1600-986f3333333333333333333333333333" },
            new Game { Id = 15, Title = "NBA 2K24", Price = 49.99m, GenreId = 8, Description = "Доминирайте на баскетболното игрище и изживейте историята на Коби Брайънт.", ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202306/2219/336341776ce321f8a85e6837947702f7.png" },
            new Game { Id = 16, Title = "Forza Horizon 5", Price = 59.99m, GenreId = 7, Description = "Огромен отворен свят в Мексико, стотици коли и невероятни състезания.", ImageUrl = "https://gaming-cdn.com/images/products/8701/orig/forza-horizon-5-pc-xbox-one-xbox-series-x-s-game-microsoft-store-cover.jpg" },
            new Game { Id = 17, Title = "Need for Speed Unbound", Price = 24.99m, GenreId = 7, Description = "Улични състезания с уникален визуален стил и преследвания с полицията.", ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202209/2717/Z96m7Xz9Bv8pW25v15B1Y.png" },
            new Game { Id = 18, Title = "Civilization VI", Price = 19.99m, GenreId = 5, Description = "Изградете империя, която да издържи изпитанието на времето.", ImageUrl = "https://cdn1.epicgames.com/b9340e45700d43fb8e0840134e1c6674/offer/EGS_SidMeiersCivilizationVI_FiraxisGames_S2-1200x1600-2f34731448b30f8c8574188506148679.jpg" },
            new Game { Id = 19, Title = "The Sims 4", Price = 0.00m, GenreId = 6, Description = "Създавайте уникални персонажи и контролирайте техния живот.", ImageUrl = "https://cdn1.epicgames.com/salesEvent/salesEvent/EGS_TheSims4_ElectronicArts_S2_1200x1600-336341776ce321f8a85e6837947702f7" },
            new Game { Id = 20, Title = "Flight Simulator", Price = 69.99m, GenreId = 6, Description = "Полетете над целия свят с невероятна прецизност и реализъм.", ImageUrl = "https://gaming-cdn.com/images/products/7285/orig/microsoft-flight-simulator-pc-game-xbox-play-anywhere-cover.jpg" },
            new Game { Id = 21, Title = "Resident Evil 4", Price = 59.99m, GenreId = 4, Description = "Леон Кенеди се впуска в зловеща мисия в Испания.", ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202210/0712/V0T9zUzA99Ej848W.png" },
            new Game { Id = 22, Title = "Dead Space", Price = 34.99m, GenreId = 4, Description = "Айзък Кларк се бори за оцеляване срещу некроморфи.", ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202209/2717/it0mYv9pS9.png" },
            new Game { Id = 23, Title = "Minecraft", Price = 24.99m, GenreId = 10, Description = "Стройте, копайте и оцелявайте в безкраен свят от блокове.", ImageUrl = "https://image.api.playstation.com/vulcan/img/cfn/11307u649X1pU.png" },
            new Game { Id = 24, Title = "Super Mario Odyssey", Price = 49.99m, GenreId = 10, Description = "Присъединете се към Марио в мащабно 3D приключение из целия свят.", ImageUrl = "https://assets.nintendo.com/image/upload/ar_16:9,c_lpad,w_1240/b_white/f_auto/q_auto/ncom/software/switch/70010000000141/desc/c6585140d348e3a47941ca6c243da6a7" },
            new Game { Id = 25, Title = "It Takes Two", Price = 15.99m, GenreId = 10, Description = "Уникално кооперативно приключение за двама играчи.", ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202012/0814/9yX9Z9m7Xz9Bv8pW25v15B1Y.png" }
        );

        builder.Entity<Review>().HasData(
            new Review { Id = 1, GameId = 1, UserId = borkoId, Rating = 5, Content = "Най-добрата игра на FromSoftware. Предизвикателна и красива!" },
            new Review { Id = 2, GameId = 1, UserId = vladoId, Rating = 4, Content = "Трудна ми е, но светът е невероятен за изследване." },
            new Review { Id = 3, GameId = 2, UserId = borkoId, Rating = 5, Content = "Гералт е легенда. Историята е ненадмината." },
            new Review { Id = 4, GameId = 2, UserId = vladoId, Rating = 5, Content = "Любимото ми RPG. Вече я превъртам за трети път." },
            new Review { Id = 5, GameId = 3, UserId = borkoId, Rating = 5, Content = "Артур Морган е най-великият персонаж. Графиката е топ." },
            new Review { Id = 6, GameId = 3, UserId = vladoId, Rating = 4, Content = "Малко е бавна, но реализмът е на друго ниво." },
            new Review { Id = 7, GameId = 4, UserId = borkoId, Rating = 5, Content = "Кратос и Атреус са невероятен екип. Бойната система е брутална." },
            new Review { Id = 8, GameId = 4, UserId = vladoId, Rating = 5, Content = "Епичен завършек на скандинавската сага!" },
            new Review { Id = 9, GameId = 5, UserId = borkoId, Rating = 5, Content = "Най-красивата игра за самураи. Пътят на призрака е велик." },
            new Review { Id = 10, GameId = 5, UserId = vladoId, Rating = 4, Content = "Страхотна атмосфера и много добър арт стил." },
            new Review { Id = 11, GameId = 6, UserId = borkoId, Rating = 4, Content = "След ъпдейтите играта стана това, което обещаваха." },
            new Review { Id = 12, GameId = 6, UserId = vladoId, Rating = 5, Content = "Найт Сити ме погълна. Невероятна киберпънк атмосфера." },
            new Review { Id = 13, GameId = 7, UserId = borkoId, Rating = 4, Content = "Огромна игра. Космосът е интересен, макар и малко празен." },
            new Review { Id = 14, GameId = 7, UserId = vladoId, Rating = 3, Content = "Типична игра на Bethesda. Има своите минуси." },
            new Review { Id = 15, GameId = 8, UserId = borkoId, Rating = 5, Content = "Сбъдната мечта за всеки фен на Хари Потър." },
            new Review { Id = 16, GameId = 8, UserId = vladoId, Rating = 4, Content = "Хогуортс е направен перфектно. Магията е навсякъде." },
            new Review { Id = 17, GameId = 9, UserId = borkoId, Rating = 5, Content = "Шедьовър. Свободата на избор тук е нереална." },
            new Review { Id = 18, GameId = 9, UserId = vladoId, Rating = 5, Content = "Най-доброто D&D преживяване пред екрана." },
            new Review { Id = 19, GameId = 10, UserId = borkoId, Rating = 4, Content = "Машините са още по-големи и опасни. Алой е супер." },
            new Review { Id = 20, GameId = 10, UserId = vladoId, Rating = 5, Content = "Графично това е най-доброто на пазара в момента." },
            new Review { Id = 21, GameId = 11, UserId = borkoId, Rating = 3, Content = "Мултиплейърът е същият, кампанията е кратка." },
            new Review { Id = 22, GameId = 11, UserId = vladoId, Rating = 4, Content = "Става за постреляне вечер с приятели." },
            new Review { Id = 23, GameId = 12, UserId = borkoId, Rating = 2, Content = "Пълно разочарование. Къде са класовете?" },
            new Review { Id = 24, GameId = 12, UserId = vladoId, Rating = 3, Content = "Има проблясъци, но Battlefield 4 беше по-добра." },
            new Review { Id = 25, GameId = 13, UserId = borkoId, Rating = 5, Content = "Rip and Tear! Най-бързият и добър шутър." },
            new Review { Id = 26, GameId = 13, UserId = vladoId, Rating = 4, Content = "Доста е напрегната, но музиката те държи в ритъм." },
            new Review { Id = 27, GameId = 14, UserId = borkoId, Rating = 3, Content = "Ново име, същата игра. Микротранзакциите дразнят." },
            new Review { Id = 28, GameId = 14, UserId = vladoId, Rating = 4, Content = "За футболни фенове е задължителна всяка година." },
            new Review { Id = 29, GameId = 15, UserId = borkoId, Rating = 4, Content = "Геймплеят е добър, но MyCareer е доста скъп режим." },
            new Review { Id = 30, GameId = 15, UserId = vladoId, Rating = 3, Content = "Анимациите са супер, но всичко е за пари." },
            new Review { Id = 31, GameId = 16, UserId = borkoId, Rating = 5, Content = "Най-добрата рейсинг игра с отворен свят." },
            new Review { Id = 32, GameId = 16, UserId = vladoId, Rating = 5, Content = "Мексико е красиво, а колите са стотици." },
            new Review { Id = 33, GameId = 17, UserId = borkoId, Rating = 4, Content = "Арт стилът е свеж. Гонките с полицията са на ниво." },
            new Review { Id = 34, GameId = 17, UserId = vladoId, Rating = 3, Content = "Добър опит за промяна, но историята е слаба." },
            new Review { Id = 35, GameId = 18, UserId = borkoId, Rating = 5, Content = "Още само един ход... и стана 4 сутринта." },
            new Review { Id = 36, GameId = 18, UserId = vladoId, Rating = 5, Content = "Най-добрата стратегия. Можеш да я играеш вечно." },
            new Review { Id = 37, GameId = 19, UserId = borkoId, Rating = 3, Content = "Става за убиване на време, но трябват много DLC-та." },
            new Review { Id = 38, GameId = 19, UserId = vladoId, Rating = 5, Content = "Обожавам да строя къщи и да развивам семейства." },
            new Review { Id = 39, GameId = 20, UserId = borkoId, Rating = 5, Content = "Технологично чудо. Да летиш над града си е уникално." },
            new Review { Id = 40, GameId = 20, UserId = vladoId, Rating = 4, Content = "Изисква сериозна машина, но изглежда реално." },
            new Review { Id = 41, GameId = 21, UserId = borkoId, Rating = 5, Content = "Перфектен римейк. Леон е по-голям пич от всякога." },
            new Review { Id = 42, GameId = 21, UserId = vladoId, Rating = 5, Content = "Класически хорър, направен по модерен начин." },
            new Review { Id = 43, GameId = 22, UserId = borkoId, Rating = 5, Content = "Звуковият дизайн ще ви побърка. Много страшно!" },
            new Review { Id = 44, GameId = 22, UserId = vladoId, Rating = 4, Content = "Космосът никога не е бил толкова зловещ." },
            new Review { Id = 45, GameId = 23, UserId = borkoId, Rating = 4, Content = "Класика за креативност. Безкрайни възможности." },
            new Review { Id = 46, GameId = 23, UserId = vladoId, Rating = 5, Content = "Играта, която никога не омръзва. Лего на стероиди." },
            new Review { Id = 47, GameId = 24, UserId = borkoId, Rating = 5, Content = "Чисто забавление. Дизайнът на нивата е гениален." },
            new Review { Id = 48, GameId = 24, UserId = vladoId, Rating = 5, Content = "Най-добрата Марио игра досега." },
            new Review { Id = 49, GameId = 25, UserId = borkoId, Rating = 5, Content = "Най-доброто ко-оп изживяване. Задължително се играе с двама." },
            new Review { Id = 50, GameId = 25, UserId = vladoId, Rating = 5, Content = "Механиките се сменят постоянно. Невероятна история." }
        );
    }
}