namespace Система.КомпонентнаМодель.АннотаціїДаних.Схема;

public class ТаблицяAttribute : System.ComponentModel.DataAnnotations.Schema.TableAttribute
{
    public ТаблицяAttribute(string назва) : base(назва) { }

    public string Назва => Name;
    public string Схема
    {
        get => Schema;
        set => Schema = value;
    }
}
