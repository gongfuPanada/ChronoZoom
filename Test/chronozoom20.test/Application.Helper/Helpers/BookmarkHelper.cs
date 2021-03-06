﻿using System;
using Application.Driver;
using Application.Helper.UserActions;
using OpenQA.Selenium;

namespace Application.Helper.Helpers
{
    public class BookmarkHelper : DependentActions 
    {

        public void HideBookmark()
        {
            Logger.Log("<-");
            Click(By.ClassName("cz-tour-form-min-btn"));
            Logger.Log("->");
        }

        public bool IsBookmarkExpanded()
        {
            Logger.Log("<-");
            bool result = IsElementDisplayed(By.XPath("//*[@id='tour-caption-form']//*[@class='cz-form-content']"));
            Logger.Log("-> IsBookmarkExpanded: " + result);
            return result;
        }
    }
}