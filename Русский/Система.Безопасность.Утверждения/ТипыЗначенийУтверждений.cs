using System.Security.Claims;

namespace Система.Безопасность.Утверждения;

/// <summary>
/// Определяет типы значений для утверждений в соответствии с URI типам, определенных W3C и OASIS.
/// Этот класс нельзя наследовать.
/// </summary>
public static class ТипыЗначенийУтверждений
{
	/// <summary>
	/// URI, который представляет тип данных XML base64Binary.
	/// </summary>
	public static string ДвоичныеБаза64 => ClaimValueTypes.Base64Binary;

	/// <summary>
	/// URI, который представляет тип данных SOAP UPN.
	/// </summary>
	public static string ИмяUpn => ClaimValueTypes.UpnName;

	/// <summary>
	/// URI, который представляет тип данных XML uinteger64.
	/// </summary>
	public static string БЦелое64 => ClaimValueTypes.UInteger64;

	/// <summary>
	/// URI, который представляет тип данных XML uinteger32.
	/// </summary>
	public static string БЦелое32 => ClaimValueTypes.UInteger32;

	/// <summary>
	/// URI, который представляет тип данных XML time.
	/// </summary>
	public static string Время => ClaimValueTypes.Time;

	/// <summary>
	/// URI, который представляет тип данных XML string.
	/// </summary>
	public static string Строка => ClaimValueTypes.String;

	/// <summary>
	/// URI, который представляет тип данных XML sid.
	/// </summary>
	public static string Sid => ClaimValueTypes.Sid;

	/// <summary>
	/// URI, который представляет тип данных RSAKeyValue XML Signature.
	/// </summary>
	public static string RsaKeyValue => ClaimValueTypes.RsaKeyValue;

	/// <summary>
	/// URI, который представляет тип данных rsa SOAP.
	/// </summary>
	public static string Rsa => ClaimValueTypes.Rsa;

	/// <summary>
	/// URI, который представляет тип данных rfc822Name XACML 1.0.
	/// </summary>
	public static string Rfc822Name => ClaimValueTypes.Rfc822Name;

	/// <summary>
	/// URI, который представляет тип данных KeyInfo XML Signature.
	/// </summary>
	public static string KeyInfo => ClaimValueTypes.KeyInfo;

	/// <summary>
	/// URI, который представляет тип данных XML integer64.
	/// </summary>
	public static string Целое64 => ClaimValueTypes.Integer64;

	/// <summary>
	/// URI, который представляет тип данных x500Name XACML 1.0.
	/// </summary>
	public static string X500Name => ClaimValueTypes.X500Name;

	/// <summary>
	/// URI, который представляет тип данных XML integer32.
	/// </summary>
	public static string Целое32 => ClaimValueTypes.Integer32;

	/// <summary>
	/// URI, который представляет тип данных XML hexBinary.
	/// </summary>
	public static string ДвоичныйХекс => ClaimValueTypes.HexBinary;

	/// <summary>
	/// URI, который представляет тип данных XML fqbn.
	/// </summary>
	public static string Fqbn => ClaimValueTypes.Fqbn;

	/// <summary>
	/// URI, который представляет тип данных SOAP emailaddress.
	/// </summary>
	public static string Почта => ClaimValueTypes.Email;

	/// <summary>
	/// URI, который представляет тип данных DSAKeyValue XML Signature.
	/// </summary>
	public static string DsaKeyValue => ClaimValueTypes.DsaKeyValue;

	/// <summary>
	/// URI, который представляет тип данных XML double.
	/// </summary>
	public static string Двойное => ClaimValueTypes.Double;

	/// <summary>
	/// URI, который представляет тип данных SOAP dns.
	/// </summary>
	public static string ИмяDns => ClaimValueTypes.DnsName;

	/// <summary>
	/// URI, который представляет тип данных XQuery daytimeDuration.
	/// </summary>
	public static string DaytimeDuration => ClaimValueTypes.DaytimeDuration;

	/// <summary>
	/// URI, который представляет тип данных XML dateTime.
	/// </summary>
	public static string ДатаИВремя => ClaimValueTypes.DateTime;

	/// <summary>
	/// URI, который представляет тип данных XML date.
	/// </summary>
	public static string Дата => ClaimValueTypes.Date;

	/// <summary>
	/// URI, который представляет тип данных XML boolean.
	/// </summary>
	public static string Логичное => ClaimValueTypes.Boolean;

	/// <summary>
	/// URI, который представляет тип данных XML base64Octet.
	/// </summary>
	public static string ОктетБаза64 => ClaimValueTypes.Base64Octet;

	/// <summary>
	/// URI, который представляет тип данных XML integer.
	/// </summary>
	public static string Целое => ClaimValueTypes.Integer;

	/// <summary>
	/// URI, который представляет тип данных XQuery yearMonthDuration.
	/// </summary>
	public static string YearMonthDuration => ClaimValueTypes.YearMonthDuration;
}
