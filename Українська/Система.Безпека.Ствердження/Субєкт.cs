using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Claims;
using System.Security.Principal;

namespace Система.Безпека.Ствердження;

public class СубєктСтверджень : ClaimsPrincipal
{
	public СубєктСтверджень()
		: base()
	{
	}

	public СубєктСтверджень(IEnumerable<ClaimsIdentity> особистісті)
		: base(особистісті)
	{
	}

	public СубєктСтверджень(BinaryReader читач)
		: base(читач)
	{
	}

	public СубєктСтверджень(IIdentity особистість)
		: base(особистість)
	{
	}

	public СубєктСтверджень(IPrincipal субєкт)
		: base(субєкт)
	{
	}

	public static ClaimsPrincipal Поточний => Current;

	public static Func<ClaimsPrincipal> СелекторСубєкта
	{
		get => ClaimsPrincipalSelector;
		set => ClaimsPrincipalSelector = value;
	}

	public static Func<IEnumerable<ClaimsIdentity>, ClaimsIdentity> СелекторГоловноїОсобистості
	{
		get => PrimaryIdentitySelector;
		set => PrimaryIdentitySelector = value;
	}

	public virtual IIdentity Особистість => this.Identity;

	public virtual IEnumerable<ClaimsIdentity> Особистості => Identities;
	public virtual IEnumerable<Claim> Ствердження => Claims;

	public virtual void ДодатиОсобистості(IEnumerable<ClaimsIdentity> особистості)
	{
		this.AddIdentities(особистості);
	}

	public virtual void ДодатиОсобистость(ClaimsIdentity особистость)
	{
		this.AddIdentity(особистость);
	}

	public virtual ClaimsPrincipal Склонувати() => this.Clone();

	public virtual IEnumerable<Claim> ЗнайтиУсі(Predicate<Claim> співставлення) => this.FindAll(співставлення);

	public virtual IEnumerable<Claim> ЗнайтиУсі(string тип) => this.FindAll(тип);

	public virtual Claim ЗнайтиПерше(string тип) => this.FindFirst(тип);

	public virtual Claim ЗнайтиПерше(Predicate<Claim> співставлення) => this.FindFirst(співставлення);

	public virtual bool ІснуєСтверждення(Predicate<Claim> співставлення) => this.HasClaim(співставлення);

	public virtual bool ІснуєСтверждення(string тип, string значення) => this.HasClaim(тип, значення);

	public virtual bool УРолі(string роль) => this.IsInRole(роль);
}
