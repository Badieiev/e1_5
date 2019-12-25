using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_5
{
    //    Разработать объектно-ориентированную модель игры в футбол.

    //1 этап.
    //- создать класс Футболист
    //- создать класс Команда
    //- создать класс Игра
    //- продемонстрировать работоспособность модели
    //Класс Футболист:
    //Поля;
    //- фамилия футболиста
    //- возраст футболиста
    //- уровень мастерства(целое число от 0 до 100, определяется случайным образом)
    //Класс Команда;
    //    Поля:
    //- название команды
    //- список футболистов
    //- командный уровень мастерства(сумма уровней футболистов)
    //Метод;
    //- добавить ОДНОГО футболиста в команду
    //Класс Игра:
    //Поля:
    //- первая команда
    //- вторая команда
    //Методы:
    //- получить результат игры(выигрывает та команда, у которой выше командный уровень
    //мастерства. Если они отличаются не более, чем на 10%, результат игры ничья).

    //    2 этап.Дополнить модель следующими классами и методами
    //Класс Тренер:
    //Поля:
    //- фамилия тренера
    //- уровень везучести(вещественное число от 0.5 до 1.5, определяется случайным образом)
    //Внести изменения в класс Команда
    //Класс Команда;
    //Поля:
    //- название команды
    //- список футболистов
    //- тренер
    //- командный уровень мастерства(сумма уровней футболистов, умноженная на
    //уровень везучести тренера)
    //Методы;
    //- добавить футболиста
    //- вывести список всех игроков по алфавиту(использовать LINQ)
    //- вывести список всех игроков старше 30 лет по убыванию уровня их мастерства
    //(использовать LINQ)

    //3 этап.Дополнить модель следующими классами и методами
    //Класс Судья;
    //    Поля;
    //-фамилия судьи
    //- предпочтения судьи(0 – нейтральный, 1 – подсуживает первой команде, 2 – подсуживает
    //второй)
    //Внести изменения в класс Игра
    //Класс Игра:
    //Поля;
    //- первая команда
    //- вторая команда
    //- судья
    //Методы:
    //- получить результат игры

    //4 этап.Дополнить модель событиями
    //Класс Игра:
    //События:
    //- нарушение правил
    //- гол
    //Методы:
    //- игра началась
    //Дополнить класс Судья методами, обрабатывающими эти события

    //5 этап
    //Создать собственный класс “Исключительная ситуация во время игры”
    //Сгенерировать эту исключительную ситуацию в методе «Игра началась» и обработать ее.

    //6 этап(творческий)
    //Дополнить модель новыми классами и(или) усовершенствовать уже разработанные
    //классы, путем добавления новых полей, методов, событий и так далее.
    class Program
    {
        static void Main(string[] args)
        {

            Team Dnipro = new Team();
            Dnipro.AddPlayee(new Player("V", 29));
            Dnipro.AddPlayee(new Player("S", 28));
            Dnipro.AddPlayee(new Player("X", 27));
            Dnipro.AddPlayee(new Player("Z", 26));

            Team Zoria = new Team();
            Zoria.AddPlayee(new Player("V", 29));
            Zoria.AddPlayee(new Player("S", 28));
            Zoria.AddPlayee(new Player("X", 27));
            Zoria.AddPlayee(new Player("Z", 26));

            Game game = new Game(Dnipro, Zoria);
            game.Сomparison2Teams(Dnipro, Zoria);
            Console.ReadKey();

        }
    }
}