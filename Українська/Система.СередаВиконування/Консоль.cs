using System;
using System.IO;
using System.Text;
using static System.Console;

namespace Система;

public class Консоль
{
    public static bool ВхідПеренаправлен => IsInputRedirected;
    public static int ВисотаБуфера { get => BufferHeight; set => BufferHeight = value; }
    public static int ШиринаБуфера { get => BufferWidth; set => BufferWidth = value; }
    public static bool БлокЗагол => CapsLock;
    public static int ЛівоКурсора { get => CursorLeft; set => CursorLeft = value; }
    public static int РозмірКурсора { get => CursorSize; set => CursorSize = value; }
    public static int ВерхКурсора { get => CursorTop; set => CursorTop = value; }
    public static bool КурсорВидим { get => CursorVisible; set => CursorVisible = value; }
    public static TextWriter Помилка => Error;
    public static ConsoleColor КолірПередньгоФону { get => ForegroundColor; set => ForegroundColor = value; }
    public static TextReader Вхід => In;
    public static Encoding КодировкаВходу { get => InputEncoding; set => InputEncoding = value; }
    public static bool ПомилкаПеренаправлена => IsErrorRedirected;
    public static int ШиринаВікна { get => WindowWidth; set => WindowWidth = value; }
    public static bool ВивідПеренаправлен => IsOutputRedirected;
    public static bool КнопкаДоступна => KeyAvailable;
    public static int НайбільшаВисотаВікна => LargestWindowHeight;
    public static int НайбільшаШиринаВікна => LargestWindowWidth;
    public static bool БлокЦифр => NumberLock;
    public static TextWriter Вивід => Out;
    public static Encoding КодировкаВиводу { get => OutputEncoding; set => OutputEncoding = value; }
    public static string Заголовок { get => Title; set => Title = value; }
    public static bool ОброблятиControlCЯкВхід { get => TreatControlCAsInput; set => TreatControlCAsInput = value; }
    public static int ВисотаВікна { get => WindowHeight; set => WindowHeight = value; }
    public static int ЛівоВікна { get => WindowLeft; set => WindowLeft = value; }
    public static int ВерхВікна { get => WindowTop; set => WindowTop = value; }
    public static ConsoleColor ФоновийКолір { get => BackgroundColor; set => BackgroundColor = value; }

    public static event ConsoleCancelEventHandler КнопкаВідміниНатиснена
    {
        add { CancelKeyPress += value; }
        remove { CancelKeyPress -= value; }
    }

    public static void Гудок() => Beep();
    public static void Гудок(int частота, int тривалість) => Beep(частота, тривалість);
    public static void Очистити() => Clear();
    public static void ПереміститиОбластьБуфера(int джерелоЛіво, int джерелоВерх, int джерелоШиріна, int джерелоВисота, int одержувачЛіво, int одержувачВерх) => MoveBufferArea(джерелоЛіво, джерелоВерх, джерелоШиріна, джерелоВисота, одержувачЛіво, одержувачВерх);
    public static void ПереміститиОбластьБуфера(int джерелоЛіво, int джерелоВерх, int джерелоШиріна, int джерелоВисота, int одержувачЛіво, int одержувачВерх, char джерелоСимвол, ConsoleColor джерелоПередКолір, ConsoleColor джерелоФонКолір) => MoveBufferArea(джерелоЛіво, джерелоВерх, джерелоШиріна, джерелоВисота, одержувачЛіво, одержувачВерх, джерелоСимвол, джерелоПередКолір, джерелоФонКолір);

