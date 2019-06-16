using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public class Game
    {
        private int rI, rJ;
        private PictureBox fruit;//изображение еды
        private PictureBox[] snake = new PictureBox[400];//массив изображений змейки
        public int dirX, dirY;//заправление движении змейки
        private int _width;//высота поля
        private int _height;//ширина поля
        private int _sizeOfSides = 40;//размер ячейки
        private int score = 0;//счет
        Timer t = new Timer();//таймер, который позволяет обрабатывать, некоторые процедуры в отдельном потоке
        public bool gameStatus = false;//статус игры

        private bool isBorder = false;

        uint seconds = 300;//число секунд - длительность игры

        //запуск таймера
        private void TickTimer()
        {
            //пока игра начата
            while (gameStatus)
            {
                seconds--;//уменьшаем секунды на 1
                gameForm.Time(seconds.ToString());//передаем их на отрисовку
                System.Threading.Thread.Sleep(1000);//пауза в секунду
                if (seconds < 1)//если время кончилось
                {
                    EndGame();//конец игры
                    break;
                }
            }
        }

        private GameForm gameForm;//объект формы

        //инициализация базовый параметров игры
        public Game(GameForm form)
        {
            gameForm = form;

            dirX = 1;
            dirY = 0;
            _width = 900;
            _height = 800;
            snake[0] = new PictureBox();
            snake[0].Location = new Point(201, 201);
            snake[0].Size = new Size(_sizeOfSides - 1, _sizeOfSides - 1);
            snake[0].BackColor = Color.Red;
            gameForm.Controls.Add(snake[0]);
            fruit = new PictureBox();
            fruit.BackColor = Color.Black;
            fruit.Size = new Size(_sizeOfSides, _sizeOfSides);
            _generateMap();//генерация поля
            _generateFruit();//генерация еды
        }

        //генерация поля в случайном месте игрового поля
        private void _generateFruit()
        {
            Random r = new Random();
            rI = r.Next(0, _height - _sizeOfSides);
            int tempI = rI % _sizeOfSides;
            rI -= tempI;
            rJ = r.Next(0, _height - _sizeOfSides);
            int tempJ = rJ % _sizeOfSides;
            rJ -= tempJ;
            rI++;
            rJ++;
            fruit.Location = new Point(rI, rJ);
            gameForm.Controls.Add(fruit);
        }

        //если змейка вышла за границу игрового поля, то игра окончена, игра проиграна
        private void _checkBorders()
        {
            if (snake[0].Location.X < 0 || snake[0].Location.X > _height || snake[0].Location.Y < 0 ||
                snake[0].Location.Y > _height)
            {
                isBorder = true;
                Stop();
            }
        }

        //если змейка съела себя, то она откусывает свой хвост и очки уменьшаются на число откусанных секция
        private void _eatItself()
        {
            for (int _i = 1; _i < score; _i++)
            {
                if (snake[0].Location == snake[_i].Location)
                {
                    for (int _j = _i; _j <= score; _j++)
                        gameForm.Controls.Remove(snake[_j]);
                    score = score - (score - _i + 1);
                    gameForm.Scope(score.ToString());
                }
            }
        }

        //если змейка съела фрукт, но увеличиваются очки и генерируется новый фрукт
        private void _eatFruit()
        {
            if (snake[0].Location.X == rI && snake[0].Location.Y == rJ)
            {
                ++score;
                gameForm.Scope(score.ToString());
                snake[score] = new PictureBox();
                snake[score].Location = new Point(snake[score - 1].Location.X + 40 * dirX, snake[score - 1].Location.Y - 40 * dirY);
                snake[score].Size = new Size(_sizeOfSides - 1, _sizeOfSides - 1);
                snake[score].BackColor = Color.Green;
                gameForm.Controls.Add(snake[score]);
                _generateFruit();
            }
        }

        //генерация поля, циклично отрисовываются картинки поля на форме
        private void _generateMap()
        {
            for (int i = 0; i < _width / _sizeOfSides; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(0, _sizeOfSides * i);
                pic.Size = new Size(_width - 100, 1);
                gameForm.Controls.Add(pic);
            }
            for (int i = 0; i <= _height / _sizeOfSides; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(_sizeOfSides * i, 0);
                pic.Size = new Size(1, _width);
                gameForm.Controls.Add(pic);
            }
        }

        //передвижение змейки по полю, в зависимости от заданного направления
        private void _moveSnake()
        {
            for (int i = score; i >= 1; i--)
            {
                snake[i].Location = snake[i - 1].Location;
            }
            snake[0].Location = new Point(snake[0].Location.X + dirX * (_sizeOfSides), snake[0].Location.Y + dirY * (_sizeOfSides));
            _eatItself();
        }

        //процедура, которая в отдельном потоке каждый 200мс, проверяет вышла ли змейка за границы, съела ли фрукт, а также двигает змейку
        private void _update(Object myObject, EventArgs eventsArgs)
        {
            _checkBorders();
            _eatFruit();
            _moveSnake();
        }

        //запуск игры
        public void Start()
        {
            gameStatus = true;
            Task.Run(() => TickTimer());//запуск таймера времени
            t.Tick += new EventHandler(_update);//формирования таймера, который и обрабатывает игровые механики
            t.Interval = 200;//таймер срабатывает каждый 200мс
            t.Start();//запуск таймера

        }

        //если время вышло, то игра считается оконченной, результат отправляет на сервер, а также загружается новый список результатов
        private void EndGame()
        {
            t.Stop();
            gameStatus = false;
            MessageBox.Show("Время вышло! Игра окончена!");
            gameForm.SendRes(score.ToString());
            gameForm.SendGetResult();
        }

        //остановка игры
        private void Stop()
        {

            t.Stop();
            gameStatus = false;

            //удаляем змейку с поля
            for (int i=0; i<snake.Length; i++)
            {
                gameForm.Controls.Remove(snake[i]);   
            }
            gameForm.GameEnd();//показываем, что игра окончена

            //если игра окончена из-за проигрыша, показываем сообщение
            if(isBorder)
                MessageBox.Show("Вы проиграли! Змейка вышла за границы!");
        }

        //обработчик нажатых клавиш, который определяет направление змейки
        public void KeyListener(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    dirX = 1;
                    dirY = 0;
                    break;
                case "Left":
                    dirX = -1;
                    dirY = 0;
                    break;
                case "Up":
                    dirY = -1;
                    dirX = 0;
                    break;
                case "Down":
                    dirY = 1;
                    dirX = 0;
                    break;
            }
        }
    }
}
