using Lib.Data;
using Lib.Logic;
using System.Collections;

namespace Lib.Logic.Visitors
{
    public class CVisitorToModel
    {
        public void VisitCopy<T>(IDBTable p_oSourceTable, List<T> p_oDestModel) where T: IEntity, new() 
        {
            p_oDestModel.Clear();
            foreach (var oRec in p_oSourceTable.RecordSet)
            {
                T oBank = new T() { Rec = oRec };
                p_oDestModel.Add(oBank);    
            }
        }

    }
}
