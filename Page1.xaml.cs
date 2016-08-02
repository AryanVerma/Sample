using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;

namespace App3
{
	public partial class Page1 : ContentPage
	{
        public static Image clearBtn;     
       
        public static TapGestureRecognizer clearBtnGesture;
        public Page1 ()
		{
			InitializeComponent ();
		}
        protected async void clearTap(object sender, EventArgs args)
        {
            try
            {
                                  
                    await Navigation.PushPopupAsync(new ClearCurrentPopup());
                
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
