using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationCode.PageObjects
{
    class HomePage : GeneralPage
    {
        public void Open()
        {
            Constant.Constant.WEBDRIVER.Navigate().GoToUrl(Constant.Constant.APP_URL);
        }
    }
}
