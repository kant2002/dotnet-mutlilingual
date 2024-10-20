using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Система.Лінкью;

public static class Перечисляєме
{
    public static ТДжерело Агрегувати<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, ТДжерело, ТДжерело> функ)
        => Enumerable.Aggregate(джерел﻿о, функ);
    public static TAccumulate Агрегувати<ТДжерело, TAccumulate>(this IEnumerable<ТДжерело> джерел﻿о, TAccumulate зерно, Func<TAccumulate, ТДжерело, TAccumulate> функ)
        => Enumerable.Aggregate(джерел﻿о, зерно, функ);
    public static ТРезультат Агрегувати<ТДжерело, TAccumulate, ТРезультат>(this IEnumerable<ТДжерело> джерел﻿о, TAccumulate зерно, Func<TAccumulate, ТДжерело, TAccumulate> функ, Func<TAccumulate, ТРезультат> resultSelector)
        => Enumerable.Aggregate(джерел﻿о, зерно, функ, resultSelector);
    public static bool Усі<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат)
        => Enumerable.All(джерел﻿о, предікат);
    public static bool БудьХто<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.Any(джерел﻿о);
    public static bool БудьХто<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат)
        => Enumerable.Any(джерел﻿о, предікат);
    public static IEnumerable<ТДжерело> Додати<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, ТДжерело елемент)
        => Enumerable.Append(джерел﻿о, елемент);
    public static IEnumerable<ТДжерело> ЯкПеречисляєме<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.AsEnumerable(джерел﻿о);
    public static double Середне<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, int> вибирач)
        => Enumerable.Average(джерел﻿о, вибирач);
    public static double Середне<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, long> вибирач)
        => Enumerable.Average(джерел﻿о, вибирач);
    public static decimal? Середне<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, decimal?> вибирач)
        => Enumerable.Average(джерел﻿о, вибирач);
    public static float? Середне<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, float?> вибирач)
        => Enumerable.Average(джерел﻿о, вибирач);
    public static double? Середне<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, int?> вибирач)
        => Enumerable.Average(джерел﻿о, вибирач);
    public static double? Середне<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, long?> вибирач)
        => Enumerable.Average(джерел﻿о, вибирач);
    public static double Середне<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, double> вибирач)
        => Enumerable.Average(джерел﻿о, вибирач);
    public static double? Середне<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, double?> вибирач)
        => Enumerable.Average(джерел﻿о, вибирач);
    public static decimal Середне<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, decimal> вибирач)
        => Enumerable.Average(джерел﻿о, вибирач);
    public static double? Середне(this IEnumerable<int?> джерел﻿о)
        => Enumerable.Average(джерел﻿о);
    public static float? Середне(this IEnumerable<float?> джерел﻿о)
        => Enumerable.Average(джерел﻿о);
    public static double? Середне(this IEnumerable<long?> джерел﻿о)
        => Enumerable.Average(джерел﻿о);
    public static float Середне<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, float> вибирач)
        => Enumerable.Average(джерел﻿о, вибирач);
    public static double? Середне(this IEnumerable<double?> джерел﻿о)
        => Enumerable.Average(джерел﻿о);
    public static decimal? Середне(this IEnumerable<decimal?> джерел﻿о)
        => Enumerable.Average(джерел﻿о);
    public static double Середне(this IEnumerable<long> джерел﻿о)
        => Enumerable.Average(джерел﻿о);
    public static double Середне(this IEnumerable<int> джерел﻿о)
        => Enumerable.Average(джерел﻿о);
    public static double Середне(this IEnumerable<double> джерел﻿о)
        => Enumerable.Average(джерел﻿о);
    public static decimal Середне(this IEnumerable<decimal> джерел﻿о)
        => Enumerable.Average(джерел﻿о);
    public static float Середне(this IEnumerable<float> джерел﻿о)
        => Enumerable.Average(джерел﻿о);
    public static IEnumerable<ТРезультат> Привести<ТРезультат>(this IEnumerable джерел﻿о)
        => Enumerable.Cast<ТРезультат>(джерел﻿о);
#if NET8_0_OR_GREATER
    public static IEnumerable<ТДжерело[]> Кусок<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, int size)
        => Enumerable.Chunk(джерел﻿о, size);
