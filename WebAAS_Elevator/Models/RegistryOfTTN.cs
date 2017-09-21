using System;
using System.Collections.Generic;

namespace WebAAS_Elevator.Models
{
    /// <summary>
    /// Регистр ТТН
    /// </summary>
    public class RegistryOfTTN
    {
        /// <summary>
        /// Номер реестра
        /// </summary>
        public int NumRegistry { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Сельскохозяйственная культура
        /// </summary>
        public Agriculture Agriculture { get; set; }

        /// <summary>
        /// Масса
        /// </summary>
        public int Mass { get; set; }

        /// <summary>
        /// Средняя сорность по накладным в реестре
        /// </summary>
        public int AverageSoreness { get; set; }

        /// <summary>
        /// Средняя влажность по накладным в реестре
        /// </summary>
        public int AverageHumidity { get; set; }

        /// <summary>
        /// Номер карта анализов
        /// </summary>
        public int NumAnCard { get; set; }

        /// <summary>
        /// Номер партии
        /// </summary>
        public int NumPart { get; set; }

        /// <summary>
        /// Номер квитанции
        /// </summary>
        public int NumReceipt { get; set; }

        /// <summary>
        /// Карта анализов
        /// </summary>
        public virtual AnalysisCard AnalysisCard { get; set; }

        /// <summary>
        /// Партия
        /// </summary>
        public virtual Party Party { get; set; }
        

        /// <summary>
        /// Накладные
        /// </summary>
        public virtual ICollection<TTN> TTN { get; set; }

        public RegistryOfTTN(ActionData actionData)
        {
            NumRegistry = (int)actionData.fields[0];
            Date = (DateTime)actionData.fields[1];
            Agriculture = (Agriculture)actionData.fields[2];
            AverageSoreness = (int)actionData.fields[3];
            AverageHumidity = (int)actionData.fields[4];
            NumAnCard = (int)actionData.fields[5];
            NumPart = (int)actionData.fields[6];
            NumReceipt = (int)actionData.fields[7];
        }
    }
}