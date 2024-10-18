namespace Система.КомпонентнаМодель.АннотаціїДаних.Схема;

public class СтовпчикAttribute : System.ComponentModel.DataAnnotations.Schema.ColumnAttribute
{
    public СтовпчикAttribute() : base() { }
    public СтовпчикAttribute(string назва) : base(назва) { }

    public string Назва => Name;
    public int Послідовність
    {
        get => Order;
        set => Order = value;
    }
    public string НазваТипу
    {
        get => TypeName;
        set => TypeName = value;
    }
}
