using System.Collections.Generic;

namespace WebAAS_Elevator.Models
{
    /// <summary>
    /// Объект для хранения полей передаваемого объекта (для POST-запросов)
    /// </summary>
    public class ActionData
    {
        /// <summary>
        /// Массив для хранения полей передаваемого объекта
        /// </summary>
        public List<object> fields { get; set; }

        public ActionData(List<object> list)
        {
            fields = list;
        }
    }
}