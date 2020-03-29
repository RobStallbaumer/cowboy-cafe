using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class CowpokeChiliPropertyChangedTests
    { // Test 1: cheese fries Should Implement TheINotifyPropertyChangedInterface
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var food = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(food);
        }
        
        // Test 3: Changing the "Bread" Property should invoke PropertyChanged for "Bread"
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedforRoomForCream()
        {
            var chicken = new CowpokeChili();
            Assert.PropertyChanged(chicken, "Cheese", () =>
            {
                chicken.Cheese = true;
            });

        }
        // Test 4: Changing the "Bread" Property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new CowpokeChili();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Cheese = true;
            });

        }
        // Test 5: Changing the "Pickle" Property shouldinvoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingDecafshouldInvokePropertyChangedforDecaf()
        {
            var chicken = new CowpokeChili();
            Assert.PropertyChanged(chicken, "GreenOnions", () =>
            {
                chicken.GreenOnions = false;
            });

        }
        // Test 6: Changing the "Pickle" Property shouldinvoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingDecafshouldInvokePropertyChangedforSpecialInstructions()
        {
            var chicken = new CowpokeChili();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.GreenOnions = false;
            });

        }
        // Test 5: Changing the "Pickle" Property shouldinvoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingIceshouldInvokePropertyChangedforIce()
        {
            var chicken = new CowpokeChili();
            Assert.PropertyChanged(chicken, "SourCream", () =>
            {
                chicken.SourCream = false;
            });

        }
        // Test 6: Changing the "Pickle" Property shouldinvoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceshouldInvokePropertyChangedforSpecialInstructions()
        {
            var chicken = new CowpokeChili();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.SourCream = true;
            });

        }
    }
}
