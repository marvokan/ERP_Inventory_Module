using Inventory.Logic.Entities;
using Lib.Logic;
using Lib.Logic.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Inventory.Logic.Models
{
    public class CStatusModel : List<CStatus>, IModel
    {
        public void AcceptVisitAfterLoad(CVisitorToModel p_oVisitor)
        {
        }

        public void AcceptVisitBeforeSave(CVisitorToTable p_oVisitor)
        {
        }

        public void Delete()
        {
        }

        public void Load()
        {
         
            this.Add(new CStatus() { ID = 0, Name = "Incomplete" });
            this.Add(new CStatus() { ID = 1, Name = "Complete" });
            this.Add(new CStatus() { ID = 2, Name = "InProgress" });

        }

        public IEntity New()
        {
            return null;
        }

        public int Save()
        {
            return 0;
        }
    }
}
