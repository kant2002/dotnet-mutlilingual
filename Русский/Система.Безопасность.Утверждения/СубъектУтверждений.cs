using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Claims;
using System.Security.Principal;

namespace Система.Безопасность.Утверждения;

public class СубъектУтверждений : ClaimsPrincipal
{
	public СубъектУтверждений()
		: base()
	{
	}

	public СубъектУтверждений(IEnumerable<ClaimsIdentity> личности)
		: base(личности)
	{
	}

	public СубъектУтверждений(BinaryReader читатель)
		: base(читатель)
	{
	}

	public СубъектУтверждений(IIdentity личность)
		: base(личность)
	{
	}

	public СубъектУтверждений(IPrincipal субъект)
		: base(субъект)
	{
	}

	public static ClaimsPrincipal Текущий => Current;

	public static Func<ClaimsPrincipal> СелекторСубъекта
	{
		get => ClaimsPrincipalSelector;
		set => ClaimsPrincipalSelector = value;
	}

	public static Func<IEnumerable<ClaimsIdentity>, ClaimsIdentity> СелекторГлавнойЛичности
	{
		get => PrimaryIdentitySelector;
		set => PrimaryIdentitySelector = value;
	}

	public virtual IIdentity Личность => this.Identity;

	public virtual IEnumerable<ClaimsIdentity> Личности => Identities;
	public virtual IEnumerable<Claim> Утверждения => Claims;

	public virtual void ДобавитьЛичности(IEnumerable<ClaimsIdentity> личности)
	{
		this.AddIdentities(личности);
	}

	public virtual void ДобавитьЛичность(ClaimsIdentity личность)
	{
		this.AddIdentity(личность);
	}

	public virtual ClaimsPrincipal Склонировать() => this.Clone();

	public virtual IEnumerable<Claim> НайтиВсе(Predicate<Claim> сопоставление) => this.FindAll(сопоставление);

	public virtual IEnumerable<Claim> НайтиВсе(string тип) => this.FindAll(тип);

	public virtual Claim НайтиПервое(string тип) => this.FindFirst(тип);

	public virtual Claim НайтиПервое(Predicate<Claim> сопоставление) => this.FindFirst(сопоставление);

	public virtual bool ЕстьУтверждение(Predicate<Claim> сопоставление) => this.HasClaim(сопоставление);

	public virtual bool ЕстьУтверждение(string тип, string значення) => this.HasClaim(тип, значення);

	public virtual bool ВРоли(string роль) => this.IsInRole(роль);
}
