using NHibernate;
using NHibernate.Criterion;
using Retalix.StoreServices.Model.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retalix.StoreServices.BusinessServices.FrontEnd.BusinessRoles
{
    class BusinessRolesDao : IBusinessRolesDao
    {
        private readonly ISessionProvider<ISession> _sessionProvider;
        public BusinessRolesDao(ISessionProvider<ISession> sessionProvider, IDataAccessManager dataAccessManager)
        {
            _sessionProvider = sessionProvider;
        }
        private ISession Session
        {
            get { return _sessionProvider.Session; }
        }
        public IBusinessRoles Find(string name)
        {
            var query = Session.QueryOver<IBusinessRoles>().Where(u => u.Rolecode == name);
            var returnedApplicationLink = query.SingleOrDefault();
            return returnedApplicationLink;
        }
        public IBusinessRoles Get(string Key)
        {
            var criteria = Session.CreateCriteria(typeof(IBusinessRoles)).Add(Restrictions.Eq("Roleid", Key));
            var result = criteria.List<IBusinessRoles>();
            return result.FirstOrDefault();
        }
        public IEnumerable<IBusinessRoles> GetAll()
        {
            List<IBusinessRoles> records = Session.Query<IBusinessRoles>().ToList();
            return records;
        }
        public IBusinessRoles GetItemById(string Roleid, string BusinessUnitid)
        {
            //Log.Info(message => message("BundleItemDao.GetBundleItemById : entered"));

            return Session.CreateCriteria(typeof(IBusinessRoles))
                .Add(Restrictions.Eq("Roleid", Roleid))
                .Add(Restrictions.Eq("BusinessUnitId", BusinessUnitid)).UniqueResult<IBusinessRoles>();
        }
        public void SaveOrUpdate(IBusinessRoles BusinessRole)
        {
            var ExitingBusinessRole = Get(BusinessRole.Roleid.ToString());
            if (ExitingBusinessRole != null)
            {
                ExitingBusinessRole.Rolecode = BusinessRole.Rolecode;
                ExitingBusinessRole.Name = BusinessRole.Name;
                ExitingBusinessRole.BusinessUnitid = BusinessRole.BusinessUnitid;
            }
            else
            {
                ExitingBusinessRole = BusinessRole;
            }
            Session.SaveOrUpdate("BusinessRoles", ExitingBusinessRole);
            Session.Flush();
        }
        public void Save(IBusinessRoles BusinessRole)
        {
            Session.Save(BusinessRole);
            Session.Flush();
        }
        public void Update(IBusinessRoles BusinessRole)
        {
            var _BusinessRole = Find(BusinessRole.Rolecode);
            if (_BusinessRole == null)
                Session.SaveOrUpdate(_BusinessRole);
            else
                Session.Merge(BusinessRole);
            Session.Flush();
        }
        public void Delete(IBusinessRoles BusinessRole)
        {
            Session.Delete(BusinessRole);
        }
    }
}
