using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Training8.PageObject
{
    public class LoginPage
    {

        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement loginButton;

        
        [FindsBy(How = How.LinkText, Using = "Password")]
        private IWebElement password;

        [FindsBy(How = How.ClassName, Using = "email")]
        private IWebElement email;

        [FindsBy(How = How.XPath, Using = "signIn")]
        private IWebElement signInButton;

        public void ClickOnLoginButton()
        {
            loginButton.Click();
        }

        public void EnterEmailAddress()
        {
            email.Clear();
            email.SendKeys("subomi847@gmail.com");
        }

        public void EnterPassword()
        {
            password.Clear();
            password.SendKeys("password");
        }
        public void ClickOnSignInButton();


 
    
    
    
    
    }














}
