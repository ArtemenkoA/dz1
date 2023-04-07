using dz1;
using System.ComponentModel;
using System;

public enum ChoiceLang { Eng, Rus };

internal class Program
{

    private static void Main(string[] args)
    {
        int Answer()
        {
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }


        var dictionary = new Dictionary<ChoiceLang, string[]>();
        int vibor;
        Random rnd = new Random();
        string[] RussiansStr = new[] {  "Интервьюер интервента интервьюировал",
                                        "Жили-были три китайца: Як, Як - цедрак, Як - цедрак - цедрак - цедрони",
                                        "Рыла свинья белорыла, тупорыла; полдвора рылом изрыла, вырыла, подрыла",
                                        "Скороговорун скороговорил скоровыговаривал, что всех скороговорок не перескороговоришь не перескоровыговариваешь",
                                        "Карл у Клары украл рекламу, а Клара у Карла украла бюджет",
                                        "У рекламы ухватов — швах с охватом, а прихватки и без охвата расхватали",
                                        "Мерчендайзеры соврали — сорван сэмплинг самоваров!",
                                        "Ядро потребителей пиастров — пираты, а пиратов — пираньи",
                                        "Полосу про паласы заменили двумя полуполосами про пылесосы",
                                        "Невелик на ситиборде бодибилдера бицепс",
                                        "Скреативлен креатив не по-креативному, нужно перекреативить!",
                                        "Брейншторм: гам, гром, ор ртов, пир рифм, вдруг — бум! Блеск!",
                                        "Выборка по уборщицам на роллс - ройсах нерепрезентативна",
                                        "В Каннах львы только ленивым венки не вили",
                                        "В Кабардино-Балкарии валокордин из Болгарии",
                                        "Деидеологизировали - деидеологизировали, и додеидеологизировались",
                                        "Их пестициды не перепистицидят наши по своей пестицидности",
                                        "Кокосовары варят в скорококосоварках кокосовый сок",
                                        "Работники предприятие приватизировали - приватизировали, да не выприватизировали",
                                        "Сиреневенькая зубовыковыривательница",
                                        "Флюорографист флюорографировал флюорографистку",
                                        "Стаффордширский терьер ретив, а черношерстный ризеншнауцер резв",
                                        "Волховал волхв в хлеву с волхвами",
                                        "Наш голова вашего голову головой переголовил, перевыголовил",
                                        "Павел Павлушку пеленовал - пеленовал и распелёновывал",
                                        "Рапортовал, да не дорапортовал; дорапортовал, да зарапортовался",
                                        "Не хочет косой косить косой, говорит, коса коса",
                                        "По семеро в сани уселись сами"
        };

            string[] EnglishStr = new[] { "The memory warms you up inside, but it also breaks your soul apart",
                                        "Stretching his hand out to catch the stars, he forgets the flowers at his feet",
                                        "When you start thinking a lot about your past, it becomes your present and you can’t see your future without it",
                                        "Memories take us back, dreams take us forward",
                                        "Be careful with your thoughts. - they are the beginning of deeds",
                                        "Remember that the most dangerous prison is the one in your head",
                                        "Life is what happens while you’re busy making other plans",
                                        "Life is a one time offer, use it well",
                                        "Life begins at the end of your comfort zone",
                                        "Life is short. Smile while you still have teeth",
                                        "Life is a succession of lessons which must be lived to be understood",
                                        "The future belongs to those who believe in their dreams",
                                        "The inevitable price we pay for our happiness is eternal fear to lose it",
                                        "For the world you may be just one person, but for one person you may be the whole world",
                                        "It was love at first sight, at last sight, at ever and ever sight",
                                        "Real beauty lives in the heart, is reflected in the eyes and leads to action",
                                        "Youth is counted sweetest by those who are no longer young",
                                        "To succeed in life, you need two things: ignorance and confidence",
                                        "To live is the rarest thing in the world. Most people exist, that's all",
                                        "Anyone who lives within their means suffers from a lack of imagination",
                                        "Success does not consist in never making mistakes but in never making the same one a second time",
                                        "Either write something worth reading or do something worth writing",
                                        "Your time is limited, so don’t waste it living someone else’s life",
                                        "Build your own dreams, or someone else will hire you to build theirs",
                                        "Success is not the key to happiness. Happiness is the key to success",
                                        "When I do good, I feel good. When I do bad, I feel bad. That’s my religion"
        };
        dictionary.Add(ChoiceLang.Rus, RussiansStr);
        dictionary.Add(ChoiceLang.Eng, EnglishStr);

        //НАЧАЛО РАБОТЫ
        Console.WriteLine("Выбор языка: 0 - английский, 1 - русский");

        int code_lang = Answer();
        ChoiceLang choiceLang = (ChoiceLang)code_lang;

        List<Stroka> Strings = new List<Stroka>();//для хранения статистики по попыткам
        List<int> SpeedWriteTry = new List<int>();//для хранения статистики скорости

        Console.WriteLine("Начать? (да - 1/ нет - 0)");
        
        do
        {
            vibor = Answer();
            if (vibor == 1)
            {

                if (dictionary.ContainsKey(choiceLang))
                {
                    string[] Words = dictionary[choiceLang];
                    string number_str, answer; int count, errors = 0;
                    Console.WriteLine(number_str = Words[count = rnd.Next(0, Words.Length)]);

                    DateTime StartedAT = DateTime.Now;

                    answer = Console.ReadLine();

                    TimeSpan span = DateTime.Now - StartedAT;

                    for (int i = 0; i < answer.Length; i++)
                    {
                        if (answer[i] != number_str[i])
                        {
                            errors++;
                        }
                    }

                    if (answer.Length < number_str.Length)
                    {
                        errors += number_str.Length - answer.Length;
                    }

                    Strings.Add(new(count, span, errors));

                    double min = (double)(span.Seconds);

                    int SpeedWrite = (int)(number_str.Length / min * 60);
                    
                    SpeedWriteTry.Add(SpeedWrite);

                    Console.WriteLine("Время печати: {0}, скорость печати: {1} символов в минуту, количество ошибок: {2}", Strings.Last().Time, SpeedWrite, Strings.Last().Error);
                    Console.WriteLine("Попробовать еще раз? (да - 1/ нет - 0)");
                }
            }
        } while (vibor != 0);
        
        Console.WriteLine("у вас было {0} попыток, средняя скорость - {1} зн/мин, лучшая - {2} зн/мин, худшая {3} зн/мин\r\n", Strings.Count, SpeedWriteTry.Sum() / SpeedWriteTry.Count, SpeedWriteTry.Max(), SpeedWriteTry.Min());
    }
}
