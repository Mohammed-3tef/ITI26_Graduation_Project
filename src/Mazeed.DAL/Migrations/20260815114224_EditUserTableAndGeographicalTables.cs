using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mazeed.DAL.Migrations
{
    /// <inheritdoc />
    public partial class EditUserTableAndGeographicalTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Theme",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Birthdate",
                table: "Users",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "ProfilePicture",
                table: "Users",
                newName: "ImageUrl");

            migrationBuilder.AddColumn<long>(
                name: "CityId",
                table: "Users",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Governorates",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governorates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Governorates_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GovernorateId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalTable: "Governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "ArabicName", "EnglishName" },
                values: new object[,]
                {
                    { 1L, "القاهرة الكبرى", "Great Cairo" },
                    { 2L, "الاسكندرية", "Alexandria" },
                    { 3L, "الدلتا", "Al-Delta" },
                    { 4L, "القناة", "Al-Canal" },
                    { 5L, "شمال الصعيد", "North of Al-Saieed" },
                    { 6L, "وسط الصعيد", "Middle of Al-Saieed" },
                    { 7L, "جنوب الصعيد", "South of Al-Saieed" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "User", "USER" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CityId", "CreatedAt", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed" },
                values: new object[] { null, new DateTime(2026, 8, 15, 11, 42, 23, 533, DateTimeKind.Utc).AddTicks(6638), "AQAAAAIAAYagAAAAEN+/6rxBr5lZ4p6ftZGJUxtae5Y11kvahvInEtDNWflstJrzGcv4NNdRheqJoo6ehg==", "01234567890", true });

            migrationBuilder.InsertData(
                table: "Governorates",
                columns: new[] { "Id", "ArabicName", "EnglishName", "ProvinceId" },
                values: new object[,]
                {
                    { 1L, "القاهرة", "Cairo", 1L },
                    { 2L, "الجيزة", "Giza", 1L },
                    { 3L, "الأسكندرية", "Alexandria", 2L },
                    { 4L, "الدقهلية", "Dakahlia", 3L },
                    { 5L, "البحر الأحمر", "Red Sea", 6L },
                    { 6L, "البحيرة", "Beheira", 2L },
                    { 7L, "الفيوم", "Fayoum", 5L },
                    { 8L, "الغربية", "Gharbiya", 3L },
                    { 9L, "الإسماعلية", "Ismailia", 4L },
                    { 10L, "المنوفية", "Menofia", 3L },
                    { 11L, "المنيا", "Minya", 5L },
                    { 12L, "القليوبية", "Qaliubiya", 1L },
                    { 13L, "الوادي الجديد", "New Valley", 6L },
                    { 14L, "السويس", "Suez", 4L },
                    { 15L, "شمال سيناء", "North Sinai", 4L },
                    { 16L, "جنوب سيناء", "South Sinai", 4L },
                    { 17L, "بني سويف", "Beni Suef", 5L },
                    { 18L, "بورسعيد", "Port Said", 6L },
                    { 19L, "دمياط", "Damietta", 3L },
                    { 20L, "الشرقية", "Sharkia", 4L },
                    { 21L, "جنوب سيناء", "South Sinai", 4L },
                    { 22L, "كفر الشيخ", "Kafr Al Sheikh", 3L },
                    { 23L, "مطروح", "Matrouh", 2L },
                    { 24L, "الأقصر", "Luxor", 7L },
                    { 25L, "قنا", "Qena", 7L },
                    { 26L, "شمال سيناء", "North Sinai", 4L },
                    { 27L, "سوهاج", "Sohag", 7L }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "ArabicName", "EnglishName", "GovernorateId" },
                values: new object[,]
                {
                    { 1L, "15 مايو", "15 May", 1L },
                    { 2L, "الازبكية", "Al Azbakeyah", 1L },
                    { 3L, "البساتين", "Al Basatin", 1L },
                    { 4L, "التبين", "Tebin", 1L },
                    { 5L, "الخليفة", "El-Khalifa", 1L },
                    { 6L, "الدراسة", "El darrasa", 1L },
                    { 7L, "الدرب الاحمر", "Aldarb Alahmar", 1L },
                    { 8L, "الزاوية الحمراء", "Zawya al-Hamra", 1L },
                    { 9L, "الزيتون", "El-Zaytoun", 1L },
                    { 10L, "الساحل", "Sahel", 1L },
                    { 11L, "السلام", "El Salam", 1L },
                    { 12L, "السيدة زينب", "Sayeda Zeinab", 1L },
                    { 13L, "الشرابية", "El Sharabeya", 1L },
                    { 14L, "مدينة الشروق", "Shorouk", 1L },
                    { 15L, "الظاهر", "El Daher", 1L },
                    { 16L, "العتبة", "Ataba", 1L },
                    { 17L, "القاهرة الجديدة", "New Cairo", 1L },
                    { 18L, "المرج", "El Marg", 1L },
                    { 19L, "عزبة النخل", "Ezbet el Nakhl", 1L },
                    { 20L, "المطرية", "Matareya", 1L },
                    { 21L, "المعادى", "Maadi", 1L },
                    { 22L, "المعصرة", "Maasara", 1L },
                    { 23L, "المقطم", "Mokattam", 1L },
                    { 24L, "المنيل", "Manyal", 1L },
                    { 25L, "الموسكى", "Mosky", 1L },
                    { 26L, "النزهة", "Nozha", 1L },
                    { 27L, "الوايلى", "Waily", 1L },
                    { 28L, "باب الشعرية", "Bab al-Shereia", 1L },
                    { 29L, "بولاق", "Bolaq", 1L },
                    { 30L, "جاردن سيتى", "Garden City", 1L },
                    { 31L, "حدائق القبة", "Hadayek El-Kobba", 1L },
                    { 32L, "حلوان", "Helwan", 1L },
                    { 33L, "دار السلام", "Dar Al Salam", 1L },
                    { 34L, "شبرا", "Shubra", 1L },
                    { 35L, "طره", "Tura", 1L },
                    { 36L, "عابدين", "Abdeen", 1L },
                    { 37L, "عباسية", "Abaseya", 1L },
                    { 38L, "عين شمس", "Ain Shams", 1L },
                    { 39L, "مدينة نصر", "Nasr City", 1L },
                    { 40L, "مصر الجديدة", "New Heliopolis", 1L },
                    { 41L, "مصر القديمة", "Masr Al Qadima", 1L },
                    { 42L, "منشية ناصر", "Mansheya Nasir", 1L },
                    { 43L, "مدينة بدر", "Badr City", 1L },
                    { 44L, "مدينة العبور", "Obour City", 1L },
                    { 45L, "وسط البلد", "Cairo Downtown", 1L },
                    { 46L, "الزمالك", "Zamalek", 1L },
                    { 47L, "قصر النيل", "Kasr El Nile", 1L },
                    { 48L, "الرحاب", "Rehab", 1L },
                    { 49L, "القطامية", "Katameya", 1L },
                    { 50L, "مدينتي", "Madinty", 1L },
                    { 51L, "روض الفرج", "Rod Alfarag", 1L },
                    { 52L, "شيراتون", "Sheraton", 1L },
                    { 53L, "الجمالية", "El-Gamaleya", 1L },
                    { 54L, "العاشر من رمضان", "10th of Ramadan City", 1L },
                    { 55L, "الحلمية", "Helmeyat Alzaytoun", 1L },
                    { 56L, "النزهة الجديدة", "New Nozha", 1L },
                    { 57L, "العاصمة الإدارية", "Capital New", 1L },
                    { 58L, "الجيزة", "Giza", 2L },
                    { 59L, "السادس من أكتوبر", "Sixth of October", 2L },
                    { 60L, "الشيخ زايد", "Cheikh Zayed", 2L },
                    { 61L, "الحوامدية", "Hawamdiyah", 2L },
                    { 62L, "البدرشين", "Al Badrasheen", 2L },
                    { 63L, "الصف", "Saf", 2L },
                    { 64L, "أطفيح", "Atfih", 2L },
                    { 65L, "العياط", "Al Ayat", 2L },
                    { 66L, "الباويطي", "Al-Bawaiti", 2L },
                    { 67L, "منشأة القناطر", "ManshiyetAl Qanater", 2L },
                    { 68L, "أوسيم", "Oaseem", 2L },
                    { 69L, "كرداسة", "Kerdasa", 2L },
                    { 70L, "أبو النمرس", "Abu Nomros", 2L },
                    { 71L, "كفر غطاطي", "Kafr Ghati", 2L },
                    { 72L, "منشأة البكاري", "Manshiyet Al Bakari", 2L },
                    { 73L, "الدقى", "Dokki", 2L },
                    { 74L, "العجوزة", "Agouza", 2L },
                    { 75L, "الهرم", "Haram", 2L },
                    { 76L, "الوراق", "Warraq", 2L },
                    { 77L, "امبابة", "Imbaba", 2L },
                    { 78L, "بولاق الدكرور", "Boulaq Dakrour", 2L },
                    { 79L, "الواحات البحرية", "Al Wahat Al Baharia", 2L },
                    { 80L, "العمرانية", "Omraneya", 2L },
                    { 81L, "المنيب", "Moneeb", 2L },
                    { 82L, "بين السرايات", "Bin Alsarayat", 2L },
                    { 83L, "الكيت كات", "Kit Kat", 2L },
                    { 84L, "المهندسين", "Mohandessin", 2L },
                    { 85L, "فيصل", "Faisal", 2L },
                    { 86L, "أبو رواش", "Abu Rawash", 2L },
                    { 87L, "حدائق الأهرام", "Hadayek Alahram", 2L },
                    { 88L, "الحرانية", "Haraneya", 2L },
                    { 89L, "حدائق اكتوبر", "Hadayek October", 2L },
                    { 90L, "صفط اللبن", "Saft Allaban", 2L },
                    { 91L, "القرية الذكية", "Smart Village", 2L },
                    { 92L, "ارض اللواء", "Ard Ellwaa", 2L },
                    { 93L, "ابو قير", "Abu Qir", 3L },
                    { 94L, "الابراهيمية", "Al Ibrahimeyah", 3L },
                    { 95L, "الأزاريطة", "Azarita", 3L },
                    { 96L, "الانفوشى", "Anfoushi", 3L },
                    { 97L, "الدخيلة", "Dekheila", 3L },
                    { 98L, "السيوف", "El Soyof", 3L },
                    { 99L, "العامرية", "Ameria", 3L },
                    { 100L, "اللبان", "El Labban", 3L },
                    { 101L, "المفروزة", "Al Mafrouza", 3L },
                    { 102L, "المنتزه", "El Montaza", 3L },
                    { 103L, "المنشية", "Mansheya", 3L },
                    { 104L, "الناصرية", "Naseria", 3L },
                    { 105L, "امبروزو", "Ambrozo", 3L },
                    { 106L, "باب شرق", "Bab Sharq", 3L },
                    { 107L, "برج العرب", "Bourj Alarab", 3L },
                    { 108L, "ستانلى", "Stanley", 3L },
                    { 109L, "سموحة", "Smouha", 3L },
                    { 110L, "سيدى بشر", "Sidi Bishr", 3L },
                    { 111L, "شدس", "Shads", 3L },
                    { 112L, "غيط العنب", "Gheet Alenab", 3L },
                    { 113L, "فلمينج", "Fleming", 3L },
                    { 114L, "فيكتوريا", "Victoria", 3L },
                    { 115L, "كامب شيزار", "Camp Shizar", 3L },
                    { 116L, "كرموز", "Karmooz", 3L },
                    { 117L, "محطة الرمل", "Mahta Alraml", 3L },
                    { 118L, "مينا البصل", "Mina El-Basal", 3L },
                    { 119L, "العافرة", "Asafra", 3L },
                    { 120L, "العجمي", "Agamy", 3L },
                    { 121L, "بكوس", "Bakos", 3L },
                    { 122L, "بولكلي", "Boulkly", 3L },
                    { 123L, "كليوباترا", "Cleopatra", 3L },
                    { 124L, "جليم", "Glim", 3L },
                    { 125L, "المعمورة", "Al Mamurah", 3L },
                    { 126L, "المندرة", "Al Mandara", 3L },
                    { 127L, "محرم بك", "Moharam Bek", 3L },
                    { 128L, "الشاطبي", "Elshatby", 3L },
                    { 129L, "سيدي جابر", "Sidi Gaber", 3L },
                    { 130L, "الساحل الشمالي", "North Coast/sahel", 3L },
                    { 131L, "الحضرة", "Alhadra", 3L },
                    { 132L, "العطارين", "Alattarin", 3L },
                    { 133L, "سيدي كرير", "Sidi Kerir", 3L },
                    { 134L, "الجمرك", "Elgomrok", 3L },
                    { 135L, "المكس", "Al Max", 3L },
                    { 136L, "مارينا", "Marina", 3L },
                    { 137L, "المنصورة", "Mansoura", 4L },
                    { 138L, "طلخا", "Talkha", 4L },
                    { 139L, "ميت غمر", "Mitt Ghamr", 4L },
                    { 140L, "دكرنس", "Dekernes", 4L },
                    { 141L, "أجا", "Aga", 4L },
                    { 142L, "منية النصر", "Menia El Nasr", 4L },
                    { 143L, "السنبلاوين", "Sinbillawin", 4L },
                    { 144L, "الكردي", "El Kurdi", 4L },
                    { 145L, "بني عبيد", "Bani Ubaid", 4L },
                    { 146L, "المنزلة", "Al Manzala", 4L },
                    { 147L, "تمي الأمديد", "tami al'amdid", 4L },
                    { 148L, "الجمالية", "aljamalia", 4L },
                    { 149L, "شربين", "Sherbin", 4L },
                    { 150L, "المطرية", "Mataria", 4L },
                    { 151L, "بلقاس", "Belqas", 4L },
                    { 152L, "ميت سلسيل", "Meet Salsil", 4L },
                    { 153L, "جمصة", "Gamasa", 4L },
                    { 154L, "محلة دمنة", "Mahalat Damana", 4L },
                    { 155L, "نبروه", "Nabroh", 4L },
                    { 156L, "الغردقة", "Hurghada", 5L },
                    { 157L, "رأس غارب", "Ras Ghareb", 5L },
                    { 158L, "سفاجا", "Safaga", 5L },
                    { 159L, "القصير", "El Qusiar", 5L },
                    { 160L, "مرسى علم", "Marsa Alam", 5L },
                    { 161L, "الشلاتين", "Shalatin", 5L },
                    { 162L, "حلايب", "Halaib", 5L },
                    { 163L, "الدهار", "Aldahar", 5L },
                    { 164L, "دمنهور", "Damanhour", 6L },
                    { 165L, "كفر الدوار", "Kafr El Dawar", 6L },
                    { 166L, "رشيد", "Rashid", 6L },
                    { 167L, "إدكو", "Edco", 6L },
                    { 168L, "أبو المطامير", "Abu al-Matamir", 6L },
                    { 169L, "أبو حمص", "Abu Homs", 6L },
                    { 170L, "الدلنجات", "Delengat", 6L },
                    { 171L, "المحمودية", "Mahmoudiyah", 6L },
                    { 172L, "الرحمانية", "Rahmaniyah", 6L },
                    { 173L, "إيتاي البارود", "Itai Baroud", 6L },
                    { 174L, "حوش عيسى", "Housh Eissa", 6L },
                    { 175L, "شبراخيت", "Shubrakhit", 6L },
                    { 176L, "كوم حمادة", "Kom Hamada", 6L },
                    { 177L, "بدر", "Badr", 6L },
                    { 178L, "وادي النطرون", "Wadi Natrun", 6L },
                    { 179L, "النوبارية الجديدة", "New Nubaria", 6L },
                    { 180L, "النوبارية", "Alnoubareya", 6L },
                    { 181L, "الفيوم", "Fayoum", 7L },
                    { 182L, "الفيوم الجديدة", "Fayoum El Gedida", 7L },
                    { 183L, "طامية", "Tamiya", 7L },
                    { 184L, "سنورس", "Snores", 7L },
                    { 185L, "إطسا", "Etsa", 7L },
                    { 186L, "إبشواي", "Epschway", 7L },
                    { 187L, "يوسف الصديق", "Yusuf El Sediaq", 7L },
                    { 188L, "الحادقة", "Hadqa", 7L },
                    { 189L, "اطسا", "Atsa", 7L },
                    { 190L, "الجامعة", "Algamaa", 7L },
                    { 191L, "السيالة", "Sayala", 7L },
                    { 192L, "طنطا", "Tanta", 8L },
                    { 193L, "المحلة الكبرى", "Al Mahalla Al Kobra", 8L },
                    { 194L, "كفر الزيات", "Kafr El Zayat", 8L },
                    { 195L, "زفتى", "Zefta", 8L },
                    { 196L, "السنطة", "El Santa", 8L },
                    { 197L, "قطور", "Qutour", 8L },
                    { 198L, "بسيون", "Basion", 8L },
                    { 199L, "سمنود", "Samannoud", 8L },
                    { 200L, "الإسماعيلية", "Ismailia", 9L },
                    { 201L, "فايد", "Fayed", 9L },
                    { 202L, "القنطرة شرق", "Qantara Sharq", 9L },
                    { 203L, "القنطرة غرب", "Qantara Gharb", 9L },
                    { 204L, "التل الكبير", "El Tal El Kabier", 9L },
                    { 205L, "أبو صوير", "Abu Sawir", 9L },
                    { 206L, "القصاصين الجديدة", "Kasasien El Gedida", 9L },
                    { 207L, "نفيشة", "Nefesha", 9L },
                    { 208L, "الشيخ زايد", "Sheikh Zayed", 9L },
                    { 209L, "شبين الكوم", "Shbeen El Koom", 10L },
                    { 210L, "مدينة السادات", "Sadat City", 10L },
                    { 211L, "منوف", "Menouf", 10L },
                    { 212L, "سرس الليان", "Sars El-Layan", 10L },
                    { 213L, "أشمون", "Ashmon", 10L },
                    { 214L, "الباجور", "Al Bagor", 10L },
                    { 215L, "قويسنا", "Quesna", 10L },
                    { 216L, "بركة السبع", "Berkat El Saba", 10L },
                    { 217L, "تلا", "Tala", 10L },
                    { 218L, "الشهداء", "Al Shohada", 10L },
                    { 219L, "المنيا", "Minya", 11L },
                    { 220L, "المنيا الجديدة", "Minya El Gedida", 11L },
                    { 221L, "العدوة", "El Adwa", 11L },
                    { 222L, "مغاغة", "Magagha", 11L },
                    { 223L, "بني مزار", "Bani Mazar", 11L },
                    { 224L, "مطاي", "Mattay", 11L },
                    { 225L, "سمالوط", "Samalut", 11L },
                    { 226L, "المدينة الفكرية", "Madinat El Fekria", 11L },
                    { 227L, "ملوي", "Meloy", 11L },
                    { 228L, "دير مواس", "Deir Mawas", 11L },
                    { 229L, "ابو قرقاص", "Abu Qurqas", 11L },
                    { 230L, "ارض سلطان", "Ard Sultan", 11L },
                    { 231L, "بنها", "Banha", 12L },
                    { 232L, "قليوب", "Qalyub", 12L },
                    { 233L, "شبرا الخيمة", "Shubra Al Khaimah", 12L },
                    { 234L, "القناطر الخيرية", "Al Qanater Charity", 12L },
                    { 235L, "الخانكة", "Khanka", 12L },
                    { 236L, "كفر شكر", "Kafr Shukr", 12L },
                    { 237L, "طوخ", "Tukh", 12L },
                    { 238L, "قها", "Qaha", 12L },
                    { 239L, "العبور", "Obour", 12L },
                    { 240L, "الخصوص", "Khosous", 12L },
                    { 241L, "شبين القناطر", "Shibin Al Qanater", 12L },
                    { 242L, "مسطرد", "Mostorod", 12L },
                    { 243L, "الخارجة", "El Kharga", 13L },
                    { 244L, "باريس", "Paris", 13L },
                    { 245L, "موط", "Mout", 13L },
                    { 246L, "الفرافرة", "Farafra", 13L },
                    { 247L, "بلاط", "Balat", 13L },
                    { 248L, "الداخلة", "Dakhla", 13L },
                    { 249L, "السويس", "Suez", 14L },
                    { 250L, "الجناين", "Alganayen", 14L },
                    { 251L, "عتاقة", "Ataqah", 14L },
                    { 252L, "العين السخنة", "Ain Sokhna", 14L },
                    { 253L, "فيصل", "Faysal", 14L },
                    { 254L, "أسوان", "Aswan", 15L },
                    { 255L, "أسوان الجديدة", "Aswan El Gedida", 15L },
                    { 256L, "دراو", "Drau", 15L },
                    { 257L, "كوم أمبو", "Kom Ombo", 15L },
                    { 258L, "نصر النوبة", "Nasr Al Nuba", 15L },
                    { 259L, "كلابشة", "Kalabsha", 15L },
                    { 260L, "إدفو", "Edfu", 15L },
                    { 261L, "الرديسية", "Al-Radisiyah", 15L },
                    { 262L, "البصيلية", "Al Basilia", 15L },
                    { 263L, "السباعية", "Al Sibaeia", 15L },
                    { 264L, "ابوسمبل السياحية", "Abo Simbl Al Siyahia", 15L },
                    { 265L, "مرسى علم", "Marsa Alam", 15L },
                    { 266L, "أسيوط", "Assiut", 16L },
                    { 267L, "أسيوط الجديدة", "Assiut El Gedida", 16L },
                    { 268L, "ديروط", "Dayrout", 16L },
                    { 269L, "منفلوط", "Manfalut", 16L },
                    { 270L, "القوصية", "Qusiya", 16L },
                    { 271L, "أبنوب", "Abnoub", 16L },
                    { 272L, "أبو تيج", "Abu Tig", 16L },
                    { 273L, "الغنايم", "El Ghanaim", 16L },
                    { 274L, "ساحل سليم", "Sahel Selim", 16L },
                    { 275L, "البداري", "El Badari", 16L },
                    { 276L, "صدفا", "Sidfa", 16L },
                    { 277L, "بني سويف", "Bani Sweif", 17L },
                    { 278L, "بني سويف الجديدة", "Beni Suef El Gedida", 17L },
                    { 279L, "الواسطى", "Al Wasta", 17L },
                    { 280L, "ناصر", "Naser", 17L },
                    { 281L, "إهناسيا", "Ehnasia", 17L },
                    { 282L, "ببا", "beba", 17L },
                    { 283L, "الفشن", "Fashn", 17L },
                    { 284L, "سمسطا", "Somasta", 17L },
                    { 285L, "الاباصيرى", "Alabbaseri", 17L },
                    { 286L, "مقبل", "Mokbel", 17L },
                    { 287L, "بورسعيد", "PorSaid", 18L },
                    { 288L, "بورفؤاد", "Port Fouad", 18L },
                    { 289L, "العرب", "Alarab", 18L },
                    { 290L, "حى الزهور", "Zohour", 18L },
                    { 291L, "حى الشرق", "Alsharq", 18L },
                    { 292L, "حى الضواحى", "Aldawahi", 18L },
                    { 293L, "حى المناخ", "Almanakh", 18L },
                    { 294L, "حى مبارك", "Mubarak", 18L },
                    { 295L, "دمياط", "Damietta", 19L },
                    { 296L, "دمياط الجديدة", "New Damietta", 19L },
                    { 297L, "رأس البر", "Ras El Bar", 19L },
                    { 298L, "فارسكور", "Faraskour", 19L },
                    { 299L, "الزرقا", "Zarqa", 19L },
                    { 300L, "السرو", "alsaru", 19L },
                    { 301L, "الروضة", "alruwda", 19L },
                    { 302L, "كفر البطيخ", "Kafr El-Batikh", 19L },
                    { 303L, "عزبة البرج", "Azbet Al Burg", 19L },
                    { 304L, "ميت أبو غالب", "Meet Abou Ghalib", 19L },
                    { 305L, "كفر سعد", "Kafr Saad", 19L },
                    { 306L, "الزقازيق", "Zagazig", 20L },
                    { 307L, "العاشر من رمضان", "Al Ashr Men Ramadan", 20L },
                    { 308L, "منيا القمح", "Minya Al Qamh", 20L },
                    { 309L, "بلبيس", "Belbeis", 20L },
                    { 310L, "مشتول السوق", "Mashtoul El Souq", 20L },
                    { 311L, "القنايات", "Qenaiat", 20L },
                    { 312L, "أبو حماد", "Abu Hammad", 20L },
                    { 313L, "القرين", "El Qurain", 20L },
                    { 314L, "ههيا", "Hehia", 20L },
                    { 315L, "أبو كبير", "Abu Kabir", 20L },
                    { 316L, "فاقوس", "Faccus", 20L },
                    { 317L, "الصالحية الجديدة", "El Salihia El Gedida", 20L },
                    { 318L, "الإبراهيمية", "Al Ibrahimiyah", 20L },
                    { 319L, "ديرب نجم", "Deirb Negm", 20L },
                    { 320L, "كفر صقر", "Kafr Saqr", 20L },
                    { 321L, "أولاد صقر", "Awlad Saqr", 20L },
                    { 322L, "الحسينية", "Husseiniya", 20L },
                    { 323L, "صان الحجر القبلية", "san alhajar alqablia", 20L },
                    { 324L, "منشأة أبو عمر", "Manshayat Abu Omar", 20L },
                    { 325L, "الطور", "Al Toor", 21L },
                    { 326L, "شرم الشيخ", "Sharm El-Shaikh", 21L },
                    { 327L, "دهب", "Dahab", 21L },
                    { 328L, "نويبع", "Nuweiba", 21L },
                    { 329L, "طابا", "Taba", 21L },
                    { 330L, "سانت كاترين", "Saint Catherine", 21L },
                    { 331L, "أبو رديس", "Abu Redis", 21L },
                    { 332L, "أبو زنيمة", "Abu Zenaima", 21L },
                    { 333L, "رأس سدر", "Ras Sidr", 21L },
                    { 334L, "كفر الشيخ", "Kafr El Sheikh", 22L },
                    { 335L, "وسط البلد كفر الشيخ", "Kafr El Sheikh Downtown", 22L },
                    { 336L, "دسوق", "Desouq", 22L },
                    { 337L, "فوه", "Fooh", 22L },
                    { 338L, "مطوبس", "Metobas", 22L },
                    { 339L, "برج البرلس", "Burg Al Burullus", 22L },
                    { 340L, "بلطيم", "Baltim", 22L },
                    { 341L, "مصيف بلطيم", "Masief Baltim", 22L },
                    { 342L, "الحامول", "Hamol", 22L },
                    { 343L, "بيلا", "Bella", 22L },
                    { 344L, "الرياض", "Riyadh", 22L },
                    { 345L, "سيدي سالم", "Sidi Salm", 22L },
                    { 346L, "قلين", "Qellen", 22L },
                    { 347L, "سيدي غازي", "Sidi Ghazi", 22L },
                    { 348L, "مرسى مطروح", "Marsa Matrouh", 23L },
                    { 349L, "الحمام", "El Hamam", 23L },
                    { 350L, "العلمين", "Alamein", 23L },
                    { 351L, "الضبعة", "Dabaa", 23L },
                    { 352L, "النجيلة", "Al-Nagila", 23L },
                    { 353L, "سيدي براني", "Sidi Brani", 23L },
                    { 354L, "السلوم", "Salloum", 23L },
                    { 355L, "سيوة", "Siwa", 23L },
                    { 356L, "مارينا", "Marina", 23L },
                    { 357L, "الساحل الشمالى", "North Coast", 23L },
                    { 358L, "الأقصر", "Luxor", 24L },
                    { 359L, "الأقصر الجديدة", "New Luxor", 24L },
                    { 360L, "إسنا", "Esna", 24L },
                    { 361L, "طيبة الجديدة", "New Tiba", 24L },
                    { 362L, "الزينية", "Al ziynia", 24L },
                    { 363L, "البياضية", "Al Bayadieh", 24L },
                    { 364L, "القرنة", "Al Qarna", 24L },
                    { 365L, "أرمنت", "Armant", 24L },
                    { 366L, "الطود", "Al Tud", 24L },
                    { 367L, "قنا", "Qena", 25L },
                    { 368L, "قنا الجديدة", "New Qena", 25L },
                    { 369L, "ابو طشت", "Abu Tesht", 25L },
                    { 370L, "نجع حمادي", "Nag Hammadi", 25L },
                    { 371L, "دشنا", "Deshna", 25L },
                    { 372L, "الوقف", "Alwaqf", 25L },
                    { 373L, "قفط", "Qaft", 25L },
                    { 374L, "نقادة", "Naqada", 25L },
                    { 375L, "فرشوط", "Farshout", 25L },
                    { 376L, "قوص", "Quos", 25L },
                    { 377L, "العريش", "Arish", 26L },
                    { 378L, "الشيخ زويد", "Sheikh Zowaid", 26L },
                    { 379L, "نخل", "Nakhl", 26L },
                    { 380L, "رفح", "Rafah", 26L },
                    { 381L, "بئر العبد", "Bir al-Abed", 26L },
                    { 382L, "الحسنة", "Al Hasana", 26L },
                    { 383L, "سوهاج", "Sohag", 27L },
                    { 384L, "سوهاج الجديدة", "Sohag El Gedida", 27L },
                    { 385L, "أخميم", "Akhmeem", 27L },
                    { 386L, "أخميم الجديدة", "Akhmim El Gedida", 27L },
                    { 387L, "البلينا", "Albalina", 27L },
                    { 388L, "المراغة", "El Maragha", 27L },
                    { 389L, "المنشأة", "almunsha''a", 27L },
                    { 390L, "دار السلام", "Dar AISalaam", 27L },
                    { 391L, "جرجا", "Gerga", 27L },
                    { 392L, "جهينة الغربية", "Jahina Al Gharbia", 27L },
                    { 393L, "ساقلته", "Saqilatuh", 27L },
                    { 394L, "طما", "Tama", 27L },
                    { 395L, "طهطا", "Tahta", 27L },
                    { 396L, "الكوثر", "Alkawthar", 27L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityId",
                table: "Users",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_GovernorateId",
                table: "Cities",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Governorates_ProvinceId",
                table: "Governorates",
                column: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cities_CityId",
                table: "Users",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cities_CityId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Governorates");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropIndex(
                name: "IX_Users_CityId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Users",
                newName: "Birthdate");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Users",
                newName: "ProfilePicture");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Users",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Theme",
                table: "Users",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Shopper", "SHOPPER" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "City", "Country", "CreatedAt", "Language", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Theme" },
                values: new object[] { null, null, new DateTime(2026, 8, 14, 13, 36, 7, 885, DateTimeKind.Utc).AddTicks(1652), "en", "AQAAAAIAAYagAAAAEBJJz7/w+F9JDvUaq6CesH14KJb+nySx9ldW8w+b430oTFHNgy/xezY94mDrD/TqAg==", null, false, "light" });
        }
    }
}
