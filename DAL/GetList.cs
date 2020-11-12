using System;
using Common;
using System.Collections.Generic;
using System.Linq;
namespace DAL
{
    public class GetList
    {
        public static List<AccountMovementsResponse> getAccountMovements(int skip)
        {
            try
            {
                var t = (from a in ListsOfObjects.accountMovements.OrderByDescending(o => o.pkReferenceCode).Skip(skip).Take(10)
                         join b in ListsOfObjects.branches
                         on a.branchCode equals b.branchCode
                         join c in ListsOfObjects.subjectActions
                         on a.subjectCode equals c.subjectCode
                         select new AccountMovementsResponse(a, b, c)).ToList();
                return t;
            }
            catch
            {
                return null;
            }
        }
        public static AccountMovementsResponse GetAccountMovementByPkReferenceCode(int pkReferenceCode)
        {
            try
            {
                return (from a in ListsOfObjects.accountMovements.Where(o => o.pkReferenceCode == pkReferenceCode)
                        join b in ListsOfObjects.branches
                        on a.branchCode equals b.branchCode
                        join c in ListsOfObjects.subjectActions
                        on a.subjectCode equals c.subjectCode
                        select new AccountMovementsResponse(a, b, c)).ToList()[0];
            }
            catch
            {
                return null;
            }
        }
        public static List<branch> GetBranchList()
        {
            try
            {
                return ListsOfObjects.branches;
            }
            catch
            {
                return null;
            }
        }

        public static List<city> GetCityList()
        {
            try
            {
                return ListsOfObjects.cities;
            }
            catch
            {
                return null;
            }
        }
    }
}