    public static Stream ВідкритиСтандартнуПомилку(int розмірБуфера) => OpenStandardError(розмірБуфера);
    public static Stream ВідкритиСтандартнуПомилку() => OpenStandardError();
    public static Stream ВідкритиСтандартнийВхід(int розмірБуфера) => OpenStandardInput(розмірБуфера);
    public static Stream ВідкритиСтандартнийВхід() => OpenStandardInput();
    public static Stream ВідкритиСтандартнийВихід(int розмірБуфера) => OpenStandardOutput(розмірБуфера);
    public static Stream ВідкритиСтандартнийВихід() => OpenStandardOutput();
    public static int Прочитати() => Read();
    public static ConsoleKeyInfo ПрочитатиКнопку(bool перехватить) => ReadKey(перехватить);
    public static ConsoleKeyInfo ПрочитатиКнопку() => ReadKey();
    public static string ПрочитатиРядок() => ReadLine();
    public static void СброситиКолір() => ResetColor();
    public static void ВстановитиРозмірБуфера(int ширина, int висота) => SetBufferSize(ширина, висота);
    public static void ВстановитиПозиціюКурсора(int ліво, int верх) => SetCursorPosition(ліво, верх);
    public static void ВстановитиПомилку(TextWriter newError) => SetError(newError);
    public static void ВстановитиВхід(TextReader newIn) => SetIn(newIn);
    public static void ВстановитиВихід(TextWriter newOut) => SetOut(newOut);
    public static void ВстановитиПозиціюВікна(int ліво, int верх) => SetWindowPosition(ліво, верх);
    public static void ВстановитиРазмірВікна(int ширина, int висота) => SetWindowSize(ширина, висота);
    public static void Написати(ulong значення) => Write(значення);
    public static void Написати(bool значення) => Write(значення);
    public static void Написати(char значення) => Write(значення);
    public static void Написати(char[] буфер) => Write(буфер);
    public static void Написати(char[] буфер, int індекс, int количество) => Write(буфер, індекс, количество);
    public static void Написати(double значення) => Write(значення);
    public static void Написати(long значення) => Write(значення);
    public static void Написати(object значення) => Write(значення);
    public static void Написати(float значення) => Write(значення);
    public static void Написати(string значення) => Write(значення);
    public static void Написати(string формат, object арг0) => Write(формат, арг0);
    public static void Написати(string формат, object арг0, object арг1) => Write(формат, арг0, арг1);
    public static void Написати(string формат, object арг0, object арг1, object арг2) => Write(формат, арг0, арг1, арг2);
    public static void Написати(string формат, params object[] арг) => Write(формат, арг);
    public static void Написати(uint значення) => Write(значення);
    public static void Написати(decimal значення) => Write(значення);
    public static void Написати(int значення) => Write(значення);
    public static void НаписатиРядок(ulong значення) => WriteLine(значення);
    public static void НаписатиРядок(string формат, params object[] арг) => WriteLine(формат, арг);
    public static void НаписатиРядок() => WriteLine();
    public static void НаписатиРядок(bool значення) => WriteLine(значення);
    public static void НаписатиРядок(char[] буфер) => WriteLine(буфер);
    public static void НаписатиРядок(char[] буфер, int индекс, int количество) => WriteLine(буфер, индекс, количество);
    public static void НаписатиРядок(decimal значення) => WriteLine(значення);
    public static void НаписатиРядок(double значення) => WriteLine(значення);
    public static void НаписатиРядок(uint значення) => WriteLine(значення);
    public static void НаписатиРядок(int значення) => WriteLine(значення);
    public static void НаписатиРядок(object значення) => WriteLine(значення);
    public static void НаписатиРядок(float значення) => WriteLine(значення);
    public static void НаписатиРядок(string значення) => WriteLine(значення);
    public static void НаписатиРядок(string формат, object арг0) => WriteLine(формат, арг0);
    public static void НаписатиРядок(string формат, object арг0, object арг1) => WriteLine(формат, арг0, арг1);
    public static void НаписатиРядок(string формат, object арг0, object арг1, object арг2) => WriteLine(формат, арг0, арг1, арг2);
    public static void НаписатиРядок(long значення) => WriteLine(значення);
    public static void НаписатиРядок(char значення) => WriteLine(значення);
}
