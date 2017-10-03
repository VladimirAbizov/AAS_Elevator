using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAAS_Elevator.Models
{
    /// <summary>
    /// Журнал анализов
    /// </summary>
    public class AnalysisJournal
    {
        /// <summary>
        /// Номер журнала анализов
        /// </summary>
        [Key]
        public int NumAnJourn { get; set; }

        /// <summary>
        /// Дата начала ведения
        /// </summary>
        public DateTime DateStart { get; set; }

        /// <summary>
        /// Дата окончания ведения
        /// </summary>
        public DateTime DateFinish { get; set; }

        /// <summary>
        /// Анализные карты
        /// </summary>
        public virtual ICollection<AnalysisCard> AnCards { get; set; }
    }
}