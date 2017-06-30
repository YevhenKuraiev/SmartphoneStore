using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace SmartphoneStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Acer Aspire ES1-533-C3ZX",
                        Description = "Экран 15.6'' (1366x768) HD, матовый / Intel Celeron N3350 (1.1 - 2.4 ГГц) " +
                        "/ RAM 2 ГБ / HDD 500 ГБ / Intel HD Graphics 500 / без ОД / LAN / Wi-Fi / Bluetooth " +
                        "/ веб-камера / Без ОС / 2.4 кг / черный",
                        Category = "Ноутбуки",
                        Price = 6299
                    },
                    new Product
                    {
                        Name = "Acer Spin 7 SP714-51-M0BK",
                        Description = "Экран 14 IPS(1920x1080) Full HD Multi - touch, матовый / " +
                        "Intel Core i7 - 7Y75(1.3 - 3.6 ГГц) / RAM 8 ГБ / SSD 256 ГБ / Intel HD Graphics 615 " +
                        "/ без ОД / Wi - Fi / Bluetooth 4.0 / веб - камера / Windows 10 Home / 1.2 кг / черный",
                        Category = "Ноутбуки",
                        Price = 37999
                    },
                    new Product
                    {
                        Name = "Sony Xperia Z5 Dual Premium Chrome",
                        Description = "Экран (5.5, IPS, 3840x2160)/ Qualcomm Snapdragon 810 MSM8994(Quad 2 ГГц + Quad 1.5 ГГц) " +
                        "/ основная камера: 23 Мп, фронтальная камера: 5 Мп / RAM 3 ГБ / 32 ГБ встроенной памяти + microSD " +
                        "/ SDHC(до 200 ГБ) / 3G / LTE / GPS / поддержка 2х SIM - карт(Nano - SIM) / Android 5.1(Lollipop) " +
                        "/ 3430 мА * ч",
                        Category = "Смартфоны",
                        Price = 13999
                    },
                    new Product
                    {
                        Name = "Prestigio MultiPhone Muze A7 7530 Duo",
                        Description = "Экран (5.3, IPS, 1280x720)/ MediaTek MT6592m(1.4 ГГц) / основная камера: 13 Мп, " +
                        "фронтальная камера: 5 Мп / RAM 2 ГБ / 16 ГБ встроенной памяти + microSD / SDHC(до 32 ГБ) / 3G / GPS " +
                        "/ поддержка 2х SIM - карт(Mini - SIM) / Android 5.1(Lollipop) / 2500 мА * ч",
                        Category = "Смартфоны",
                        Price = 2999
                    },
                    new Product
                    {
                        Name = "Sony Xperia Z5 Dual Premium Chrome",
                        Description = "Экран (5.5, IPS, 3840x2160)/ Qualcomm Snapdragon 810 MSM8994(Quad 2 ГГц + Quad 1.5 ГГц) " +
                        "/ основная камера: 23 Мп, фронтальная камера: 5 Мп / RAM 3 ГБ / 32 ГБ встроенной памяти + microSD " +
                        "/ SDHC(до 200 ГБ) / 3G / LTE / GPS / поддержка 2х SIM - карт(Nano - SIM) / Android 5.1(Lollipop) " +
                        "/ 3430 мА * ч",
                        Category = "Смартфоны",
                        Price = 13999
                    },
                    new Product
                    {
                        Name = "Prestigio MultiPhone Muze A7 7530 Duo",
                        Description = "Экран (5.3, IPS, 1280x720)/ MediaTek MT6592m(1.4 ГГц) / основная камера: 13 Мп, " +
                        "фронтальная камера: 5 Мп / RAM 2 ГБ / 16 ГБ встроенной памяти + microSD / SDHC(до 32 ГБ) / 3G / GPS " +
                        "/ поддержка 2х SIM - карт(Mini - SIM) / Android 5.1(Lollipop) / 2500 мА * ч",
                        Category = "Смартфоны",
                        Price = 2999
                    },
                    new Product
                    {
                        Name = "Sony Xperia Z5 Dual Premium Chrome",
                        Description = "Экран (5.5, IPS, 3840x2160)/ Qualcomm Snapdragon 810 MSM8994(Quad 2 ГГц + Quad 1.5 ГГц) " +
                        "/ основная камера: 23 Мп, фронтальная камера: 5 Мп / RAM 3 ГБ / 32 ГБ встроенной памяти + microSD " +
                        "/ SDHC(до 200 ГБ) / 3G / LTE / GPS / поддержка 2х SIM - карт(Nano - SIM) / Android 5.1(Lollipop) " +
                        "/ 3430 мА * ч",
                        Category = "Смартфоны",
                        Price = 13999
                    },
                    new Product
                    {
                        Name = "Prestigio MultiPhone Muze A7 7530 Duo",
                        Description = "Экран (5.3, IPS, 1280x720)/ MediaTek MT6592m(1.4 ГГц) / основная камера: 13 Мп, " +
                        "фронтальная камера: 5 Мп / RAM 2 ГБ / 16 ГБ встроенной памяти + microSD / SDHC(до 32 ГБ) / 3G / GPS " +
                        "/ поддержка 2х SIM - карт(Mini - SIM) / Android 5.1(Lollipop) / 2500 мА * ч",
                        Category = "Смартфоны",
                        Price = 2999
                    },
                    new Product
                    {
                        Name = "Everest Home & Office 1030",
                        Description = "Intel Core i3-4170 (3.7 ГГц) / RAM 4 ГБ / HDD 500 ГБ / Intel HD Graphics / DVD+/-RW " +
                        "/ LAN / Кард-ридер / Без ОС",
                        Category = "Компьютеры",
                        Price = 8829
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

