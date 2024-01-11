using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Claims;
using System.Security.Principal;

namespace Система.Безпека.Вимоги;

public class СубєктВимог : ClaimsPrincipal
{
	public СубєктВимог()
		: base()
	{
	}

	public СубєктВимог(IEnumerable<ClaimsIdentity> особистісті)
		: base(особистісті)
	{
	}

	public СубєктВимог(IEnumerable<ОсобистістьВимог> особистісті)
		: base(особистісті)
	{
	}

	public СубєктВимог(BinaryReader читач)
		: base(читач)
	{
	}

	public СубєктВимог(IIdentity особистість)
		: base(особистість)
	{
	}

	public СубєктВимог(IPrincipal субєкт)
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
	public virtual IEnumerable<Claim> Вимоги => Claims;

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

	public virtual bool ІснуєВимога(Predicate<Claim> співставлення) => this.HasClaim(співставлення);

	public virtual bool ІснуєВимога(string тип, string значення) => this.HasClaim(тип, значення);

	public virtual bool УРолі(string роль) => this.IsInRole(роль);
}
