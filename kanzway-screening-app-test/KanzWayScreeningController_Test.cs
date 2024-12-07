using kanzway_screening_app.Controllers;

namespace kanzway_screening_app_test
{
    public class KanzWayScreeningController_Test
    {
        [Fact]
        public void GetStrings_Test()
        {
            // Arrange
            var apis = new KanzWayScreeningController();

            // Act
            var result = apis.GetStrings(5);//TEST

            // Assert
            Assert.Equal(["1","2","Kanz","4","Way"], result);//EXPECTED OUTPUT

            result = apis.GetStrings(15);//TEST FOR ANOTHER INPUT
            Assert.Equal(["1","2","Kanz","4","Way","Kanz","7","8","Kanz","Way","11","Kanz","13","14","KanzWay"],result);//EXPECTED OUTPUT

        }
    }
}