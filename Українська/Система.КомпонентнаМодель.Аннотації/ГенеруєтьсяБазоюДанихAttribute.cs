using System.ComponentModel.DataAnnotations.Schema;

namespace Система.КомпонентнаМодель.АннотаціїДаних.Схема;

public class ГенеруєтьсяБазоюДанихAttribute : DatabaseGeneratedAttribute
{
    public ГенеруєтьсяБазоюДанихAttribute(ОпціяГенераціїБазоюДаних опціїГенераціїБазоюДаних) : base((DatabaseGeneratedOption)(int)опціїГенераціїБазоюДаних) { }

    public ОпціяГенераціїБазоюДаних ОпціїГенераціїБазоюДаних => (ОпціяГенераціїБазоюДаних)(int)DatabaseGeneratedOption;
}
