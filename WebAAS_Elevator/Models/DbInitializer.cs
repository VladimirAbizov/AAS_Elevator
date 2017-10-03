using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAAS_Elevator.Models
{
    public class DbInitializer : DropCreateDatabaseAlways<BookkeepingContext>
    {
        protected override void Seed(BookkeepingContext db)
        {
            ActionData actionData = new ActionData(new List<object>());
            actionData.fields.Add(new DateTime(2000, 1, 1));
            actionData.fields.Add(1);
            actionData.fields.Add(2);
            actionData.fields.Add(3);

            db.TTNs.Add(new TTN(actionData));
            db.TTNs.Add(new TTN(actionData));
            db.TTNs.Add(new TTN(actionData));
            db.TTNs.Add(new TTN(actionData));
            db.TTNs.Add(new TTN(actionData));
            db.SaveChanges();

            base.Seed(db);
        }
    }
}