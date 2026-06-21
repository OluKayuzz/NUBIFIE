using Microsoft.EntityFrameworkCore;

namespace NUBIFIE_Web_Portal.Models
{
    [Keyless]
    public class SysOption
    {
        public string RefID { get; set; }
        public byte[] EmptyFrame { get; set; }
        public byte[] MediaFrame { get; set; }
        public string Password { get; set; }
        public string ImageTitle1 { get; set; }
        public string ImageTitle2 { get; set; }
        public string ImageTitle3 { get; set; }
        public string ImageTitle4 { get; set; }
        public string ImageTitle5 { get; set; }
        public string ImageURL1 { get; set; }
        public string ImageURL2 { get; set; }
        public string ImageURL3 { get; set; }
        public string ImageURL4 { get; set; }   
        public string ImageURL5 { get; set; }
        public string AboutUsContent { get; set; }
        public string HistoryContent { get; set; }
        public string ObjectiveContent { get; set; }
        public string MissionContent { get; set; }
        public string VissionContent { get; set; }
        public string NACM_Intro { get; set; }
        public string NSS_ZCS_Intro { get; set;}
    }
}
