﻿using System;
using calculator;
using StudentName;
using collegestrength;
using Typocasting;
using Typeconverting;
using LoanInterestcalculation;
using Conditionalstatement;
using GradeSystem;
using Operators;
using parameterandreturntype;
using Alphabetvowels;
using Constructor;
using Loopingstate;
using Arrayfunction;
using Userdefinedfun;
using Electioncandidate;
using Propertycheck;
using Programque;
using Statictype;
using Extension;
using Vowelprogram;
using OOPSCONCEPT;
//using Polymorphism;
using Polyexecrise;
using Biggestcheck;
using numberreverse;
using Wordcount;
using Wordreverse;
using ExceptionalHandling;
using GenericList;
using System.Collections.Generic;
using Naveenbusinesslayer;




namespace NaveenpConsoleApp1
{

    /*class Program
    {
        static void Main(string[] args)
        {
            arthematic add = new arthematic();
            add.addition();

            arthematic sub = new arthematic();
            sub.subtraction();

            arthematic div = new arthematic();
            div.divide();
            
        }
       
        

        
    }*/

    //class Program
    //{
    //    static void Main(string [] args)
    //    {
    //        Studenttotal marks = new Studenttotal();
    //        marks.Totalmark();

    //    }
    /*class college
 {
     static void Main(string[] args)
     {
         sections total = new sections();
         sectionsofcollege totalcollege = new sectionsofcollege();
         total.Electrical();
         total.Computer();
         totalcollege.Mechanical();
         totalcollege.Civil();
         total.totaldepartment = totalcollege.totalsdepartment;
         int wholedepartment = 20;
         Console.WriteLine(total.totaldepartment+wholedepartment);
         total.ecestaff = totalcollege.mechstaff;
         int ecemechstaff = (  totalcollege.mechstaff);
         Console.WriteLine("both the departments have same amount of staffs"+" " + ecemechstaff);

     }



}*/
    //// class programs
    // {
    //     static void Main(string[] args)
    //     {
    //         Casting data = new Casting();
    //         data.changing();

    //     }//


    //    class bankloan
    //{
    //    static void Main(string[] args)
    //    {
    //        Interestcalculation data = new Interestcalculation();
    //            data.Interest();
    //        data.Compoundinterest();


    //    }

    //}
    //class Ifprogram
    //{
    //    static void Main(string[] args)
    //    {
    //        Conditions data = new Conditions();
    //        //data.ifcondition();
    //        //data.Evenorodd();
    //        //data.Simple();
    //        data.Leapyear();
    //    }

    //class operating 
    //{
    //    static void Main(string[] args)
    //    {
    //        Operatorfun data = new Operatorfun();
    //        //data.arthematicopp(20,30);
    //        //data.conditonopp(10,20);
    //        //data.Logicalopp(10, 20);
    //        //data.unaryopp(10);
    //    }


    //}

    //class Gradeoperate
    //{
    //    static void Main(string[] args)
    //    {
    //        StudentGrade data = new StudentGrade();
    //        data.TotalMark();
    //        data.Markcheck();
    //    }
    //}

    //class Programreturn
    //{
    //    static void Main(string[] args)
    //    {
    //        //Nonreturntype data = new Nonreturntype();
    //        //data.Nonreturn();

    //        Returntype data1 = new Returntype();

    //        Console.WriteLine(data1.Addition());



    //Nonreturnpara data2 = new Nonreturnpara();
    //data2.num(10,10,10);


    //returnpara data3 = new returnpara();

    //Console.WriteLine(data3.Add(10, 20, 30));
    //Console.WriteLine(data3.Add(30, 30, 30));
    //Console.WriteLine(data3.Add(50, 30, 50));


    //returnparaex data4 = new returnparaex();
    //Console.WriteLine(data4.details(10, "naveen",'m'));

    // }
    //}

    //class program
    //{
    //    static void Main (string[] args)
    //    {
    //        vowels data = new vowels();
    //        data.vowelcheck();
    //    }
    //}
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        Constructorexe data = new Constructorexe();
    //        Constructorexe data1 = new Constructorexe(10,10);
    //        Constructorexe data2 = new Constructorexe(70);
    //        Constructorexe data3 = new Constructorexe(22,"naveen");
    //    }
    //}

    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Console.WriteLine("these are the even number between 0 to 50");
    //        //Forlooping data = new Forlooping();
    //        //Console.WriteLine("these are the odd number between 0 to 50");
    //        //Oddlooping data1 = new Oddlooping();
    //        //Console.WriteLine("two table");
    //        //Twotable data2 = new Twotable();
    //        Examples data3 = new Examples();
    //        //data3.Loopexamples();
    //        data3.Naturalnumber();

