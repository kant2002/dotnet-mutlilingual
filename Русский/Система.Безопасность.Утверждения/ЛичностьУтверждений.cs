using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Security.Principal;

namespace Система.Безопасность.Утверждения;

public class ЛичностьУтверждений : ClaimsIdentity
{
	public const string ВыпускающаяСторонаПоУмолчанию = DefaultIssuer;
	public const string ТипУтвержденияИмениПоУмолчанию = DefaultNameClaimType;
	public const string ТипУтвержденияРольПоУмолчанию = DefaultRoleClaimType;

	public ЛичностьУтверждений()
	{
	}

	public ЛичностьУтверждений(IEnumerable<Claim> утверждения) : base(утверждения)
	{
	}

	public ЛичностьУтверждений(BinaryReader читатель) : base(читатель)
	{
	}

	public ЛичностьУтверждений(IIdentity личность) : base(личность)
	{
	}

	public ЛичностьУтверждений(string типАутентификации) : base(типАутентификации)
	{
	}

	public ЛичностьУтверждений(IEnumerable<Claim> утверждения, string типАутентификации) : base(утверждения, типАутентификации)
	{
	}

	public ЛичностьУтверждений(IIdentity личность, IEnumerable<Claim> утверждения) : base(личность, утверждения)
	{
	}

	public ЛичностьУтверждений(string типАутентификации, string типИмени, string типРоли) : base(типАутентификации, типИмени, типРоли)
	{
	}

	public ЛичностьУтверждений(IEnumerable<Claim> утверждения, string типАутентификации, string типИмени, string типРоли) : base(утверждения, типАутентификации, типИмени, типРоли)
	{
	}

	public ЛичностьУтверждений(IIdentity личность, IEnumerable<Claim> утверждения, string типАутентификации, string типИмени, string типРоли) : base(личность, утверждения, типАутентификации, типИмени, типРоли)
	{
	}

	protected ЛичностьУтверждений(SerializationInfo инфо) : base(инфо)
	{
	}

	protected ЛичностьУтверждений(ClaimsIdentity другая) : base(другая)
	{
	}

	protected ЛичностьУтверждений(SerializationInfo инфо, StreamingContext контекст) : base(инфо, контекст)
	{
	}

	public virtual string ТипАутентификации => this.AuthenticationType;

	public virtual string Имя => this.Name;
	public string Пометка { get => this.Label; set => this.Label = value; }
	public virtual bool Аутентифицирован => this.IsAuthenticated;
	public virtual IEnumerable<Claim> Утверждения => this.Claims;
	public ClaimsIdentity Актор { get => this.Actor; set => this.Actor = value; }
	public string ТипУтвержденияРоль => this.NameClaimType;
	public string ТипУтвержденияИмя => this.NameClaimType;
	public virtual void ДобавитьУтверждение(Claim утверждение) => this.AddClaim(утверждение);
	public virtual void ДобавитьУтверждения(IEnumerable<Claim> утверждения) => this.AddClaims(утверждения);
	public virtual ClaimsIdentity Склонировать() => this.Clone();

	public virtual IEnumerable<Claim> НайтиВсе(Predicate<Claim> сопоставление) => this.FindAll(сопоставление);

	public virtual IEnumerable<Claim> НайтиВсе(string тип) => this.FindAll(тип);

	public virtual Claim НайтиПервое(string тип) => this.FindFirst(тип);

	public virtual Claim НайтиПервое(Predicate<Claim> сопоставление) => this.FindFirst(сопоставление);

	public virtual bool ЕстьУтверждение(Predicate<Claim> сопоставление) => this.HasClaim(сопоставление);

	public virtual bool ЕстьУтверждение(string тип, string значение) => this.HasClaim(тип, значение);

	public virtual void УдалитьУтверждение(Claim claim) => this.RemoveClaim(claim);

	public virtual bool ПопробоватьУдалитьУтверждение(Claim claim) => this.TryRemoveClaim(claim);
}
