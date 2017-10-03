using System;
using System.ComponentModel.DataAnnotations;

namespace WebAAS_Elevator.Models
{
    /// <summary>
    /// Карта анализов
    /// </summary>
    public class AnalysisCard
    {
        /// <summary>
        /// Номер карты анализов
        /// </summary>
        [Key]
        public int NumAnCard { get; set; }

        /// <summary>
        /// Средняя сорность по реестру
        /// </summary>
        public int AverageSoreness { get; set; }

        /// <summary>
        /// Средняя влажность по реестру
        /// </summary>
        public int AverageHumidity { get; set; }

        /// <summary>
        /// Зараженность
        /// </summary>
        public int Infection { get; set; }

        /// <summary>
        /// Число падения
        /// </summary>
        public int NumberOfFalls { get; set; }

        /// <summary>
        /// Натура
        /// </summary>
        public int Nature { get; set; }

        /// <summary>
        /// Дата отбора пробы
        /// </summary>
        public DateTime DateOfSampling { get; set; }

        /// <summary>
        /// Номер журнала анализов
        /// </summary>
        public int NumOfAnJourn { get; set; }
    }
}