#endif
    public static IEnumerable<ТДжерело> Скласти<ТДжерело>(this IEnumerable<ТДжерело> first, IEnumerable<ТДжерело> second)
        => Enumerable.Concat(first, second);
    public static bool Містить<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, ТДжерело value)
        => Enumerable.Contains(джерел﻿о, value);
    public static bool Містить<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, ТДжерело value, IEqualityComparer<ТДжерело>? comparer)
        => Enumerable.Contains(джерел﻿о, value, comparer);
    public static int Кількість<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.Count(джерел﻿о);
    public static int Кількість<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат)
        => Enumerable.Count(джерел﻿о, предікат);
    public static IEnumerable<ТДжерело?> ЗаЗамовчаннямЯкщоПусто<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.DefaultIfEmpty(джерел﻿о);
    public static IEnumerable<ТДжерело> ЗаЗамовчаннямЯкщоПусто<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, ТДжерело defaultValue)
        => Enumerable.DefaultIfEmpty(джерел﻿о, defaultValue);
    public static IEnumerable<ТДжерело> Унікальні<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.Distinct(джерел﻿о);
    public static IEnumerable<ТДжерело> Унікальні<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, IEqualityComparer<ТДжерело>? comparer)
        => Enumerable.Distinct(джерел﻿о, comparer);
#if NET8_0_OR_GREATER
    public static IEnumerable<ТДжерело> УнікальніПо<ТДжерело, TKey>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector)
        => Enumerable.DistinctBy(джерел﻿о, keySelector);
    public static IEnumerable<ТДжерело> УнікальніПо<ТДжерело, TKey>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, IEqualityComparer<TKey>? comparer)
        => Enumerable.DistinctBy(джерел﻿о, keySelector, comparer);
    public static ТДжерело ЕлементВ<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Index index)
        => Enumerable.ElementAt(джерел﻿о, index);
#endif
    public static ТДжерело ЕлементВ<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, int index)
        => Enumerable.ElementAt(джерел﻿о, index);
#if NET8_0_OR_GREATER
    public static ТДжерело? ЕлементВАбоЗаЗамовчанням<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Index index)
        => Enumerable.ElementAtOrDefault(джерел﻿о, index);
#endif
    public static ТДжерело? ЕлементВАбоЗаЗамовчанням<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, int index)
        => Enumerable.ElementAtOrDefault(джерел﻿о, index);
    public static IEnumerable<ТРезультат> Пусте<ТРезультат>()
        => Enumerable.Empty<ТРезультат>();
    public static IEnumerable<ТДжерело> ЗаВинятком<ТДжерело>(this IEnumerable<ТДжерело> first, IEnumerable<ТДжерело> second)
        => Enumerable.Except(first, second);
    public static IEnumerable<ТДжерело> ЗаВинятком<ТДжерело>(this IEnumerable<ТДжерело> first, IEnumerable<ТДжерело> second, IEqualityComparer<ТДжерело>? comparer)
        => Enumerable.Except(first, second, comparer);
#if NET8_0_OR_GREATER
    public static IEnumerable<ТДжерело> ЗаВиняткомПо<ТДжерело, TKey>(this IEnumerable<ТДжерело> first, IEnumerable<TKey> second, Func<ТДжерело, TKey> keySelector)
        => Enumerable.ExceptBy(first, second, keySelector);
    public static IEnumerable<ТДжерело> ЗаВиняткомПо<ТДжерело, TKey>(this IEnumerable<ТДжерело> first, IEnumerable<TKey> second, Func<ТДжерело, TKey> keySelector, IEqualityComparer<TKey>? comparer)
        => Enumerable.ExceptBy(first, second, keySelector, comparer);
#endif
    public static ТДжерело Перший<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат)
        => Enumerable.First(джерел﻿о, предікат);
    public static ТДжерело Перший<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.First(джерел﻿о);
#if NET8_0_OR_GREATER
    public static ТДжерело ПершийАбоЗаЗамовчанням<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат, ТДжерело defaultValue)
        => Enumerable.FirstOrDefault(джерел﻿о, предікат, defaultValue);
    public static ТДжерело ПершийАбоЗаЗамовчанням<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, ТДжерело defaultValue)
        => Enumerable.FirstOrDefault(джерел﻿о, defaultValue);
