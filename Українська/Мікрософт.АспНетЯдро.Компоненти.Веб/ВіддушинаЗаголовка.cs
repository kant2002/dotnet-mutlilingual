namespace Мікрософт.АспНетЯдро.Компоненти.Веб;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Sections;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

public sealed class ВіддушинаЗаголовка : ComponentBase
{
    private const string GetAndRemoveExistingTitle = "Blazor._internal.PageTitle.getAndRemoveExistingTitle";

    internal static readonly object ИдСекціїЗаголовка = new object();

    internal static readonly object ИдСекціїНазви = new object();

    private string _defaultTitle;

    [Inject]
    private IJSRuntime JSRuntime { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            _defaultTitle = await JSRuntimeExtensions.InvokeAsync<string>(JSRuntime, "Blazor._internal.PageTitle.getAndRemoveExistingTitle", Array.Empty<object>());
            StateHasChanged();
        }
    }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenComponent<SectionOutlet>(0);
        builder.AddComponentParameter(1, "SectionId", ИдСекціїНазви);
        builder.CloseComponent();
        if (!string.IsNullOrEmpty(_defaultTitle))
        {
            builder.OpenComponent<SectionContent>(2);
            builder.AddComponentParameter(3, "SectionId", ИдСекціїНазви);
            builder.AddComponentParameter(4, "IsDefaultContent", true);
            builder.AddComponentParameter(5, "ChildContent", new RenderFragment(BuildDefaultTitleRenderTree));
            builder.CloseComponent();
        }

        builder.OpenComponent<SectionOutlet>(6);
        builder.AddComponentParameter(7, "SectionId", ИдСекціїЗаголовка);
        builder.CloseComponent();
    }

    private void BuildDefaultTitleRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "title");
        builder.AddContent(1, _defaultTitle);
        builder.CloseElement();
    }
}
