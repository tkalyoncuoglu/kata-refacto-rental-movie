using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRental.Movie;
using MovieRental.Rental;

namespace MovieRental.Tests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TestCustomer()
        {
            Customer c = new CustomerBuilder().build();
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void TestAddRental()
        {
            Customer customer2 = new CustomerBuilder().withName("Julia").build();
            Movie.Regular movie1 = new Movie.Regular("Gone with the Wind");
            IRental rental1 = new Rental.Regular(movie1, 3); // 3 day rental
            customer2.addRental(rental1);
        }

        [TestMethod]
        public void TestGetName()
        {
            Customer c = new Customer("David");
            Assert.AreEqual("David", c.getName());
        }
        [TestMethod]
        public void StatementForRegularMovie()
        {
            Movie.Regular movie1 = new Movie.Regular("Gone with the Wind");
            IRental rental1 = new Rental.Regular(movie1, 3); // 3 day rental
            Customer customer2 =
                    new CustomerBuilder()
                            .withName("Sallie")
                            .withRentals(rental1)
                            .build();
            string expected = "Rental Record for Sallie\n" +
                    "\tGone with the Wind\t3,5\n" +
                    "Amount owed is 3,5\n" +
                    "You earned 1 frequent renter points";
            string statement = customer2.statement();
            Assert.AreEqual(expected, statement);
        }

        [TestMethod]
        public void StatementForNewReleaseMovie()
        {
            Movie.NewRelease movie1 = new Movie.NewRelease("Star Wars");
            IRental rental1 = new Rental.NewRelease(movie1, 3); // 3 day rental
            Customer customer2 =
                    new CustomerBuilder()
                            .withName("Sallie")
                            .withRentals(rental1)
                            .build();
            string expected = "Rental Record for Sallie\n" +
                    "\tStar Wars\t9\n" +
                    "Amount owed is 9\n" +
                    "You earned 2 frequent renter points";
            string statement = customer2.statement();
            Assert.AreEqual(expected, statement);
        }

        [TestMethod]
        public void StatementForChildrensMovie()
        {
            Movie.Childrens movie1 = new Movie.Childrens("Madagascar");
            IRental rental1 = new Rental.Childrens(movie1, 3); // 3 day rental
            Customer customer2
                    = new CustomerBuilder()
                    .withName("Sallie")
                    .withRentals(rental1)
                    .build();
            string expected = "Rental Record for Sallie\n" +
                    "\tMadagascar\t1,5\n" +
                    "Amount owed is 1,5\n" +
                    "You earned 1 frequent renter points";
            string statement = customer2.statement();
            Assert.AreEqual(expected, statement);
        }

        [TestMethod]
        public void StatementForManyMovies()
        {
            Movie.Childrens movie1 = new Movie.Childrens("Madagascar");
            IRental rental1 = new Rental.Childrens(movie1, 6); // 6 day rental
            Movie.NewRelease movie2 = new Movie.NewRelease("Star Wars");
            IRental rental2 = new Rental.NewRelease(movie2, 2); // 2 day rental
            Movie.Regular movie3 = new Movie.Regular("Gone with the Wind");
            IRental rental3 = new Rental.Regular(movie3, 8); // 8 day rental
            Customer customer1
                    = new CustomerBuilder()
                    .withName("David")
                    .withRentals(rental1, rental2, rental3)
                    .build();
            string expected = "Rental Record for David\n" +
                    "\tMadagascar\t6\n" +
                    "\tStar Wars\t6\n" +
                    "\tGone with the Wind\t11\n" +
                    "Amount owed is 23\n" +
                    "You earned 4 frequent renter points";
            string statement = customer1.statement();
            Assert.AreEqual(expected, statement);
        }

        //TODO make test for price breaks in code.
    }

}
