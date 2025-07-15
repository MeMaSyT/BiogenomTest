namespace BiogenomText.Core.Dto
{
    public record ReportDto
    (
    Guid? Id,
    DateTime ReportDate,

    //current daily intake
    float Current_VitaminC,
    float Current_VitaminD,
    float Current_Water,
    float Current_Cink,
    float Current_Energy,

    //new daily intake
    float New_VitaminD,
    float New_Cink,
    float New_Iodine,
    float New_VitaminB6,
    float New_VitaminС
    );
    
}
