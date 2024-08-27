using System;

namespace BusinessLayer
{
    public interface ICommunication
    {

        public void SendSMS();
    }


    public class MemberResgirtation : ExceptionHandling, ICommunication
    {
        public MemberResgirtation( int c,string j):base(c,j)
        {
           
            Console.WriteLine($"MemberRegistration----{c}");

        }

        public override void M1()
        {
            //jhgjggjh
        }

        public void SendSMS()
        {
            //jasgfjdsg
        }

        public void RegisterUser()
        {

            try
            {
                int b = 0;
                var a = 10 / b;
                var name = Console.ReadLine();
                //

                base.SendEMail();
                M3();

            }catch (Exception e)
            {
                throw e;
            }
        }


        protected override void SendEMail()
        {
            //Anaiyaan SMTP 
        }
        public void Order ()
        {
            SendEMail();
        }
    }
}
