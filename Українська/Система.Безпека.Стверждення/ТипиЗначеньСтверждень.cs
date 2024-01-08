using System.Security.Claims;

namespace Система.Безпека.Стверждення;

/// <summary>
/// Визначає типи значень стверждень відповідно до URI типів, визначених W3C і OASIS.
/// Цей клас не можна успадкувати.
/// </summary>
public static class ТипиЗначеньСтверждень
{
	/// <summary>
	/// URI, який представляє тип даних XML base64Binary.
	/// </summary>
	public static string БінарніБаза64 => ClaimValueTypes.Base64Binary;

	/// <summary>
	/// URI, який представляє тип даних SOAP UPN.
	/// </summary>
	public static string ІмяUpn => ClaimValueTypes.UpnName;

	/// <summary>
	/// URI, який представляє тип даних XML uinteger64.
	/// </summary>
	public static string БЦіле64 => ClaimValueTypes.UInteger64;

	/// <summary>
	/// URI, який представляє тип даних XML uinteger32.
	/// </summary>
	public static string БЦіле32 => ClaimValueTypes.UInteger32;

	/// <summary>
	/// URI, який представляє тип даних XML time.
	/// </summary>
	public static string Час => ClaimValueTypes.Time;

	/// <summary>
	/// URI, який представляє тип даних XML string.
	/// </summary>
	public static string Рядок => ClaimValueTypes.String;

	/// <summary>
	/// URI, який представляє тип даних XML sid.
	/// </summary>
	public static string Sid => ClaimValueTypes.Sid;

	/// <summary>
	/// URI, який представляє тип даних RSAKeyValue XML Signature.
	/// </summary>
	public static string RsaKeyValue => ClaimValueTypes.RsaKeyValue;

	/// <summary>
	/// URI, який представляє тип даних rsa SOAP.
	/// </summary>
	public static string Rsa => ClaimValueTypes.Rsa;

	/// <summary>
	/// URI, який представляє тип даних rfc822Name XACML 1.0.
	/// </summary>
	public static string Rfc822Name => ClaimValueTypes.Rfc822Name;

	/// <summary>
	/// URI, який представляє тип даних KeyInfo XML Signature.
	/// </summary>
	public static string KeyInfo => ClaimValueTypes.KeyInfo;

	/// <summary>
	/// URI, який представляє тип даних XML integer64.
	/// </summary>
	public static string Ціле64 => ClaimValueTypes.Integer64;

	/// <summary>
	/// URI, який представляє тип даних x500Name XACML 1.0.
	/// </summary>
	public static string X500Name => ClaimValueTypes.X500Name;

	/// <summary>
	/// URI, який представляє тип даних XML integer32.
	/// </summary>
	public static string Ціле32 => ClaimValueTypes.Integer32;

	/// <summary>
	/// URI, який представляє тип даних XML hexBinary.
	/// </summary>
	public static string БінарніГекс => ClaimValueTypes.HexBinary;

	/// <summary>
	/// URI, який представляє тип даних XML fqbn.
	/// </summary>
	public static string Fqbn => ClaimValueTypes.Fqbn;

	/// <summary>
	/// URI, який представляє тип даних SOAP emailaddress.
	/// </summary>
	public static string Пошта => ClaimValueTypes.Email;

	/// <summary>
	/// URI, який представляє тип даних DSAKeyValue XML Signature.
	/// </summary>
	public static string DsaKeyValue => ClaimValueTypes.DsaKeyValue;

	/// <summary>
	/// URI, який представляє тип даних XML double.
	/// </summary>
	public static string Подвійне => ClaimValueTypes.Double;

	/// <summary>
	/// URI, який представляє тип даних SOAP dns.
	/// </summary>
	public static string ІмяDns => ClaimValueTypes.DnsName;

	/// <summary>
	/// URI, який представляє тип даних XQuery daytimeDuration.
	/// </summary>
	public static string DaytimeDuration => ClaimValueTypes.DaytimeDuration;

	/// <summary>
	/// URI, який представляє тип даних XML dateTime.
	/// </summary>
	public static string ДатаІЧас => ClaimValueTypes.DateTime;

	/// <summary>
	/// URI, який представляє тип даних XML date.
	/// </summary>
	public static string Дата => ClaimValueTypes.Date;

	/// <summary>
	/// URI, який представляє тип даних XML boolean.
	/// </summary>
	public static string Логічне => ClaimValueTypes.Boolean;

	/// <summary>
	/// URI, який представляє тип даних XML base64Octet.
	/// </summary>
	public static string ОктетБаза64 => ClaimValueTypes.Base64Octet;

	/// <summary>
	/// URI, який представляє тип даних XML integer.
	/// </summary>
	public static string Ціле => ClaimValueTypes.Integer;

	/// <summary>
	/// URI, який представляє тип даних XQuery yearMonthDuration.
	/// </summary>
	public static string YearMonthDuration => ClaimValueTypes.YearMonthDuration;
}