#endif
    public static ТДжерело? ПершийАбоЗаЗамовчанням<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.FirstOrDefault(джерел﻿о);
    public static ТДжерело? ПершийАбоЗаЗамовчанням<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат)
        => Enumerable.FirstOrDefault(джерел﻿о, предікат);
    public static IEnumerable<ТРезультат> СгрупуватиПо<ТДжерело, TKey, ТРезультат>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, Func<TKey, IEnumerable<ТДжерело>, ТРезультат> resultSelector, IEqualityComparer<TKey>? comparer)
        => Enumerable.GroupBy(джерел﻿о, keySelector, resultSelector, comparer);
    public static IEnumerable<ТРезультат> СгрупуватиПо<ТДжерело, TKey, TElement, ТРезультат>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, Func<ТДжерело, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, ТРезультат> resultSelector, IEqualityComparer<TKey>? comparer)
        => Enumerable.GroupBy(джерел﻿о, keySelector, elementSelector, resultSelector, comparer);
    public static IEnumerable<ТРезультат> СгрупуватиПо<ТДжерело, TKey, TElement, ТРезультат>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, Func<ТДжерело, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, ТРезультат> resultSelector)
        => Enumerable.GroupBy(джерел﻿о, keySelector, elementSelector, resultSelector);
    public static IEnumerable<ТРезультат> СгрупуватиПо<ТДжерело, TKey, ТРезультат>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, Func<TKey, IEnumerable<ТДжерело>, ТРезультат> resultSelector)
        => Enumerable.GroupBy(джерел﻿о, keySelector, resultSelector);
    public static IEnumerable<IGrouping<TKey, TElement>> СгрупуватиПо<ТДжерело, TKey, TElement>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, Func<ТДжерело, TElement> elementSelector)
        => Enumerable.GroupBy(джерел﻿о, keySelector, elementSelector);
    public static IEnumerable<IGrouping<TKey, ТДжерело>> СгрупуватиПо<ТДжерело, TKey>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, IEqualityComparer<TKey>? comparer)
        => Enumerable.GroupBy(джерел﻿о, keySelector, comparer);
    public static IEnumerable<IGrouping<TKey, ТДжерело>> СгрупуватиПо<ТДжерело, TKey>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector)
        => Enumerable.GroupBy(джерел﻿о, keySelector);
    public static IEnumerable<IGrouping<TKey, TElement>> СгрупуватиПо<ТДжерело, TKey, TElement>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, Func<ТДжерело, TElement> elementSelector, IEqualityComparer<TKey>? comparer)
        => Enumerable.GroupBy(джерел﻿о, keySelector, elementSelector, comparer);
    public static IEnumerable<ТРезультат> ПоєднатиСгруповано<TOuter, TInner, TKey, ТРезультат>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, ТРезультат> resultSelector)
        => Enumerable.GroupJoin(outer, inner, outerKeySelector, innerKeySelector, resultSelector);
    public static IEnumerable<ТРезультат> ПоєднатиСгруповано<TOuter, TInner, TKey, ТРезультат>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, ТРезультат> resultSelector, IEqualityComparer<TKey>? comparer)
        => Enumerable.GroupJoin(outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
    public static IEnumerable<ТДжерело> Перетнути<ТДжерело>(this IEnumerable<ТДжерело> first, IEnumerable<ТДжерело> second)
        => Enumerable.Intersect(first, second);
    public static IEnumerable<ТДжерело> Перетнути<ТДжерело>(this IEnumerable<ТДжерело> first, IEnumerable<ТДжерело> second, IEqualityComparer<ТДжерело>? comparer)
        => Enumerable.Intersect(first, second, comparer);
#if NET8_0_OR_GREATER
    public static IEnumerable<ТДжерело> ПеретнутиПо<ТДжерело, TKey>(this IEnumerable<ТДжерело> first, IEnumerable<TKey> second, Func<ТДжерело, TKey> keySelector)
        => Enumerable.IntersectBy(first, second, keySelector);
    public static IEnumerable<ТДжерело> ПеретнутиПо<ТДжерело, TKey>(this IEnumerable<ТДжерело> first, IEnumerable<TKey> second, Func<ТДжерело, TKey> keySelector, EqualityComparer<TKey>? comparer)
        => Enumerable.IntersectBy(first, second, keySelector, comparer);
#endif
    public static IEnumerable<ТРезультат> Поєднати<TOuter, TInner, TKey, ТРезультат>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, ТРезультат> resultSelector)
        => Enumerable.Join(outer, inner, outerKeySelector, innerKeySelector, resultSelector);
    public static IEnumerable<ТРезультат> Поєднати<TOuter, TInner, TKey, ТРезультат>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, ТРезультат> resultSelector, IEqualityComparer<TKey>? comparer)
        => Enumerable.Join(outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
    public static ТДжерело Останній<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.Last(джерел﻿о);
    public static ТДжерело Остання<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.Last(джерел﻿о);
    public static ТДжерело Останній<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат)
        => Enumerable.Last(джерел﻿о, предікат);
    public static ТДжерело Остання<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат)
        => Enumerable.Last(джерел﻿о, предікат);
#if NET8_0_OR_GREATER
    public static ТДжерело ОстаннійАбоЗаЗамовчанням<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат, ТДжерело defaultValue)
        => Enumerable.LastOrDefault(джерел﻿о, предікат, defaultValue);
#endif
    public static ТДжерело? ОстаннійАбоЗаЗамовчанням<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.LastOrDefault(джерел﻿о);
