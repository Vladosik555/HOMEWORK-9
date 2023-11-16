

namespace Тумаков
{
    internal abstract class Figure : ICoordinates, IOptions
    {
        protected int x { get; set; }
        protected int y { get; set; }
        protected Color color { get; set; }
        protected State state { get; set; }

        public Figure(int x, int y, Color color, State state)
        {
            this.x = x;
            this.y = y;
            this.color = color;
            this.state = state;
        }
        /// <summary>
        /// Метод, который передвигает объект по оси X
        /// </summary>
        public void Movement_X()
        {
        }
        /// <summary>
        /// Метод, который передвигает объект по оси Y
        /// </summary>
        public void Movement_Y()
        {
        }
        /// <summary>
        /// Метод, который изменяет цвет объекта
        /// </summary>
        public void Change_Color()
        {
        }
        /// <summary>
        /// Метод, который показывает состояние объекта
        /// </summary>
        public void Change_State()
        {
        }
        /// <summary>
        /// Метод, который выводит информацию об объекте
        /// </summary>
        public abstract void Information();
    }
}
