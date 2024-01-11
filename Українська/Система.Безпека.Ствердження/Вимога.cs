using System.Collections.Generic;
using System.IO;
using System.Security.Claims;

namespace Система.Безпека.Вимоги;

public class Вимога : Claim
{
	public Вимога(BinaryReader читач)
		: base(читач)
	{
	}

	public Вимога(BinaryReader читач, ClaimsIdentity субєкт)
		: base(читач, субєкт)
	{
	}

	public Вимога(string тип, string значення)
		: base(тип, значення)
	{
	}

	public Вимога(string тип, string значення, string типЗначення)
		: base(тип, значення, типЗначення)
	{
	}

	public Вимога(string тип, string значення, string типЗначення, string випускаючаСторона)
		: base(тип, значення, типЗначення, випускаючаСторона)
	{
	}

	public Вимога(string тип, string значення, string типЗначення, string випускаючаСторона, string орігінальнаВипускаючаСторона)
		: base(тип, значення, типЗначення, випускаючаСторона, орігінальнаВипускаючаСторона)
	{
	}

	public Вимога(string тип, string значення, string типЗначення, string випускаючаСторона, string орігінальнаВипускаючаСторона, ClaimsIdentity субєкт)
		: base(тип, значення, типЗначення, випускаючаСторона, орігінальнаВипускаючаСторона, субєкт)
	{
	}

	protected Вимога(Claim інший)
		: base(інший)
	{
	}

	protected Вимога(Claim інший, ClaimsIdentity субєкт)
		: base(інший, субєкт)
	{
	}

	public string Тип => this.Type;

	public ClaimsIdentity Субєкт => this.Subject;

	public IDictionary<string, string> Властивості => this.Properties;

	public string ОрігінальнаВипускаючаСторона => this.OriginalIssuer;

	public string ВипускаючаСторона => this.Issuer;

	public string ТипЗначення => this.ValueType;

	public string Значення => this.Value;
}
