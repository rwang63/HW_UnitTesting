using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Drawing.Printing;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Set_Date_Should_Equal_5102020()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Date = new DateTime(2020, 05, 10);

            // Assert
            Assert.AreEqual("5/10/2020", result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("Unknown", result.Email);
        }

        [TestMethod]
        public void ProductModel_Set_Email_Should_Equal_Test()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Email = "Test";

            // Assert
            Assert.AreEqual("Test", result.Email);
        }

        [TestMethod]
        public void ProductModel_Get_Id_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Id);
        }

        [TestMethod]
        public void ProductModel_Set_Id_Should_Equal_1()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Id = "1";

            // Assert
            Assert.AreEqual("1", result.Id);
        }

        [TestMethod]
        public void ProductModel_Get_Maker_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Maker);
        }

        [TestMethod]
        public void ProductModel_Set_Maker_Should_Equal_Panasonic()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Maker = "Panasonic";

            // Assert
            Assert.AreEqual("Panasonic", result.Maker);
        }

        [TestMethod]
        public void ProductModel_Get_Image_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Image);
        }

        [TestMethod]
        public void ProductModel_Set_Image_Should_Equal_ImgURL()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Image = "ImgURL";

            // Assert
            Assert.AreEqual("ImgURL", result.Image);
        }

        [TestMethod]
        public void ProductModel_Get_Url_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Url);
        }

        [TestMethod]
        public void ProductModel_Set_Url_Should_Equal_PanasonicWebsite()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Url = "PanasonicWebsite";

            // Assert
            Assert.AreEqual("PanasonicWebsite", result.Url);
        }

        [TestMethod]
        public void ProductModel_Get_Title_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Title);
        }

        [TestMethod]
        public void ProductModel_Set_Title_Should_Equal_NewTV()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Title = "NewTV";

            // Assert
            Assert.AreEqual("NewTV", result.Title);
        }

        [TestMethod]
        public void ProductModel_Get_Description_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Description);
        }

        [TestMethod]
        public void ProductModel_Set_Description_Should_Equal_NewTV()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Description = "NewTV";

            // Assert
            Assert.AreEqual("NewTV", result.Description);
        }

        [TestMethod]
        public void ProductModel_Get_Sequence_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Set_Sequence_Should_Equal_4()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Sequence = "4";

            // Assert
            Assert.AreEqual("4", result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Set_Logistics_Should_Equal_Delivered()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Logistics = "Delivered";

            // Assert
            Assert.AreEqual("Delivered", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Get_Ratings_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            for (int i = 0; i < result.Ratings.Length; i++)
            {
                Assert.AreEqual(5, result.Ratings[i]);
            }
        }

        [TestMethod]
        public void ProductModel_Set_Ratings_Should_Equal_3()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings[0] = 3;

            // Assert
            Assert.AreEqual(3, result.Ratings[0]);
        }

        [TestMethod]
        public void ProductModel_ToString_SetDate_Other_Fields_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            var SecondResult = new ProductModel();
            result.Date = new DateTime(2020, 05, 10);
            SecondResult.Date = new DateTime(2020, 05, 10);

            // Assert
            Assert.AreEqual(SecondResult.ToString(), result.ToString());
        }

        [TestMethod]
        public void ProductModel_AverageRatings_RatingsEqualNull_Should_Equal_0()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = null;

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_AverageRatings_Default_Should_Equal_5()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(5, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_AverageRatings_CountEquals0_Should_Equal_0()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = new int[] { };

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_AverageRatings_TotalEquals0_Should_Equal_0()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings[0] = 0;

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

    }
}
