using Mazeed.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Seeders
{
    public static class GovernorateSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Governorate>().HasData(
                new Governorate { Id = 1, ArabicName = "القاهرة", EnglishName = "Cairo", ProvinceId = 1 },
                new Governorate { Id = 2, ArabicName = "الجيزة", EnglishName = "Giza", ProvinceId = 1 },
                new Governorate { Id = 3, ArabicName = "الأسكندرية", EnglishName = "Alexandria", ProvinceId = 2 },
                new Governorate { Id = 4, ArabicName = "الدقهلية", EnglishName = "Dakahlia", ProvinceId = 3 },
                new Governorate { Id = 5, ArabicName = "البحر الأحمر", EnglishName = "Red Sea", ProvinceId = 6 },
                new Governorate { Id = 6, ArabicName = "البحيرة", EnglishName = "Beheira", ProvinceId = 2 },
                new Governorate { Id = 7, ArabicName = "الفيوم", EnglishName = "Fayoum", ProvinceId = 5 },

                new Governorate { Id = 8, ArabicName = "الغربية", EnglishName = "Gharbiya", ProvinceId = 3 },
                new Governorate { Id = 9, ArabicName = "الإسماعلية", EnglishName = "Ismailia", ProvinceId = 4 },
                new Governorate { Id = 10, ArabicName = "المنوفية", EnglishName = "Menofia", ProvinceId = 3 },
                new Governorate { Id = 11, ArabicName = "المنيا", EnglishName = "Minya", ProvinceId = 5 },
                new Governorate { Id = 12, ArabicName = "القليوبية", EnglishName = "Qaliubiya", ProvinceId = 1 },
                new Governorate { Id = 13, ArabicName = "الوادي الجديد", EnglishName = "New Valley", ProvinceId = 6 },

                new Governorate { Id = 14, ArabicName = "السويس", EnglishName = "Suez", ProvinceId = 4 },
                new Governorate { Id = 15, ArabicName = "شمال سيناء", EnglishName = "North Sinai", ProvinceId = 4 },
                new Governorate { Id = 16, ArabicName = "جنوب سيناء", EnglishName = "South Sinai", ProvinceId = 4 },
                new Governorate { Id = 17, ArabicName = "بني سويف", EnglishName = "Beni Suef", ProvinceId = 5 },
                new Governorate { Id = 18, ArabicName = "بورسعيد", EnglishName = "Port Said", ProvinceId = 6 },
                new Governorate { Id = 19, ArabicName = "دمياط", EnglishName = "Damietta", ProvinceId = 3 },

                new Governorate { Id = 20, ArabicName = "الشرقية", EnglishName = "Sharkia", ProvinceId = 4 },
                new Governorate { Id = 21, ArabicName = "جنوب سيناء", EnglishName = "South Sinai", ProvinceId = 4 },
                new Governorate { Id = 22, ArabicName = "كفر الشيخ", EnglishName = "Kafr Al Sheikh", ProvinceId = 3 },
                new Governorate { Id = 23, ArabicName = "مطروح", EnglishName = "Matrouh", ProvinceId = 2 },
                new Governorate { Id = 24, ArabicName = "الأقصر", EnglishName = "Luxor", ProvinceId = 7 },
                new Governorate { Id = 25, ArabicName = "قنا", EnglishName = "Qena", ProvinceId = 7 },
                new Governorate { Id = 26, ArabicName = "شمال سيناء", EnglishName = "North Sinai", ProvinceId = 4 },
                new Governorate { Id = 27, ArabicName = "سوهاج", EnglishName = "Sohag", ProvinceId = 7 }
            );
        }
    }
}