#if NET8_0_OR_GREATER
    public static ТДжерело ОстаннійАбоЗаЗамовчанням<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, ТДжерело defaultValue)
        => Enumerable.LastOrDefault(джерел﻿о, defaultValue);
#endif
    public static ТДжерело? ОстаннійАбоЗаЗамовчанням<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат)
        => Enumerable.LastOrDefault(джерел﻿о, предікат);
#if NET8_0_OR_GREATER
    public static ТДжерело ОстанняАбоЗаЗамовчанням<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат, ТДжерело defaultValue)
        => Enumerable.LastOrDefault(джерел﻿о, предікат, defaultValue);
#endif
    public static ТДжерело? ОстанняАбоЗаЗамовчанням<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.LastOrDefault(джерел﻿о);
#if NET8_0_OR_GREATER
    public static ТДжерело ОстанняАбоЗаЗамовчанням<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, ТДжерело defaultValue)
        => Enumerable.LastOrDefault(джерел﻿о, defaultValue);
#endif
    public static ТДжерело? ОстанняАбоЗаЗамовчанням<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат)
        => Enumerable.LastOrDefault(джерел﻿о, предікат);
    public static long ДовгаКількість<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.LongCount(джерел﻿о);
    public static long ДовгаКількість<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат)
        => Enumerable.LongCount(джерел﻿о, предікат);
    public static double Макс<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, double> вибирач)
        => Enumerable.Max(джерел﻿о, вибирач);
    public static int Макс<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, int> вибирач)
        => Enumerable.Max(джерел﻿о, вибирач);
    public static decimal? Макс<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, decimal?> вибирач)
        => Enumerable.Max(джерел﻿о, вибирач);
    public static long Макс<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, long> вибирач)
        => Enumerable.Max(джерел﻿о, вибирач);
    public static double? Макс<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, double?> вибирач)
        => Enumerable.Max(джерел﻿о, вибирач);
    public static float? Макс(this IEnumerable<float?> джерел﻿о)
        => Enumerable.Max(джерел﻿о);
    public static long? Макс<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, long?> вибирач)
        => Enumerable.Max(джерел﻿о, вибирач);
    public static float? Макс<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, float?> вибирач)
        => Enumerable.Max(джерел﻿о, вибирач);
    public static float Макс<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, float> вибирач)
        => Enumerable.Max(джерел﻿о, вибирач);
    public static ТРезультат? Макс<ТДжерело, ТРезультат>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, ТРезультат> вибирач)
        => Enumerable.Max(джерел﻿о, вибирач);
    public static decimal Макс<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, decimal> вибирач)
        => Enumerable.Max(джерел﻿о, вибирач);
    public static int? Макс<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, int?> вибирач)
        => Enumerable.Max(джерел﻿о, вибирач);
#if NET8_0_OR_GREATER
    public static ТДжерело? Макс<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, IComparer<ТДжерело>? comparer)
        => Enumerable.Max(джерел﻿о, comparer);
#endif
    public static double? Макс(this IEnumerable<double?> джерел﻿о)
        => Enumerable.Max(джерел﻿о);
    public static float Макс(this IEnumerable<float> джерел﻿о)
        => Enumerable.Max(джерел﻿о);
    public static long? Макс(this IEnumerable<long?> джерел﻿о)
        => Enumerable.Max(джерел﻿о);
    public static int? Макс(this IEnumerable<int?> джерел﻿о)
        => Enumerable.Max(джерел﻿о);
    public static decimal? Макс(this IEnumerable<decimal?> джерел﻿о)
        => Enumerable.Max(джерел﻿о);
    public static long Макс(this IEnumerable<long> джерел﻿о)
        => Enumerable.Max(джерел﻿о);
    public static int Макс(this IEnumerable<int> джерел﻿о)
        => Enumerable.Max(джерел﻿о);
    public static double Макс(this IEnumerable<double> джерел﻿о)
        => Enumerable.Max(джерел﻿о);
    public static decimal Макс(this IEnumerable<decimal> джерел﻿о)
        => Enumerable.Max(джерел﻿о);
    public static ТДжерело? Макс<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.Max(джерел﻿о);
#if NET8_0_OR_GREATER
    public static ТДжерело? МаксПо<ТДжерело, TKey>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, IComparer<TKey>? comparer)
        => Enumerable.MaxBy(джерел﻿о, keySelector, comparer);
    public static ТДжерело? МаксПо<ТДжерело, TKey>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector)
        => Enumerable.MaxBy(джерел﻿о, keySelector);
