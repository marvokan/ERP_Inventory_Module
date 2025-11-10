using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Data;
using Lib.Data.DB;
using Inventory.Common;
using Inventory.Data.Tables;

namespace Inventory.Data
{
    public class CDataTableFactory: Dictionary<string, Type>
    {
        // [.NET] Automatic lazy initialization mechanism with the built-in Lazy class.
        // The constructor of Lazy needs a function, here an anonymous function is created with a lambda expression
        private static Lazy<CDataTableFactory> _instanceLazy = new Lazy<CDataTableFactory>(() => new CDataTableFactory());

        public static CDataTableFactory Instance { get { return _instanceLazy.Value; } }

        // ................................................................
        private CDBMSSQL _db = null!;
        public CDBMSSQL DB
        {
            get
            {
                // [PATTERNS] Lazy initialization: Establishes a DB connection on first use
                if (_db == null)
                {
                    _db = new CDBMSSQL()
                    {
                        ServerName = CSettings.Instance.DBServerURL,
                        DatabaseName = CSettings.Instance.DBName,
                        UserName = CSettings.Instance.DBUser,
                        Password = CSettings.Instance.DBPassword
                    };
                    _db.Connect();
                }
                return _db;
            }

        }
        // ................................................................



        // ----------------------------------------------------------------------------------
        public CDataTableFactory()
        {
            // [PATTERNS] Factory Method: We register classes for specified identifiers
            // so that the factory method can use them for creating table object.
            this["Item"] = typeof(TableITEM);
            this["ItemInv"] = typeof(TableITEM_INV);
            this["ItemInvLine"] = typeof(TableITEM_INV_LINE);
            this["ItemPkg"] = typeof(TableITEM_PKG);
            this["Store"] = typeof(TableSTORE);
            this["StorePos"] = typeof(TableSTORE_POS);
            this["ViewInventories"] = typeof(ViewINVENTORIES);
        }
        // ----------------------------------------------------------------------------------
        // [PATTERNS] Factory Method
        public IDBTable? Produce(string p_sTableIdentifier)
        {
            IDBTable? iResult = null;
            if (this.ContainsKey(p_sTableIdentifier))
            {
                // [C#] [ADVANCED] Creating an object using a class type reference.
                Type p_tTableClass = this[p_sTableIdentifier];
                Object oTable = Activator.CreateInstance(p_tTableClass)!;
                iResult = oTable as IDBTable;
                if (iResult != null)
                    iResult.DB = this.DB;
            }
            return iResult;
        }
        // ----------------------------------------------------------------------------------
    }
}
