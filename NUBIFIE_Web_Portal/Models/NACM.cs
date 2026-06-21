using System.ComponentModel.DataAnnotations;

namespace NUBIFIE_Web_Portal.Models
{
    public class NACM
    {
        [Key]
        public int Id { get; set; }
        public string PersonTitle { get; set; }
        public string PersonName { get; set; }
        public string PersonContent { get; set; }
	    public string PersonPicAddress { get; set; }
        public DateTime OfficeDate {  get; set; }
        public bool Active { get; set; }
        public int OrderList { get; set; }
    }
}
