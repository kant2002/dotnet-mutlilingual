using System.Collections.Generic;
using System.IO;
using System.Security.Claims;

namespace Система.Безопасность.Утверждения;

public class Утверждение : Claim
{
	public Утверждение(BinaryReader читатель)
		: base(читатель)
	{
	}

	public Утверждение(BinaryReader читатель, ClaimsIdentity субъєкт)
		: base(читатель, субъєкт)
	{
	}

	public Утверждение(string тип, string значение)
		: base(тип, значение)
	{
	}

	public Утверждение(string тип, string значение, string типЗначения)
		: base(тип, значение, типЗначения)
	{
	}

	public Утверждение(string тип, string значение, string типЗначения, string выпускающаяСторона)
		: base(тип, значение, типЗначения, выпускающаяСторона)
	{
	}

	public Утверждение(string тип, string значение, string типЗначения, string выпускающаяСторона, string оригинальнаяВыпускающаяСторона)
		: base(тип, значение, типЗначения, выпускающаяСторона, оригинальнаяВыпускающаяСторона)
	{
	}

	public Утверждение(string тип, string значение, string типЗначения, string выпускающаяСторона, string оригинальнаяВыпускающаяСторона, ClaimsIdentity субъєкт)
		: base(тип, значение, типЗначения, выпускающаяСторона, оригинальнаяВыпускающаяСторона, субъєкт)
	{
	}

	protected Утверждение(Claim другой)
		: base(другой)
	{
	}

	protected Утверждение(Claim другой, ClaimsIdentity субъєкт)
		: base(другой, субъєкт)
	{
	}

	public string Тип => this.Type;

	public ClaimsIdentity Субъєкт => this.Subject;

	public IDictionary<string, string> Свойства => this.Properties;

	public string ОригинальнаяВыпускающаяСторона => this.OriginalIssuer;

	public string ВыпускающаяСторона => this.Issuer;

	public string ТипЗначения => this.ValueType;

	public string Значение => this.Value;
}
