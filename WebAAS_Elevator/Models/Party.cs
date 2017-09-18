using System;
using System.Collections.Generic;

namespace WebAAS_Elevator.Models
{
    /// <summary>
    /// Партия
    /// </summary>
    public class Party
    {
        /// <summary>
        /// Номер партии
        /// </summary>
        public int NumParty { get; set; }

        /// <summary>
        /// Дата формирования
        /// </summary>
        public DateTime? DateOfFormation { get; set; }

        /// <summary>
        /// Квитанция
        /// </summary>
        public virtual Receipt Receipt { get; set; }

        /// <summary>
        /// Реестры ТТН-ок
        /// </summary>
        public virtual ICollection<RegistryOfTTN> RegistryOfTTN { get; set; }
    }
}