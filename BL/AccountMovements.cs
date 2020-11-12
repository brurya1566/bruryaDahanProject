using System;
using System.Collections.Generic;
using Common;
using DAL;


namespace BL
{
    public static class AccountMovements
    {
        public static List<AccountMovementsResponse> getAccountMovements(int skip)
        {
            return GetList.getAccountMovements(skip);
        }
        public static AccountMovementsResponse GetAccountMovementByPkReferenceCode(int pkReferenceCode)
        {
            return GetList.GetAccountMovementByPkReferenceCode(pkReferenceCode);
        }
        public static List<branch> GetBranchList()
        {
            return GetList.GetBranchList();
        }        
        public static List<city> GetCityList()
        {
            return GetList.GetCityList();
        }
    }
}
