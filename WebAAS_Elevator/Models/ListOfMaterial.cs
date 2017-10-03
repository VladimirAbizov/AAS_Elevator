using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAAS_Elevator.Models
{
    /// <summary>
    /// Перечень материальных ценностей
    /// </summary>
    public class ListOfMaterial
    {
        /// <summary>
        /// Номер пречня
        /// </summary>
        [Key]
        public int NumList { get; set; }

        /// <summary>
        /// Матер. ценность
        /// </summary>
        public string MaterialValue { get; set; }

        /// <summary>
        /// Единица измерения
        /// </summary>
        public int Unit { get; set; }

        /// <summary>
        /// Колличество
        /// </summary>
        public int Sum { get; set; }

        ///// <summary>
        ///// Доверенность, к которому прикреплен перечень
        ///// </summary>
        //public virtual PowerOfAttorney PowerOfAttorney { get; set; }

        /// <summary>
        /// Сорт
        /// </summary>
        public virtual Grade Grade { get; set; }
    }
}