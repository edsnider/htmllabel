using System;
using System.ComponentModel;
using Foundation;
using UIKit;
using XamForms.HtmlLabel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(HtmlLabel), typeof(HtmlLabelIosRenderer))]
namespace XamForms.HtmlLabel
{
    public class HtmlLabelIosRenderer : ViewRenderer<HtmlLabel, UITextView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<HtmlLabel> e)
        {
            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    SetNativeControl(new UITextView());
                }

                UpdateText();
            }

            base.OnElementChanged(e);
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
            NSError error = null;
            Control.AttributedText = new NSAttributedString(NSData.FromString(Element.Text), 
                                                            new NSAttributedStringDocumentAttributes { DocumentType = NSDocumentType.HTML }, 
                                                            ref error);
            Control.Editable = false;
            Control.ScrollEnabled = false;
            Control.ShouldInteractWithUrl += delegate { return true; };
        }
    }
}
