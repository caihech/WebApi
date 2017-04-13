using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase.Models
{
    [Table("User")]
    public partial class User
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 公司外键
        /// </summary>
        [ForeignKey("Company")]
        public int CompanyId { get; set; }

        /// <summary>
        /// Navigationproperties
        /// </summary>
        public virtual Company Company{get;set;}
    }
}
