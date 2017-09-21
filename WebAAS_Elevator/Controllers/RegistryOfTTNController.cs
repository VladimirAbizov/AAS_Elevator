using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAAS_Elevator.Models;

namespace WebAAS_Elevator.Controllers
{
    public class RegistryOfTTNController : ApiController
    {
        private readonly BookkeepingContext _bookkeepingContext = new BookkeepingContext();

        /// <summary>
        /// Возвращает список всех реестров ТТН
        /// </summary>
        /// <returns></returns>
        // GET api/regttn
        public IEnumerable<RegistryOfTTN> Get()
        {
            return _bookkeepingContext.RegistersOfTTNs.ToList();
        }

        /// <summary>
        /// Возвращает реестр, найденный по номеру
        /// </summary>
        /// <param name="numRegOfTTN">Номер накладной</param>
        /// <returns></returns>
        // GET api/ttn/5
        public RegistryOfTTN Get(int numRegOfTTN)
            {
                return _bookkeepingContext.RegistersOfTTNs.Find(numRegOfTTN);
            }

            /// <summary>
            /// Добавляет реестр в базу данных
            /// </summary>
            /// <param name="actionData"></param>
            /// <returns></returns>
            // POST api/ttn
            public HttpResponseMessage Post(ActionData actionData)
            {
                if (actionData == null)
                    return new HttpResponseMessage(HttpStatusCode.NoContent);

                _bookkeepingContext.RegistersOfTTNs.Add(new RegistryOfTTN(actionData));
                _bookkeepingContext.SaveChanges();

                return new HttpResponseMessage(HttpStatusCode.Created);
            }

            /// <summary>
            /// Обновляет реестр в базе данных по идентификатору <see cref="RegistryOfTTN.NumRegistry"/>
            /// </summary>
            /// <param name="id"></param>
            /// <param name="registry"></param>
            // PUT api/ttn/5
            public void Put(int id, [FromBody]RegistryOfTTN registry)
            {
                if (id == registry.NumRegistry)
                {
                    _bookkeepingContext.Entry(registry).State = EntityState.Modified;

                    _bookkeepingContext.SaveChanges();
                }
            }

            /// <summary>
            /// Удаляет реестр из базы данных
            /// </summary>
            /// <param name="id"></param>
            // DELETE api/ttn/5
            public void Delete(int id)
            {
                RegistryOfTTN registry = _bookkeepingContext.RegistersOfTTNs.Find(id);
                if (registry != null)
                {
                    _bookkeepingContext.RegistersOfTTNs.Remove(registry);
                    _bookkeepingContext.SaveChanges();
                }
            }
    }
}
