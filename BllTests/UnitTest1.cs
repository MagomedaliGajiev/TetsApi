using Moq;
using TestApi.Bll;
using TestApi.DAL;

namespace BllTests
{
    public class UnitTest1

    {
        [Test]
        public void Test1()
        {
            //Arange
            var expectedUser = new User { Id = 11, Name = "Tom" };
            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock.Setup(x => x.Get(It.IsAny<int>())).Returns(new User { Id = 10, Name ="Tom"});

            IUserService service = new UserService(userRepositoryMock.Object);

            //Act
            var user = service.GetById(10);

            //Assert
            Assert.AreEqual(expectedUser.Id, user.Id);
        }
    }
}