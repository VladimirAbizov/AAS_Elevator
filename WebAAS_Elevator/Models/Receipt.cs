using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Key]
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

        ///// <summary>
        ///// Партия
        ///// </summary>
        //public virtual Party Party { get; set; }

        public Receipt(ActionData actionData)
        {
            NumReceipt = (int)actionData.fields[0];
            Date = (DateTime)actionData.fields[1];
            TypeOfAdmission = (string) actionData.fields[2];
            Sender = (string) actionData.fields[3];
            PricePerKilo = (int) actionData.fields[4];
            Summ = (int) actionData.fields[5];
        }
    }
}