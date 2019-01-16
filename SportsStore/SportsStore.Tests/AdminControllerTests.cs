﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Moq;
using SportsStore.Controllers;
using SportsStore.Models;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SportsStore.Tests
{
    public class AdminControllerTests
    {
        [Fact]
        public void Index_Contains_All_Products()
        {
            //Arrange - create the mock repository
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[]
            {
                new Product {ProductID = 1, Name ="P1"},
                new Product {ProductID = 2, Name ="P2"},
                new Product {ProductID = 3, Name ="P3"},
            }.AsQueryable<Product>());

            //Create a controller
            AdminController target = new AdminController(mock.Object);
            //Action
            Product[] result
                = GetViewModel<IEnumerable<Product>>(target.Index())?.ToArray();

            //Assert
            Assert.Equal(3, result.Length);
            Assert.Equal("P1", result[0].Name);
            Assert.Equal("P2", result[1].Name);
            Assert.Equal("P3", result[2].Name);
        }

        [Fact]
        public void Can_Edit_Product()
        {
            //Arrange - create the mock repository
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[]
            {
                new Product {ProductID = 1, Name ="P1"},
                new Product {ProductID = 2, Name ="P2"},
                new Product {ProductID = 3, Name ="P3"},
            }.AsQueryable<Product>());

            //Create a controller
            AdminController target = new AdminController(mock.Object);

            //Act
            Product p1 = GetViewModel<Product>(target.Edit(1));
            Product p2 = GetViewModel<Product>(target.Edit(2));
            Product p3 = GetViewModel<Product>(target.Edit(3));

            //Assert
            Assert.Equal(1, p1.ProductID);
            Assert.Equal(2, p2.ProductID);
            Assert.Equal(3, p3.ProductID);
        }

        [Fact]
        public void Cannot_Edit_Nonexistent_Product()
        {            
            //Arrange - create the mock repository
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[]
            {
                new Product {ProductID = 1, Name ="P1"},
                new Product {ProductID = 2, Name ="P2"},
                new Product {ProductID = 3, Name ="P3"},
            }.AsQueryable<Product>());

            //Create a controller
            AdminController target = new AdminController(mock.Object);

            //Act
            Product result = GetViewModel<Product>(target.Edit(4));

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void Can_Save_Valid_Changes()
        {
            //Arrange - create mock repository
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            //Create temp data for mock
            Mock<ITempDataDictionary> tempData = new Mock<ITempDataDictionary>();
            //create controller
            AdminController target = new AdminController(mock.Object)
            {
                TempData = tempData.Object
            };
            //create a product
            Product product = new Product { Name = "Test" };

            //Act - try to save the product
            IActionResult result = target.Edit(product);

            //Assert - check that the repo was called
            mock.Verify(m => m.SaveProduct(product));
            // check the result type is a redirection
            Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", (result as RedirectToActionResult).ActionName);
        }

        [Fact]
        public void Cannot_Save_Invalid_Changes()
        {
            //Arrange - create mock repo
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            // create the controller
            AdminController target = new AdminController(mock.Object);
            // create a product
            Product product = new Product { Name = "Test" };
            // add an error to the model state
            target.ModelState.AddModelError("error", "error");

            //Act - try to save the product
            IActionResult result = target.Edit(product);

            //Assert - check that the repository was not called
            mock.Verify(m => m.SaveProduct(It.IsAny<Product>()), Times.Never());
            //Check the method result type
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Can_Delete_Valid_Products()
        {
            //Arrange - create a product
            Product prod = new Product { ProductID = 2, Name = "Test" };
            //Create the mock repo
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[]
            {
                new Product {ProductID = 1, Name = "P1"},
                prod,
                new Product {ProductID = 3, Name = "P3"},
            }.AsQueryable<Product>());
            //Create the controller
            AdminController target = new AdminController(mock.Object);

            //Act - delete the product
            target.Delete(prod.ProductID);

            //Assert - ensure that the repo delte method was called with the correct product
            mock.Verify(m => m.DeleteProduct(prod.ProductID));
        }

        private T GetViewModel<T>(IActionResult result) where T : class
        {
            return (result as ViewResult)?.ViewData.Model as T;
        }
    }
}