namespace WebAppAddMenu.Models
{
    public class SaMenu
    {
        public Guid RowId { get; set; }

        public string CreatedBy { get; set; } = null!;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string ModifiedBy { get; set; } = null!;

        public DateTime ModifiedDate { get; set; } = DateTime.Now;

        public string MenuCode { get; set; } = null!;

        public string? MenuName { get; set; }

        public string? Description { get; set; }

        public string ModuleCode { get; set; } = null!;

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }

        public int? OpenTime { get; set; }

        public DateTime? LatestOpenTime { get; set; }
    }
}
