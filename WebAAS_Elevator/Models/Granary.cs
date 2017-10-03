using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAAS_Elevator.Models
{
    /// <summary>
    /// Зернохранилище
    /// </summary>
    public class Granary
    {
        /// <summary>
        /// Номер хранилища
        /// </summary>
        [Key]
        public int NumGranary { get; set; }

        /// <summary>
        /// Ёмкость хранилища
        /// </summary>
        public int Capacity { get; set; }
    }
}