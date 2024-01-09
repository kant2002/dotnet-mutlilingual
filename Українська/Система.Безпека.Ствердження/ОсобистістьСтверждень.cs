using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Security.Principal;

namespace Система.Безпека.Ствердження;

public class ОсобистістьСтверждень : ClaimsIdentity
{
	public const string ВипускаючаСторонаЗаЗамовчанням = DefaultIssuer;
	public const string ТипСтвержденняІменіЗаЗамовчанням = DefaultNameClaimType;
	public const string ТипСтвержденняРольЗаЗамовчанням = DefaultRoleClaimType;

	public ОсобистістьСтверждень()
	{
	}

	public ОсобистістьСтверждень(IEnumerable<Claim> ствердження) : base(ствердження)
	{
	}

	public ОсобистістьСтверждень(BinaryReader читач) : base(читач)
	{
	}

	public ОсобистістьСтверждень(IIdentity особистість) : base(особистість)
	{
	}

	public ОсобистістьСтверждень(string типАутентіфікації) : base(типАутентіфікації)
	{
	}

	public ОсобистістьСтверждень(IEnumerable<Claim> стверждення, string типАутентіфікації) : base(стверждення, типАутентіфікації)
	{
	}

	public ОсобистістьСтверждень(IIdentity особистість, IEnumerable<Claim> стверждення) : base(особистість, стверждення)
	{
	}

	public ОсобистістьСтверждень(string типАутентіфікації, string типІмені, string типРолі) : base(типАутентіфікації, типІмені, типРолі)
	{
	}

	public ОсобистістьСтверждень(IEnumerable<Claim> стверждення, string типАутентіфікації, string типІмені, string типРолі) : base(стверждення, типАутентіфікації, типІмені, типРолі)
	{
	}

	public ОсобистістьСтверждень(IIdentity особистість, IEnumerable<Claim> стверждення, string типАутентіфікації, string типІмені, string типРолі) : base(особистість, стверждення, типАутентіфікації, типІмені, типРолі)
	{
	}

	protected ОсобистістьСтверждень(SerializationInfo інфо) : base(інфо)
	{
	}

	protected ОсобистістьСтверждень(ClaimsIdentity інша) : base(інша)
	{
	}

	protected ОсобистістьСтверждень(SerializationInfo інфо, StreamingContext контекст) : base(інфо, контекст)
	{
	}

	public virtual string ТипАутентіфікації => this.AuthenticationType;

	public virtual string Імя => this.Name;
	public string Помітка { get => this.Label; set => this.Label = value; }
	public virtual bool Аутентіфіковано => this.IsAuthenticated;
	public virtual IEnumerable<Claim> Стверждення => this.Claims;
	public ClaimsIdentity Актор { get => this.Actor; set => this.Actor = value; }
	public string ТипСтвержденняРоль => this.NameClaimType;
	public string ТипСтвержденняІмя => this.NameClaimType;
	public virtual void ДодатиСтверждення(Claim claim) => this.AddClaim(claim);
	public virtual void ДодатиСтверждення(IEnumerable<Claim> claims) => this.AddClaims(claims);
	public virtual ClaimsIdentity Склонувати() => this.Clone();

	public virtual IEnumerable<Claim> ЗнайтиУсі(Predicate<Claim> співставлення) => this.FindAll(співставлення);

	public virtual IEnumerable<Claim> ЗнайтиУсі(string тип) => this.FindAll(тип);

	public virtual Claim ЗнайтиПерше(string тип) => this.FindFirst(тип);

	public virtual Claim ЗнайтиПерше(Predicate<Claim> співставлення) => this.FindFirst(співставлення);

	public virtual bool ІснуєСтверждення(Predicate<Claim> співставлення) => this.HasClaim(співставлення);

	public virtual bool ІснуєСтверждення(string тип, string значення) => this.HasClaim(тип, значення);

	public virtual void ВидалитиСтверждення(Claim claim) => this.RemoveClaim(claim);

	public virtual bool СпробуватиВидалитиСтверждення(Claim claim) => this.TryRemoveClaim(claim);
}
