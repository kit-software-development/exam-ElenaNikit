using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class GameForm : Form
    {
        private Game game;//объект игровых механик
        public Net net;//объект сетевого взаимодействия

        public GameForm()
        {
            InitializeComponent();
        }

        //нажатие кнопки Начать Игру
        private void Start_Click(object sender, EventArgs e)
        {
            game.Start();//запуск игры
            Start.Enabled = false;//отключение кнопки Начать Игру
        }

        //Установка времени в лейбл времени
        public void Time(string t)
        {
            TimeCounter.Text = t;
        }

        //загрузка рузультатов игр
        //загружаются только 10 лучших
        public void LoadResult(string mes)
        {
            if (!String.IsNullOrEmpty(mes))//если строка с результатами не пустая
            {
                //обрабатываем 10 первых результатов
                for (int i = 0; i < 10; i++)
                {
                    if (mes.IndexOf("|") > -1)//разделитель |, значит ищем его
                    {
                        string score = mes.Substring(0, mes.IndexOf("|"));//получаем очередной результата
                        mes = mes.Substring(mes.IndexOf("|") + 1);//удаляем его
                        (Controls["score" + (i + 1).ToString()] as Label).Text = score;//записываем в нужные лейбл, лейблы имеют имя score[номер]
                    }
                    else//если нет разделителя, то пишем черточку в результат
                    {
                        if (!String.IsNullOrEmpty(mes))
                        {
                            (Controls["score" + (i + 1).ToString()] as Label).Text = mes;
                            mes = String.Empty;
                        }
                        else
                        {
                            (Controls["score" + (i + 1).ToString()] as Label).Text =
                                "-";
                        }
                    }
                }
            }
        }

        //процедура отправки результата на сервера
        public void SendRes(string score)
        {
            net.SendMessage("Result-" + score);
        }

        //процедура запроса результатов от сервера
        public void SendGetResult()
        {
            net.SendMessage("LoadResult-");
        }

        //если игра закончена, активируется кнопка новой игры
        public void GameEnd()
        {
            NewGame.Enabled = true;
        }

        //записывается в нужный лейбл счет игры
        public void Scope(string score)
        {
            ScoreCounter.Text = score;
        }

        //если нажата кнопка новой игры, то программа перезагружается
        private void NewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            net = new Net(this);//инициализируем сеть
            net.Start();//запускаем соединение
            game = new Game(this);//инициализируем игровые механики
            this.KeyDown += new KeyEventHandler(game.KeyListener);//добавлем действие при нажатии клавиш клавиатуры

            //запрашиваем результат, если есть соединение с сервером
            if (net.isConnect)
            {
                net.SendMessage("LoadResult-");
            }
            else//если нет, то игра запустить без отправки\запроса результатов
            {
                MessageBox.Show("Отсутствует соединение с сервером! Игра будет запущена в оффлайн режиме!");
            }
        }
    }
}
