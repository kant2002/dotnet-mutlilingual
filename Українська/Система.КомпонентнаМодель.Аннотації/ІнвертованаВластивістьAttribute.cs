namespace Система.КомпонентнаМодель.АннотаціїДаних.Схема;

public class ІнвертованаВластивістьAttribute : System.ComponentModel.DataAnnotations.Schema.InversePropertyAttribute
{
    public ІнвертованаВластивістьAttribute(string властивість) : base(властивість) { }

    public string Властивість => Property;
}