#endif
    public static decimal? Мин<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, decimal?> вибирач)
        => Enumerable.Min(джерел﻿о, вибирач);
    public static double Мин<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, double> вибирач)
        => Enumerable.Min(джерел﻿о, вибирач);
    public static int Мин<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, int> вибирач)
        => Enumerable.Min(джерел﻿о, вибирач);
    public static long Мин<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, long> вибирач)
        => Enumerable.Min(джерел﻿о, вибирач);
    public static double? Мин<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, double?> вибирач)
        => Enumerable.Min(джерел﻿о, вибирач);
    public static decimal Мин<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, decimal> вибирач)
        => Enumerable.Min(джерел﻿о, вибирач);
    public static long? Мин<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, long?> вибирач)
        => Enumerable.Min(джерел﻿о, вибирач);
    public static float? Мин<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, float?> вибирач)
        => Enumerable.Min(джерел﻿о, вибирач);
    public static float Мин<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, float> вибирач)
        => Enumerable.Min(джерел﻿о, вибирач);
    public static ТРезультат? Мин<ТДжерело, ТРезультат>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, ТРезультат> вибирач)
        => Enumerable.Min(джерел﻿о, вибирач);
    public static int? Мин<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, int?> вибирач)
        => Enumerable.Min(джерел﻿о, вибирач);
#if NET8_0_OR_GREATER
    public static ТДжерело? Мин<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, IComparer<ТДжерело>? comparer)
        => Enumerable.Min(джерел﻿о, comparer);
#endif
    public static int Мин(this IEnumerable<int> джерел﻿о)
        => Enumerable.Min(джерел﻿о);
    public static long Мин(this IEnumerable<long> джерел﻿о)
        => Enumerable.Min(джерел﻿о);
    public static decimal Мин(this IEnumerable<decimal> джерел﻿о)
        => Enumerable.Min(джерел﻿о);
    public static float Мин(this IEnumerable<float> джерел﻿о)
        => Enumerable.Min(джерел﻿о);
    public static float? Мин(this IEnumerable<float?> джерел﻿о)
        => Enumerable.Min(джерел﻿о);
    public static long? Мин(this IEnumerable<long?> джерел﻿о)
        => Enumerable.Min(джерел﻿о);
    public static int? Мин(this IEnumerable<int?> джерел﻿о)
        => Enumerable.Min(джерел﻿о);
    public static double? Мин(this IEnumerable<double?> джерел﻿о)
        => Enumerable.Min(джерел﻿о);
    public static decimal? Мин(this IEnumerable<decimal?> джерел﻿о)
        => Enumerable.Min(джерел﻿о);
    public static double Мин(this IEnumerable<double> джерел﻿о)
        => Enumerable.Min(джерел﻿о);
    public static ТДжерело? Мин<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.Min(джерел﻿о);
#if NET8_0_OR_GREATER
    public static ТДжерело? МинПо<ТДжерело, TKey>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, IComparer<TKey>? comparer)
        => Enumerable.MinBy(джерел﻿о, keySelector, comparer);
    public static ТДжерело? МинПо<ТДжерело, TKey>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector)
        => Enumerable.MinBy(джерел﻿о, keySelector);
#endif
    public static IEnumerable<ТРезультат> ВказанногоТипу<ТРезультат>(this IEnumerable джерел﻿о)
        => Enumerable.OfType<ТРезультат>(джерел﻿о);
#if NET8_0_OR_GREATER
    public static IOrderedEnumerable<T> Впорядкувати<T>(this IEnumerable<T> джерел﻿о, IComparer<T>? comparer)
        => Enumerable.Order(джерел﻿о, comparer);
    public static IOrderedEnumerable<T> Впорядкувати<T>(this IEnumerable<T> джерел﻿о)
        => Enumerable.Order(джерел﻿о);
#endif
    public static IOrderedEnumerable<ТДжерело> ВпорядкуватиПо<ТДжерело, TKey>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector)
        => Enumerable.OrderBy(джерел﻿о, keySelector);
    public static IOrderedEnumerable<ТДжерело> ВпорядкуватиПо<ТДжерело, TKey>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, IComparer<TKey>? comparer)
        => Enumerable.OrderBy(джерел﻿о, keySelector, comparer);
    public static IOrderedEnumerable<ТДжерело> ВпорядкуватиПоСпаданню<ТДжерело, TKey>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector)
        => Enumerable.OrderByDescending(джерел﻿о, keySelector);
    public static IOrderedEnumerable<ТДжерело> ВпорядкуватиПоСпаданню<ТДжерело, TKey>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, IComparer<TKey>? comparer)
        => Enumerable.OrderByDescending(джерел﻿о, keySelector, comparer);
#if NET8_0_OR_GREATER
    public static IOrderedEnumerable<T> ВпорядкуватиСпадаючи<T>(this IEnumerable<T> джерел﻿о, IComparer<T>? comparer)
        => Enumerable.OrderDescending(джерел﻿о, comparer);
    public static IOrderedEnumerable<T> ВпорядкуватиСпадаючи<T>(this IEnumerable<T> джерел﻿о)
        => Enumerable.OrderDescending(джерел﻿о);
