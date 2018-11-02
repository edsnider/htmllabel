using System;
using System.ComponentModel;
using Android.Content;
using Android.Text;
using XamForms.HtmlLabel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(HtmlLabel), typeof(HtmlLabelAndroidRenderer))]
namespace XamForms.HtmlLabel
{
    public class HtmlLabelAndroidRenderer : LabelRenderer
    {
        public HtmlLabelAndroidRenderer(Context context)
            : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null && e.NewElement != null)
            {
                UpdateText();
            }
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
            if (string.IsNullOrWhiteSpace(Element?.Text))
            {
                Control.Text = string.Empty;
                return;
            }

            Control.TextFormatted = Html.FromHtml(Element.Text, FromHtmlOptions.ModeCompact);
            Control.MovementMethod = Android.Text.Method.LinkMovementMethod.Instance;
        }
    }
}
