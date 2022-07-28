using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eclerx.Question3.Anshuman.Models
{
    public class Supplier
    {
        [Key]//applying primary key
        
        public int SupplierId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [DisplayName("Company Name")]
        
        public string ComapanyName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string  ContactName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(200)]
        public string Address { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string City { get; set; }
        [DisplayName("Pin Code")]
        [Column(TypeName = "CHAR")]
        [StringLength(6)]
        public string Pincode { get; set; }

        [Index("Ix_MobileNo", IsUnique = true)]//applying unique key
        [Column(TypeName = "VARCHAR")]
        [StringLength(12)]
        [DisplayName("Mobile No")]
        public string MobileNo { get; set; }

        [Index("Ix_EmailId", IsUnique = true)]
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        [DisplayName("Email ID")]
        public string EmailId { get; set; }

        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }=DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
    }
}