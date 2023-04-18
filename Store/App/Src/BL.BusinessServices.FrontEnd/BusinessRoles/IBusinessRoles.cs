using Retalix.StoreServices.Model.Infrastructure.DataMovement;
using Retalix.StoreServices.Model.Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retalix.StoreServices.BusinessServices.FrontEnd.BusinessRoles
{
   public interface IBusinessRoles 
    {
        int Roleid { get; set; }
        string BusinessUnitid { get; set; }
        string Rolecode { get; set; }
        string Name { get; set; }
    }
}
