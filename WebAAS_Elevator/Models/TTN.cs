using System;
using System.ComponentModel.DataAnnotations;

namespace WebAAS_Elevator.Models
{
    /// <summary>
    /// Товарно-транспортная накладная
    /// </summary>
    public class TTN
    {
        /// <summary>
        /// Номер накладной
        /// </summary>
        [Key]
        public int NumTTN { get; set; }
        
        /// <summary>
        /// Дата поступления
        /// </summary>
        public DateTime DateOfReceipt { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Сорность
        /// </summary>
        public int Soreness { get; set; }

        /// <summary>
        /// Влажность
        /// </summary>
        public int Humidity { get; set; }

        /// <summary>
        /// Журнал взвешивания
        /// </summary>
        public virtual WeighingJournal WeighingJournal { get; set; }

        /// <summary>
        /// Регеестр ТТН-ок
        /// </summary>
        public virtual RegistryOfTTN RegistryOfTTN { get; set; }

        /// <summary>
        /// Сорт
        /// </summary>
        public virtual Grade Grade { get; set; }

        /// <summary>
        /// Хранилище
        /// </summary>
        public virtual Granary Granary { get; set; }

        public TTN(ActionData actionData)
        {
            DateOfReceipt = Convert.ToDateTime(actionData.fields[0]);
            Price = Convert.ToInt32(actionData.fields[1]);
            Soreness = Convert.ToInt32(actionData.fields[2]);
            Humidity = Convert.ToInt32(actionData.fields[3]);
        }
        public TTN() { }
    }
}