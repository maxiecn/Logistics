using System.ComponentModel.DataAnnotations;

namespace Model.DefaultModels
{
    public class T_Status
    {
        [Key]
        public string StatusID { get; set; }

        public string StatusName { get; set; }
    }
}