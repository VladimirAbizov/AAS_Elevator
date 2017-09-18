using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAAS_Elevator.Models
{
    /// <summary>
    /// Квитанция
    /// </summary>
    public class Receipt
    {
        /// <summary>
        /// Номер квитанции
        /// </summary>
        public int NumReceipt { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Вид поступления
        /// </summary>
        public string TypeOfAdmission { get; set; }

        /// <summary>
        /// Отправитель
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// Цена за килограмм
        /// </summary>
        public int PricePerKilo { get; set; }

        /// <summary>
        /// Сумма
        /// </summary>
        public int Summ { get; set; }

        /// <summary>
        /// Партия
        /// </summary>
        public virtual Party Party { get; set; }
    }
}