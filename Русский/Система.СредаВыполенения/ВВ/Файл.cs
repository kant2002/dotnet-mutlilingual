﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Система.ВВ;

public static class Файл
{
	public static void ДобавитьВсеЛинии(string путь, IEnumerable<string> содержимое) => File.AppendAllLines(путь, содержимое);
	public static void ДобавитьВсеЛинии(string путь, IEnumerable<string> содержимое, Encoding кодировка) => File.AppendAllLines(путь, содержимое, кодировка);
	public static void ДобавитьВесьТекст(string путь, string содержимое) => File.AppendAllText(путь, содержимое);
	public static void ДобавитьВесьТекст(string путь, string содержимое, Encoding кодировка) => File.AppendAllText(путь, содержимое, кодировка);
	public static StreamWriter ДобавитьТекст(string путь) => File.AppendText(путь);
	public static void Скопировать(string имяИсходногоФайла, string имяФайлаНазнач) => File.Copy(имяИсходногоФайла, имяФайлаНазнач);
	public static void Скопировать(string имяИсходногоФайла, string имяФайлаНазнач, bool перезаписать) => File.Copy(имяИсходногоФайла, имяФайлаНазнач, перезаписать);
	public static FileStream Создать(string путь) => File.Create(путь);
	public static FileStream Создать(string путь, int размерБуфера) => File.Create(путь, размерБуфера);
	public static FileStream Создать(string путь, int размерБуфера, FileOptions опции) => File.Create(путь, размерБуфера, опции);
	public static StreamWriter СоздатьТекст(string путь) => File.CreateText(путь);
	public static void Расшифровать(string путь) => File.Decrypt(путь);
	public static void Удалить(string путь) => File.Delete(путь);
	public static void Зашифровать(string путь) => File.Encrypt(путь);
	public static bool Существует(string путь) => File.Exists(путь);
	public static FileAttributes ПолучитьАтрибуты(string путь) => File.GetAttributes(путь);
	public static DateTime ПолучитьВремяСоздания(string путь) => File.GetCreationTime(путь);
	public static DateTime ПолучитьВремяСозданияUtc(string путь) => File.GetCreationTimeUtc(путь);
	public static DateTime ПолучитьВремяПоследнегоДоступа(string путь) => File.GetLastAccessTime(путь);
	public static DateTime ПолучитьВремяПоследнегоДоступаUtc(string путь) => File.GetLastAccessTimeUtc(путь);
	public static DateTime ПолучитьВремяПоследнейЗаписи(string путь) => File.GetLastWriteTime(путь);
	public static DateTime ПолучитьВремяПоследнейЗаписиUtc(string путь) => File.GetLastWriteTimeUtc(путь);
	public static void Переместить(string имяИсходногоФайла, string имяФайлаНазнач) => File.Move(имяИсходногоФайла, имяФайлаНазнач);
	public static FileStream Открыть(string путь, FileMode режим, FileAccess доступ) => File.Open(путь, режим, доступ);
	public static FileStream Открыть(string путь, FileMode режим, FileAccess доступ, FileShare share) => File.Open(путь, режим, доступ, share);
	public static FileStream Открыть(string путь, FileMode режим) => File.Open(путь, режим);
	public static FileStream ОткрытьЧтение(string путь) => File.OpenRead(путь);
	public static StreamReader ОткрытьТекст(string путь) => File.OpenText(путь);
	public static FileStream ОткрытьЗапись(string путь) => File.OpenWrite(путь);
	public static byte[] ПрочитатьВсеБайты(string путь) => File.ReadAllBytes(путь);
	public static string[] ПрочитатьВсеЛинии(string путь) => File.ReadAllLines(путь);
	public static string[] ПрочитатьВсеЛинии(string путь, Encoding кодировка) => File.ReadAllLines(путь, кодировка);
	public static string ПрочитатьВесьТекст(string путь) => File.ReadAllText(путь);
	public static string ПрочитатьВесьТекст(string путь, Encoding кодировка) => File.ReadAllText(путь, кодировка);
	public static IEnumerable<string> ПрочитатьЛинии(string путь) => File.ReadLines(путь);
	public static IEnumerable<string> ПрочитатьЛинии(string путь, Encoding кодировка) => File.ReadLines(путь, кодировка);
	public static void Заменить(string имяИсходногоФайла, string имяФайлаНазначения, string имяФайлаРезервнойКопииНазначения, bool игнорироватьОшибкиМетаданных) => File.Replace(имяИсходногоФайла, имяФайлаНазначения, имяФайлаРезервнойКопииНазначения, игнорироватьОшибкиМетаданных);
	public static void Заменить(string имяИсходногоФайла, string имяФайлаНазначения, string имяФайлаРезервнойКопииНазначения) => File.Replace(имяИсходногоФайла, имяФайлаНазначения, имяФайлаРезервнойКопииНазначения);
	public static void УстановитьАтрибуты(string путь, FileAttributes атрибутыФайла) => File.SetAttributes(путь, атрибутыФайла);
	public static void УстановитьВремяСоздания(string путь, DateTime времяСоздания) => File.SetCreationTime(путь, времяСоздания);
	public static void УстановитьВремяСозданияUtc(string путь, DateTime времяСозданияUtc) => File.SetCreationTimeUtc(путь, времяСозданияUtc);
	public static void УстановитьВремяПоследнегоДоступа(string путь, DateTime времяПоследнегоДоступа) => File.SetLastAccessTime(путь, времяПоследнегоДоступа);
	public static void УстановитьВремяПоследнегоДоступаUtc(string путь, DateTime времяПоследнегоДоступаUtc) => File.SetLastAccessTimeUtc(путь, времяПоследнегоДоступаUtc);
	public static void УстановитьВремяПоследнейЗаписи(string путь, DateTime времяПоследнейЗаписи) => File.SetLastWriteTime(путь, времяПоследнейЗаписи);
	public static void УстановитьВремяПоследнейЗаписиUtc(string путь, DateTime времяПоследнейЗаписиUtc) => File.SetLastWriteTimeUtc(путь, времяПоследнейЗаписиUtc);
	public static void ЗаписатьВсеБайты(string путь, byte[] байты) => File.WriteAllBytes(путь, байты);
	public static void ЗаписатьВсеЛинии(string путь, IEnumerable<string> содержание) => File.WriteAllLines(путь, содержание);
	public static void ЗаписатьВсеЛинии(string путь, IEnumerable<string> содержание, Encoding кодировка) => File.WriteAllLines(путь, содержание, кодировка);
	public static void ЗаписатьВсеЛинии(string путь, string[] содержание) => File.WriteAllLines(путь, содержание);
	public static void ЗаписатьВсеЛинии(string путь, string[] содержание, Encoding кодировка) => File.WriteAllLines(путь, содержание, кодировка);
	public static void ЗаписатьВесьТекст(string путь, string содержание) => File.WriteAllText(путь, содержание);
	public static void ЗаписатьВесьТекст(string путь, string содержание, Encoding кодировка) => File.WriteAllText(путь, содержание, кодировка);
}
