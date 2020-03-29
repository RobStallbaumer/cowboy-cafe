using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class DakotaDoubleBurgerPropertyChangedTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var food = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(food);
        }

        // Test 3: Changing the "Bread" Property should invoke PropertyChanged for "Bread"
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedforRoomForCream()
        {
            var chicken = new DakotaDoubleBurger();
            Assert.PropertyChanged(chicken, "Cheese", () =>
            {
                chicken.Cheese = false;
            });

        }
        // Test 4: Changing the "Bread" Property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new DakotaDoubleBurger();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Cheese = false;
            });

        }
        // Test 5: Changing the "Pickle" Property shouldinvoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingDecafshouldInvokePropertyChangedforDecaf()
        {
            var chicken = new DakotaDoubleBurger();
            Assert.PropertyChanged(chicken, "Tomato", () =>
            {
                chicken.Tomato = false;
            });

        }
        // Test 6: Changing the "Pickle" Property shouldinvoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingDecafshouldInvokePropertyChangedforSpecialInstructions()
        {
            var chicken = new DakotaDoubleBurger();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Tomato = false;
            });

        }
        // Test 5: Changing the "Pickle" Property shouldinvoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingIceshouldInvokePropertyChangedforIce()
        {
            var chicken = new DakotaDoubleBurger();
            Assert.PropertyChanged(chicken, "Ketchup", () =>
            {
                chicken.Ketchup = false;
            });

        }
        // Test 6: Changing the "Pickle" Property shouldinvoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceshouldInvokePropertyChangedforSpecialInstructions()
        {
            var chicken = new DakotaDoubleBurger();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Ketchup = false;
            });

        }
        // Test 5: Changing the "Pickle" Property shouldinvoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingIceshoulInvokePropertyChangedforIce()
        {
            var chicken = new DakotaDoubleBurger();
            Assert.PropertyChanged(chicken, "Mayo", () =>
            {
                chicken.Mayo = false;
            });

        }
        // Test 6: Changing the "Pickle" Property shouldinvoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceshoulInvokePropertyChangedforSpecialInstructions()
        {
            var chicken = new DakotaDoubleBurger();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Mayo = false;
            });
        }
        [Fact]
        public void ChangingIceshoulInvokeProdertyChangedforIce()
        {
            var chicken = new DakotaDoubleBurger();
            Assert.PropertyChanged(chicken, "Bun", () =>
            {
                chicken.Bun = false;
            });

        }
        // Test 6: Changing the "Pickle" Property shouldinvoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceshoulInvokeProdertyChangedforSpecialInstructions()
        {
            var chicken = new DakotaDoubleBurger();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Bun = false;
            });
        }
        [Fact]
        public void ChangingIceshoulInvokePrpertyChangedforIce()
        {
            var chicken = new DakotaDoubleBurger();
            Assert.PropertyChanged(chicken, "Lettuce", () =>
            {
                chicken.Lettuce = false;
            });

        }
        // Test 6: Changing the "Pickle" Property shouldinvoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceshoulInvokeProprtyChangedforSpecialInstructions()
        {
            var chicken = new DakotaDoubleBurger();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Lettuce = false;
            });
        }
    }
}
