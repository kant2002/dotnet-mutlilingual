using System.Security.Claims;

namespace Система.Безпека.Стверждення;

/// <summary>
/// Визначає константи для відомих типів стверждень, які можна призначити суб’єкту.
/// Цей клас не можна успадкувати.
/// </summary>
public static class ТипиСтверджень
{
	/// <summary>
	/// http://schemas.xmlsoap.org/ws/2005/05/identity/claims/actor.
	/// </summary>
	public static string Актор => ClaimTypes.Actor;

	/// <summary>
	/// URI для ствердження, яке визначає поштовий індекс організації, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode.
	/// </summary>
	public static string Індекс => ClaimTypes.PostalCode;

	/// <summary>
	/// URI для ствердження, яке визначає головний SID групи сутності, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/primarygroupsid.
	/// </summary>
	public static string ГоловнийSidГрупи => ClaimTypes.PrimaryGroupSid;

	/// <summary>
	/// URI для ствердження, яке визначає головний SID сутності, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/primarysid.
	/// </summary>
	public static string ГоловнийSid => ClaimTypes.PrimarySid;

	/// <summary>
	/// URI для ствердження, яке визначає роль сутності, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/role.
	/// </summary>
	public static string Роль => ClaimTypes.Role;

	/// <summary>
	/// URI для ствердження, яке визначає RSA ключ, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa.
	/// </summary>
	public static string Rsa => ClaimTypes.Rsa;

	/// <summary>
	/// URI для ствердження, яке визначає серійний номер, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/serialnumber.
	/// </summary>
	public static string СерійнийНомер => ClaimTypes.SerialNumber;

	/// <summary>
	/// URI для ствердження, яке визначає ідентифікатор безпеки (SID), http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid.
	/// </summary>
	public static string Sid => ClaimTypes.Sid;

	/// <summary>
	/// URI для ствердження, яке визначає стверждення імені принципала служби (SPN), http://schemas.xmlsoap.org/ws/2005/05/identity/claims/spn.
	/// </summary>
	public static string Spn => ClaimTypes.Spn;

	/// <summary>
	/// URI для ствердження, яке визначає штат або провінцію, у якій проживає суб’єкт, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince.
	/// </summary>
	public static string ШтатАбоПровінція => ClaimTypes.StateOrProvince;

	/// <summary>
	/// URI для ствердження, яке визначає вуличну адресу сутності, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress.
	/// </summary>
	public static string Адреса => ClaimTypes.StreetAddress;

	/// <summary>
	/// URI для ствердження, яке визначає фамілію сутності, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname.
	/// </summary>
	public static string Фамілія => ClaimTypes.Surname;

	/// <summary>
	/// URI для ствердження, яке визначає системну сутність, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/system.
	/// </summary>
	public static string Система => ClaimTypes.System;

	/// <summary>
	/// URI для ствердження, яке визначає цифровий відбиток, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/thumbprint.
	/// Відбиток – це глобально унікальний хеш SHA-1 сертифіката X.509.
	/// </summary>
	public static string Відбиток => ClaimTypes.Thumbprint;

	/// <summary>
	/// URI для ствердження, яке визначає основне ім’я користувача (UPN), http://schemas.xmlsoap.org/ws/2005/05/identity/claims/role.
	/// </summary>
	public static string Upn => ClaimTypes.Upn;

	/// <summary>
	/// URI для ствердження, яке визначає роль URI, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri.
	/// </summary>
	public static string Uri => ClaimTypes.Uri;

	/// <summary>
	/// http://schemas.xmlsoap.org/ws/2005/05/identity/claims/userdata.
	/// </summary>
	public static string ДаніКористувача => ClaimTypes.UserData;

	/// <summary>
	/// http://schemas.xmlsoap.org/ws/2005/05/identity/claims/version.
	/// </summary>
	public static string Версія => ClaimTypes.Version;

	/// <summary>
	/// URI для ствердження, яке визначає веб-сторінку сутності, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage.
	/// </summary>
	public static string ВебСторінка => ClaimTypes.Webpage;

	/// <summary>
	/// URI для ствердження, яке визначає назву сутності, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name.
	/// </summary>
	public static string Імя => ClaimTypes.Name;
}
