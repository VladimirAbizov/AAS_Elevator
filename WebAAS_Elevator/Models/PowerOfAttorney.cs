using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAAS_Elevator.Models
{
    /// <summary>
    /// Доверенность
    /// </summary>
    public class PowerOfAttorney
    {
        /// <summary>
        /// Номер доверенности
        /// </summary>
        public int NumPowOfAttorney { get; set; }

        /// <summary>
        /// Дата выдачи
        /// </summary>
        public DateTime DateDelivery { get; set; }

        /// <summary>
        /// Номер счёта
        /// </summary>
        public int NumAccount { get; set; }

        /// <summary>
        /// Банк
        /// </summary>
        public string Bank { get; set; }

        /// <summary>
        /// Потребитель
        /// </summary>
        public string Consumer { get; set; }

        /// <summary>
        /// Плательщик
        /// </summary>
        public string Payer { get; set; }

        /// <summary>
        /// Поставщик
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// Прикрепленный перечень мат. средств
        /// </summary>
        public virtual ListOfMaterial ListOfMateriel { get; set; }
    }
}