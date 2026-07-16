using LendingLibrary;

namespace TestProject
{
    //public class UnitTest1
    //{
    //    [Fact]
    //    public void Create()
    //    {
    //        Library library = new Library();
    //        Member ittzy = library.Add(name: "Ittzy Child", age: 15);
    //        Member irma = irma = library.Add(name: "Irma Adult", age: 73);
    //        Assert.Equal(2, library.NumberOfMembers);
    //        Assert.Equal(1, ittzy.MembershipNumber);
    //        Assert.Equal(2, irma.MembershipNumber);
    //    }
    //}

    public class UnitTest1
    {
        Library library;
        Member ittzy;
        Member irma;

        //public UnitTest1()
        //{
        //    library = new Library();
        //    ittzy = library.Add(name: "Ittzy Child", age: 15);
        //    irma = library.Add(name: "Irma Adult", age: 73);
        //}

        public UnitTest1()
        {
            library = new Library();
            ittzy = library.Add(name: "Ittzy Child", age: 15);
            ittzy.Street = "1 the High Street";
            ittzy.City = "Buddlington";
            ittzy.OutstandingFines = 25M;
            irma = irma = library.Add(name: "irma Adult", age: 73);
            irma.Street = "2 the High Street";
            irma.City = "Cruddlington";
            irma.OutstandingFines = 2500M;
        }

        [Fact]
        public void Create()
        {
            Assert.Equal(2, library.NumberOfMembers);
            Assert.Equal(1, ittzy.MembershipNumber);
            Assert.Equal(2, irma.MembershipNumber);
        }

        [Fact]
        public void Child_Borrows_Child_Book_OK()
        {
            // a junior member (under 16) can borrow only child category books
            Book childBook = library.GetBook(101);
            Assert.True(ittzy.Borrow(childBook));
        }

        [Fact]
        public void Child_Borrows_Adult_Book_Fails()
        {
            // a junior member (under 16) can borrow only child category books
            Book adultBook = library.GetBook(100);
            Assert.False(ittzy.Borrow(adultBook));
        }

        [Fact]
        public void Adult_Can_Borrow_Any_Book()
        {
            // a junior member (under 16) can borrow only child category books
            Book adultBook = library.GetBook(100);
            Book childBook = library.GetBook(101);
            Assert.True(irma.Borrow(adultBook));
            Assert.True(irma.Borrow(childBook));
        }

        [Fact]
        public void Child_Pays_Fine_From_Cash_Fund()
        {
            ittzy.SetFineLimit(20M);
            ittzy.PayFine(7M);
            Assert.Equal(13M, ittzy.GetFineCredit());
        }

        [Fact]
        public void Adult_Pays_Fine_By_Bank_Transfer()
        {
            irma.SetFineLimit(20M);
            irma.PayFine(7M);
            Assert.Equal(13M, irma.GetFineCredit());
        }
    }
}