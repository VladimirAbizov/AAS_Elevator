using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAAS_Elevator.Models
{
    /// <summary>
    /// Журнал взвешивания
    /// </summary>
    public class WeighingJournal
    {
        /// <summary>
        /// Номер строки в журнале взвешивания
        /// </summary>
        public int NumStrInWJ { get; set; }

        /// <summary>
        /// Дата взвешивания
        /// </summary>
        public DateTime DateWeighing { get; set; }

        /// <summary>
        /// Брутто
        /// </summary>
        public int Gross { get; set; }

        /// <summary>
        /// Тара
        /// </summary>
        public int Tare { get; set; }

        /// <summary>
        /// Нетто
        /// </summary>
        public int Net { get; set; }
    }
}