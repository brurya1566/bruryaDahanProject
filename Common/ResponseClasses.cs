using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class AccountMovementsResponse:AccountMovements
    {
        public string descSubject;
        public string descBranch;
        public AccountMovementsResponse() { }
        public AccountMovementsResponse(AccountMovements AccountMovements,branch branch,SubjectAction subject):base(AccountMovements.pkReferenceCode, AccountMovements.accountNumber,AccountMovements.sum, AccountMovements.datePeilut, AccountMovements.subjectCode, AccountMovements.codeZchutChova, AccountMovements.branchCode)
        {
            this.descSubject = subject.descSubject;
            this.descBranch = branch.descBranch;

        }
    }

}
