using System.Security.Claims;

namespace Система.Безопасность.Утверждения;

/// <summary>
/// Определяет константы для известных типов утверждений, которые можна назначить субъекту.
/// Этот класс нельзя наследовать.
/// </summary>
internal sealed class ТипыУтверждений
{
	/// <summary>
	/// http://schemas.xmlsoap.org/ws/2005/05/identity/claims/actor.
	/// </summary>
	public static string Актор => ClaimTypes.Actor;

	/// <summary>
	/// URI для утверждения, которое обозначает почтовий индекс организации, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode.
	/// </summary>
	public static string Индекс => ClaimTypes.PostalCode;

	/// <summary>
	/// URI для утверждения, которое обозначает главный SID группы сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/primarygroupsid.
	/// </summary>
	public static string ГлавныйSidГрупи => ClaimTypes.PrimaryGroupSid;

	/// <summary>
	/// URI для утверждения, которое обозначает главный SID сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/primarysid.
	/// </summary>
	public static string ГлавныйSid => ClaimTypes.PrimarySid;

	/// <summary>
	/// URI для утверждения, которое обозначает роль сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/role.
	/// </summary>
	public static string Роль => ClaimTypes.Role;

	/// <summary>
	/// URI для утверждения, которое обозначает RSA ключ, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa.
	/// </summary>
	public static string Rsa => ClaimTypes.Rsa;

	/// <summary>
	/// URI для утверждения, которое обозначает серийный номер, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/serialnumber.
	/// </summary>
	public static string СерийныйНомер => ClaimTypes.SerialNumber;

	/// <summary>
	/// URI для утверждения, которое обозначает идентификатор безопасности (SID), http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid.
	/// </summary>
	public static string Sid => ClaimTypes.Sid;

	/// <summary>
	/// URI для утверждения, которое обозначает утверждение имени принципала служби (SPN), http://schemas.xmlsoap.org/ws/2005/05/identity/claims/spn.
	/// </summary>
	public static string Spn => ClaimTypes.Spn;

	/// <summary>
	/// URI для утверждения, которое обозначает штат или провинцию, в которой проживает субъект, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince.
	/// </summary>
	public static string ШтатИлиПровинция => ClaimTypes.StateOrProvince;

	/// <summary>
	/// URI для утверждения, которое обозначает адрес сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress.
	/// </summary>
	public static string Адрес => ClaimTypes.StreetAddress;

	/// <summary>
	/// URI для утверждения, которое обозначает фамилию сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname.
	/// </summary>
	public static string Фамилия => ClaimTypes.Surname;

	/// <summary>
	/// URI для утверждения, которое обозначает системну сущность, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/system.
	/// </summary>
	public static string Система => ClaimTypes.System;

	/// <summary>
	/// URI для утверждения, которое обозначает цифровой отпечаток, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/thumbprint.
	/// Отпечаток – это глобально уникальний хеш SHA-1 сертификата X.509.
	/// </summary>
	public static string Отпечаток => ClaimTypes.Thumbprint;

	/// <summary>
	/// URI для утверждения, которое обозначает основное имя пользователя (UPN), http://schemas.xmlsoap.org/ws/2005/05/identity/claims/role.
	/// </summary>
	public static string Upn => ClaimTypes.Upn;

	/// <summary>
	/// URI для утверждения, которое обозначает роль URI, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri.
	/// </summary>
	public static string Uri => ClaimTypes.Uri;

	/// <summary>
	/// http://schemas.xmlsoap.org/ws/2005/05/identity/claims/userdata.
	/// </summary>
	public static string ДанныеПользователя => ClaimTypes.UserData;

	/// <summary>
	/// http://schemas.xmlsoap.org/ws/2005/05/identity/claims/version.
	/// </summary>
	public static string Версия => ClaimTypes.Version;

	/// <summary>
	/// URI для утверждения, которое обозначает веб-страницу сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage.
	/// </summary>
	public static string ВебСтраница => ClaimTypes.Webpage;

	/// <summary>
	/// URI для утверждения, которое обозначает название сущности, http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name.
	/// </summary>
	public static string Имя => ClaimTypes.Name;
}
