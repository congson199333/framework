namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdminUser")]
    public partial class AdminUser
    {
        [Key]
        public int adminId { get; set; }
        
        [StringLength(50)]
        [Display(Name = "Tên đăng nhập")]
        public string adminName { get; set; }

        [StringLength(50)]
        [Display(Name = "Mật khẩu")]
        public string adminPass { get; set; }

        [StringLength(50)]
        public string email { get; set; }
    }
}
