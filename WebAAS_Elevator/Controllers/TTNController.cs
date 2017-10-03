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
    public class TTNController : ApiController
    {
        private readonly BookkeepingContext _bookkeepingContext = new BookkeepingContext();

        /// <summary>
        /// Возвращает список всех накладных
        /// </summary>
        /// <returns></returns>
        // GET api/ttn
        public IEnumerable<TTN> Get()
        {
            var temp = _bookkeepingContext.TTNs.ToList();
            if (temp == null)
                return null;
            return temp;
        }

        /// <summary>
        /// Возвращает накладную, найденную по номеру
        /// </summary>
        /// <param name="numTTN">Номер накладной</param>
        /// <returns></returns>
        // GET api/ttn/
        public TTN Get(int numTTN)
        {
            return _bookkeepingContext.TTNs.Find(numTTN);
        }

        /// <summary>
        /// Добавляет накладную в базу данных
        /// </summary>
        /// <param name="actionData"></param>
        /// <returns></returns>
        // POST api/ttn
        public HttpResponseMessage Post(ActionData actionData)
        {
            if (actionData == null)
                return new HttpResponseMessage(HttpStatusCode.NoContent);

            _bookkeepingContext.TTNs.Add(new TTN(actionData));
            _bookkeepingContext.SaveChanges();

            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        /// <summary>
        /// Обновляет накладную в базе данных по идентификатору <see cref="TTN.NumTTN"/>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ttn"></param>
        // PUT api/ttn/5
        public void Put(int id, [FromBody]TTN ttn)
        {
            if (id == ttn.NumTTN)
            {
                _bookkeepingContext.Entry(ttn).State = EntityState.Modified;

                _bookkeepingContext.SaveChanges();
            }
        }

        /// <summary>
        /// Удаляет накладную из базы данных
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/ttn/5
        public void Delete(int id)
        {
            TTN ttn = _bookkeepingContext.TTNs.Find(id);
            if (ttn != null)
            {
                _bookkeepingContext.TTNs.Remove(ttn);
                _bookkeepingContext.SaveChanges();
            }
        }
    }
}
