using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAAS_Elevator.Models
{
    /// <summary>
    /// Очистные машины
    /// </summary>
    public class PurificationMachine
    {
        /// <summary>
        /// Инвентарный номер
        /// </summary>
        [Key]
        public int InventoryNum { get; set; }

        /// <summary>
        /// Наименование машины
        /// </summary>
        public string NameMachine { get; set; }

        /// <summary>
        /// Номер распоряжения
        /// </summary>
        public int NumOrder { get; set; }
    }
}