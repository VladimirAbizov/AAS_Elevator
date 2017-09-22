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
    public class POAController : ApiController
    {
        private readonly BookkeepingContext _bookkeepingContext = new BookkeepingContext();

        /// <summary>
        /// Возвращает список всех доверенностей
        /// </summary>
        /// <returns></returns>
        // GET api/poa
        public IEnumerable<PowerOfAttorney> Get()
        {
            return _bookkeepingContext.PowersOfAttorney.ToList();
        }

        /// <summary>
        /// Возвращает доверенность, найденную по номеру
        /// </summary>
        /// <param name="numPOA">Номер доверенности</param>
        /// <returns></returns>
        // GET api/poa/5
        public PowerOfAttorney Get(int numPOA)
        {
            return _bookkeepingContext.PowersOfAttorney.Find(numPOA);
        }

        /// <summary>
        /// Добавляет доверенность в базу данных
        /// </summary>
        /// <param name="actionData"></param>
        /// <returns></returns>
        // POST api/poa
        public HttpResponseMessage Post(ActionData actionData)
        {
            if (actionData == null)
                return new HttpResponseMessage(HttpStatusCode.NoContent);

            _bookkeepingContext.PowersOfAttorney.Add(new PowerOfAttorney(actionData));
            _bookkeepingContext.SaveChanges();

            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        /// <summary>
        /// Обновляет доверенность в базе данных по идентификатору <see cref="PowerOfAttorney.NumPowOfAttorney"/>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="poa"></param>
        // PUT api/poa/5
        public void Put(int id, [FromBody]PowerOfAttorney poa)
        {
            if (id == poa.NumPowOfAttorney)
            {
                _bookkeepingContext.Entry(poa).State = EntityState.Modified;

                _bookkeepingContext.SaveChanges();
            }
        }

        /// <summary>
        /// Удаляет довереннось из базы данных
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/poa/5
        public void Delete(int id)
        {
            PowerOfAttorney poa = _bookkeepingContext.PowersOfAttorney.Find(id);
            if (poa != null)
            {
                _bookkeepingContext.PowersOfAttorney.Remove(poa);
                _bookkeepingContext.SaveChanges();
            }
        }
    }
}
