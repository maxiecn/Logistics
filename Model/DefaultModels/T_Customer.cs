using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class T_Customer
    {
        [Key]
        public int CustomerID { get; set; }

        public string SenderName { get; set; }

        public string SenderTel { get; set; }

        public string CustomerName { get; set; }

        public string Tel { get; set; }

        public string Address { get; set; }

        public int TransID { get; set; }

        public string TransName { get; set; }

        public override string ToString()
        {
            return CustomerName;
        }
    }
}