using System.Collections.Generic;
using System.IO;
using System.Security.Claims;

namespace Система.Безпека.Стверждення;

public class Ствердження : Claim
{
	public Ствердження(BinaryReader читач)
		: base(читач)
	{
	}

	public Ствердження(BinaryReader читач, ClaimsIdentity субєкт)
		: base(читач, субєкт)
	{
	}

	public Ствердження(string тип, string значення)
		: base(тип, значення)
	{
	}

	public Ствердження(string тип, string значення, string типЗначення)
		: base(тип, значення, типЗначення)
	{
	}

	public Ствердження(string тип, string значення, string типЗначення, string випускаючаСторона)
		: base(тип, значення, типЗначення, випускаючаСторона)
	{
	}

	public Ствердження(string тип, string значення, string типЗначення, string випускаючаСторона, string орігінальнаВипускаючаСторона)
		: base(тип, значення, типЗначення, випускаючаСторона, орігінальнаВипускаючаСторона)
	{
	}

	public Ствердження(string тип, string значення, string типЗначення, string випускаючаСторона, string орігінальнаВипускаючаСторона, ClaimsIdentity субєкт)
		: base(тип, значення, типЗначення, випускаючаСторона, орігінальнаВипускаючаСторона, субєкт)
	{
	}

	protected Ствердження(Claim інший)
		: base(інший)
	{
	}

	protected Ствердження(Claim інший, ClaimsIdentity субєкт)
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
