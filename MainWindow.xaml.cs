using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DragAndDropApp
{
    public partial class DragAndDropControls : Window
    {
        double FirstXPos, FirstYPos, FirstArrowXPos, FirstArrowYPos;
        object MovingObject;
        Line Path1, Path2, Path3, Path4;
        Rectangle FirstPosition, CurrentPosition;

        public DragAndDropControls()
        {
            InitializeComponent();
            /*
             * Назначение PreviewMouseLeftButtonDown, PreviewMouseMove и PreviewMouseLeftButtonUp
             * события для каждого элемента управления на нашем элементе управления холста.
             * Некоторые события управления, такие как MouseLeftButtonDown TextBox, не срабатывают из-за этого
             * мы используем события Preview.
             */
            foreach (Control control in DesigningCanvas.Children)
            {
                control.PreviewMouseLeftButtonDown += this.MouseLeftButtonDown;
                //control.PreviewMouseLeftButtonUp += this.PreviewMouseLeftButtonUp;
                control.Cursor = Cursors.Hand;
            }

            // Установка события MouseMove для нашего родительского элемента управления (в данном случае это DesigningCanvas).
            DesigningCanvas.PreviewMouseMove += this.MouseMove;

            // Настройка линий, по которым мы хотим показать путь движения
            /*List<Double> Dots = new List<double>();
            Dots.Add(1);
            Dots.Add(2);*/

            /*Path1 = new Line();
            Path1.Width = DesigningCanvas.Width;
            Path1.Height = DesigningCanvas.Height;
            Path1.Stroke = Brushes.DarkGray;
            Path1.StrokeDashArray = new DoubleCollection(Dots);*/

            /*Path2 = new Line();
            Path2.Width = DesigningCanvas.Width;
            Path2.Height = DesigningCanvas.Height;
            Path2.Stroke = Brushes.DarkGray;
            Path2.StrokeDashArray = new DoubleCollection(Dots);*/

            /*Path3 = new Line();
            Path3.Width = DesigningCanvas.Width;
            Path3.Height = DesigningCanvas.Height;
            Path3.Stroke = Brushes.DarkGray;
            Path3.StrokeDashArray = new DoubleCollection(Dots);*/

            /* Path4 = new Line();
             Path4.Width = DesigningCanvas.Width;
             Path4.Height = DesigningCanvas.Height;
             Path4.Stroke = Brushes.DarkGray;
             Path4.StrokeDashArray = new DoubleCollection(Dots);*/

            /*FirstPosition = new Rectangle();
            FirstPosition.Stroke = Brushes.DarkGray;
            FirstPosition.StrokeDashArray = new DoubleCollection(Dots);*/

            /*CurrentPosition = new Rectangle();
            CurrentPosition.Stroke = Brushes.DarkGray;
            CurrentPosition.StrokeDashArray = new DoubleCollection(Dots);*/

            // Добавление линий на главную панель проектирования (холст)
            /*DesigningCanvas.Children.Add(Path1);
            DesigningCanvas.Children.Add(Path2);
            DesigningCanvas.Children.Add(Path3);
            DesigningCanvas.Children.Add(Path4);*/
            /* DesigningCanvas.Children.Add(FirstPosition);
             DesigningCanvas.Children.Add(CurrentPosition);*/
        }

        void PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // В этом случае мы должны установить видимость линий на Скрытый
            //MovingObject = null;                                  //  Если раскомментировать то при попытке перемещения пустоты выскакивает исключение 

            /*Path1.Visibility = System.Windows.Visibility.Hidden;
            Path2.Visibility = System.Windows.Visibility.Hidden;
            Path3.Visibility = System.Windows.Visibility.Hidden;
            Path4.Visibility = System.Windows.Visibility.Hidden;*/

            /*FirstPosition.Visibility = System.Windows.Visibility.Hidden;
            CurrentPosition.Visibility = System.Windows.Visibility.Hidden;*/
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            /*
             * В этом случае сначала проверяем состояние левой кнопки мыши. Если он нажат и
             * объект отправителя события похож на наш движущийся объект, мы можем перемещать наш элемент управления с помощью
             * некоторые эффекты.
             */
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                // Перемещение объектов начинаем с задания позиций линий.
               /* Path1.X1 = FirstArrowXPos;
                Path1.Y1 = FirstArrowYPos;
                Path1.X2 = e.GetPosition((MovingObject as FrameworkElement).Parent as FrameworkElement).X - FirstXPos;
                Path1.Y2 = e.GetPosition((MovingObject as FrameworkElement).Parent as FrameworkElement).Y - FirstYPos;

                Path2.X1 = Path1.X1 + (MovingObject as FrameworkElement).ActualWidth;
                Path2.Y1 = Path1.Y1;
                Path2.X2 = Path1.X2 + (MovingObject as FrameworkElement).ActualWidth;
                Path2.Y2 = Path1.Y2;

                Path3.X1 = Path1.X1;
                Path3.Y1 = Path1.Y1 + (MovingObject as FrameworkElement).ActualHeight;
                Path3.X2 = Path1.X2;
                Path3.Y2 = Path1.Y2 + (MovingObject as FrameworkElement).ActualHeight;

                Path4.X1 = Path1.X1 + (MovingObject as FrameworkElement).ActualWidth;
                Path4.Y1 = Path1.Y1 + (MovingObject as FrameworkElement).ActualHeight;
                Path4.X2 = Path1.X2 + (MovingObject as FrameworkElement).ActualWidth;
                Path4.Y2 = Path1.Y2 + (MovingObject as FrameworkElement).ActualHeight;*/

               /* FirstPosition.Width = (MovingObject as FrameworkElement).ActualWidth;
                FirstPosition.Height = (MovingObject as FrameworkElement).ActualHeight;
                FirstPosition.SetValue(Canvas.LeftProperty, FirstArrowXPos);
                FirstPosition.SetValue(Canvas.TopProperty, FirstArrowYPos);*/

                /*CurrentPosition.Width = (MovingObject as FrameworkElement).ActualWidth;
                CurrentPosition.Height = (MovingObject as FrameworkElement).ActualHeight;*/
               /* CurrentPosition.SetValue(Canvas.LeftProperty, Path1.X2);
                CurrentPosition.SetValue(Canvas.TopProperty, Path1.Y2);*/

               /* Path1.Visibility = System.Windows.Visibility.Visible;
                Path2.Visibility = System.Windows.Visibility.Visible;
                Path3.Visibility = System.Windows.Visibility.Visible;
                Path4.Visibility = System.Windows.Visibility.Visible;*/
               /* FirstPosition.Visibility = System.Windows.Visibility.Visible;
                CurrentPosition.Visibility = System.Windows.Visibility.Visible;*/

                /*
                 * Для изменения положения элемента управления мы должны использовать метод SetValue для установки
                 * зависимости Canvas.LeftProperty и Canvas.TopProperty.
                 *
                 * Для расчета текущего положения элемента управления необходимо:
                 * Текущая позиция курсора мыши на родительском объекте -
                 * Положение мыши на элементе управления в начале движения -
                 * позиция родителя элемента управления.
                 */

                // движение по вертикали
                (MovingObject as FrameworkElement).SetValue(Canvas.LeftProperty,
                    e.GetPosition((MovingObject as FrameworkElement).Parent as FrameworkElement).X - FirstXPos);

                // движение по горизонтали
                (MovingObject as FrameworkElement).SetValue(Canvas.TopProperty,
                    e.GetPosition((MovingObject as FrameworkElement).Parent as FrameworkElement).Y - FirstYPos);
            }
        }

        private void MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // В этом случае мы получаем текущую позицию мыши на элементе управления, чтобы использовать его в событии MouseMove.
            FirstXPos = e.GetPosition(sender as Control).X;
            FirstYPos = e.GetPosition(sender as Control).Y;
            /*FirstArrowXPos = e.GetPosition((sender as Control).Parent as Control).X - FirstXPos;
            FirstArrowYPos = e.GetPosition((sender as Control).Parent as Control).Y - FirstYPos;*/
            MovingObject = sender;
        }
    }
}