#endif
    public static IEnumerable<ТДжерело> ВПочаток<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, ТДжерело елемент)
        => Enumerable.Prepend(джерел﻿о, елемент);
    public static IEnumerable<int> Діапазон(int start, int count)
        => Enumerable.Range(start, count);
    public static IEnumerable<ТРезультат> Повторити<ТРезультат>(ТРезультат елемент, int count)
        => Enumerable.Repeat(елемент, count);
    public static IEnumerable<ТДжерело> Розвернути<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.Reverse(джерел﻿о);
    public static IEnumerable<ТРезультат> Вибрати<ТДжерело, ТРезультат>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, int, ТРезультат> вибирач)
        => Enumerable.Select(джерел﻿о, вибирач);
    public static IEnumerable<ТРезультат> Вибрати<ТДжерело, ТРезультат>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, ТРезультат> вибирач)
        => Enumerable.Select(джерел﻿о, вибирач);
    public static IEnumerable<ТРезультат> ВибратиБагато<ТДжерело, TCollection, ТРезультат>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, int, IEnumerable<TCollection>> collectionSelector, Func<ТДжерело, TCollection, ТРезультат> resultSelector)
        => Enumerable.SelectMany(джерел﻿о, collectionSelector, resultSelector);
    public static IEnumerable<ТРезультат> ВибратиБагато<ТДжерело, ТРезультат>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, int, IEnumerable<ТРезультат>> вибирач)
        => Enumerable.SelectMany(джерел﻿о, вибирач);
    public static IEnumerable<ТРезультат> ВибратиБагато<ТДжерело, ТРезультат>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, IEnumerable<ТРезультат>> вибирач)
        => Enumerable.SelectMany(джерел﻿о, вибирач);
    public static IEnumerable<ТРезультат> ВибратиБагато<ТДжерело, TCollection, ТРезультат>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, IEnumerable<TCollection>> collectionSelector, Func<ТДжерело, TCollection, ТРезультат> resultSelector)
        => Enumerable.SelectMany(джерел﻿о, collectionSelector, resultSelector);
    public static bool ПослідовнеДорівнює<ТДжерело>(this IEnumerable<ТДжерело> first, IEnumerable<ТДжерело> second)
        => Enumerable.SequenceEqual(first, second);
    public static bool ПослідовнеДорівнює<ТДжерело>(this IEnumerable<ТДжерело> first, IEnumerable<ТДжерело> second, IEqualityComparer<ТДжерело>? comparer)
        => Enumerable.SequenceEqual(first, second, comparer);
    public static ТДжерело Один<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.Single(джерел﻿о);
    public static ТДжерело Один<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат)
        => Enumerable.Single(джерел﻿о, предікат);
    public static ТДжерело? ОдинАбоЗаЗамовчанням<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.SingleOrDefault(джерел﻿о);
#if NET8_0_OR_GREATER
    public static ТДжерело ОдинАбоЗаЗамовчанням<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, ТДжерело defaultValue)
        => Enumerable.SingleOrDefault(джерел﻿о, defaultValue);
#endif
    public static ТДжерело? ОдинАбоЗаЗамовчанням<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат)
        => Enumerable.SingleOrDefault(джерел﻿о, предікат);
#if NET8_0_OR_GREATER
    public static ТДжерело ОдинАбоЗаЗамовчанням<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат, ТДжерело defaultValue)
        => Enumerable.SingleOrDefault(джерел﻿о, предікат, defaultValue);
#endif
    public static IEnumerable<ТДжерело> Пропустити<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, int count)
        => Enumerable.Skip(джерел﻿о, count);
#if NET8_0_OR_GREATER
    public static IEnumerable<ТДжерело> ПропуститиЗКінця<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, int count)
        => Enumerable.SkipLast(джерел﻿о, count);
