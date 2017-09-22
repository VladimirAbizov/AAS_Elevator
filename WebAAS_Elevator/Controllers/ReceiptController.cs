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
    public class ReceiptController : ApiController
    {
        private readonly BookkeepingContext _bookkeepingContext = new BookkeepingContext();

        /// <summary>
        /// Возвращает список всех квитанций
        /// </summary>
        /// <returns></returns>
        // GET api/receipt
        public IEnumerable<Receipt> Get()
        {
            return _bookkeepingContext.Receipts.ToList();
        }

        /// <summary>
        /// Возвращает квитанцию, найденную по номеру
        /// </summary>
        /// <param name="numRec">Номер квитанции</param>
        /// <returns></returns>
        // GET api/receipt/5
        public Receipt Get(int numRec)
        {
            return _bookkeepingContext.Receipts.Find(numRec);
        }

        /// <summary>
        /// Добавляет квитанцию в базу данных
        /// </summary>
        /// <param name="actionData"></param>
        /// <returns></returns>
        // POST api/receipt
        public HttpResponseMessage Post(ActionData actionData)
        {
            if (actionData == null)
                return new HttpResponseMessage(HttpStatusCode.NoContent);

            _bookkeepingContext.Receipts.Add(new Receipt(actionData));
            _bookkeepingContext.SaveChanges();

            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        /// <summary>
        /// Обновляет квитанцию в базе данных по идентификатору <see cref="Receipt.NumReceipt"/>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="receipt"></param>
        // PUT api/receipt/5
        public void Put(int id, [FromBody]Receipt receipt)
        {
            if (id == receipt.NumReceipt)
            {
                _bookkeepingContext.Entry(receipt).State = EntityState.Modified;

                _bookkeepingContext.SaveChanges();
            }
        }

        /// <summary>
        /// Удаляет квитанцию из базы данных
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/receipt/5
        public void Delete(int id)
        {
            Receipt receipt = _bookkeepingContext.Receipts.Find(id);
            if (receipt != null)
            {
                _bookkeepingContext.Receipts.Remove(receipt);
                _bookkeepingContext.SaveChanges();
            }
        }
    }
}
