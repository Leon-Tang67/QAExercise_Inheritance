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

        public UnitTest1()
        {
            library = new Library();
            ittzy = library.Add(name: "Ittzy Child", age: 15);
            irma = library.Add(name: "Irma Adult", age: 73);
        }

        [Fact]
        public void Create()
        {
            Assert.Equal(2, library.NumberOfMembers);
            Assert.Equal(1, ittzy.MembershipNumber);
            Assert.Equal(2, irma.MembershipNumber);
        }
    }
}