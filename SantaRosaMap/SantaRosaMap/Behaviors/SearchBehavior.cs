using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SantaRosaMap.Behaviors
{
    class SearchBehavior : Behavior<SearchBar>
    {
        private SearchBar AssociateObject { get; set; }

        public static BindableProperty CommandProperty =
            BindableProperty.Create("Command", typeof(ICommand), typeof(SearchBehavior));

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        protected override void OnAttachedTo(SearchBar bindable)
        {
            base.OnAttachedTo(bindable);
            AssociateObject = bindable;
            bindable.TextChanged += Bindable_TextChanged;
            bindable.BindingContextChanged += Bindable_BindingContextChanged;
        }

        private void Bindable_BindingContextChanged(object sender, EventArgs e)
        {
            OnBindingContextChanged();
        }

        protected override void OnDetachingFrom(SearchBar bindable)
        {
            base.OnDetachingFrom(bindable);
            AssociateObject = null;
            bindable.TextChanged -= Bindable_TextChanged;
            bindable.BindingContextChanged -= Bindable_BindingContextChanged;
        }

        private void Bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Command == null)
                return;
            if (Command.CanExecute(null))
                Command.Execute(null);
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            BindingContext = AssociateObject.BindingContext;
        }

    }
}
