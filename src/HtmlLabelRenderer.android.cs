using System;
using System.ComponentModel;
using Android.Content;
using Android.Text;
using Plugins.Forms.HtmlLabel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(HtmlLabel), typeof(HtmlLabelAndroidRenderer))]
namespace Plugins.Forms.HtmlLabel
{
    public class HtmlLabelAndroidRenderer : ViewRenderer<HtmlLabel, HtmlTextView>
    {
        public HtmlLabelAndroidRenderer(Context context)
            : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<HtmlLabel> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                SetNativeControl(new HtmlTextView(Context));
            }

            UpdateText();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == nameof(HtmlLabel.Text))
            {
                UpdateText();
            }
        }

        void UpdateText()
        {
            Control.TextFormatted = Html.FromHtml(Element.Text, FromHtmlOptions.ModeCompact);
            Control.MovementMethod = Android.Text.Method.LinkMovementMethod.Instance;
        }
    }
}
