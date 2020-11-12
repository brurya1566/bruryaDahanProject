using System;
using Common;
using System.Collections.Generic;

namespace DAL
{
    public  class ListsOfObjects
    {
        public static readonly List<Account> accountList = new List<Account>() {
        new Account(4711032, "brurya dahan"),
        new Account(5713032, "Mahesh Chand"),
        new Account(4511032, "Yoni cohen"),
        new Account(4351032, "Lilian levi"),
        new Account(5711032, "gidi chohen"),
        new Account(4315032, "Miri Weber"),
        new Account(3711035, "Nomi Pozen"),
        new Account(47000032, "Tami kalazan")
        };
        public static readonly List<Customer> customers = new List<Customer>()
        {
        new Customer(4711032, "brurya dahan","0527181566","brurya_ma@postil.com"),
        new Customer(5713032, "Mahesh Chand","0526895888","mkjh@gmail.com"),
        new Customer(4511032, "Yoni cohen","0583240898","y0583@hotmail.com"),
        new Customer(4351032, "Lilian levi","0533225658","gfgfdf@gmail.com"),
        new Customer(5711032, "gidi chohen","0584759665","052414@gmail.com"),
        new Customer(4315032, "Miri Weber","0532478596",""),
        new Customer(3711035, "Namir Pozen","0578965412",""),
        new Customer(47000032, "Tami kalazan","0527699585","")
        };
        public static List<AccountMovements> accountMovements = new List<AccountMovements>()
        {
            new AccountMovements(123,4711032,200,new DateTime(2020,05,02),2,1,222),
            new AccountMovements(124,4711032,200,new DateTime(2020,06,03),1,1,456),
            new AccountMovements(125,4711032,200,new DateTime(2020,08,28),9,2,789),
            new AccountMovements(126,4711032,200,new DateTime(2020,08,21),8,1,425),
            new AccountMovements(127,4711032,200,new DateTime(2020,05,15),7,2,728),
            new AccountMovements(128,4711032,200,new DateTime(2020,06,08),6,2,385),
            new AccountMovements(129,5713032,200,new DateTime(2020,01,02),2,1,415),
            new AccountMovements(130,5713032,200,new DateTime(2019,04,02),2,1,321),
            new AccountMovements(131,5713032,200,new DateTime(2020,05,02),2,1,745),
            new AccountMovements(132,5713032,200,new DateTime(2018,05,02),2,1,456),
            new AccountMovements(133,5713032,200,new DateTime(2020,08,02),2,1,456),
            new AccountMovements(134,5713032,200,new DateTime(2020,05,02),2,1,728),
            new AccountMovements(135,5713032,200,new DateTime(2020,05,08),2,1,745),
            new AccountMovements(136,4711032,200,new DateTime(2020,05,02),2,1,456),
            new AccountMovements(137,4711032,200,new DateTime(2020,05,02),2,1,222),
            new AccountMovements(138,4711032,200,new DateTime(2020,05,08),2,1,222),
            new AccountMovements(139,4711032,200,new DateTime(2020,08,02),2,1,456),
            new AccountMovements(140,4711032,200,new DateTime(2020,05,02),2,1,789),
            new AccountMovements(141,4711032,200,new DateTime(2020,05,02),2,1,425),
            new AccountMovements(142,4711032,200,new DateTime(2020,05,02),2,1,728),
            new AccountMovements(143,4711032,200,new DateTime(2020,05,02),2,1,385),
            new AccountMovements(145,4711032,200,new DateTime(2020,05,02),2,1,415),
            new AccountMovements(146,4711032,200,new DateTime(2020,05,02),2,1,321),
            new AccountMovements(147,4711032,200,new DateTime(2020,05,02),2,1,745),
            new AccountMovements(148,4711032,200,new DateTime(2020,05,02),2,1,456),
            new AccountMovements(149,4711032,200,new DateTime(2020,05,02),2,1,456),
            new AccountMovements(150,4711032,200,new DateTime(2020,05,02),2,1,728),
            new AccountMovements(151,4711032,200,new DateTime(2019,04,08),2,1,222),
            new AccountMovements(152,4711032,200,new DateTime(2020,05,02),2,1,456),
            new AccountMovements(153,4711032,200,new DateTime(2020,05,02),2,1,789),
            new AccountMovements(154,4711032,200,new DateTime(2012,05,02),2,1,425),
            new AccountMovements(155,4711032,200,new DateTime(2018,05,02),2,1,728),
            new AccountMovements(156,4711032,200,new DateTime(2020,05,02),2,1,385)
                                                                              
        };                                                                    
        public static List<AccountMovements>  GetListTest()                   
        {                                                                     
            var  accountMovements = new List<AccountMovements>()              
        {                                                                     
            new AccountMovements(123,4711032,200,2,1,456)

        };
            return accountMovements;
    }
        public static readonly List<branch> branches = new List<branch>()
        {
            new branch(456,"Yafo 21",1),
            new branch(789,"Hahagana 9",1),
            new branch(425,"Hahalutz 56",2),
            new branch(222,"Ben moshe 14",2),
            new branch(745,"Haganenet 55",3),
            new branch(758,"Tel Aviv Darom",2),
            new branch(869,"Eylat",5),
            new branch(321,"Hanes 5",1),
            new branch(985,"Openhion 78",7),
            new branch(415,"Matalon 80",9),

        };
        public static readonly List<city> cities = new List<city>()
        {
            new city(1,"Jerusalem"),
            new city(2,"Tel Aviv"),
            new city(3,"heifa"),
            new city(4,"Ashdod"),
            new city(5,"Ashkelon"),
            new city(6,"Maalot"),
            new city(7,"Eylat"),
            new city(8,"Sefat"),
            new city(9,"Petach tikva"),
            new city(10,"Yokneam"),

        };
        public static readonly List<SubjectAction> subjectActions = new List<SubjectAction>()
        {
            new SubjectAction(1,"deposit Check"),
            new SubjectAction(2,"Invite Check"),
             new SubjectAction(3,"Cancel Check"),
            new SubjectAction(4,"Western Union"),
            new SubjectAction(5,"EuroGiro"),
            new SubjectAction(6,"EuroGiro"),
            new SubjectAction(7,"Cash In Time"),
            new SubjectAction(8,"Charge Card"),
            new SubjectAction(9,"Money Transfer")
        };
    }

}
