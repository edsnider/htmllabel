using System;
using System.ComponentModel;
using Foundation;
using Plugins.Forms.HtmlLabel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(HtmlLabel), typeof(HtmlLabelIosRenderer))]
namespace Plugins.Forms.HtmlLabel
{
    public class HtmlLabelIosRenderer : ViewRenderer<HtmlLabel, HtmlUITextView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<HtmlLabel> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                SetNativeControl(new HtmlUITextView());
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