#endif
    public static IEnumerable<ТДжерело> ПропуститиПоки<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат)
        => Enumerable.SkipWhile(джерел﻿о, предікат);
    public static IEnumerable<ТДжерело> ПропуститиПоки<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, int, bool> предікат)
        => Enumerable.SkipWhile(джерел﻿о, предікат);
    public static float Сума<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, float> вибирач)
        => Enumerable.Sum(джерел﻿о, вибирач);
    public static int Сума<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, int> вибирач)
        => Enumerable.Sum(джерел﻿о, вибирач);
    public static long Сума<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, long> вибирач)
        => Enumerable.Sum(джерел﻿о, вибирач);
    public static decimal? Сума<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, decimal?> вибирач)
        => Enumerable.Sum(джерел﻿о, вибирач);
    public static double Сума<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, double> вибирач)
        => Enumerable.Sum(джерел﻿о, вибирач);
    public static int? Сума<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, int?> вибирач)
        => Enumerable.Sum(джерел﻿о, вибирач);
    public static long? Сума<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, long?> вибирач)
        => Enumerable.Sum(джерел﻿о, вибирач);
    public static float? Сума<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, float?> вибирач)
        => Enumerable.Sum(джерел﻿о, вибирач);
    public static double? Сума<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, double?> вибирач)
        => Enumerable.Sum(джерел﻿о, вибирач);
    public static decimal Сума<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, decimal> вибирач)
        => Enumerable.Sum(джерел﻿о, вибирач);
    public static double? Сума(this IEnumerable<double?> джерел﻿о)
        => Enumerable.Sum(джерел﻿о);
    public static float? Сума(this IEnumerable<float?> джерел﻿о)
        => Enumerable.Sum(джерел﻿о);
    public static long? Сума(this IEnumerable<long?> джерел﻿о)
        => Enumerable.Sum(джерел﻿о);
    public static int? Сума(this IEnumerable<int?> джерел﻿о)
        => Enumerable.Sum(джерел﻿о);
    public static decimal? Сума(this IEnumerable<decimal?> джерел﻿о)
        => Enumerable.Sum(джерел﻿о);
    public static long Сума(this IEnumerable<long> джерел﻿о)
        => Enumerable.Sum(джерел﻿о);
    public static int Сума(this IEnumerable<int> джерел﻿о)
        => Enumerable.Sum(джерел﻿о);
    public static double Сума(this IEnumerable<double> джерел﻿о)
        => Enumerable.Sum(джерел﻿о);
    public static decimal Сума(this IEnumerable<decimal> джерел﻿о)
        => Enumerable.Sum(джерел﻿о);
    public static float Сума(this IEnumerable<float> джерел﻿о)
        => Enumerable.Sum(джерел﻿о);
#if NET8_0_OR_GREATER
    public static IEnumerable<ТДжерело> Взяти<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Range range)
        => Enumerable.Take(джерел﻿о, range);
#endif
    public static IEnumerable<ТДжерело> Взяти<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, int count)
        => Enumerable.Take(джерел﻿о, count);
#if NET8_0_OR_GREATER
    public static IEnumerable<ТДжерело> ВзятиЗКінця<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, int count)
        => Enumerable.TakeLast(джерел﻿о, count);
#endif
    public static IEnumerable<ТДжерело> ВзятиПоки<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, int, bool> предікат)
        => Enumerable.TakeWhile(джерел﻿о, предікат);
    public static IEnumerable<ТДжерело> ВзятиПоки<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат)
        => Enumerable.TakeWhile(джерел﻿о, предікат);
    public static IOrderedEnumerable<ТДжерело> ПотімПо<ТДжерело, TKey>(this IOrderedEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector)
        => Enumerable.ThenBy(джерел﻿о, keySelector);
    public static IOrderedEnumerable<ТДжерело> ПотімПо<ТДжерело, TKey>(this IOrderedEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, IComparer<TKey>? comparer)
        => Enumerable.ThenBy(джерел﻿о, keySelector, comparer);
    public static IOrderedEnumerable<ТДжерело> ПотімПоСпаданню<ТДжерело, TKey>(this IOrderedEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector)
        => Enumerable.ThenByDescending(джерел﻿о, keySelector);
    public static IOrderedEnumerable<ТДжерело> ПотімПоСпаданню<ТДжерело, TKey>(this IOrderedEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, IComparer<TKey>? comparer)
        => Enumerable.ThenByDescending(джерел﻿о, keySelector, comparer);
    public static ТДжерело[] ДоМасиву<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.ToArray(джерел﻿о);
    public static Dictionary<TKey, TElement> ДоСловника<ТДжерело, TKey, TElement>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, Func<ТДжерело, TElement> elementSelector, IEqualityComparer<TKey>? comparer) where TKey : notnull
        => Enumerable.ToDictionary(джерел﻿о, keySelector, elementSelector, comparer);
    public static Dictionary<TKey, TElement> ДоСловника<ТДжерело, TKey, TElement>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, Func<ТДжерело, TElement> elementSelector) where TKey : notnull
        => Enumerable.ToDictionary(джерел﻿о, keySelector, elementSelector);
    public static Dictionary<TKey, ТДжерело> ДоСловника<ТДжерело, TKey>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, IEqualityComparer<TKey>? comparer) where TKey : notnull
        => Enumerable.ToDictionary(джерел﻿о, keySelector, comparer);
    public static Dictionary<TKey, ТДжерело> ДоСловника<ТДжерело, TKey>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector) where TKey : notnull
        => Enumerable.ToDictionary(джерел﻿о, keySelector);
