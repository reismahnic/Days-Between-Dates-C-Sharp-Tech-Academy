﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Days_Between_Dates
{
    public partial class DaysBetweenDates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ResultBtn_Click(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate > Calendar2.SelectedDate)
            {
                DaysLbl.Text = Calendar1.SelectedDate.Subtract(Calendar2.SelectedDate).TotalDays.ToString();
            }
            else
            {
                DaysLbl.Text = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate).TotalDays.ToString();

            }
        }
    }
}