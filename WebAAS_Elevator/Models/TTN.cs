using System;

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
            NumTTN = (int)actionData.fields[0];
            DateOfReceipt = (DateTime)actionData.fields[1];
            Price = (int)actionData.fields[2];
            Soreness = (int)actionData.fields[3];
            Humidity = (int)actionData.fields[4];
        }
    }
}