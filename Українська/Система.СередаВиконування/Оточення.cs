using System;
using System.Collections;
using static System.Environment;

namespace Система;

public static class Оточення
{
    public static int КодВиходу { get => ExitCode; set => ExitCode = value; }
    public static bool Є64БітнимПроцесом => Is64BitProcess;
    public static int ПоточнийИдКерованогоПотока => CurrentManagedThreadId;
    public static string ПоточнаДіректорія { get => CurrentDirectory; set => CurrentDirectory = value; }
    public static string КоманднийРядок => CommandLine;
    public static string ІмяМашини => MachineName;
    public static string НовийРядок => NewLine;
    public static OperatingSystem ВерсіяОС => OSVersion;
    public static int КількістьПроцесорів => ProcessorCount;
    public static string ТрасіровкаСтека => StackTrace;
    public static string СистемнаДіректорія => SystemDirectory;
    public static int РозмірСистемноїСторінки => SystemPageSize;
    public static int КількістьТіків => TickCount;
    public static string ІмяКористувачаДомену => UserDomainName;
    public static bool КористувачІнтерактивний => UserInteractive;
    public static string ІмяКористувача => UserName;
    public static Version Версія => Environment.Version;
    public static long РобочийНабір => WorkingSet;
    public static bool ВиключенняПочалося => HasShutdownStarted;
    public static bool Є64БітноїОпераційноюСистемою => Is64BitOperatingSystem;
    public static void Вихід(int кодВиходу) => Exit(кодВиходу);
    public static string ExpandEnvironmentVariables(string name) => ExpandEnvironmentVariables(name);
    public static void FailFast(string message, Exception exception) => FailFast(message, exception);
    public static void FailFast(string message) => FailFast(message);
    public static string[] ОтриматиАргументиКомандногоРядка() => GetCommandLineArgs();
    public static string ОтриматиЗміннуОточення(string змінна, EnvironmentVariableTarget ціль) => GetEnvironmentVariable(змінна, ціль);
    public static string ОтриматиЗміннуОточення(string змінна) => GetEnvironmentVariable(змінна);
    public static IDictionary ОтриматиЗмінниОточення(EnvironmentVariableTarget ціль) => GetEnvironmentVariables(ціль);
    public static IDictionary ОтриматиЗмінниОточення() => GetEnvironmentVariables();
    public static string ОтриматиШляхПапки(СпеціальнаПапка папка, ПараметриСпеціальноїПапки option) => GetFolderPath((SpecialFolder)(int)папка, (SpecialFolderOption)(int)option);
    public static string ОтриматиШляхПапки(СпеціальнаПапка папка) => GetFolderPath((SpecialFolder)(int)папка);
    public static string[] ОтриматиЛогічніДиски() => GetLogicalDrives();
    public static void ВстановитиЗміннуОточення(string змінна, string значення, EnvironmentVariableTarget ціль) => SetEnvironmentVariable(змінна, значення, ціль);
    public static void ВстановитиЗміннуОточення(string змінна, string значення) => SetEnvironmentVariable(змінна, значення);

    public enum СпеціальнаПапка
    {
        РобочийСтіл = 0,
        Програми = 2,
        МоїДокументи = 5,
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
    public enum ПараметриСпеціальноїПапки
    {
        Ніяких = 0,
        НеПеревіряти = 16384,
        Створити = 32768
    }
}
