using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace YahooTest.Pages
{
    class MainPage
    {
        private IWebDriver _driver;
        By _newButton = By.CssSelector("#app > div.I_ZnwrMC.D_F.em_N.o_h.W_6D6F.H_6D6F > div > div.a_3rehn.W_3o4BO.s_3o4BO.cZ10Gnkk_ZM1sUU.D_F.ek_BB.em_0 > nav > div > div:nth-child(1)");
        By _sendButton = By.CssSelector("#mail-app-component > div > div > div.em_N.D_F.ek_BB.p_R.o_h > div:nth-child(2) > div > button");
        By _confirmButton = By.CssSelector("#modal-outer > div > div > div.P_ZG120x > button.P_1EudUu.C_52qC.r_P.y_Z2uhb3X.A_6EqO.cvhIH6_T.ir3_1JO2M7.cZ11XJIl_0.k_w.e_dRA.D_X.M_6LEV.o_v.p_R.V_M.t_C.cZ1RN91d_n.u_e69.i_3qGKe.H_A.cn_dBP.cg_FJ.l_Z2aVTcY.j_n.S_n.S4_n.I_Z2aVTcY.I3_Z2bdAhD.l3_Z2bdIi1.I0_Z2bdAhD.l0_Z2bdIi1.I4_Z2bdAhD.l4_Z2bdIi1");
        By _toField = By.CssSelector("#message-to-field");
        By _check = By.CssSelector("#mail-app-component > div > div > div.D_F.ab_FT.em_N.ek_BB.iz_A.H_6D6F > div > div > div.W_6D6F.H_6D6F.cZ1RN91d_n.o_h.p_R.em_N.D_F > div > div.p_R.Z_0.iy_h.iz_A.W_6D6F.H_6D6F.k_w.em_N.c22hqzz_GN > ul > li > a > div > div.D_F.o_h.ab_C.H_6D6F.em_sL.ej_0");
        By _sendByText = By.CssSelector("#mail-app-component > div > div.iz_A.I_52qC.em_0.Z_0 > div:nth-child(2) > ul > li:nth-child(2) > div > header > div.o_h.D_F.em_0.E_fq7.ek_BB > div.D_F.en_0 > span > span > span");

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void PressNewButton()
        {
            _driver.FindElement(_newButton).Click();
        }

        public void EnterEmailToSend(string Email)
        {
            _driver.FindElement(_toField).SendKeys(Email);
        }

        public void PressSendButton()
        {
            _driver.FindElement(_sendButton).Click();
        }

        public void PressConfirmButton()
        {
            _driver.FindElement(_confirmButton).Click();
        }

        public string ConfirmEmailCatch()
        {
            _driver.FindElement(_check).Click();
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            string actual = _driver.FindElement(_sendByText).Text;
            return actual;
        }
    }
}
