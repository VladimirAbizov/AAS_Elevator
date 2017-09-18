using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAAS_Elevator.Models
{   
    /// <summary>
    /// Отходы
    /// </summary>
    public class Waste
    {
        /// <summary>
        /// Номер ФККО
        /// </summary>
        public string NumFKKO { get; set; }

        /// <summary>
        /// Наименование отходов
        /// </summary>
        public string NameWaste { get; set; }
    }
}