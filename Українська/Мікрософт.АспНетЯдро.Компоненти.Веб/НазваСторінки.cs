namespace Мікрософт.АспНетЯдро.Компоненти.Веб;

using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Sections;
using Microsoft.AspNetCore.Components;

/// <summary>
/// Enables rendering an HTML <c>&lt;title&gt;</c> to a <see cref="ВіддушинаЗаголовка"/> component.
/// </summary>
public sealed class НазваСторінки : ComponentBase
{
    /// <summary>
    /// Gets or sets the content to be rendered as the document title.
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    /// <inheritdoc/>
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenComponent<SectionContent>(0);
        builder.AddComponentParameter(1, nameof(SectionContent.SectionId), ВіддушинаЗаголовка.ИдСекціїНазви);
        builder.AddComponentParameter(2, nameof(SectionContent.ChildContent), (RenderFragment)BuildTitleRenderTree);
        builder.CloseComponent();
    }

    private void BuildTitleRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "title");
        builder.AddContent(1, ChildContent);
        builder.CloseElement();
    }
}