using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicCRUDTool2.Windows;

namespace BasicCRUDTool2.Tests
{
    
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ObservableObjectTests
    {
        [TestMethod]
        public void PropertyChangedEventHandlerIsRaised()
        {
            var obj = new StubObservableObject();

            bool raised = false;

            obj.PropertyChanged += (sender, e) =>
            {
                Assert.IsTrue(e.PropertyName == "ChangedProperty");
                raised = true;
            };

            obj.ChangedProperty = "Some Value";

            if (!raised) Assert.Fail("PropertyChanged was never invoked");
        }

        class StubObservableObject : ObservableObject
        {
            private string changedProperty;
            public string ChangedProperty
            {
                get { return changedProperty; }
                set
                {
                    changedProperty = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
