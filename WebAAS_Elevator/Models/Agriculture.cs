using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAAS_Elevator.Models
{
    /// <summary>
    /// Сельскохозяйственная культура
    /// </summary>
    public class Agriculture
    {
        /// <summary>
        /// Номер с/х культуры
        /// </summary>
        [Key]
        public int NumAgriculture { get; set; }
        
        /// <summary>
        /// Наименование с/х культуры
        /// </summary>
        public string TitleAgriculture { get; set; }
    }
}