    //    }
    //}
    //class Arrayprogram
    // {
    //     static void Main(string[] args)
    //     {
    //Arraycondition data = new Arraycondition();
    //data.Arrayfun();
    //Studentdetails data1 = new Studentdetails();
    //data1.StudentData();
    //Summing data2 = new Summing();
    //Console.WriteLine(data2.Addition(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
    //Productsales data = new Productsales();
    //data.Monthlysales();
    //Markdetails data = new Markdetails();
    //data.Calculation();
    //Detailelection datanew = new Detailelection();
    //Detailfetch datas = new Detailfetch();
    //Detailelection[] dd = datas.Details();
    //for (int i = 0; i < datas.count; i++)
    //{
    //    Console.WriteLine("these are the candidate details");
    //    Console.WriteLine(dd[i].name);
    //    Console.WriteLine(dd[i].constitution);
    //    Console.WriteLine(dd[i].age);
    //}












    //    }
    //}
    //class program
    //{
    //static void Main(string[] args)
    //{
    //    string[] names = new string[] { "naveen", "magesh", "pranesh", "dinesh", "rakesh" };
    //    Hospitaldetails source = new Hospitaldetails();
    //    Property[] sd = (source.Details(names));
    //    for (int i = 0; i < sd.Length; i++)
    //    {

    //            Console.WriteLine(sd[i].DoctorName);

    //            Console.WriteLine(sd[i].Qualification);

    //            Console.WriteLine(sd[i].Docage);
    //        }
    //    }
    //}
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Printingque data = new Printingque();
    //        //data.Question();
    //        Staticclasstype data = new Staticclasstype();
    //        data.name = "naveen";
    //        Staticclasstype.count = 10;
    //        Console.WriteLine(data.name);
    //        Console.WriteLine(Staticclasstype.count);
    //        source.details();
    //        A obj = new A();
    //        A obj1 = new A(10, 20);


    //    }
    //}
    //class Addingexten
    //{
    //    static void Main(String[] args)
    //    {
    //        TestExtension data = new TestExtension();
    //        data.Testing();
    //    }
    //}
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        Separatevowelcount data = new Separatevowelcount();
    //        data.Finding();
    //    }
    //}
    //class program
    //{
    //   static void Main(string[] args)
    //    {
    //        Multilevel data = new Multilevel();
    //        data.multileveling();
           

    //    }
    class program
    {
        static void Main(string[] args)
        {
            //overridingconc data = new overridingconc();
            //data.Names();
            //Nextstep data1 = new Nextstep();
            //data1.Names();
            //Laststep data2 = new Laststep();
            //data2.Names();
            //polyexam data = new polyexam();
            //data.Mainfun();
            //Nextstep data = new Nextstep();
            //data.Submain(10);
            //string ww = (data.Submain(10));
            //Console.WriteLine(ww);
            //Biggestnofind data = new Biggestnofind();
            //data.checking();
            //ternarycheck data1 = new ternarycheck();
            //data1.Checkternary();
            //numReversing data = new numReversing();
            //data.Numberev();
            //Counting data = new Counting();
            //data.wordcou();
            //countingwoin datas = new countingwoin();
            //datas.countsword();
            //Reversing data = new Reversing();
            //data.wordcou();
            //Reversingwosplit data1 = new Reversingwosplit();
            //data1.words();
            //try
            //{
            //    Exceptional data = new Exceptional();
            //    data.words();
            //}
            //catch (Exception A)
            //{
            //    Console.WriteLine("the input is wrong");
            //}
            //try
            //{
            //    ListExe Info = new ListExe();
            //    List<Employee> Last = Info.Details();
            //    for (int j = 0; j < Last.Count; j++)
            //    {
            //        Console.WriteLine("-----------------Employee Detail-----------------");
            //        Console.WriteLine($"Employee Name:{Last[j].Name}");
            //        Console.WriteLine($"Employee Name:{Last[j].Age}");
            //        Console.WriteLine($"Employee Location:{Last[j].Location}");
            //    }
            //}
            //catch(Exception A)
            //{
            //    Console.WriteLine(A);

            //}
            try
            {
                RegistrationServicenk data = new RegistrationServicenk();
                data.GetUserInfo();
            }
            catch(Exception ex)
            {
                Console.WriteLine("something went wrong");
            }
            finally
            {

            }




        }
    }
 }

   

    

    
