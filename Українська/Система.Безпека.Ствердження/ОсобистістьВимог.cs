using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Security.Principal;

namespace Система.Безпека.Вимоги;

public class ОсобистістьВимог : ClaimsIdentity
{
	public const string ВипускаючаСторонаЗаЗамовчанням = DefaultIssuer;
	public const string ТипВимогиІменіЗаЗамовчанням = DefaultNameClaimType;
	public const string ТипВимогиРольЗаЗамовчанням = DefaultRoleClaimType;

	public ОсобистістьВимог()
	{
	}

	public ОсобистістьВимог(IEnumerable<Claim> ствердження) : base(ствердження)
	{
	}

	public ОсобистістьВимог(IEnumerable<Вимога> ствердження) : base(ствердження)
	{
	}

	public ОсобистістьВимог(BinaryReader читач) : base(читач)
	{
	}

	public ОсобистістьВимог(IIdentity особистість) : base(особистість)
	{
	}

	public ОсобистістьВимог(string типАутентіфікації) : base(типАутентіфікації)
	{
	}

	public ОсобистістьВимог(IEnumerable<Claim> вимоги, string типАутентіфікації) : base(вимоги, типАутентіфікації)
	{
	}

	public ОсобистістьВимог(IIdentity особистість, IEnumerable<Claim> вимоги) : base(особистість, вимоги)
	{
	}

	public ОсобистістьВимог(string типАутентіфікації, string типІмені, string типРолі) : base(типАутентіфікації, типІмені, типРолі)
	{
	}

	public ОсобистістьВимог(IEnumerable<Claim> вимоги, string типАутентіфікації, string типІмені, string типРолі) : base(вимоги, типАутентіфікації, типІмені, типРолі)
	{
	}

	public ОсобистістьВимог(IIdentity особистість, IEnumerable<Claim> вимоги, string типАутентіфікації, string типІмені, string типРолі) : base(особистість, вимоги, типАутентіфікації, типІмені, типРолі)
	{
	}

	protected ОсобистістьВимог(SerializationInfo інфо) : base(інфо)
	{
	}

	protected ОсобистістьВимог(ClaimsIdentity інша) : base(інша)
	{
	}

	protected ОсобистістьВимог(SerializationInfo інфо, StreamingContext контекст) : base(інфо, контекст)
	{
	}

	public virtual string ТипАутентіфікації => this.AuthenticationType;

	public virtual string Імя => this.Name;
	public string Помітка { get => this.Label; set => this.Label = value; }
	public virtual bool Аутентіфіковано => this.IsAuthenticated;
	public virtual IEnumerable<Claim> Вимоги => this.Claims;
	public ClaimsIdentity Актор { get => this.Actor; set => this.Actor = value; }
	public string ТипВимогиРоль => this.NameClaimType;
	public string ТипВимогиІмя => this.NameClaimType;
	public virtual void ДодатиВимогу(Claim вимога) => this.AddClaim(вимога);
	public virtual void ДодатиВимоги(IEnumerable<Claim> вимоги) => this.AddClaims(вимоги);
	public virtual ClaimsIdentity Склонувати() => this.Clone();

	public virtual IEnumerable<Claim> ЗнайтиУсі(Predicate<Claim> співставлення) => this.FindAll(співставлення);

	public virtual IEnumerable<Claim> ЗнайтиУсі(string тип) => this.FindAll(тип);

	public virtual Claim ЗнайтиПерше(string тип) => this.FindFirst(тип);

	public virtual Claim ЗнайтиПерше(Predicate<Claim> співставлення) => this.FindFirst(співставлення);

	public virtual bool ІснуєВимога(Predicate<Claim> співставлення) => this.HasClaim(співставлення);

	public virtual bool ІснуєВимога(string тип, string значення) => this.HasClaim(тип, значення);

	public virtual void ВидалитиВимога(Claim вимога) => this.RemoveClaim(вимога);

	public virtual bool СпробуватиВидалитиВимога(Claim вимога) => this.TryRemoveClaim(вимога);
}
