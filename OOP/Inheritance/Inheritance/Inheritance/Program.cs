using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //NormalMember mem1 = new NormalMember("Special Rate", "Rick", 1, 2020);

            //VIPMember mem2 = new VIPMember("Joe", 2, 2021);

            //mem1.CalculateAnnualFee();
            //mem2.CalculateAnnualFee();

            //Console.WriteLine(mem1.ToString());
            //Console.WriteLine(mem2.ToString());


            // POLYMORPHISM

            Member[] clubMembers = new Member[5];

            clubMembers[0] = new NormalMember("Special Rate", "James", 1, 2010);
            clubMembers[1] = new NormalMember("Normal Rate", "Andy", 2, 2011);
            clubMembers[2] = new NormalMember("Normal Rate", "Bill", 3, 2011);
            clubMembers[3] = new VIPMember("Carol", 1, 2012);
            clubMembers[4] = new VIPMember("Evelyn", 1, 2012);

            foreach(Member m in clubMembers)
            {
                m.CalculateAnnualFee();
                Console.WriteLine(m.ToString());
            }

            if (clubMembers[3].GetType() == typeof(VIPMember))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.Read();

        }
    }

    class Member
    {
        protected int annualFee;
        private string name;
        private int memberID;
        private int memberSince;


        public virtual void CalculateAnnualFee()
        {
            annualFee = 0;
        }

        public override string ToString()
        {
            return "\nName: " + name + "\nMember ID: " + memberID + "\nMember Since: " + memberSince + "\nTotal Annual Fee: " + annualFee;
        }

        public Member()
        {
            Console.WriteLine("Parent Constructor with no parameters");
        }

        public Member(string pName, int pMemberID, int pMemberSince)
        {
            Console.WriteLine("Parent Constructor with no parameters");

            name = pName;
            memberID = pMemberID;
            memberSince = pMemberSince;
        }
    }

    class NormalMember : Member
    { 
        public NormalMember()
        {
            Console.WriteLine("Child constructor with no parameter");
        }

        public NormalMember(string remarks, string name, int memberID, int memberSince) : base(name, memberID, memberSince)
        {
            Console.WriteLine("Child Constructor with 4 parameters");
            Console.WriteLine("Remarks = {0}", remarks);
        }

        public override void CalculateAnnualFee()
        {
            annualFee = 100 + 12 * 30;
        }
    }

    class VIPMember : Member
    {
        public VIPMember(string name, int memberId, int memberSince) : base(name, memberId, memberSince)
        {
            Console.WriteLine("Child Constructor with 3 parameters");
        }

        public override void CalculateAnnualFee()
        {
            annualFee = 1200;
        }
    }
}
