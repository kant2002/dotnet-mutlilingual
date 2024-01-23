using System;
using System.IO;
using System.Text;
using static System.Console;

namespace Система;

public class Консоль
{
    public static bool ВводПеренаправлен => IsInputRedirected;
    public static int ВысотаБуфера { get => BufferHeight; set => BufferHeight = value; }
    public static int ШиринаБуфера { get => BufferWidth; set => BufferWidth = value; }
    public static bool БлокЗагл => CapsLock;
    public static int ЛевоКурсора { get => CursorLeft; set => CursorLeft = value; }
    public static int РазмерКурсора { get => CursorSize; set => CursorSize = value; }
    public static int ВерхКурсора { get => CursorTop; set => CursorTop = value; }
    public static bool КурсорВидим { get => CursorVisible; set => CursorVisible = value; }
    public static TextWriter Ошибка => Error;
    public static ConsoleColor ЦветПереднегоПлана { get => ForegroundColor; set => ForegroundColor = value; }
    public static TextReader Ввод => In;
    public static Encoding КодировкаВвода { get => InputEncoding; set => InputEncoding = value; }
    public static bool ОшибкаПеренаправлена => IsErrorRedirected;
    public static int ШиринаОкна { get => WindowWidth; set => WindowWidth = value; }
    public static bool ВыводПеренаправлен => IsOutputRedirected;
    public static bool КнопкаДоступна => KeyAvailable;
    public static int НаибольшаяВысотаОкна => LargestWindowHeight;
    public static int НаибольшаяШиринаОкна => LargestWindowWidth;
    public static bool БлокЦифр => NumberLock;
    public static TextWriter Вывод => Out;
    public static Encoding КодировкаВывода { get => OutputEncoding; set => OutputEncoding = value; }
    public static string Заголовок { get => Title; set => Title = value; }
    public static bool ОбрабатыватьControlCКакВвод { get => TreatControlCAsInput; set => TreatControlCAsInput = value; }
    public static int ВысотаОкна { get => WindowHeight; set => WindowHeight = value; }
    public static int ЛевоОкна { get => WindowLeft; set => WindowLeft = value; }
    public static int ВерхОкна { get => WindowTop; set => WindowTop = value; }
    public static ConsoleColor ФоновыйЦвет { get => BackgroundColor; set => BackgroundColor = value; }

    public static event ConsoleCancelEventHandler КнопкаОтменыНажата
    {
        add { CancelKeyPress += value; }
        remove { CancelKeyPress -= value; }
    }

    public static void Гудок() => Beep();
    public static void Гудок(int частота, int длительность) => Beep(частота, длительность);
    public static void Очистить() => Clear();
    public static void ПереместитьОбластьБуфера(int источникЛево, int источникВерх, int источникШирина, int источникВысота, int получательЛево, int получательВерх) => MoveBufferArea(источникЛево, источникВерх, источникШирина, источникВысота, получательЛево, получательВерх);
    public static void ПереместитьОбластьБуфера(int источникЛево, int источникВерх, int источникШирина, int источникВысота, int получательЛево, int получательВерх, char источникСимвол, ConsoleColor источникПередЦвет, ConsoleColor источникФонЦвет) => MoveBufferArea(источникЛево, источникВерх, источникШирина, источникВысота, получательЛево, получательВерх, источникСимвол, источникПередЦвет, источникФонЦвет);

    public static Stream ОткрытьСтандартнуюОшибку(int размерБуфера) => OpenStandardError(размерБуфера);
    public static Stream ОткрытьСтандартнуюОшибку() => OpenStandardError();
    public static Stream ОткрытьСтандартныйВвод(int размерБуфера) => OpenStandardInput(размерБуфера);
    public static Stream ОткрытьСтандартныйВвод() => OpenStandardInput();
    public static Stream ОткрытьСтандартныйВывод(int размерБуфера) => OpenStandardOutput(размерБуфера);
    public static Stream ОткрытьСтандартныйВывод() => OpenStandardOutput();
    public static int Прочитать() => Read();
    public static ConsoleKeyInfo ПрочитатьКнопку(bool перехватить) => ReadKey(перехватить);
    public static ConsoleKeyInfo ПрочитатьКнопку() => ReadKey();
    public static string ПрочитатьСтроку() => ReadLine();
    public static void СброситьЦвет() => ResetColor();
    public static void УстановитьРазмерБуфера(int ширина, int высота) => SetBufferSize(ширина, высота);
    public static void УстановитьПозициюКурсора(int лево, int верх) => SetCursorPosition(лево, верх);
    public static void УстановитьОшибку(TextWriter newError) => SetError(newError);
    public static void УстановитьВвод(TextReader newIn) => SetIn(newIn);
    public static void УстановитьВывод(TextWriter newOut) => SetOut(newOut);
    public static void УстановитьПозициюОкна(int лево, int верх) => SetWindowPosition(лево, верх);
    public static void УстановитьРазмерОкна(int ширина, int высота) => SetWindowSize(ширина, высота);
    public static void Написать(ulong значение) => Write(значение);
    public static void Написать(bool значение) => Write(значение);
    public static void Написать(char значение) => Write(значение);
    public static void Написать(char[] буфер) => Write(буфер);
    public static void Написать(char[] буфер, int индекс, int количество) => Write(буфер, индекс, количество);
    public static void Написать(double значение) => Write(значение);
    public static void Написать(long значение) => Write(значение);
    public static void Написать(object значение) => Write(значение);
    public static void Написать(float значение) => Write(значение);
    public static void Написать(string значение) => Write(значение);
    public static void Написать(string формат, object арг0) => Write(формат, арг0);
    public static void Написать(string формат, object арг0, object арг1) => Write(формат, арг0, арг1);
    public static void Написать(string формат, object арг0, object арг1, object арг2) => Write(формат, арг0, арг1, арг2);
    public static void Написать(string формат, params object[] арг) => Write(формат, арг);
    public static void Написать(uint значение) => Write(значение);
    public static void Написать(decimal значение) => Write(значение);
    public static void Написать(int значение) => Write(значение);
    public static void НаписатьЛинию(ulong значение) => WriteLine(значение);
    public static void НаписатьЛинию(string формат, params object[] арг) => WriteLine(формат, арг);
    public static void НаписатьЛинию() => WriteLine();
    public static void НаписатьЛинию(bool значение) => WriteLine(значение);
    public static void НаписатьЛинию(char[] буфер) => WriteLine(буфер);
    public static void НаписатьЛинию(char[] буфер, int индекс, int количество) => WriteLine(буфер, индекс, количество);
    public static void НаписатьЛинию(decimal значение) => WriteLine(значение);
    public static void НаписатьЛинию(double значение) => WriteLine(значение);
    public static void НаписатьЛинию(uint значение) => WriteLine(значение);
    public static void НаписатьЛинию(int значение) => WriteLine(значение);
    public static void НаписатьЛинию(object значение) => WriteLine(значение);
    public static void НаписатьЛинию(float значение) => WriteLine(значение);
    public static void НаписатьЛинию(string значение) => WriteLine(значение);
    public static void НаписатьЛинию(string формат, object арг0) => WriteLine(формат, арг0);
    public static void НаписатьЛинию(string формат, object арг0, object арг1) => WriteLine(формат, арг0, арг1);
    public static void НаписатьЛинию(string формат, object арг0, object арг1, object арг2) => WriteLine(формат, арг0, арг1, арг2);
    public static void НаписатьЛинию(long значение) => WriteLine(значение);
    public static void НаписатьЛинию(char значение) => WriteLine(значение);
}
