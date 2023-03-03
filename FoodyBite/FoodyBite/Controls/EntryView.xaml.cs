using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodyBite.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryView : ContentView
    {

        public ImageSource SourceImage
        {
            get { return (ImageSource)GetValue(SourceImageProperty); }
            set { SetValue(SourceImageProperty, value); }
        }
        public string TextEntry
        {
            get { return (string)GetValue(TextEntryProperty); }
            set { SetValue(TextEntryProperty, value); }
        }
        public bool IsPassEntry
        {
            get { return (bool)GetValue(IsPassEntryProperty); }
            set { SetValue(IsPassEntryProperty, value); }
        }
        public string PlaceHolde
        {
            get { return (string)GetValue(PlaceHoldeProperty); }
            set { SetValue(PlaceHoldeProperty, value); }
        }
        public static readonly BindableProperty SourceImageProperty =
             BindableProperty.Create(
             nameof(SourceImage),
             typeof(ImageSource),
             typeof(EntryView),
             defaultValue: null,
             defaultBindingMode: BindingMode.TwoWay,
             propertyChanged: OnSourceImagePropertyChanged); 
        public static readonly BindableProperty IsPassEntryProperty =
            BindableProperty.Create(
            nameof(IsPassEntry),
            typeof(bool),
            typeof(EntryView),
            defaultValue: false,
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: OnIsPasswordEntryPropertyChanged);

        public static readonly BindableProperty TextEntryProperty =
             BindableProperty.Create(
             nameof(TextEntry),
             typeof(string),
             typeof(EntryView),
             defaultValue: null,
             defaultBindingMode: BindingMode.TwoWay,
             propertyChanged: OnTextEntryPropertyChanged);

        public static readonly BindableProperty PlaceHoldeProperty =
            BindableProperty.Create(
            nameof(PlaceHolde),
            typeof(string),
            typeof(EntryView),
            defaultValue: null,
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: OnPlaceHolderEntryPropertyChanged);

        private static void OnPlaceHolderEntryPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is EntryView button && newValue is Entry label)
                button.textEntry.Placeholder = label.Placeholder;
        }

        private static void OnTextEntryPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is EntryView button && newValue is Entry label)
                button.textEntry.Text = label.Text;
        }
        private static void OnIsPasswordEntryPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is EntryView button && newValue is Entry label)
                button.textEntry.IsPassword = label.IsPassword;
        }
        private static void OnSourceImagePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is EntryView button && newValue is ImageSource image)
                button.sourceImage.Source = image;
        }

        public EntryView()
        {
            InitializeComponent();
        }
    }
}