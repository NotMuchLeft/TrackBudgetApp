﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackBudgetApp.Business.Abstract;
using TrackBudgetApp.Business.Concrete;
using TrackBudgetApp.DataAccess.Concrete.EntityFramework;
using TrackBudgetApp.Entities.Concrete;

namespace TrackBudgetApp.ConsoleUI
{
    class Program
    {
       
        static void Main(string[] args)
        {
           

            //CategoryManager categoryManager=new CategoryManager(new EfCategoryDal());

            ////List<Transaction> transactionList= userManager.GetAllTransactionsByUserId(2);

            ////foreach (var transaction in transactionList)
            ////{
            ////    Console.WriteLine(transaction.Amount);
            ////    Console.WriteLine(transaction.CategoryId);
            ////    Console.WriteLine(transaction.Description);
            ////    Console.WriteLine(transaction.EffectiveTime);
            ////    Console.WriteLine(transaction.IssuedTime);
            ////    Console.WriteLine(transaction.Name);
            ////    Console.WriteLine(transaction.RepetitionAfterXDay);
            ////    Console.WriteLine(transaction.TypeId);
            ////    Console.WriteLine(transaction.UserId);
            ////    Console.WriteLine(transaction.Id);
            ////}

            ////var currentBudget = userManager.CalculateBudgetDependingOnTimeAndUser(DateTime.Now,
            ////    "ahmettkuris@gmail.com");

            ////Console.WriteLine("Current Budget: {0}", currentBudget);

            //List<Category> listCategories= categoryManager.GetAll();


            //foreach (var category in listCategories)
            //{
            //    Console.WriteLine(category.Name);
            //    Console.WriteLine(category.UserId);
            //}
           Console.ReadLine();

        }
    }

    
}
