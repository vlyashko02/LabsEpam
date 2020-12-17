using lab1.BL;
using System;
using System.Windows;
using System.Windows.Input;

namespace lab1.WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly LogicWpf logicWpf = new LogicWpf();
        /// <summary>
        /// Инициализатор WPF формы
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Валидация данных для текст боксов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ".")))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Кнопка - открытие файла и чтение данных из него
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            logicWpf.GetDate(ModeForData.File);

            for (int i = logicWpf.CoorList.Count - logicWpf.CountOfResultLines; i < logicWpf.CoorList.Count; i++)
            {
                ResultText.Text += $"{logicWpf.CoorList[i].formatted}\n";
            }
        }
        /// <summary>
        /// Добавление данных из текст боксов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(XText.Text) && !string.IsNullOrWhiteSpace(YText.Text))
            {
                if (logicWpf.ValidationData(XText.Text + "," + YText.Text))
                {
                    logicWpf.CoorList.Add(new Data(XText.Text + "," + YText.Text));
                    ResultText.Text += $"{logicWpf.CoorList[logicWpf.CoorList.Count - 1].formatted}\n";
                    XText.Text = "";
                    YText.Text = "";
                }
                else
                {
                    MessageBox.Show("Одно или два поля не прошли проверку данных. Неверный формат.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Одно или два поля имеет пустоту.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
