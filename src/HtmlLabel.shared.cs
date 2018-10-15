using System;
using Xamarin.Forms;

#if XAMARIN_IOS
using UIKit;
#elif MONOANDROID
using Android.Content;
using Android.Widget;
#endif

namespace Plugins.Forms.HtmlLabel
{
    public class HtmlLabel : Label 
    {
    }

#if XAMARIN_IOS
    public class HtmlUITextView : UITextView 
    {
    }
#elif MONOANDROID
    public class HtmlTextView : TextView 
    {
        public HtmlTextView(Context context) 
            : base(context) 
        {
        } 
    }
#endif
}
