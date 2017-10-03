using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAAS_Elevator.Models
{
    /// <summary>
    /// Сорт
    /// </summary>
    public class Grade
    {
        /// <summary>
        /// Номер сорта
        /// </summary>
        [Key]
        public int NumGrade { get; set; }

        /// <summary>
        /// Наименование сорта
        /// </summary>
        public string NameGrade { get; set; }

        /// <summary>
        /// Перечни материальных средств
        /// </summary>
        public virtual ICollection<ListOfMaterial> listOfMaterial { get; set; }

        /// <summary>
        /// Накладные
        /// </summary>
        public virtual ICollection<TTN> TTN { get; set; }
    }
}