using NUnit.Framework;
using Moq;
using ManagerApplication;
using Wisej.Web;
using System;

namespace TestProject
{
    [TestFixture]
    public class EdittStaffFormTests
    {
        private Mock<DatabaseManager> _mockDbManager;

        [SetUp]
        public void Setup()
        {
            _mockDbManager = new Mock<DatabaseManager>();
        }

        [Test]
        public void Savebutton_Click_ShouldFail_WhenFirstNameIsEmpty()
        {
            // Arrange
            var form = new EdittStaffForm(_mockDbManager.Object, 1, "Mr.", "", "Doe", "1234567890", "john.doe@example.com", 1);

            // Act
            form.Savebutton_Click(null, EventArgs.Empty);

            // Assert
            _mockDbManager.Verify(db => db.UpdateStaff(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Never);
            Assert.That(form.DialogResult, Is.EqualTo(DialogResult.None));
        }

        [Test]
        public void Savebutton_Click_ShouldFail_WhenEmailIsInvalid()
        {
            // Arrange
            var form = new EdittStaffForm(_mockDbManager.Object, 1, "Mr.", "John", "Doe", "1234567890", "invalid-email", 1);

            // Act
            form.Savebutton_Click(null, EventArgs.Empty);

            // Assert
            _mockDbManager.Verify(db => db.UpdateStaff(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Never);
            Assert.That(form.DialogResult, Is.EqualTo(DialogResult.None));
        }

        [Test]
        public void Savebutton_Click_ShouldSave_WhenAllFieldsAreValid()
        {
            // Arrange
            var form = new EdittStaffForm(_mockDbManager.Object, 1, "Mr.", "John", "Doe", "1234567890", "john.doe@example.com", 1);

            // Act
            form.Savebutton_Click(null, EventArgs.Empty);

            // Assert
            _mockDbManager.Verify(db => db.UpdateStaff(1, "Mr.", "John", "Doe", "1234567890", "john.doe@example.com", 1), Times.Once);
            Assert.That(form.DialogResult, Is.EqualTo(DialogResult.OK));
        }
    }
}
