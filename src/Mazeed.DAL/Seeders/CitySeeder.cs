using Mazeed.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Seeders
{
    public static class CitySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                /* Start Cairo ID:1 */
                new City { Id = 1, ArabicName = "15 مايو", EnglishName = "15 May", GovernorateId = 1 },
                new City { Id = 2, ArabicName = "الازبكية", EnglishName = "Al Azbakeyah", GovernorateId = 1 },
                new City { Id = 3, ArabicName = "البساتين", EnglishName = "Al Basatin", GovernorateId = 1 },
                new City { Id = 4, ArabicName = "التبين", EnglishName = "Tebin", GovernorateId = 1 },
                new City { Id = 5, ArabicName = "الخليفة", EnglishName = "El-Khalifa", GovernorateId = 1 },
                new City { Id = 6, ArabicName = "الدراسة", EnglishName = "El darrasa", GovernorateId = 1 },
                new City { Id = 7, ArabicName = "الدرب الاحمر", EnglishName = "Aldarb Alahmar", GovernorateId = 1 },
                new City { Id = 8, ArabicName = "الزاوية الحمراء", EnglishName = "Zawya al-Hamra", GovernorateId = 1 },
                new City { Id = 9, ArabicName = "الزيتون", EnglishName = "El-Zaytoun", GovernorateId = 1 },
                new City { Id = 10, ArabicName = "الساحل", EnglishName = "Sahel", GovernorateId = 1 },
                new City { Id = 11, ArabicName = "السلام", EnglishName = "El Salam", GovernorateId = 1 },
                new City { Id = 12, ArabicName = "السيدة زينب", EnglishName = "Sayeda Zeinab", GovernorateId = 1 },
                new City { Id = 13, ArabicName = "الشرابية", EnglishName = "El Sharabeya", GovernorateId = 1 },
                new City { Id = 14, ArabicName = "مدينة الشروق", EnglishName = "Shorouk", GovernorateId = 1 },
                new City { Id = 15, ArabicName = "الظاهر", EnglishName = "El Daher", GovernorateId = 1 },
                new City { Id = 16, ArabicName = "العتبة", EnglishName = "Ataba", GovernorateId = 1 },
                new City { Id = 17, ArabicName = "القاهرة الجديدة", EnglishName = "New Cairo", GovernorateId = 1 },
                new City { Id = 18, ArabicName = "المرج", EnglishName = "El Marg", GovernorateId = 1 },
                new City { Id = 19, ArabicName = "عزبة النخل", EnglishName = "Ezbet el Nakhl", GovernorateId = 1 },
                new City { Id = 20, ArabicName = "المطرية", EnglishName = "Matareya", GovernorateId = 1 },
                new City { Id = 21, ArabicName = "المعادى", EnglishName = "Maadi", GovernorateId = 1 },
                new City { Id = 22, ArabicName = "المعصرة", EnglishName = "Maasara", GovernorateId = 1 },
                new City { Id = 23, ArabicName = "المقطم", EnglishName = "Mokattam", GovernorateId = 1 },
                new City { Id = 24, ArabicName = "المنيل", EnglishName = "Manyal", GovernorateId = 1 },
                new City { Id = 25, ArabicName = "الموسكى", EnglishName = "Mosky", GovernorateId = 1 },
                new City { Id = 26, ArabicName = "النزهة", EnglishName = "Nozha", GovernorateId = 1 },
                new City { Id = 27, ArabicName = "الوايلى", EnglishName = "Waily", GovernorateId = 1 },
                new City { Id = 28, ArabicName = "باب الشعرية", EnglishName = "Bab al-Shereia", GovernorateId = 1 },
                new City { Id = 29, ArabicName = "بولاق", EnglishName = "Bolaq", GovernorateId = 1 },
                new City { Id = 30, ArabicName = "جاردن سيتى", EnglishName = "Garden City", GovernorateId = 1 },
                new City { Id = 31, ArabicName = "حدائق القبة", EnglishName = "Hadayek El-Kobba", GovernorateId = 1 },
                new City { Id = 32, ArabicName = "حلوان", EnglishName = "Helwan", GovernorateId = 1 },
                new City { Id = 33, ArabicName = "دار السلام", EnglishName = "Dar Al Salam", GovernorateId = 1 },
                new City { Id = 34, ArabicName = "شبرا", EnglishName = "Shubra", GovernorateId = 1 },
                new City { Id = 35, ArabicName = "طره", EnglishName = "Tura", GovernorateId = 1 },
                new City { Id = 36, ArabicName = "عابدين", EnglishName = "Abdeen", GovernorateId = 1 },
                new City { Id = 37, ArabicName = "عباسية", EnglishName = "Abaseya", GovernorateId = 1 },
                new City { Id = 38, ArabicName = "عين شمس", EnglishName = "Ain Shams", GovernorateId = 1 },
                new City { Id = 39, ArabicName = "مدينة نصر", EnglishName = "Nasr City", GovernorateId = 1 },
                new City { Id = 40, ArabicName = "مصر الجديدة", EnglishName = "New Heliopolis", GovernorateId = 1 },
                new City { Id = 41, ArabicName = "مصر القديمة", EnglishName = "Masr Al Qadima", GovernorateId = 1 },
                new City { Id = 42, ArabicName = "منشية ناصر", EnglishName = "Mansheya Nasir", GovernorateId = 1 },
                new City { Id = 43, ArabicName = "مدينة بدر", EnglishName = "Badr City", GovernorateId = 1 },
                new City { Id = 44, ArabicName = "مدينة العبور", EnglishName = "Obour City", GovernorateId = 1 },
                new City { Id = 45, ArabicName = "وسط البلد", EnglishName = "Cairo Downtown", GovernorateId = 1 },
                new City { Id = 46, ArabicName = "الزمالك", EnglishName = "Zamalek", GovernorateId = 1 },
                new City { Id = 47, ArabicName = "قصر النيل", EnglishName = "Kasr El Nile", GovernorateId = 1 },
                new City { Id = 48, ArabicName = "الرحاب", EnglishName = "Rehab", GovernorateId = 1 },
                new City { Id = 49, ArabicName = "القطامية", EnglishName = "Katameya", GovernorateId = 1 },
                new City { Id = 50, ArabicName = "مدينتي", EnglishName = "Madinty", GovernorateId = 1 },
                new City { Id = 51, ArabicName = "روض الفرج", EnglishName = "Rod Alfarag", GovernorateId = 1 },
                new City { Id = 52, ArabicName = "شيراتون", EnglishName = "Sheraton", GovernorateId = 1 },
                new City { Id = 53, ArabicName = "الجمالية", EnglishName = "El-Gamaleya", GovernorateId = 1 },
                new City { Id = 54, ArabicName = "العاشر من رمضان", EnglishName = "10th of Ramadan City", GovernorateId = 1 },
                new City { Id = 55, ArabicName = "الحلمية", EnglishName = "Helmeyat Alzaytoun", GovernorateId = 1 },
                new City { Id = 56, ArabicName = "النزهة الجديدة", EnglishName = "New Nozha", GovernorateId = 1 },
                new City { Id = 57, ArabicName = "العاصمة الإدارية", EnglishName = "Capital New", GovernorateId = 1 },
                /* End Cairo ID:1 */

                /* Start Giza ID:2 */
                new City { Id = 58, ArabicName = "الجيزة", EnglishName = "Giza", GovernorateId = 2 },
                new City { Id = 59, ArabicName = "السادس من أكتوبر", EnglishName = "Sixth of October", GovernorateId = 2 },
                new City { Id = 60, ArabicName = "الشيخ زايد", EnglishName = "Cheikh Zayed", GovernorateId = 2 },
                new City { Id = 61, ArabicName = "الحوامدية", EnglishName = "Hawamdiyah", GovernorateId = 2 },
                new City { Id = 62, ArabicName = "البدرشين", EnglishName = "Al Badrasheen", GovernorateId = 2 },
                new City { Id = 63, ArabicName = "الصف", EnglishName = "Saf", GovernorateId = 2 },
                new City { Id = 64, ArabicName = "أطفيح", EnglishName = "Atfih", GovernorateId = 2 },
                new City { Id = 65, ArabicName = "العياط", EnglishName = "Al Ayat", GovernorateId = 2 },
                new City { Id = 66, ArabicName = "الباويطي", EnglishName = "Al-Bawaiti", GovernorateId = 2 },
                new City { Id = 67, ArabicName = "منشأة القناطر", EnglishName = "ManshiyetAl Qanater", GovernorateId = 2 },
                new City { Id = 68, ArabicName = "أوسيم", EnglishName = "Oaseem", GovernorateId = 2 },
                new City { Id = 69, ArabicName = "كرداسة", EnglishName = "Kerdasa", GovernorateId = 2 },
                new City { Id = 70, ArabicName = "أبو النمرس", EnglishName = "Abu Nomros", GovernorateId = 2 },
                new City { Id = 71, ArabicName = "كفر غطاطي", EnglishName = "Kafr Ghati", GovernorateId = 2 },
                new City { Id = 72, ArabicName = "منشأة البكاري", EnglishName = "Manshiyet Al Bakari", GovernorateId = 2 },
                new City { Id = 73, ArabicName = "الدقى", EnglishName = "Dokki", GovernorateId = 2 },
                new City { Id = 74, ArabicName = "العجوزة", EnglishName = "Agouza", GovernorateId = 2 },
                new City { Id = 75, ArabicName = "الهرم", EnglishName = "Haram", GovernorateId = 2 },
                new City { Id = 76, ArabicName = "الوراق", EnglishName = "Warraq", GovernorateId = 2 },
                new City { Id = 77, ArabicName = "امبابة", EnglishName = "Imbaba", GovernorateId = 2 },
                new City { Id = 78, ArabicName = "بولاق الدكرور", EnglishName = "Boulaq Dakrour", GovernorateId = 2 },
                new City { Id = 79, ArabicName = "الواحات البحرية", EnglishName = "Al Wahat Al Baharia", GovernorateId = 2 },
                new City { Id = 80, ArabicName = "العمرانية", EnglishName = "Omraneya", GovernorateId = 2 },
                new City { Id = 81, ArabicName = "المنيب", EnglishName = "Moneeb", GovernorateId = 2 },
                new City { Id = 82, ArabicName = "بين السرايات", EnglishName = "Bin Alsarayat", GovernorateId = 2 },
                new City { Id = 83, ArabicName = "الكيت كات", EnglishName = "Kit Kat", GovernorateId = 2 },
                new City { Id = 84, ArabicName = "المهندسين", EnglishName = "Mohandessin", GovernorateId = 2 },
                new City { Id = 85, ArabicName = "فيصل", EnglishName = "Faisal", GovernorateId = 2 },
                new City { Id = 86, ArabicName = "أبو رواش", EnglishName = "Abu Rawash", GovernorateId = 2 },
                new City { Id = 87, ArabicName = "حدائق الأهرام", EnglishName = "Hadayek Alahram", GovernorateId = 2 },
                new City { Id = 88, ArabicName = "الحرانية", EnglishName = "Haraneya", GovernorateId = 2 },
                new City { Id = 89, ArabicName = "حدائق اكتوبر", EnglishName = "Hadayek October", GovernorateId = 2 },
                new City { Id = 90, ArabicName = "صفط اللبن", EnglishName = "Saft Allaban", GovernorateId = 2 },
                new City { Id = 91, ArabicName = "القرية الذكية", EnglishName = "Smart Village", GovernorateId = 2 },
                new City { Id = 92, ArabicName = "ارض اللواء", EnglishName = "Ard Ellwaa", GovernorateId = 2 },
                /* End Giza ID:2 */

                /* Start Alexandria ID:3 */
                new City { Id = 93, ArabicName = "ابو قير", EnglishName = "Abu Qir", GovernorateId = 3 },
                new City { Id = 94, ArabicName = "الابراهيمية", EnglishName = "Al Ibrahimeyah", GovernorateId = 3 },
                new City { Id = 95, ArabicName = "الأزاريطة", EnglishName = "Azarita", GovernorateId = 3 },
                new City { Id = 96, ArabicName = "الانفوشى", EnglishName = "Anfoushi", GovernorateId = 3 },
                new City { Id = 97, ArabicName = "الدخيلة", EnglishName = "Dekheila", GovernorateId = 3 },
                new City { Id = 98, ArabicName = "السيوف", EnglishName = "El Soyof", GovernorateId = 3 },
                new City { Id = 99, ArabicName = "العامرية", EnglishName = "Ameria", GovernorateId = 3 },
                new City { Id = 100, ArabicName = "اللبان", EnglishName = "El Labban", GovernorateId = 3 },
                new City { Id = 101, ArabicName = "المفروزة", EnglishName = "Al Mafrouza", GovernorateId = 3 },
                new City { Id = 102, ArabicName = "المنتزه", EnglishName = "El Montaza", GovernorateId = 3 },
                new City { Id = 103, ArabicName = "المنشية", EnglishName = "Mansheya", GovernorateId = 3 },
                new City { Id = 104, ArabicName = "الناصرية", EnglishName = "Naseria", GovernorateId = 3 },
                new City { Id = 105, ArabicName = "امبروزو", EnglishName = "Ambrozo", GovernorateId = 3 },
                new City { Id = 106, ArabicName = "باب شرق", EnglishName = "Bab Sharq", GovernorateId = 3 },
                new City { Id = 107, ArabicName = "برج العرب", EnglishName = "Bourj Alarab", GovernorateId = 3 },
                new City { Id = 108, ArabicName = "ستانلى", EnglishName = "Stanley", GovernorateId = 3 },
                new City { Id = 109, ArabicName = "سموحة", EnglishName = "Smouha", GovernorateId = 3 },
                new City { Id = 110, ArabicName = "سيدى بشر", EnglishName = "Sidi Bishr", GovernorateId = 3 },
                new City { Id = 111, ArabicName = "شدس", EnglishName = "Shads", GovernorateId = 3 },
                new City { Id = 112, ArabicName = "غيط العنب", EnglishName = "Gheet Alenab", GovernorateId = 3 },
                new City { Id = 113, ArabicName = "فلمينج", EnglishName = "Fleming", GovernorateId = 3 },
                new City { Id = 114, ArabicName = "فيكتوريا", EnglishName = "Victoria", GovernorateId = 3 },
                new City { Id = 115, ArabicName = "كامب شيزار", EnglishName = "Camp Shizar", GovernorateId = 3 },
                new City { Id = 116, ArabicName = "كرموز", EnglishName = "Karmooz", GovernorateId = 3 },
                new City { Id = 117, ArabicName = "محطة الرمل", EnglishName = "Mahta Alraml", GovernorateId = 3 },
                new City { Id = 118, ArabicName = "مينا البصل", EnglishName = "Mina El-Basal", GovernorateId = 3 },
                new City { Id = 119, ArabicName = "العافرة", EnglishName = "Asafra", GovernorateId = 3 },
                new City { Id = 120, ArabicName = "العجمي", EnglishName = "Agamy", GovernorateId = 3 },
                new City { Id = 121, ArabicName = "بكوس", EnglishName = "Bakos", GovernorateId = 3 },
                new City { Id = 122, ArabicName = "بولكلي", EnglishName = "Boulkly", GovernorateId = 3 },
                new City { Id = 123, ArabicName = "كليوباترا", EnglishName = "Cleopatra", GovernorateId = 3 },
                new City { Id = 124, ArabicName = "جليم", EnglishName = "Glim", GovernorateId = 3 },
                new City { Id = 125, ArabicName = "المعمورة", EnglishName = "Al Mamurah", GovernorateId = 3 },
                new City { Id = 126, ArabicName = "المندرة", EnglishName = "Al Mandara", GovernorateId = 3 },
                new City { Id = 127, ArabicName = "محرم بك", EnglishName = "Moharam Bek", GovernorateId = 3 },
                new City { Id = 128, ArabicName = "الشاطبي", EnglishName = "Elshatby", GovernorateId = 3 },
                new City { Id = 129, ArabicName = "سيدي جابر", EnglishName = "Sidi Gaber", GovernorateId = 3 },
                new City { Id = 130, ArabicName = "الساحل الشمالي", EnglishName = "North Coast/sahel", GovernorateId = 3 },
                new City { Id = 131, ArabicName = "الحضرة", EnglishName = "Alhadra", GovernorateId = 3 },
                new City { Id = 132, ArabicName = "العطارين", EnglishName = "Alattarin", GovernorateId = 3 },
                new City { Id = 133, ArabicName = "سيدي كرير", EnglishName = "Sidi Kerir", GovernorateId = 3 },
                new City { Id = 134, ArabicName = "الجمرك", EnglishName = "Elgomrok", GovernorateId = 3 },
                new City { Id = 135, ArabicName = "المكس", EnglishName = "Al Max", GovernorateId = 3 },
                new City { Id = 136, ArabicName = "مارينا", EnglishName = "Marina", GovernorateId = 3 },
                /* End Alexandria ID:3 */

                /* Start Dakahlia ID:4 */
                new City { Id = 137, ArabicName = "المنصورة", EnglishName = "Mansoura", GovernorateId = 4 },
                new City { Id = 138, ArabicName = "طلخا", EnglishName = "Talkha", GovernorateId = 4 },
                new City { Id = 139, ArabicName = "ميت غمر", EnglishName = "Mitt Ghamr", GovernorateId = 4 },
                new City { Id = 140, ArabicName = "دكرنس", EnglishName = "Dekernes", GovernorateId = 4 },
                new City { Id = 141, ArabicName = "أجا", EnglishName = "Aga", GovernorateId = 4 },
                new City { Id = 142, ArabicName = "منية النصر", EnglishName = "Menia El Nasr", GovernorateId = 4 },
                new City { Id = 143, ArabicName = "السنبلاوين", EnglishName = "Sinbillawin", GovernorateId = 4 },
                new City { Id = 144, ArabicName = "الكردي", EnglishName = "El Kurdi", GovernorateId = 4 },
                new City { Id = 145, ArabicName = "بني عبيد", EnglishName = "Bani Ubaid", GovernorateId = 4 },
                new City { Id = 146, ArabicName = "المنزلة", EnglishName = "Al Manzala", GovernorateId = 4 },
                new City { Id = 147, ArabicName = "تمي الأمديد", EnglishName = "tami al'amdid", GovernorateId = 4 },
                new City { Id = 148, ArabicName = "الجمالية", EnglishName = "aljamalia", GovernorateId = 4 },
                new City { Id = 149, ArabicName = "شربين", EnglishName = "Sherbin", GovernorateId = 4 },
                new City { Id = 150, ArabicName = "المطرية", EnglishName = "Mataria", GovernorateId = 4 },
                new City { Id = 151, ArabicName = "بلقاس", EnglishName = "Belqas", GovernorateId = 4 },
                new City { Id = 152, ArabicName = "ميت سلسيل", EnglishName = "Meet Salsil", GovernorateId = 4 },
                new City { Id = 153, ArabicName = "جمصة", EnglishName = "Gamasa", GovernorateId = 4 },
                new City { Id = 154, ArabicName = "محلة دمنة", EnglishName = "Mahalat Damana", GovernorateId = 4 },
                new City { Id = 155, ArabicName = "نبروه", EnglishName = "Nabroh", GovernorateId = 4 },
                /* End Dakahlia ID:4 */

                /* Start Red Sea ID:5 */
                new City { Id = 156, ArabicName = "الغردقة", EnglishName = "Hurghada", GovernorateId = 5 },
                new City { Id = 157, ArabicName = "رأس غارب", EnglishName = "Ras Ghareb", GovernorateId = 5 },
                new City { Id = 158, ArabicName = "سفاجا", EnglishName = "Safaga", GovernorateId = 5 },
                new City { Id = 159, ArabicName = "القصير", EnglishName = "El Qusiar", GovernorateId = 5 },
                new City { Id = 160, ArabicName = "مرسى علم", EnglishName = "Marsa Alam", GovernorateId = 5 },
                new City { Id = 161, ArabicName = "الشلاتين", EnglishName = "Shalatin", GovernorateId = 5 },
                new City { Id = 162, ArabicName = "حلايب", EnglishName = "Halaib", GovernorateId = 5 },
                new City { Id = 163, ArabicName = "الدهار", EnglishName = "Aldahar", GovernorateId = 5 },
                /* End Red Sea ID:5 */

                /* Start Beheira ID:6 */
                new City { Id = 164, ArabicName = "دمنهور", EnglishName = "Damanhour", GovernorateId = 6 },
                new City { Id = 165, ArabicName = "كفر الدوار", EnglishName = "Kafr El Dawar", GovernorateId = 6 },
                new City { Id = 166, ArabicName = "رشيد", EnglishName = "Rashid", GovernorateId = 6 },
                new City { Id = 167, ArabicName = "إدكو", EnglishName = "Edco", GovernorateId = 6 },
                new City { Id = 168, ArabicName = "أبو المطامير", EnglishName = "Abu al-Matamir", GovernorateId = 6 },
                new City { Id = 169, ArabicName = "أبو حمص", EnglishName = "Abu Homs", GovernorateId = 6 },
                new City { Id = 170, ArabicName = "الدلنجات", EnglishName = "Delengat", GovernorateId = 6 },
                new City { Id = 171, ArabicName = "المحمودية", EnglishName = "Mahmoudiyah", GovernorateId = 6 },
                new City { Id = 172, ArabicName = "الرحمانية", EnglishName = "Rahmaniyah", GovernorateId = 6 },
                new City { Id = 173, ArabicName = "إيتاي البارود", EnglishName = "Itai Baroud", GovernorateId = 6 },
                new City { Id = 174, ArabicName = "حوش عيسى", EnglishName = "Housh Eissa", GovernorateId = 6 },
                new City { Id = 175, ArabicName = "شبراخيت", EnglishName = "Shubrakhit", GovernorateId = 6 },
                new City { Id = 176, ArabicName = "كوم حمادة", EnglishName = "Kom Hamada", GovernorateId = 6 },
                new City { Id = 177, ArabicName = "بدر", EnglishName = "Badr", GovernorateId = 6 },
                new City { Id = 178, ArabicName = "وادي النطرون", EnglishName = "Wadi Natrun", GovernorateId = 6 },
                new City { Id = 179, ArabicName = "النوبارية الجديدة", EnglishName = "New Nubaria", GovernorateId = 6 },
                new City { Id = 180, ArabicName = "النوبارية", EnglishName = "Alnoubareya", GovernorateId = 6 },
                /* End Beheira ID:6 */

                /* Start Fayoum ID:7 */
                new City { Id = 181, ArabicName = "الفيوم", EnglishName = "Fayoum", GovernorateId = 7 },
                new City { Id = 182, ArabicName = "الفيوم الجديدة", EnglishName = "Fayoum El Gedida", GovernorateId = 7 },
                new City { Id = 183, ArabicName = "طامية", EnglishName = "Tamiya", GovernorateId = 7 },
                new City { Id = 184, ArabicName = "سنورس", EnglishName = "Snores", GovernorateId = 7 },
                new City { Id = 185, ArabicName = "إطسا", EnglishName = "Etsa", GovernorateId = 7 },
                new City { Id = 186, ArabicName = "إبشواي", EnglishName = "Epschway", GovernorateId = 7 },
                new City { Id = 187, ArabicName = "يوسف الصديق", EnglishName = "Yusuf El Sediaq", GovernorateId = 7 },
                new City { Id = 188, ArabicName = "الحادقة", EnglishName = "Hadqa", GovernorateId = 7 },
                new City { Id = 189, ArabicName = "اطسا", EnglishName = "Atsa", GovernorateId = 7 },
                new City { Id = 190, ArabicName = "الجامعة", EnglishName = "Algamaa", GovernorateId = 7 },
                new City { Id = 191, ArabicName = "السيالة", EnglishName = "Sayala", GovernorateId = 7 },
                /* End Fayoum ID:7 */

                /* Start Gharbia ID:8 */
                new City { Id = 192, ArabicName = "طنطا", EnglishName = "Tanta", GovernorateId = 8 },
                new City { Id = 193, ArabicName = "المحلة الكبرى", EnglishName = "Al Mahalla Al Kobra", GovernorateId = 8 },
                new City { Id = 194, ArabicName = "كفر الزيات", EnglishName = "Kafr El Zayat", GovernorateId = 8 },
                new City { Id = 195, ArabicName = "زفتى", EnglishName = "Zefta", GovernorateId = 8 },
                new City { Id = 196, ArabicName = "السنطة", EnglishName = "El Santa", GovernorateId = 8 },
                new City { Id = 197, ArabicName = "قطور", EnglishName = "Qutour", GovernorateId = 8 },
                new City { Id = 198, ArabicName = "بسيون", EnglishName = "Basion", GovernorateId = 8 },
                new City { Id = 199, ArabicName = "سمنود", EnglishName = "Samannoud", GovernorateId = 8 },
                /* End Gharbia ID:8 */

                /* Start Ismailia ID:9 */
                new City { Id = 200, ArabicName = "الإسماعيلية", EnglishName = "Ismailia", GovernorateId = 9 },
                new City { Id = 201, ArabicName = "فايد", EnglishName = "Fayed", GovernorateId = 9 },
                new City { Id = 202, ArabicName = "القنطرة شرق", EnglishName = "Qantara Sharq", GovernorateId = 9 },
                new City { Id = 203, ArabicName = "القنطرة غرب", EnglishName = "Qantara Gharb", GovernorateId = 9 },
                new City { Id = 204, ArabicName = "التل الكبير", EnglishName = "El Tal El Kabier", GovernorateId = 9 },
                new City { Id = 205, ArabicName = "أبو صوير", EnglishName = "Abu Sawir", GovernorateId = 9 },
                new City { Id = 206, ArabicName = "القصاصين الجديدة", EnglishName = "Kasasien El Gedida", GovernorateId = 9 },
                new City { Id = 207, ArabicName = "نفيشة", EnglishName = "Nefesha", GovernorateId = 9 },
                new City { Id = 208, ArabicName = "الشيخ زايد", EnglishName = "Sheikh Zayed", GovernorateId = 9 },
                /* End Ismailia ID:9 */

                /* Start Monufya ID:10 */
                new City { Id = 209, ArabicName = "شبين الكوم", EnglishName = "Shbeen El Koom", GovernorateId = 10 },
                new City { Id = 210, ArabicName = "مدينة السادات", EnglishName = "Sadat City", GovernorateId = 10 },
                new City { Id = 211, ArabicName = "منوف", EnglishName = "Menouf", GovernorateId = 10 },
                new City { Id = 212, ArabicName = "سرس الليان", EnglishName = "Sars El-Layan", GovernorateId = 10 },
                new City { Id = 213, ArabicName = "أشمون", EnglishName = "Ashmon", GovernorateId = 10 },
                new City { Id = 214, ArabicName = "الباجور", EnglishName = "Al Bagor", GovernorateId = 10 },
                new City { Id = 215, ArabicName = "قويسنا", EnglishName = "Quesna", GovernorateId = 10 },
                new City { Id = 216, ArabicName = "بركة السبع", EnglishName = "Berkat El Saba", GovernorateId = 10 },
                new City { Id = 217, ArabicName = "تلا", EnglishName = "Tala", GovernorateId = 10 },
                new City { Id = 218, ArabicName = "الشهداء", EnglishName = "Al Shohada", GovernorateId = 10 },
                /* End Monufya ID:10 */

                /* Start Minya ID:11 */
                new City { Id = 219, ArabicName = "المنيا", EnglishName = "Minya", GovernorateId = 11 },
                new City { Id = 220, ArabicName = "المنيا الجديدة", EnglishName = "Minya El Gedida", GovernorateId = 11 },
                new City { Id = 221, ArabicName = "العدوة", EnglishName = "El Adwa", GovernorateId = 11 },
                new City { Id = 222, ArabicName = "مغاغة", EnglishName = "Magagha", GovernorateId = 11 },
                new City { Id = 223, ArabicName = "بني مزار", EnglishName = "Bani Mazar", GovernorateId = 11 },
                new City { Id = 224, ArabicName = "مطاي", EnglishName = "Mattay", GovernorateId = 11 },
                new City { Id = 225, ArabicName = "سمالوط", EnglishName = "Samalut", GovernorateId = 11 },
                new City { Id = 226, ArabicName = "المدينة الفكرية", EnglishName = "Madinat El Fekria", GovernorateId = 11 },
                new City { Id = 227, ArabicName = "ملوي", EnglishName = "Meloy", GovernorateId = 11 },
                new City { Id = 228, ArabicName = "دير مواس", EnglishName = "Deir Mawas", GovernorateId = 11 },
                new City { Id = 229, ArabicName = "ابو قرقاص", EnglishName = "Abu Qurqas", GovernorateId = 11 },
                new City { Id = 230, ArabicName = "ارض سلطان", EnglishName = "Ard Sultan", GovernorateId = 11 },
                /* End Minya ID:11 */

                /* Start Qalubia ID:12 */
                new City { Id = 231, ArabicName = "بنها", EnglishName = "Banha", GovernorateId = 12 },
                new City { Id = 232, ArabicName = "قليوب", EnglishName = "Qalyub", GovernorateId = 12 },
                new City { Id = 233, ArabicName = "شبرا الخيمة", EnglishName = "Shubra Al Khaimah", GovernorateId = 12 },
                new City { Id = 234, ArabicName = "القناطر الخيرية", EnglishName = "Al Qanater Charity", GovernorateId = 12 },
                new City { Id = 235, ArabicName = "الخانكة", EnglishName = "Khanka", GovernorateId = 12 },
                new City { Id = 236, ArabicName = "كفر شكر", EnglishName = "Kafr Shukr", GovernorateId = 12 },
                new City { Id = 237, ArabicName = "طوخ", EnglishName = "Tukh", GovernorateId = 12 },
                new City { Id = 238, ArabicName = "قها", EnglishName = "Qaha", GovernorateId = 12 },
                new City { Id = 239, ArabicName = "العبور", EnglishName = "Obour", GovernorateId = 12 },
                new City { Id = 240, ArabicName = "الخصوص", EnglishName = "Khosous", GovernorateId = 12 },
                new City { Id = 241, ArabicName = "شبين القناطر", EnglishName = "Shibin Al Qanater", GovernorateId = 12 },
                new City { Id = 242, ArabicName = "مسطرد", EnglishName = "Mostorod", GovernorateId = 12 },
                /* End Qalubia ID:12 */

                /* Start New Valley ID:13 */
                new City { Id = 243, ArabicName = "الخارجة", EnglishName = "El Kharga", GovernorateId = 13 },
                new City { Id = 244, ArabicName = "باريس", EnglishName = "Paris", GovernorateId = 13 },
                new City { Id = 245, ArabicName = "موط", EnglishName = "Mout", GovernorateId = 13 },
                new City { Id = 246, ArabicName = "الفرافرة", EnglishName = "Farafra", GovernorateId = 13 },
                new City { Id = 247, ArabicName = "بلاط", EnglishName = "Balat", GovernorateId = 13 },
                new City { Id = 248, ArabicName = "الداخلة", EnglishName = "Dakhla", GovernorateId = 13 },
                /* End New Valley ID:13 */

                /* Start South Sinai ID:14 */
                new City { Id = 249, ArabicName = "السويس", EnglishName = "Suez", GovernorateId = 14 },
                new City { Id = 250, ArabicName = "الجناين", EnglishName = "Alganayen", GovernorateId = 14 },
                new City { Id = 251, ArabicName = "عتاقة", EnglishName = "Ataqah", GovernorateId = 14 },
                new City { Id = 252, ArabicName = "العين السخنة", EnglishName = "Ain Sokhna", GovernorateId = 14 },
                new City { Id = 253, ArabicName = "فيصل", EnglishName = "Faysal", GovernorateId = 14 },
                /* End South Sinai ID:14 */

                /* Start Aswan ID:15 */
                new City { Id = 254, ArabicName = "أسوان", EnglishName = "Aswan", GovernorateId = 15 },
                new City { Id = 255, ArabicName = "أسوان الجديدة", EnglishName = "Aswan El Gedida", GovernorateId = 15 },
                new City { Id = 256, ArabicName = "دراو", EnglishName = "Drau", GovernorateId = 15 },
                new City { Id = 257, ArabicName = "كوم أمبو", EnglishName = "Kom Ombo", GovernorateId = 15 },
                new City { Id = 258, ArabicName = "نصر النوبة", EnglishName = "Nasr Al Nuba", GovernorateId = 15 },
                new City { Id = 259, ArabicName = "كلابشة", EnglishName = "Kalabsha", GovernorateId = 15 },
                new City { Id = 260, ArabicName = "إدفو", EnglishName = "Edfu", GovernorateId = 15 },
                new City { Id = 261, ArabicName = "الرديسية", EnglishName = "Al-Radisiyah", GovernorateId = 15 },
                new City { Id = 262, ArabicName = "البصيلية", EnglishName = "Al Basilia", GovernorateId = 15 },
                new City { Id = 263, ArabicName = "السباعية", EnglishName = "Al Sibaeia", GovernorateId = 15 },
                new City { Id = 264, ArabicName = "ابوسمبل السياحية", EnglishName = "Abo Simbl Al Siyahia", GovernorateId = 15 },
                new City { Id = 265, ArabicName = "مرسى علم", EnglishName = "Marsa Alam", GovernorateId = 15 },
                /* End Aswan ID:15 */

                /* Start Assiut ID:16 */
                new City { Id = 266, ArabicName = "أسيوط", EnglishName = "Assiut", GovernorateId = 16 },
                new City { Id = 267, ArabicName = "أسيوط الجديدة", EnglishName = "Assiut El Gedida", GovernorateId = 16 },
                new City { Id = 268, ArabicName = "ديروط", EnglishName = "Dayrout", GovernorateId = 16 },
                new City { Id = 269, ArabicName = "منفلوط", EnglishName = "Manfalut", GovernorateId = 16 },
                new City { Id = 270, ArabicName = "القوصية", EnglishName = "Qusiya", GovernorateId = 16 },
                new City { Id = 271, ArabicName = "أبنوب", EnglishName = "Abnoub", GovernorateId = 16 },
                new City { Id = 272, ArabicName = "أبو تيج", EnglishName = "Abu Tig", GovernorateId = 16 },
                new City { Id = 273, ArabicName = "الغنايم", EnglishName = "El Ghanaim", GovernorateId = 16 },
                new City { Id = 274, ArabicName = "ساحل سليم", EnglishName = "Sahel Selim", GovernorateId = 16 },
                new City { Id = 275, ArabicName = "البداري", EnglishName = "El Badari", GovernorateId = 16 },
                new City { Id = 276, ArabicName = "صدفا", EnglishName = "Sidfa", GovernorateId = 16 },
                /* End Assiut ID:16 */

                /* Start Bani Sweif ID:17 */
                new City { Id = 277, ArabicName = "بني سويف", EnglishName = "Bani Sweif", GovernorateId = 17 },
                new City { Id = 278, ArabicName = "بني سويف الجديدة", EnglishName = "Beni Suef El Gedida", GovernorateId = 17 },
                new City { Id = 279, ArabicName = "الواسطى", EnglishName = "Al Wasta", GovernorateId = 17 },
                new City { Id = 280, ArabicName = "ناصر", EnglishName = "Naser", GovernorateId = 17 },
                new City { Id = 281, ArabicName = "إهناسيا", EnglishName = "Ehnasia", GovernorateId = 17 },
                new City { Id = 282, ArabicName = "ببا", EnglishName = "beba", GovernorateId = 17 },
                new City { Id = 283, ArabicName = "الفشن", EnglishName = "Fashn", GovernorateId = 17 },
                new City { Id = 284, ArabicName = "سمسطا", EnglishName = "Somasta", GovernorateId = 17 },
                new City { Id = 285, ArabicName = "الاباصيرى", EnglishName = "Alabbaseri", GovernorateId = 17 },
                new City { Id = 286, ArabicName = "مقبل", EnglishName = "Mokbel", GovernorateId = 17 },
                /* End Bani Sweif ID:17 */

                /* Start PorSaid ID:18 */
                new City { Id = 287, ArabicName = "بورسعيد", EnglishName = "PorSaid", GovernorateId = 18 },
                new City { Id = 288, ArabicName = "بورفؤاد", EnglishName = "Port Fouad", GovernorateId = 18 },
                new City { Id = 289, ArabicName = "العرب", EnglishName = "Alarab", GovernorateId = 18 },
                new City { Id = 290, ArabicName = "حى الزهور", EnglishName = "Zohour", GovernorateId = 18 },
                new City { Id = 291, ArabicName = "حى الشرق", EnglishName = "Alsharq", GovernorateId = 18 },
                new City { Id = 292, ArabicName = "حى الضواحى", EnglishName = "Aldawahi", GovernorateId = 18 },
                new City { Id = 293, ArabicName = "حى المناخ", EnglishName = "Almanakh", GovernorateId = 18 },
                new City { Id = 294, ArabicName = "حى مبارك", EnglishName = "Mubarak", GovernorateId = 18 },
                /* End PorSaid ID:18 */

                /* Start Damietta ID:19 */
                new City { Id = 295, ArabicName = "دمياط", EnglishName = "Damietta", GovernorateId = 19 },
                new City { Id = 296, ArabicName = "دمياط الجديدة", EnglishName = "New Damietta", GovernorateId = 19 },
                new City { Id = 297, ArabicName = "رأس البر", EnglishName = "Ras El Bar", GovernorateId = 19 },
                new City { Id = 298, ArabicName = "فارسكور", EnglishName = "Faraskour", GovernorateId = 19 },
                new City { Id = 299, ArabicName = "الزرقا", EnglishName = "Zarqa", GovernorateId = 19 },
                new City { Id = 300, ArabicName = "السرو", EnglishName = "alsaru", GovernorateId = 19 },
                new City { Id = 301, ArabicName = "الروضة", EnglishName = "alruwda", GovernorateId = 19 },
                new City { Id = 302, ArabicName = "كفر البطيخ", EnglishName = "Kafr El-Batikh", GovernorateId = 19 },
                new City { Id = 303, ArabicName = "عزبة البرج", EnglishName = "Azbet Al Burg", GovernorateId = 19 },
                new City { Id = 304, ArabicName = "ميت أبو غالب", EnglishName = "Meet Abou Ghalib", GovernorateId = 19 },
                new City { Id = 305, ArabicName = "كفر سعد", EnglishName = "Kafr Saad", GovernorateId = 19 },
                /* End Damietta ID:19 */

                /* Start Sharqia ID:20 */
                new City { Id = 306, ArabicName = "الزقازيق", EnglishName = "Zagazig", GovernorateId = 20 },
                new City { Id = 307, ArabicName = "العاشر من رمضان", EnglishName = "Al Ashr Men Ramadan", GovernorateId = 20 },
                new City { Id = 308, ArabicName = "منيا القمح", EnglishName = "Minya Al Qamh", GovernorateId = 20 },
                new City { Id = 309, ArabicName = "بلبيس", EnglishName = "Belbeis", GovernorateId = 20 },
                new City { Id = 310, ArabicName = "مشتول السوق", EnglishName = "Mashtoul El Souq", GovernorateId = 20 },
                new City { Id = 311, ArabicName = "القنايات", EnglishName = "Qenaiat", GovernorateId = 20 },
                new City { Id = 312, ArabicName = "أبو حماد", EnglishName = "Abu Hammad", GovernorateId = 20 },
                new City { Id = 313, ArabicName = "القرين", EnglishName = "El Qurain", GovernorateId = 20 },
                new City { Id = 314, ArabicName = "ههيا", EnglishName = "Hehia", GovernorateId = 20 },
                new City { Id = 315, ArabicName = "أبو كبير", EnglishName = "Abu Kabir", GovernorateId = 20 },
                new City { Id = 316, ArabicName = "فاقوس", EnglishName = "Faccus", GovernorateId = 20 },
                new City { Id = 317, ArabicName = "الصالحية الجديدة", EnglishName = "El Salihia El Gedida", GovernorateId = 20 },
                new City { Id = 318, ArabicName = "الإبراهيمية", EnglishName = "Al Ibrahimiyah", GovernorateId = 20 },
                new City { Id = 319, ArabicName = "ديرب نجم", EnglishName = "Deirb Negm", GovernorateId = 20 },
                new City { Id = 320, ArabicName = "كفر صقر", EnglishName = "Kafr Saqr", GovernorateId = 20 },
                new City { Id = 321, ArabicName = "أولاد صقر", EnglishName = "Awlad Saqr", GovernorateId = 20 },
                new City { Id = 322, ArabicName = "الحسينية", EnglishName = "Husseiniya", GovernorateId = 20 },
                new City { Id = 323, ArabicName = "صان الحجر القبلية", EnglishName = "san alhajar alqablia", GovernorateId = 20 },
                new City { Id = 324, ArabicName = "منشأة أبو عمر", EnglishName = "Manshayat Abu Omar", GovernorateId = 20 },
                /* End Sharqia ID:20 */

                /* Start South Sinai ID:21 */
                new City { Id = 325, ArabicName = "الطور", EnglishName = "Al Toor", GovernorateId = 21 },
                new City { Id = 326, ArabicName = "شرم الشيخ", EnglishName = "Sharm El-Shaikh", GovernorateId = 21 },
                new City { Id = 327, ArabicName = "دهب", EnglishName = "Dahab", GovernorateId = 21 },
                new City { Id = 328, ArabicName = "نويبع", EnglishName = "Nuweiba", GovernorateId = 21 },
                new City { Id = 329, ArabicName = "طابا", EnglishName = "Taba", GovernorateId = 21 },
                new City { Id = 330, ArabicName = "سانت كاترين", EnglishName = "Saint Catherine", GovernorateId = 21 },
                new City { Id = 331, ArabicName = "أبو رديس", EnglishName = "Abu Redis", GovernorateId = 21 },
                new City { Id = 332, ArabicName = "أبو زنيمة", EnglishName = "Abu Zenaima", GovernorateId = 21 },
                new City { Id = 333, ArabicName = "رأس سدر", EnglishName = "Ras Sidr", GovernorateId = 21 },
                /* End South Sinai ID:21 */

                /* Start Kafr El Sheikh ID:22 */
                new City { Id = 334, ArabicName = "كفر الشيخ", EnglishName = "Kafr El Sheikh", GovernorateId = 22 },
                new City { Id = 335, ArabicName = "وسط البلد كفر الشيخ", EnglishName = "Kafr El Sheikh Downtown", GovernorateId = 22 },
                new City { Id = 336, ArabicName = "دسوق", EnglishName = "Desouq", GovernorateId = 22 },
                new City { Id = 337, ArabicName = "فوه", EnglishName = "Fooh", GovernorateId = 22 },
                new City { Id = 338, ArabicName = "مطوبس", EnglishName = "Metobas", GovernorateId = 22 },
                new City { Id = 339, ArabicName = "برج البرلس", EnglishName = "Burg Al Burullus", GovernorateId = 22 },
                new City { Id = 340, ArabicName = "بلطيم", EnglishName = "Baltim", GovernorateId = 22 },
                new City { Id = 341, ArabicName = "مصيف بلطيم", EnglishName = "Masief Baltim", GovernorateId = 22 },
                new City { Id = 342, ArabicName = "الحامول", EnglishName = "Hamol", GovernorateId = 22 },
                new City { Id = 343, ArabicName = "بيلا", EnglishName = "Bella", GovernorateId = 22 },
                new City { Id = 344, ArabicName = "الرياض", EnglishName = "Riyadh", GovernorateId = 22 },
                new City { Id = 345, ArabicName = "سيدي سالم", EnglishName = "Sidi Salm", GovernorateId = 22 },
                new City { Id = 346, ArabicName = "قلين", EnglishName = "Qellen", GovernorateId = 22 },
                new City { Id = 347, ArabicName = "سيدي غازي", EnglishName = "Sidi Ghazi", GovernorateId = 22 },
                /* End Kafr El Sheikh ID:22 */

                /* Start Matrouh ID:23 */
                new City { Id = 348, ArabicName = "مرسى مطروح", EnglishName = "Marsa Matrouh", GovernorateId = 23 },
                new City { Id = 349, ArabicName = "الحمام", EnglishName = "El Hamam", GovernorateId = 23 },
                new City { Id = 350, ArabicName = "العلمين", EnglishName = "Alamein", GovernorateId = 23 },
                new City { Id = 351, ArabicName = "الضبعة", EnglishName = "Dabaa", GovernorateId = 23 },
                new City { Id = 352, ArabicName = "النجيلة", EnglishName = "Al-Nagila", GovernorateId = 23 },
                new City { Id = 353, ArabicName = "سيدي براني", EnglishName = "Sidi Brani", GovernorateId = 23 },
                new City { Id = 354, ArabicName = "السلوم", EnglishName = "Salloum", GovernorateId = 23 },
                new City { Id = 355, ArabicName = "سيوة", EnglishName = "Siwa", GovernorateId = 23 },
                new City { Id = 356, ArabicName = "مارينا", EnglishName = "Marina", GovernorateId = 23 },
                new City { Id = 357, ArabicName = "الساحل الشمالى", EnglishName = "North Coast", GovernorateId = 23 },
                /* End Matrouh ID:23 */

                /* Start Luxor ID:24 */
                new City { Id = 358, ArabicName = "الأقصر", EnglishName = "Luxor", GovernorateId = 24 },
                new City { Id = 359, ArabicName = "الأقصر الجديدة", EnglishName = "New Luxor", GovernorateId = 24 },
                new City { Id = 360, ArabicName = "إسنا", EnglishName = "Esna", GovernorateId = 24 },
                new City { Id = 361, ArabicName = "طيبة الجديدة", EnglishName = "New Tiba", GovernorateId = 24 },
                new City { Id = 362, ArabicName = "الزينية", EnglishName = "Al ziynia", GovernorateId = 24 },
                new City { Id = 363, ArabicName = "البياضية", EnglishName = "Al Bayadieh", GovernorateId = 24 },
                new City { Id = 364, ArabicName = "القرنة", EnglishName = "Al Qarna", GovernorateId = 24 },
                new City { Id = 365, ArabicName = "أرمنت", EnglishName = "Armant", GovernorateId = 24 },
                new City { Id = 366, ArabicName = "الطود", EnglishName = "Al Tud", GovernorateId = 24 },
                /* End Luxor ID:24 */

                /* Start Qena ID:25 */
                new City { Id = 367, ArabicName = "قنا", EnglishName = "Qena", GovernorateId = 25 },
                new City { Id = 368, ArabicName = "قنا الجديدة", EnglishName = "New Qena", GovernorateId = 25 },
                new City { Id = 369, ArabicName = "ابو طشت", EnglishName = "Abu Tesht", GovernorateId = 25 },
                new City { Id = 370, ArabicName = "نجع حمادي", EnglishName = "Nag Hammadi", GovernorateId = 25 },
                new City { Id = 371, ArabicName = "دشنا", EnglishName = "Deshna", GovernorateId = 25 },
                new City { Id = 372, ArabicName = "الوقف", EnglishName = "Alwaqf", GovernorateId = 25 },
                new City { Id = 373, ArabicName = "قفط", EnglishName = "Qaft", GovernorateId = 25 },
                new City { Id = 374, ArabicName = "نقادة", EnglishName = "Naqada", GovernorateId = 25 },
                new City { Id = 375, ArabicName = "فرشوط", EnglishName = "Farshout", GovernorateId = 25 },
                new City { Id = 376, ArabicName = "قوص", EnglishName = "Quos", GovernorateId = 25 },
                /* End Qena ID:25 */

                /* Start North Sinai ID:26 */
                new City { Id = 377, ArabicName = "العريش", EnglishName = "Arish", GovernorateId = 26 },
                new City { Id = 378, ArabicName = "الشيخ زويد", EnglishName = "Sheikh Zowaid", GovernorateId = 26 },
                new City { Id = 379, ArabicName = "نخل", EnglishName = "Nakhl", GovernorateId = 26 },
                new City { Id = 380, ArabicName = "رفح", EnglishName = "Rafah", GovernorateId = 26 },
                new City { Id = 381, ArabicName = "بئر العبد", EnglishName = "Bir al-Abed", GovernorateId = 26 },
                new City { Id = 382, ArabicName = "الحسنة", EnglishName = "Al Hasana", GovernorateId = 26 },
                /* End North Sinai ID:26 */

                /* Start Sohag ID:27 */
                new City { Id = 383, ArabicName = "سوهاج", EnglishName = "Sohag", GovernorateId = 27 },
                new City { Id = 384, ArabicName = "سوهاج الجديدة", EnglishName = "Sohag El Gedida", GovernorateId = 27 },
                new City { Id = 385, ArabicName = "أخميم", EnglishName = "Akhmeem", GovernorateId = 27 },
                new City { Id = 386, ArabicName = "أخميم الجديدة", EnglishName = "Akhmim El Gedida", GovernorateId = 27 },
                new City { Id = 387, ArabicName = "البلينا", EnglishName = "Albalina", GovernorateId = 27 },
                new City { Id = 388, ArabicName = "المراغة", EnglishName = "El Maragha", GovernorateId = 27 },
                new City { Id = 389, ArabicName = "المنشأة", EnglishName = "almunsha''a", GovernorateId = 27 },
                new City { Id = 390, ArabicName = "دار السلام", EnglishName = "Dar AISalaam", GovernorateId = 27 },
                new City { Id = 391, ArabicName = "جرجا", EnglishName = "Gerga", GovernorateId = 27 },
                new City { Id = 392, ArabicName = "جهينة الغربية", EnglishName = "Jahina Al Gharbia", GovernorateId = 27 },
                new City { Id = 393, ArabicName = "ساقلته", EnglishName = "Saqilatuh", GovernorateId = 27 },
                new City { Id = 394, ArabicName = "طما", EnglishName = "Tama", GovernorateId = 27 },
                new City { Id = 395, ArabicName = "طهطا", EnglishName = "Tahta", GovernorateId = 27 },
                new City { Id = 396, ArabicName = "الكوثر", EnglishName = "Alkawthar", GovernorateId = 27 }
                /* End Sohag ID:27 */
            );
        }
    }
}
