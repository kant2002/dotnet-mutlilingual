namespace Мікрософт.АспНетЯдро.Будівник;
using System;
using Microsoft.AspNetCore.Builder;

public static class РозширенняБудівникаКонвенційКінцевихТочок
{
	public static ТБудівник ВідключитиАнтіПідробку<ТБудівник>(this ТБудівник будівник) where ТБудівник : IEndpointConventionBuilder => RoutingEndpointConventionBuilderExtensions.DisableAntiforgery(будівник);

	public static ТБудівник ПотребуєХоста<ТБудівник>(this ТБудівник будівник, params string[] хости) where ТБудівник : IEndpointConventionBuilder => RoutingEndpointConventionBuilderExtensions.RequireHost(будівник, хости);

	public static ТБудівник ІзВідображаємоюНазвою<ТБудівник>(this ТБудівник будівник, string відображаємаНазва) where ТБудівник : IEndpointConventionBuilder => RoutingEndpointConventionBuilderExtensions.WithDisplayName(будівник, відображаємаНазва);

	public static ТБудівник ІзВідображаємоюНазвою<ТБудівник>(this ТБудівник будівник, Func<EndpointBuilder, string> функ) where ТБудівник : IEndpointConventionBuilder => RoutingEndpointConventionBuilderExtensions.WithDisplayName(будівник, функ);

	public static ТБудівник ІзОпціямиВідображенняФорми<ТБудівник>(this ТБудівник будівник, int? максРозмірКолекції = null, int? максГлибинаРекурсії = null, int? максРозмірКлюча = null) where ТБудівник : IEndpointConventionBuilder => RoutingEndpointConventionBuilderExtensions.WithFormMappingOptions(будівник, максРозмірКолекції, максГлибинаРекурсії, максРозмірКлюча);

	public static ТБудівник ІзОпціямиФорми<ТБудівник>(this ТБудівник будівник, bool? буферізуватиТіло = null, int? memoryBufferThreshold = null, long? лімітДовжиниБуфераТіла = null, int? лімітКількостіЗначень = null, int? лімітДовжиниКлюча = null, int? лімітДовжиниЗначення = null, int? лімітДовжиниБагаточастинноїГраниці = null, int? лімітКількостіБагаточастиннихЗаголовків = null, int? лімітДовжиниБагаточастинmultipaнихЗаголовків = null, long? лімітДовжиниТілаБагаточстинногоЗмісту = null) where ТБудівник : IEndpointConventionBuilder => RoutingEndpointConventionBuilderExtensions.WithFormOptions(будівник, буферізуватиТіло, memoryBufferThreshold, лімітДовжиниБуфераТіла, лімітКількостіЗначень, лімітДовжиниКлюча, лімітДовжиниЗначення, лімітДовжиниБагаточастинноїГраниці, лімітКількостіБагаточастиннихЗаголовків, лімітДовжиниБагаточастинmultipaнихЗаголовків, лімітДовжиниТілаБагаточстинногоЗмісту);

	public static ТБудівник ІзНазвоюГрупи<ТБудівник>(this ТБудівник будівник, string назваГрупиКінцевоїТочки) where ТБудівник : IEndpointConventionBuilder => RoutingEndpointConventionBuilderExtensions.WithGroupName(будівник, назваГрупиКінцевоїТочки);

	public static ТБудівник ІзМетаданими<ТБудівник>(this ТБудівник будівник, params object[] елементи) where ТБудівник : IEndpointConventionBuilder => RoutingEndpointConventionBuilderExtensions.WithMetadata(будівник, елементи);

	public static ТБудівник ІзНазвою<ТБудівник>(this ТБудівник будівник, string назваКінцевоїТочки) where ТБудівник : IEndpointConventionBuilder => RoutingEndpointConventionBuilderExtensions.WithName(будівник, назваКінцевоїТочки);

	public static ТБудівник ІзПорядком<ТБудівник>(this ТБудівник будівник, int порядок) where ТБудівник : IEndpointConventionBuilder => RoutingEndpointConventionBuilderExtensions.WithOrder(будівник, порядок);


}