#if NET8_0_OR_GREATER
    public static Dictionary<TKey, TValue> ДоСловника<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> джерел﻿о) where TKey : notnull
        => Enumerable.ToDictionary(джерел﻿о);
    public static Dictionary<TKey, TValue> ДоСловника<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> джерел﻿о, IEqualityComparer<TKey>? comparer) where TKey : notnull
        => Enumerable.ToDictionary(джерел﻿о, comparer);
    public static Dictionary<TKey, TValue> ДоСловника<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> джерел﻿о) where TKey : notnull
        => Enumerable.ToDictionary(джерел﻿о);
    public static Dictionary<TKey, TValue> ДоСловника<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> джерел﻿о, IEqualityComparer<TKey>? comparer) where TKey : notnull
        => Enumerable.ToDictionary(джерел﻿о, comparer);
    public static HashSet<ТДжерело> ДоХешованоїМножини<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.ToHashSet(джерел﻿о);
    public static HashSet<ТДжерело> ДоХешованоїМножини<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, IEqualityComparer<ТДжерело>? comparer)
        => Enumerable.ToHashSet(джерел﻿о, comparer);
#endif
    public static List<ТДжерело> ДоСписку<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о)
        => Enumerable.ToList(джерел﻿о);
    public static ILookup<TKey, TElement> ДоПошуку<ТДжерело, TKey, TElement>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, Func<ТДжерело, TElement> elementSelector)
        => Enumerable.ToLookup(джерел﻿о, keySelector, elementSelector);
    public static ILookup<TKey, TElement> ДоПошуку<ТДжерело, TKey, TElement>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, Func<ТДжерело, TElement> elementSelector, IEqualityComparer<TKey>? comparer)
        => Enumerable.ToLookup(джерел﻿о, keySelector, elementSelector, comparer);
    public static ILookup<TKey, ТДжерело> ДоПошуку<ТДжерело, TKey>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector)
        => Enumerable.ToLookup(джерел﻿о, keySelector);
    public static ILookup<TKey, ТДжерело> ДоПошуку<ТДжерело, TKey>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, TKey> keySelector, IEqualityComparer<TKey>? comparer)
        => Enumerable.ToLookup(джерел﻿о, keySelector, comparer);
#if NET8_0_OR_GREATER
    public static bool СпробуватиВзятиНеПеречисляємуКількість<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, out int count)
        => Enumerable.TryGetNonEnumeratedCount(джерел﻿о, out count);
#endif
    public static IEnumerable<ТДжерело> Обєднати<ТДжерело>(this IEnumerable<ТДжерело> first, IEnumerable<ТДжерело> second)
        => Enumerable.Union(first, second);
    public static IEnumerable<ТДжерело> Обєднати<ТДжерело>(this IEnumerable<ТДжерело> first, IEnumerable<ТДжерело> second, IEqualityComparer<ТДжерело>? comparer)
        => Enumerable.Union(first, second, comparer);
#if NET8_0_OR_GREATER
    public static IEnumerable<ТДжерело> ОбєднатиПо<ТДжерело, TKey>(this IEnumerable<ТДжерело> first, IEnumerable<ТДжерело> second, Func<ТДжерело, TKey> keySelector)
        => Enumerable.UnionBy(first, second, keySelector);
    public static IEnumerable<ТДжерело> ОбєднатиПо<ТДжерело, TKey>(this IEnumerable<ТДжерело> first, IEnumerable<ТДжерело> second, Func<ТДжерело, TKey> keySelector, IEqualityComparer<TKey>? comparer)
        => Enumerable.UnionBy(first, second, keySelector, comparer);
#endif
    public static IEnumerable<ТДжерело> Коли<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, bool> предікат)
        => Enumerable.Where(джерел﻿о, предікат);
    public static IEnumerable<ТДжерело> Коли<ТДжерело>(this IEnumerable<ТДжерело> джерел﻿о, Func<ТДжерело, int, bool> предікат)
        => Enumerable.Where(джерел﻿о, предікат);
#if NET8_0_OR_GREATER
    public static IEnumerable<(TFirst First, TSecond Second, TThird Third)> Зазіпувати<TFirst, TSecond, TThird>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, IEnumerable<TThird> third)
        => Enumerable.Zip(first, second, third);
    public static IEnumerable<(TFirst First, TSecond Second)> Зазіпувати<TFirst, TSecond>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second)
        => Enumerable.Zip(first, second);
#endif
    public static IEnumerable<ТРезультат> Зазіпувати<TFirst, TSecond, ТРезультат>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, ТРезультат> resultSelector)
        => Enumerable.Zip(first, second, resultSelector);
}