using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Common
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string mailAdress { get; set; }
        public Customer() { }
        public Customer(int id, string name, string phone, string mailAdress)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.mailAdress = mailAdress;
        }
    }
    public class Bridge
    {
        public int id { get; set; }
        public int accountNumber { get; set; }
    }
    public class Account
    {
        public int accountNumber { get; set; }
        public string accountName { get; set; }

        public Account()
        {
        }

        public Account(int accountNumber, string accountName)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
        }
    }

    public class AccountMovements
    {
        public int pkReferenceCode { get; set; }
        public int accountNumber { get; set; }
        public int sum { get; set; }
        public DateTime datePeilut { get; set; }
        public int subjectCode { get; set; }
        public int codeZchutChova { get; set; }
        public int branchCode { get; set; }
        public AccountMovements() { }
        public AccountMovements(int pkReferenceCode,int accountNumber,int sum, DateTime datePeilut, int codeNose, int codeZchutChova, int codeSnif)
        {
            this.pkReferenceCode = pkReferenceCode;
            this.accountNumber = accountNumber;
            this.sum = sum;
            this.datePeilut = datePeilut;
            this.subjectCode = codeNose;
            this.codeZchutChova = codeZchutChova;
            this.branchCode = codeSnif;
        }
        public AccountMovements(int pkReferenceCode, int accountNumber, int sum, int codeNose, int codeZchutChova, int codeSnif)
        {
            this.pkReferenceCode = pkReferenceCode;
            this.accountNumber = accountNumber;
            this.sum = sum;
            this.subjectCode = codeNose;
            this.codeZchutChova = codeZchutChova;
            this.branchCode = codeSnif;
        }


    }
    public class SubjectAction
    {
        public int subjectCode { get; set; }
        public string descSubject { get; set; }
        public SubjectAction() { }
        public SubjectAction(int subjectCode, string descSubject)
        {
            this.subjectCode = subjectCode;
            this.descSubject = descSubject;

        }
    }
    public class branch
    {
        public int branchCode { get; set; }
        public string descBranch { get; set; }
        public int cityCode { get; set; }
        public branch() { }
        public branch(int branchCode, string descBranch,int cityCode)
        {
            this.cityCode = cityCode;
            this.branchCode = branchCode;
            this.descBranch = descBranch;
        }
    }
    public class city
    {
        public int cityCode { get; set; }
        public string descCity { get; set; }
        public city() { }
        public city(int cityCode, string descCity)
        {
            this.cityCode = cityCode;
            this.descCity = descCity;
        }
    }
}
