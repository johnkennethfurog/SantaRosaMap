using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SantaRosaMap.Behaviors
{
    class ListViewRefreshBehavior : Behavior<ListView>
    {

        private ListView AssociateObject { get; set; }

        public static BindableProperty CommandProperty =
            BindableProperty.Create("Command", typeof(ICommand), typeof(ListViewRefreshBehavior));

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static BindableProperty TappedCommandProperty =
            BindableProperty.Create("TappedCommand", typeof(ICommand), typeof(ListViewRefreshBehavior));

        public ICommand TappedCommand
        {
            get { return (ICommand)GetValue(TappedCommandProperty); }
            set { SetValue(TappedCommandProperty, value); }
        }

        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);
            AssociateObject = bindable;
            bindable.ItemAppearing += Bindable_ItemAppearing;
            bindable.ItemTapped += Bindable_ItemTapped;
            bindable.BindingContextChanged += Bindable_BindingContextChanged;
        }

        private void Bindable_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var lv = (ListView)sender;
            lv.SelectedItem = null;

            if (TappedCommand == null)
                return;

            TappedCommand.Execute(e.Item);
        }

        private void Bindable_BindingContextChanged(object sender, EventArgs e)
        {
            OnBindingContextChanged();
        }

        private void Bindable_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {

            if (Command == null)
                return;

            var param = e.Item;
            if (Command.CanExecute(e.Item))
                Command.Execute(e.Item);
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);
            AssociateObject = null;
            bindable.ItemAppearing -= Bindable_ItemAppearing;
            bindable.ItemTapped -= Bindable_ItemTapped;
            bindable.BindingContextChanged -= Bindable_BindingContextChanged;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            BindingContext = AssociateObject.BindingContext;
        }
    }

}
