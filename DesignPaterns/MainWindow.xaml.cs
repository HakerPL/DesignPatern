using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DesignPaterns
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetButtonsColorGreen();
            SetButtonsColorRed();

            txtField.IsReadOnly = true;
        }

        private void SetButtonsColorGreen()
        {
            btnStrategy.Background = Brushes.Green;
            btnObserver.Background = Brushes.Green;
            btnFactory.Background = Brushes.Green;
            btnAbstractFactory.Background = Brushes.Green;
        }

        private void SetButtonsColorRed()
        {
            btnSingleton.Background = Brushes.Red;
            btnBuilder.Background = Brushes.Red;
            btnPrototype.Background = Brushes.Red;
            btnDecorator.Background = Brushes.Red;
            btnCommand.Background = Brushes.Red;
            btnAdapter.Background = Brushes.Red;
            btnFacade.Background = Brushes.Red;
            btnBridge.Background = Brushes.Red;
            btnTemplate.Background = Brushes.Red;
            btnIterator.Background = Brushes.Red;
            btnComposite.Background = Brushes.Red;
            btnFlyweight.Background = Brushes.Red;
            btnState.Background = Brushes.Red;
            btnProxy.Background = Brushes.Red;
            btnVisitor.Background = Brushes.Red;
            btnInterpreter.Background = Brushes.Red;
            btnMediator.Background = Brushes.Red;
            btnMemento.Background = Brushes.Red;
            btnChainOfResponsibility.Background = Brushes.Red;
            btnMVC.Background = Brushes.Red;
        }

        private void btnStrategy_Click(object sender, RoutedEventArgs e)
        {
            string showText = "\nDesign pattern Strategy \n" + Strategy.StartDesigner.Start() + "\n";
            ShowTextOnTextBox(showText);
        }

        private void btnObserver_Click(object sender, RoutedEventArgs e)
        {
            string showText = "\nDesign pattern Observer \n" + Observer.StartDesigner.Start() + "\n";
            ShowTextOnTextBox(showText);
        }

        private void btnFactory_Click(object sender, RoutedEventArgs e)
        {
            string showText = "\nDesign pattern Factory \n" + Factory.StartDesigner.Start() + "\n";
            ShowTextOnTextBox(showText);
        }

        private void btnAbstractFactory_Click(object sender, RoutedEventArgs e)
        {
            string showText = "\nDesign pattern AbstractFactory \n" + AbstractFactory.StartDesigner.Start() + "\n";
            ShowTextOnTextBox(showText);
        }

        private void btnSingleton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void btnBuilder_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void btnPrototype_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void btnDecorator_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void btnCommand_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void btnAdapter_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void btnFacade_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void btnBridge_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void btnTemplate_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void btnIterator_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void btnComposite_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void btnFlyweight_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button button)
                ShowNotCreate(button);
        }

        private void btnState_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void btnProxy_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void btnVisitor_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void btnInterpreter_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void btnMediator_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void btnMemento_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void btnChainOfResponsibility_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void btnMVC_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
                ShowNotCreate(button);
        }

        private void ShowNotCreate(Button button)
        {
            ShowTextOnTextBox($"\nDesign pattern {button.Content} is not written.\n");
        }

        private void ShowTextOnTextBox(string text)
        {
            txtField.AppendText(text);
            SetScrollBarOnEnd(txtField);
        }

        private void SetScrollBarOnEnd(TextBox textBox)
        {
            textBox.SelectionStart = textBox.Text.Length;
            textBox.ScrollToLine(textBox.GetLineIndexFromCharacterIndex(textBox.SelectionStart));
        }
    }
}
