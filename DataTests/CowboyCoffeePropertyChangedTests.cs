using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        // Test 1: cheese fries Should Implement TheINotifyPropertyChangedInterface
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var food = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(food);
        }
        // Test 3: Changing the "Size" Property should invoke PropertyChanged for "size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChanged()
        {
            //var food = new CornDodgers();
            //Assert.PropertyChanged(food, "Size", () =>
            //{
            //    food.Size = Size.Medium;
            //});

        }
        // Test 3: Changing the "Bread" Property should invoke PropertyChanged for "Bread"
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedforRoomForCream()
        {
            var chicken = new CowboyCoffee();
            Assert.PropertyChanged(chicken, "RoomForCream", () =>
            {
                chicken.RoomForCream = true;
            });

        }
        // Test 4: Changing the "Bread" Property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new CowboyCoffee();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.RoomForCream = true ;
            });

        }
        // Test 5: Changing the "Pickle" Property shouldinvoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingDecafshouldInvokePropertyChangedforDecaf()
        {
            var chicken = new CowboyCoffee();
            Assert.PropertyChanged(chicken, "Decaf", () =>
            {
                chicken.Decaf = false;
            });

        }
        // Test 6: Changing the "Pickle" Property shouldinvoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingDecafshouldInvokePropertyChangedforSpecialInstructions()
        {
            var chicken = new CowboyCoffee();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Decaf = false;
            });

        }
        // Test 5: Changing the "Pickle" Property shouldinvoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingIceshouldInvokePropertyChangedforIce()
        {
            var chicken = new CowboyCoffee();
            Assert.PropertyChanged(chicken, "Ice", () =>
            {
                chicken.Ice = true;
            });

        }
        // Test 6: Changing the "Pickle" Property shouldinvoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceshouldInvokePropertyChangedforSpecialInstructions()
        {
            var chicken = new CowboyCoffee();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Ice = true ;
            });

        }
    }
}
