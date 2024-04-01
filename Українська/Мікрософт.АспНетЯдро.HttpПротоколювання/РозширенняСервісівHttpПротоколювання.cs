namespace Мікрософт.Розширення.ВприскЗалежностей;

using Microsoft.AspNetCore.HttpLogging;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

public static class РозширенняСервісівHttpПротоколювання
{
	public static IServiceCollection ДодатиHttpПротоколювання(this IServiceCollection сервіси, Action<HttpLoggingOptions> налаштувантиОпції) => сервіси.AddHttpLogging(налаштувантиОпції);
	public static IServiceCollection ДодатиПерехоплювачHttpПротоколювання<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] T>(this IServiceCollection сервіси) where T : class, IHttpLoggingInterceptor => сервіси.AddHttpLoggingInterceptor<T>();
	public static IServiceCollection ДодатиW3CПротоколювання(this IServiceCollection сервіси, Action<W3CLoggerOptions> налаштувантиОпції) => сервіси.AddW3CLogging(налаштувантиОпції);
}
