namespace Система.КомпонентнаМодель.АннотаціїДаних.Схема;

public class ЗовнішнійКлючAttribute : System.ComponentModel.DataAnnotations.Schema.ForeignKeyAttribute
{
    public ЗовнішнійКлючAttribute(string назва) : base(назва) { }

    public string Назва => Name;
}
