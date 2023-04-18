using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retalix.StoreServices.BusinessServices.FrontEnd.BusinessRoles
{
    [Serializable]
    public class BusinessRoles : IBusinessRoles
    {
        public BusinessRoles() { }
        public virtual int Roleid { get; set; }
        public virtual string BusinessUnitid { get; set; }
        public virtual string Rolecode { get; set; }
        public virtual string Name { get; set; }
    }
}
