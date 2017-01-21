using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRT.DAL.Models.Menus
{
    [Table(name:"Menu")]
    public sealed class MenuDal
    {
        [Key]
        public Int32 Id { get; set; }
        //public Int32 SubmenuId { get; set; }
        //public MenuDal Submenu { get; set; }
    }
}
