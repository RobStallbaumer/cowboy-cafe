using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;
namespace CowboyCafe.DataTests
{
    public class CornDodgersPropertyChangedTests
    {// Test 1: cheese fries Should Implement TheINotifyPropertyChangedInterface
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
    }
}
