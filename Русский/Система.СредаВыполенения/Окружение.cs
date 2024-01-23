using System;
using System.Collections;
using static System.Environment;

namespace Система;

public static class Окружение
{
    public static int КодВыхода { get => ExitCode; set => ExitCode = value; }
    public static bool Есть64БитнимПроцессом => Is64BitProcess;
    public static int ТекущийИдУправляемогоПотока => CurrentManagedThreadId;
    public static string ТекущаяДиректория { get => CurrentDirectory; set => CurrentDirectory = value; }
    public static string КоманднаяСтрока => CommandLine;
    public static string ИмяМашины => MachineName;
    public static string НоваяСтрока => NewLine;
    public static OperatingSystem ВерсияОС => OSVersion;
    public static int КоличествоПроцессоров => ProcessorCount;
    public static string ТрассировкаСтека => StackTrace;
    public static string СистемнаяДиректория => SystemDirectory;
    public static int РазмерСистемнойСтраницы => SystemPageSize;
    public static int КоличествоТиков => TickCount;
    public static string ИмяПользователяДомена => UserDomainName;
    public static bool ИнтерактивныйПользователь => UserInteractive;
    public static string ИмяПользователя => UserName;
    public static Version Версия => Environment.Version;
    public static long РабочийНабор => WorkingSet;
    public static bool ВыключениеНачалось => HasShutdownStarted;
    public static bool Есть64БитнойОперационноюСистемой => Is64BitOperatingSystem;
    public static void Выход(int кодВыходу) => Exit(кодВыходу);
    public static string РазвернутьПеременныеОкружения(string имя) => ExpandEnvironmentVariables(имя);
    public static void УпастьБыстро(string сообщение, Exception исключение) => FailFast(сообщение, исключение);
    public static void УпастьБыстро(string сообщение) => FailFast(сообщение);
    public static string[] ПолучитьАргументиКомандногоРядка() => GetCommandLineArgs();
    public static string ПолучитьПеременнуюОкружения(string переменная, EnvironmentVariableTarget цель) => GetEnvironmentVariable(переменная, цель);
    public static string ПолучитьПеременнуюОкружения(string переменная) => GetEnvironmentVariable(переменная);
    public static IDictionary ПолучитьПеременныеОкружения(EnvironmentVariableTarget цель) => GetEnvironmentVariables(цель);
    public static IDictionary ПолучитьПеременныеОкружения() => GetEnvironmentVariables();
    public static string ПолучитьПутьПапки(СпециальнаяПапка папка, ПараметрыСпециальнойПапки option) => GetFolderPath((SpecialFolder)(int)папка, (SpecialFolderOption)(int)option);
    public static string ПолучитьПутьПапки(СпециальнаяПапка папка) => GetFolderPath((SpecialFolder)(int)папка);
    public static string[] ПолучитьЛогическиеДиски() => GetLogicalDrives();
    public static void ВстановитиПеременнуюОкружения(string переменная, string значение, EnvironmentVariableTarget цель) => SetEnvironmentVariable(переменная, значение, цель);
    public static void ВстановитиПеременнуюОкружения(string переменная, string значение) => SetEnvironmentVariable(переменная, значение);

    public enum СпециальнаяПапка
    {
        РобочийСтол = 0,
        Программы = 2,
        МоиДокументы = 5,
        Personal = 5,
        Favorites = 6,
        Startup = 7,
        Recent = 8,
        SendTo = 9,
        StartMenu = 11,
        MyMusic = 13,
        MyVideos = 14,
        DesktopDirectory = 16,
        MyComputer = 17,
        NetworkShortcuts = 19,
        Fonts = 20,
        Templates = 21,
        CommonStartMenu = 22,
        CommonPrograms = 23,
        CommonStartup = 24,
        CommonDesktopDirectory = 25,
        ApplicationData = 26,
        PrinterShortcuts = 27,
        LocalApplicationData = 28,
        InternetCache = 32,
        Cookies = 33,
        History = 34,
        CommonApplicationData = 35,
        System = 37,
        ProgramFiles = 38,
        MyPictures = 39,
        UserProfile = 40,
        SystemX86 = 41,
        ProgramFilesX86 = 42,
        CommonProgramFiles = 43,
        CommonProgramFilesX86 = 44,
        CommonTemplates = 45,
        CommonDocuments = 46,
        CommonAdminTools = 47,
        AdminTools = 48,
        CommonMusic = 53,
        CommonPictures = 54,
        CommonVideos = 55,
        Resources = 56,
        LocalizedResources = 57,
        CommonOemLinks = 58,
        CDBurning = 59
    }
    public enum ПараметрыСпециальнойПапки
    {
        Никаких = 0,
        НеПроверять = 16384,
        Создать = 32768
    }
}
