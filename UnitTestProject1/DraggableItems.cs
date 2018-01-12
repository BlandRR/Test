using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject1
{
    class DraggableItems
    {
        [FindsBy(How = How.Id, Using = "draggable")]
        public IWebElement draggablebox { get; set; }





        public void ClickBox()
        {
            draggablebox.Click();
        }

    }
}
