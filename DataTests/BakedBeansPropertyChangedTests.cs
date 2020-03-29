using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;
namespace CowboyCafe.DataTests
{
    public class BakedBeansPropertyChangedTests
    {
        // Test 1: BakedBeans Should Implement TheINotifyPropertyChangedInterface
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var food = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(food);
        }
        // Test 3: Changing the "Size" Property should invoke PropertyChanged for "Bread"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForBakedBeans()
        {
            //var food = new BakedBeans();
            //Assert.PropertyChanged(food, "Size", () =>
            //{
            //    food.Size = Size.Medium;
            //});

        }
    }
}
