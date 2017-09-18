using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAAS_Elevator.Models
{
    /// <summary>
    /// Распоряжение о подработке/сушке зерна
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Номер распоряжения
        /// </summary>
        public int NumOrder { get; set; }

        /// <summary>
        /// Дата распоряжения
        /// </summary>
        public DateTime DateOrder { get; set; }

        /// <summary>
        /// Масса зерна
        /// </summary>
        public int MassGrain { get; set; }

        /// <summary>
        /// Цель
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// Сорт
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime DateStart { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTime DateFinish { get; set; }

        /// <summary>
        /// Масса отходов
        /// </summary>
        public int MassWaste { get; set; }

        /// <summary>
        /// Номер отходов по ФККО
        /// </summary>
        public string NumFKKO { get; set; }

        /// <summary>
        /// Номер очистительной машины
        /// </summary>
        public string NumMachines { get; set; }

        /// <summary>
        /// Номер хранилища
        /// </summary>
        public int NumGranary { get; set; }

        /// <summary>
        /// Хранилище
        /// </summary>
        public virtual Granary Granary { get; set; }
    }
}