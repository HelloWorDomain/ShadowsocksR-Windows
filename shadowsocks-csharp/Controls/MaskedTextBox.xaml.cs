using System;

namespace Shadowsocks.Controls
{
    public partial class MaskedTextBox
    {
        public MaskedTextBox()
        {
            InitializeComponent();
            PlainModeChanged += MaskedTextBoxPlainModeChanged;
            MyPasswordBox.PasswordChanged += (o, e) =>
            {
                MyTextBox.Text = MyPasswordBox.Password;
            };
        }

        private bool _plainMode;
        public bool PlainMode
        {
            get => _plainMode;
            set
            {
                if (_plainMode != value)
                {
                    _plainMode = value;
                    PlainModeChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        public string Text
        {
            get => MyTextBox.Text;

            set => MyPasswordBox.Password = value;
        }

        public event EventHandler PlainModeChanged;

        private void MaskedTextBoxPlainModeChanged(object sender, EventArgs e)
        {
            if (_plainMode)
            {
                MyPasswordBox.Visibility = System.Windows.Visibility.Collapsed;
                MyTextBox.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                MyPasswordBox.Visibility = System.Windows.Visibility.Visible;
                MyTextBox.Visibility = System.Windows.Visibility.Collapsed;
            }
        }
    }
}
