namespace BiogenomTest.DataAccess.Entities
{
    public class ReportEntity
    {
        public Guid Id { get; set; }
        public DateTime ReportDate { get; set; }

        //current daily intake
        public float Current_VitaminC { get; set; }
        public float Current_VitaminD { get; set; }
        public float Current_Water { get; set; }
        public float Current_Cink { get; set; }
        public float Current_Energy { get; set; }

        //new daily intake
        public float New_VitaminD { get; set; }
        public float New_Cink { get; set; }
        public float New_Iodine { get; set; }
        public float New_VitaminB6 { get; set; }
        public float New_VitaminС { get; set; }
    }
}
