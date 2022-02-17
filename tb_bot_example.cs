using System;
using System.Collections.Generic;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram_BOT
{
    class Program
    {
        private static string token { get; set; } = "token is string from FATHER-bot.";
        private static TelegramBotClient client;

        static void Main(string[] args)
        {
            client = new TelegramBotClient(token);
            client.StartReceiving();
            client.OnMessage += OnMessageHandler;
            Console.ReadLine();
            client.StopReceiving();
        }

        private static  async void OnMessageHandler(object sender, MessageEventArgs e)
        {
            var msg = e.Message;
            Console.WriteLine(e.Message.Text);
            if (msg.Text =="/start"){
                await client.SendStickerAsync(msg.Chat.Id, "https://tlgrm.ru/_/stickers/fbe/c69/fbec698e-1224-4da3-b399-8d09cc6ce38e/1.webp");
                await client.SendTextMessageAsync(msg.Chat.Id, msg.Text, replyMarkup: GetButtons_main_menu());
            }
            else
            {
                switch (msg.Text)
                {
                    case "Team of Dev.": await client.SendTextMessageAsync(msg.Chat.Id,"Воть", replyMarkup: GetButtons_Dev()); break;
                    case "Lection&Exercises": await client.SendTextMessageAsync(msg.Chat.Id,"Воть", replyMarkup: GetButtons_Lec()); break;
                    case "Технології программування": await client.SendTextMessageAsync(msg.Chat.Id, "Воть", replyMarkup: GetButtons_Tech()); break;
                    case "Основи функціонування комп'ютерів": await client.SendTextMessageAsync(msg.Chat.Id, "Воть", replyMarkup: GetButtons_Func()); break;
                    case "Дискретна математика": await client.SendTextMessageAsync(msg.Chat.Id, "Воть", replyMarkup: GetButtons_01Math()); break;
                    case "Вища математика": await client.SendTextMessageAsync(msg.Chat.Id, "Воть", replyMarkup: GetButtons_BMath()); break;
                    case "Назад": await client.SendTextMessageAsync(msg.Chat.Id, "Воть", replyMarkup: GetButtons_main_menu()); break;
                    //Технологии программирования
                    case "Введение в С":await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/Znakomstvo-s-yazykom-programmirovaniya-C-11-26");break;
                    case "Препроцессор в С": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/Preprocessor-v-C-12-15"); break;
                    case "Структуры в С": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/Struktury-v-S-12-15"); break;
                    case "Указатели в С": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/Ukazateli-v-S-12-15"); break;
                    case "Файлы в С": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/Fajly-v-S-12-15"); break;
                    case "Функции в С": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/Funkcii-v-S-12-15"); break;
                    //ОФК
                    case "Арифметика": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/Arifmetika-12-15"); break;
                    case "Архитектура ПК": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/Arhitektura-PK-12-15"); break;
                    case "Кодирование": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/Kodirovanie-informacii-12-15"); break;
                    case "Перефирийные устройства ПК": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/Periferijnye-ustrojstva-PK-12-155"); break;
                    case "Системы счисления": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/Sistemy-schisleniya-12-15"); break;
                    case "Структура ПК": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/Struktura-PK-12-15"); break;
                    //Вышка
                    case "Векторная алгребра": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/Vektornaya-algebra-12-16"); break;
                    case "Лимиты": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/Predely-12-16"); break;
                    case "Линейная алгебра": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/Linejnaya-algebra-12-16"); break;
                    case "Производные": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/Proizvodnaya-12-16"); break;
                    case "Неопределённый интеграл": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/Neopredelyonnyj-integral-12-16"); break;
                    case "Определённый интеграл": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/Opredelyonnyj-integral-12-16"); break;
                    //Дискретка
                    case "Высказывания и предикаты": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/LOGIKA-VYSKAZYVANIJ-i-LOGIKA-PREDIKATOV-12-16"); break;
                    case "Комбинаторика": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/KOMBINATORIKA-12-16"); break;
                    case "Теория автоматов": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/TEORIYA-AVTOMATOV-12-16"); break;
                    case "Теория булевых функций": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/TEORIYA-BULEVYH-FUNKCIJ-12-16"); break;
                    case "Теория графов": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/TEORIYA-GRAFOV-12-16"); break;
                    case "Теория множеств": await client.SendTextMessageAsync(msg.Chat.Id, "https://telegra.ph/TEORIYA-MNOZHESTV-12-16"); break;
                    default:break;
                }
            }
        }
        private static IReplyMarkup GetButtons_main_menu()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{new KeyboardButton { Text="Team of Dev."},new KeyboardButton {Text="Lection&Exercises"} },
                }
            };
        }
        
        private static IReplyMarkup GetButtons_Dev()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard=new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{new KeyboardButton { Text="Oleynikov_E_E"},new KeyboardButton { Text = "Serov_S_Y" },new KeyboardButton {Text="Derzhin_K_O"}, new KeyboardButton { Text = "Назад" } }
                }
            };
        }
        private static IReplyMarkup GetButtons_Lec()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard=new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{new KeyboardButton { Text="Технології программування"},new KeyboardButton { Text="Основи функціонування комп'ютерів"} },
                    new List<KeyboardButton>{new KeyboardButton { Text="Дискретна математика"},new KeyboardButton { Text="Вища математика"},new KeyboardButton { Text = "Назад" } }
                }
            };
        }

        private static IReplyMarkup GetButtons_Tech()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{new KeyboardButton { Text="Введение в С"},new KeyboardButton { Text="Препроцессор в С"}, new KeyboardButton { Text="Функции в С"} },
                    new List<KeyboardButton>{new KeyboardButton { Text="Указатели в С"},new KeyboardButton { Text="Структуры в С"},new KeyboardButton { Text="Файлы в С"},new KeyboardButton { Text = "Назад" } }
                }
            };
        }
        private static IReplyMarkup GetButtons_Func()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{new KeyboardButton { Text="Арифметика"},new KeyboardButton { Text="Архитектура ПК"}, new KeyboardButton { Text="Кодирование"} },
                    new List<KeyboardButton>{new KeyboardButton { Text="Перефирийные устройства ПК"},new KeyboardButton { Text="Системы счисления"},new KeyboardButton { Text="Структура ПК"}, new KeyboardButton { Text = "Назад" } }
                }
            };
        }
        private static IReplyMarkup GetButtons_01Math()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{new KeyboardButton { Text= "Высказывания и предикаты" },new KeyboardButton { Text= "Комбинаторика" }, new KeyboardButton { Text= "Теория автоматов" } },
                    new List<KeyboardButton>{new KeyboardButton { Text= "Теория булевых функций" },new KeyboardButton { Text= "Теория графов" },new KeyboardButton { Text= "Теория множеств" }, new KeyboardButton { Text = "Назад" } }
                }
            };
        }
        private static IReplyMarkup GetButtons_BMath()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{new KeyboardButton { Text="Векторная алгребра"},new KeyboardButton { Text="Лимиты"}, new KeyboardButton { Text="Линейная алгебра"} },
                    new List<KeyboardButton>{new KeyboardButton { Text="Производные"},new KeyboardButton { Text="Неопределённый интеграл"},new KeyboardButton { Text="Определённый интеграл"}, new KeyboardButton { Text = "Назад" } }
                }
            };
        }
    }
}
