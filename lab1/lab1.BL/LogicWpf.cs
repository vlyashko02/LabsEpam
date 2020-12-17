using System.Windows;

namespace lab1.BL
{
    public class LogicWpf : BaseLogic
    {
        protected override void Exception()
        {
            MessageBox.Show("Ошибка при получении пути.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
